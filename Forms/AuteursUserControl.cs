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
    /// Controle utilisateur pour la gestion des auteurs
    /// </summary>
    public partial class AuteursUserControl : UserControl
    {
        private AuteurManager auteurManager;

        /// <summary>
        /// Constructeur de la classe AuteursUserControl
        /// </summary>
        public AuteursUserControl()
        {
            InitializeComponent();
            this.Load += Auteurs_Load;
            this.auteurManager = new AuteurManager();
        }

        /// <summary>
        /// Chargement du contrôle utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Auteurs_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            AfficherAuteurs();
        }

        /// <summary>
        /// Gestion de la sélection d'une ligne dans le dataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int columnIndexNom = dataGridView1.Columns["Nom"].Index;
                int columnIndexPrenom = dataGridView1.Columns["Prenom"].Index;
                txtNomAuteur.Text = dataGridView1.SelectedRows[0].Cells[columnIndexNom].Value.ToString();
                txtPrenomAuteur.Text = dataGridView1.SelectedRows[0].Cells[columnIndexPrenom].Value.ToString();
            }
            else
            {
                txtNomAuteur.Text = "";
                txtPrenomAuteur.Text = "";
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
            // Mise en forme de la première lettre en majuscule et le reste en minuscule
            textBox.Text = ControleEntree.FormaterTexteNom(text);
            textBox.SelectionStart = text.Length;
            
        }

        /// <summary>
        /// Affichage des auteurs dans le dataGridView
        /// </summary>
        private void AfficherAuteurs()
        {
            List<Auteur> auteurs = auteurManager.RecupererListeAuteur();
            dataGridView1.Rows.Clear();

            if (dataGridView1.ColumnCount == 0)
            {
                dataGridView1.Columns.Add("ID_Auteur", "ID");
                dataGridView1.Columns.Add("nom", "Nom");
                dataGridView1.Columns.Add("prenom", "Prénom");
            }

            foreach (Auteur auteur in auteurs)
            {
                dataGridView1.Rows.Add(auteur.GetIdAuteur(), auteur.GetNom(), auteur.GetPrenom());
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// Ajustez la largeur des colonnes pour remplir la grille
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Sélectionnez toute la ligne au lieu d'une cellule
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;// Changez la couleur des en-têtes de colonnes
            dataGridView1.EnableHeadersVisualStyles = false;//Annule le style par défaut des en-têtes de colonnes
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;// Changez la couleur des lignes alternatives
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Tan;// Changez la couleur de fond de la ligne sélectionnée
        }

        /// <summary>
        /// Gestion du clic sur le bouton Créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            //Verifie que les champs ne sont pas vides et qu'ils ne contiennent pas de caractères spéciaux ou de chiffres
            if (txtNomAuteur.Text != "" && txtPrenomAuteur.Text != "" && !ControleEntree.VerifierTexteNom(txtNomAuteur.Text) && !ControleEntree.VerifierTexteNom(txtPrenomAuteur.Text))
            {
                //Vérifie si l'auteur existe déjà
                if (!auteurManager.EntreeExisteDeja(txtNomAuteur.Text, txtPrenomAuteur.Text))
                {
                    try
                    {
                        Auteur nouvelAuteur = new Auteur(0, txtNomAuteur.Text, txtPrenomAuteur.Text);
                        int lignesAjoutees = auteurManager.CreerAuteur(nouvelAuteur);

                        if (lignesAjoutees > 0)
                        {
                            MessageBox.Show("L'auteur a bien été créé", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherAuteurs();
                            txtNomAuteur.Text = "";
                            txtPrenomAuteur.Text = "";
                        }
                        else { MessageBox.Show("Erreur lors de la création de l'auteur : Aucune ligne n'a été ajoutée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    }
                    catch (Exception ex) { MessageBox.Show("Erreur lors de la création de l'auteur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("L'auteur existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else { MessageBox.Show("Veuillez remplir tous les champs.\nLes caractères spéciaux ainsi que les chiffres ne sont pas acceptés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestions du clic sur le bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            //Verifie que les champs ne sont pas vides et qu'ils ne contiennent pas de caractères spéciaux ou de chiffres
            if (txtNomAuteur.Text != "" && txtPrenomAuteur.Text != "" && !ControleEntree.VerifierTexteNom(txtNomAuteur.Text) && !ControleEntree.VerifierTexteNom(txtPrenomAuteur.Text))
            {
                try
                {
                    int idAuteur = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Auteur"].Value);
                    Auteur auteurModifie = new Auteur(idAuteur, txtNomAuteur.Text, txtPrenomAuteur.Text);
                    int lignesModifiees = auteurManager.ModifierAuteur(auteurModifie);

                    if (lignesModifiees > 0)
                    {
                        MessageBox.Show("L'auteur a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherAuteurs();
                        txtNomAuteur.Text = "";
                        txtPrenomAuteur.Text = "";
                    }
                    else { MessageBox.Show("Erreur lors de la modification de l'auteur : Aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                }
                catch (Exception ex)
                { MessageBox.Show("Erreur lors de la modification de l'auteur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else { MessageBox.Show("Veuillez remplir tous les champs.\nLes caractères spéciaux ainsi que les chiffres ne sont pas acceptés.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestions du clic sur le bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'auteur : " + txtNomAuteur.Text + " " + txtPrenomAuteur.Text, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (!auteurManager.LivreAssocie(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Auteur"].Value)))
                    {
                        try
                        {
                            int idAuteur = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_Auteur"].Value);
                            int lignesSupprimees = auteurManager.SupprimerAuteur(idAuteur);

                            if (lignesSupprimees > 0)
                            {
                                MessageBox.Show("L'auteur a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AfficherAuteurs();
                            }
                            else { MessageBox.Show("Erreur lors de la suppression de l'auteur : Aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                        }
                        catch (Exception ex) { MessageBox.Show("Erreur lors de la suppression de l'auteur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    }
                    else { MessageBox.Show("Impossible de supprimer cet auteur car il est associé à un ou plusieurs livres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                }
            }
        }
    }
}
