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
using System.Linq.Expressions;


namespace Mots_Merveilles.Forms
{
    /// <summary>
    /// Controle utilisateur pour la gestion des employés
    /// </summary>
    public partial class EmployesUserControl : UserControl
    {
        private EmployeManager employeManager;

        /// <summary>
        /// Constructeur de la classe EmployesUserControl
        /// </summary>
        public EmployesUserControl()
        {
            InitializeComponent();
            this.employeManager = new EmployeManager();
            this.Load += EmployesUserControl_Load;
        }

        /// <summary>
        /// Chargement du controle utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployesUserControl_Load(object sender, EventArgs e)
        {
            AfficherEmployes();
        }

        /// <summary>
        /// Gestions des événements de sélection de ligne dans le DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérez les valeurs de la ligne sélectionnée
                txtNom.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtPrenom.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                comboBoxGenre.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtAdresse.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtVille.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txtTelephone.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtMail.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            else
            {
                // Effacez les zones de texte s'il n'y a pas de ligne sélectionnée
                txtNom.Text = "";
                txtPrenom.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                comboBoxGenre.Text = "";
                txtAdresse.Text = "";
                txtVille.Text = "";
                txtTelephone.Text = "";
                txtMail.Text = "";
            }
        }

        /// <summary>
        /// Gestion de l'événement de changement de texte dans les TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            //textBox.Text = ControleEntree.FormaterTexteNom(text);
            textBox.SelectionStart = text.Length;
        }

        /// <summary>
        /// Afficher les employés dans le DataGridView
        /// </summary>
        private void AfficherEmployes()
        {
            List<Employe> listeEmployes = employeManager.RecupererListeEmploye();
            dataGridView1.Rows.Clear();

            if (dataGridView1.ColumnCount == 0)
            {
                dataGridView1.Columns.Add("ID_employe", "ID_employe");
                dataGridView1.Columns.Add("nom", "Nom");
                dataGridView1.Columns.Add("prenom", "Prénom");
                dataGridView1.Columns.Add("date_naissance", "Date de naissance");
                dataGridView1.Columns.Add("genre", "Genre");
                dataGridView1.Columns.Add("adresse", "Adresse");
                dataGridView1.Columns.Add("ville", "Ville");
                dataGridView1.Columns.Add("telephone", "Téléphone");
                dataGridView1.Columns.Add("mail", "Mail");
            }

            foreach (Employe employe in listeEmployes)
            {
                dataGridView1.Rows.Add(employe.GetIdEmploye(), employe.GetNom(), employe.GetPrenom(), employe.GetDateNaissance(), employe.GetGenre(), employe.GetAdresse(), employe.GetVille(), employe.GetTelephone(), employe.GetMail());
            }

        }

        /// <summary>
        /// Gestion de l'événement de clic sur le bouton Créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            //Verification des champs
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtAdresse.Text != "" && txtVille.Text != "" && txtTelephone.Text != "" && txtMail.Text != ""
                && ControleEntree.VerifierTexteNom(txtNom.Text) && ControleEntree.VerifierTexteNom(txtPrenom.Text) && ControleEntree.VerifierTexteNom(txtVille.Text) && ControleEntree.VerifierTexteTelephone(txtTelephone.Text) && ControleEntree.VerifierTexteMail(txtMail.Text))
            {
                //Vérifie si l'employé existe déjà
                if(!employeManager.EmployeExiste(txtNom.Text, txtPrenom.Text, dateTimePicker1.Value))
                {
                    try
                    {
                        Employe employe = new Employe(0, txtNom.Text, txtPrenom.Text, dateTimePicker1.Value, comboBoxGenre.Text, txtAdresse.Text, txtVille.Text, txtTelephone.Text, txtMail.Text);
                        int lignesAjoutees = employeManager.CreerEmploye(employe);

                        if (lignesAjoutees > 0)
                        {
                            MessageBox.Show("L'employé a bien été créé", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherEmployes();
                            txtAdresse.Text = "";
                            txtMail.Text = "";
                            txtNom.Text = "";
                            txtPrenom.Text = "";
                            txtTelephone.Text = "";
                            txtVille.Text = "";
                        }
                        else { MessageBox.Show("Erreur lors de la création de l'employé : aucune ligne n'a été ajoutée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}        
                    }
                    catch (Exception ex) { MessageBox.Show("Erreur lors de la création de l'employé: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("L'employé existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else { MessageBox.Show("Veuillez remplir tous les champs sous la forme attendue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestion de l'événement de clic sur le bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtAdresse.Text != "" && txtVille.Text != "" && txtTelephone.Text != "" && txtMail.Text != ""
                && ControleEntree.VerifierTexteNom(txtNom.Text) && ControleEntree.VerifierTexteNom(txtPrenom.Text) && ControleEntree.VerifierTexteNom(txtVille.Text) && ControleEntree.VerifierTexteTelephone(txtTelephone.Text) && ControleEntree.VerifierTexteMail(txtMail.Text))
            {
                try
                {
                    int idEmploye = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_employe"].Value);
                    Employe employeAModifier = employeManager.AfficherEmploye(idEmploye);
                    employeAModifier.SetNom(txtNom.Text);
                    employeAModifier.SetPrenom(txtPrenom.Text);
                    employeAModifier.SetDateNaissance(dateTimePicker1.Value);
                    employeAModifier.SetGenre(comboBoxGenre.Text);
                    employeAModifier.SetAdresse(txtAdresse.Text);
                    employeAModifier.SetVille(txtVille.Text);
                    employeAModifier.SetTelephone(txtTelephone.Text);
                    employeAModifier.SetMail(txtMail.Text);

                    int lignesModifiées = employeManager.ModifierEmploye(employeAModifier);

                    if (lignesModifiées > 0)
                    {
                        MessageBox.Show("L'employé a bien été modifié", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherEmployes();
                    }
                    else { MessageBox.Show("Erreur lors de la modification de l'employé : aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                } 
                catch (Exception ex) { MessageBox.Show("Erreur lors de la modification de l'employé : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else { MessageBox.Show("Veuillez remplir tous les champs sous la forme attendue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestion de l'événement de clic sur le bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'employé : " + txtNom.Text + " " + txtPrenom.Text, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int idEmploye = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_employe"].Value);
                        if (employeManager.EmployeUtilisateur(idEmploye)) { MessageBox.Show("Impossible de supprimer l'employé car il est lié à un utilisateur", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }
                        int lignesSupprimees = employeManager.SupprimerEmploye(idEmploye);

                        if (lignesSupprimees > 0)
                        {
                            MessageBox.Show("L'employé a bien été supprimé", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherEmployes();
                        }
                        else { MessageBox.Show("Erreur lors de la suppression de l'employé : aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'employé : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
