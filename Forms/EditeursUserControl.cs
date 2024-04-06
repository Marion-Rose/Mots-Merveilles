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
    /// Controle utilisateur pour la gestion des éditeurs
    /// </summary>
    public partial class EditeursUserControl : UserControl
    {
        private EditeurManager editeurManager;

        /// <summary>
        /// Constructeur de la classe EditeursUserControl
        /// </summary>
        public EditeursUserControl()
        {
            InitializeComponent();
            this.Load += editeurs_Load;
            this.editeurManager = new EditeurManager();
        }

        /// <summary>
        /// Chargement du contrôle utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editeurs_Load(object sender, EventArgs e)
        {
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            AfficherEditeurs();
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
                // Récupérez les valeurs de la ligne sélectionnée
                int columnIndexNom = dataGridView1.Columns["Nom"].Index;
                int columnIndexAdresse = dataGridView1.Columns["Adresse"].Index;
                int columnIndexTelephone = dataGridView1.Columns["Telephone"].Index;
                int columnIndexMail = dataGridView1.Columns["Mail"].Index;
                txtNomEditeur.Text = dataGridView1.SelectedRows[0].Cells[columnIndexNom].Value.ToString();
                txtAdresse.Text = dataGridView1.SelectedRows[0].Cells[columnIndexAdresse].Value.ToString();
                txtTelephone.Text = dataGridView1.SelectedRows[0].Cells[columnIndexTelephone].Value.ToString();
                txtMail.Text = dataGridView1.SelectedRows[0].Cells[columnIndexMail].Value.ToString();
            }
            else
            {
                // Effacez les zones de texte s'il n'y a pas de ligne sélectionnée
                txtNomEditeur.Text = "";
                txtAdresse.Text = "";
                txtTelephone.Text = "";
                txtMail.Text = "";
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
            if (textBox.Name == "txtMail")
            {
                textBox.Text = ControleEntree.FormaterTexteMail(text);
                textBox.SelectionStart = text.Length;
            }
        }

        /// <summary>
        /// Affichage des editeurs dans le dataGridView
        /// </summary>
        private void AfficherEditeurs()
        {
            List<Editeur> listeEditeurs = editeurManager.RecupererListeEditeur();
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID_editeur", "ID");
                dataGridView1.Columns.Add("Nom", "Nom");
                dataGridView1.Columns.Add("Adresse", "Adresse");
                dataGridView1.Columns.Add("Telephone", "Téléphone");
                dataGridView1.Columns.Add("Mail", "Mail");
            }

            foreach (Editeur editeur in listeEditeurs)
            {
                dataGridView1.Rows.Add(editeur.GetIdEditeur(), editeur.GetNom(), editeur.GetAdresse(), editeur.GetTelephone(), editeur.GetEmail());
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
            //Verifie les champs
            if (txtNomEditeur.Text != "" && txtAdresse.Text != "" && txtTelephone.Text != "" && txtMail.Text != "" 
                && !ControleEntree.VerifierTexteNom(txtNomEditeur.Text) && !ControleEntree.VerifierTexteMail(txtMail.Text) && !ControleEntree.VerifierTexteTelephone(txtTelephone.Text))
            {
                //Verifie si l'editeur existe
                if (!editeurManager.EditeurExiste(txtNomEditeur.Text))
                { 
                    try
                    {
                        Editeur nouvelEditeur = new Editeur(0, txtNomEditeur.Text, txtAdresse.Text, txtTelephone.Text, txtMail.Text);
                        int nbRow = editeurManager.CreerEditeur(nouvelEditeur);
                        
                        if(nbRow > 0)
                        {
                            MessageBox.Show("L'editeur a bien été créé", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherEditeurs();
                            txtNomEditeur.Text = "";
                            txtAdresse.Text = "";
                            txtTelephone.Text = "";
                            txtMail.Text = "";
                        }
                        else { MessageBox.Show("Erreur lors de la création de l'éditeur : Aucune ligne n'a été ajoutée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        
                    }
                    catch (Exception ex)
                    { MessageBox.Show("Erreur lors de la création de l'éditeur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                }
                else { MessageBox.Show("L'éditeur existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Veuillez remplir tous les champs sous la forme attendue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestions du clic sur le bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            //Verifie les champs
            if (txtNomEditeur.Text != "" && txtAdresse.Text != "" && txtTelephone.Text != "" && txtMail.Text != ""
                && !ControleEntree.VerifierTexteNom(txtNomEditeur.Text) && !ControleEntree.VerifierTexteMail(txtMail.Text) && !ControleEntree.VerifierTexteTelephone(txtTelephone.Text))
            {
                try
                {
                    int idEditeur = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_editeur"].Value);
                    Editeur editeurModifie = new Editeur(idEditeur, txtNomEditeur.Text, txtAdresse.Text, txtTelephone.Text, txtMail.Text);
                    int nbRow = editeurManager.ModifierEditeur(editeurModifie);

                    if (nbRow > 0)
                    {
                        MessageBox.Show("L'éditeur a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherEditeurs();
                        txtNomEditeur.Text = "";
                        txtAdresse.Text = "";
                        txtTelephone.Text = "";
                        txtMail.Text = "";
                    }
                    else { MessageBox.Show("Erreur lors de la modification de l'éditeur : Aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    
                }
                catch (Exception ex) { MessageBox.Show("Erreur lors de la modification de l'éditeur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else { MessageBox.Show("Veuillez remplir tous les champs sous la forme attendue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestion du clic sur le bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'éditeur : " + txtNomEditeur.Text, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (!editeurManager.LivreAssocie(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_editeur"].Value)))
                    {
                        if (!editeurManager.CommandeAssociee(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_editeur"].Value)))
                        {
                            try
                            {
                                int idEditeur = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_editeur"].Value);
                                int nbRow = editeurManager.SupprimerEditeur(idEditeur);

                                if (nbRow > 0)
                                {
                                    MessageBox.Show("L'éditeur a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    AfficherEditeurs();
                                }
                                else { MessageBox.Show("Erreur lors de la suppression de l'éditeur : Aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                            }
                            catch (Exception ex) { MessageBox.Show("Erreur lors de la suppression de l'éditeur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        else { MessageBox.Show("Impossible de supprimer l'éditeur car il est associé à une ou plusieurs commandes", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    else { MessageBox.Show("Impossible de supprimer l'éditeur car il est associé à un ou plusieurs livres", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else { MessageBox.Show("Veuillez sélectionner une ligne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}
