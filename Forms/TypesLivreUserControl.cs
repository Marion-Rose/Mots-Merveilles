using Mots_Merveilles.Managers;
using Mots_Merveilles.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mots_Merveilles.Forms
{
    /// <summary>
    /// Contrôle utilisateur pour la gestion des types de livre
    /// </summary>
    public partial class TypesLivreUserControl : UserControl
    {
        private TypeLivreManager typeLivreManager;

        /// <summary>
        /// Constructeur de la classe TypesLivreUserControl
        /// </summary>
        public TypesLivreUserControl()
        {
            InitializeComponent();
            this.Load += TypesLivre_Load;
            this.typeLivreManager = new TypeLivreManager();
        }

        /// <summary>
        /// Chargement du contrôle utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypesLivre_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            AfficherTypes();
        }

        /// <summary>
        /// Gestion de la sélection d'une ligne dans la grille
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérez les valeurs de la ligne sélectionnée
                int columnIndexType = dataGridView1.Columns["Type"].Index;
                txtType.Text = dataGridView1.SelectedRows[0].Cells[columnIndexType].Value.ToString();
            }
            else
            {
                // Effacez les zones de texte s'il n'y a pas de ligne sélectionnée
                txtType.Text = "";
            }
        }

        /// <summary>
        /// Gestion de la modification du texte dans les textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            textBox.Text = ControleEntree.FormaterTexteNom(text);
            textBox.SelectionStart = text.Length;
            
        }

        /// <summary>
        /// Affiche les types de livre dans la grille
        /// </summary>
        private void AfficherTypes()
        {
            List<TypeLivre> listeTypeLivre = typeLivreManager.RecupererListeTypeLivre();
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID_type", "ID");
                dataGridView1.Columns.Add("Type", "Type");
            }

            foreach (TypeLivre typeLivre in listeTypeLivre)
            {
                dataGridView1.Rows.Add(typeLivre.GetIdTypeLivre(), typeLivre.GetLibelle());
            }
        }

        /// <summary>
        /// Gestion de l'événement click sur le bouton Créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            // Vérifiez si le champ est vide et si le texte est valide
            if (txtType.Text != "" && ControleEntree.VerifierTexteNom(txtType.Text))
            {
                if (!typeLivreManager.TypeLivreExiste(txtType.Text))
                {
                    try
                    {
                        TypeLivre typeLivre = new TypeLivre(0, txtType.Text);
                        int nbRow = typeLivreManager.CreerTypeLivre(typeLivre);

                        if (nbRow > 0)
                        {
                            MessageBox.Show("Le type a bien été créé", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherTypes();
                            txtType.Text = "";
                        }
                        else { MessageBox.Show("Erreur lors de la création du type : Aucune ligne n'a été ajoutée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    }
                    catch (Exception ex) { MessageBox.Show("Erreur lors de la création du type : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                }
                else { MessageBox.Show("Ce type existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else { MessageBox.Show("Veuillez remplir tous les champs, sans chiffre ni caractère spéciaux.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestion de l'événement click sur le bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtType.Text != "" && ControleEntree.VerifierTexteNom(txtType.Text))
            {
                try
                {
                    int idType = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_type"].Value);
                    TypeLivre typeLivre = new TypeLivre(idType, txtType.Text);
                    int nbRow = typeLivreManager.ModifierTypeLivre(typeLivre);

                    if (nbRow > 0)
                    {
                        MessageBox.Show("Le type a bien été modifié", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherTypes();
                        txtType.Text = "";
                    }
                    else
                    { MessageBox.Show("Erreur lors de la modification du type : Aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                }
                catch (Exception ex) { MessageBox.Show("Erreur lors de la modification du type : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else { MessageBox.Show("Veuillez remplir tous les champs, sans chiffre ni caractere special", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
        
        /// <summary>
        /// Gestions de l'événement click sur le bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce type : " + txtType.Text, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (!typeLivreManager.LivreAssocie(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_type"].Value)))
                    {
                        try
                        {
                            int idType = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_type"].Value);
                            int nbRow = typeLivreManager.SupprimerTypeLivre(idType);

                            if (nbRow > 0)
                            {
                                MessageBox.Show("Le type a bien été supprimé", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AfficherTypes();
                            }
                            else { MessageBox.Show("Erreur lors de la suppression du type : Aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        catch (Exception ex) { MessageBox.Show("Erreur lors de la suppression du type : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else{MessageBox.Show("Ce type est associé à un livre, il ne peut pas être supprimé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                }
            }
        }
    }
}
