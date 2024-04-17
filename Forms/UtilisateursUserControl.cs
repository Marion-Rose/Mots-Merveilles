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
using System.Diagnostics.Eventing.Reader;

namespace Mots_Merveilles.Forms
{
    /// <summary>
    /// Classe UtilisateursUserControl
    /// </summary>
    public partial class UtilisateursUserControl : UserControl
    {
        private EmployeManager employeManager;
        private UtilisateurManager utilisateurManager;
        private GroupeUtilisateurManager groupeUtilisateurManager;
        private Employe employeSelectionne;
        private Utilisateur utilisateurSelectionne;

        /// <summary>
        /// Constructeur de la classe UtilisateursUserControl
        /// </summary>
        public UtilisateursUserControl()
        {
            InitializeComponent();
            this.employeManager = new EmployeManager();
            this.utilisateurManager = new UtilisateurManager();
            this.groupeUtilisateurManager = new GroupeUtilisateurManager();
            this.employeSelectionne = null;
            this.utilisateurSelectionne = null;
            this.Load += UtilisateursUserControl_Load;
        }

        /// <summary>
        /// Chargement du UserControl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UtilisateursUserControl_Load(object sender, EventArgs e)
        {
            AfficherUtilisateur();
            ChargerComboBox();
        }

        /// <summary>
        /// Gestion de l'eveènement changement de sélection dans le DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idUtilisateur = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                this.utilisateurSelectionne = utilisateurManager.AfficherUtilisateur(idUtilisateur);
                this.employeSelectionne = employeManager.AfficherEmploye(this.utilisateurSelectionne.GetEmploye().GetIdEmploye());
                comboBoxSalarie.Text = this.employeSelectionne.ToString();

                if (this.employeSelectionne != null)
                {
                    PreremplirChamps();
                }
                else
                {
                    txtNom.Text = "";
                    txtPrenom.Text = "";
                    comboBoxGroupe.Text = "";
                    txtIdentifiant.Text = "";
                    txtMDP.Text = "";
                    checkBoxActif.Checked = false;
                }
            }
            else
            {
                txtNom.Text = "";
                txtPrenom.Text = "";
                comboBoxGroupe.Text = "";
                txtIdentifiant.Text = "";
                txtMDP.Text = "";
                checkBoxActif.Checked = false;
            }
        }

        private void comboBoxSalarie_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.employeSelectionne = (Employe)comboBoxSalarie.SelectedItem;
            this.utilisateurSelectionne = utilisateurManager.RecupererListeUtilisateur().FirstOrDefault(u => u.GetEmploye().GetIdEmploye() == employeSelectionne.GetIdEmploye());

            PreremplirChamps();
            dataGridView1.ClearSelection();
        }

        public void PreremplirChamps()
        {
            if (this.employeSelectionne == null) return;
            txtNom.Text = this.employeSelectionne.GetNom();
            txtPrenom.Text = this.employeSelectionne.GetPrenom();


            if (this.utilisateurSelectionne != null)
            {
                txtIdentifiant.Text = this.utilisateurSelectionne.GetIdentifiant();
                checkBoxActif.Checked = this.utilisateurSelectionne.GetEstActif();
                comboBoxGroupe.Text = this.utilisateurSelectionne.GetGroupe().GetNom();
            }
            else
            {
                txtIdentifiant.Text = "";
                txtMDP.Text = "";
                checkBoxActif.Checked = false;
                comboBoxGroupe.Text = "";
            }
        }

        /// <summary>
        /// Chargement des ComboBox
        /// </summary>
        private void ChargerComboBox()
        {
            List<GroupeUtilisateur> listeGroupeUtilisateur = groupeUtilisateurManager.RecupererListeGroupeUtilisateur();
            comboBoxGroupe.DataSource = listeGroupeUtilisateur;
            comboBoxGroupe.DisplayMember = "nom";

            List<Employe> listeEmploye = employeManager.RecupererListeEmploye();
            comboBoxSalarie.DataSource = listeEmploye;
            comboBoxSalarie.DisplayMember = "nom";
        }

        /// <summary>
        /// Affichage des utilisateurs dans le DataGridView
        /// </summary>
        private void AfficherUtilisateur()
        {
            List<Utilisateur> listeUtilisateurs = utilisateurManager.RecupererListeUtilisateur();
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID_utilisateur", "ID_utilisateur");
                dataGridView1.Columns.Add("Nom", "Nom");
                dataGridView1.Columns.Add("Prenom", "Prenom");
                dataGridView1.Columns.Add("Identifiant", "Identifiant");
                dataGridView1.Columns.Add("Est_actif", "Est_actif");
                dataGridView1.Columns.Add("Groupe", "Groupe");
            }

            foreach (Utilisateur utilisateur in listeUtilisateurs)
            {
                dataGridView1.Rows.Add(utilisateur.GetID(), utilisateur.GetEmploye().GetNom(), utilisateur.GetEmploye().GetPrenom(), utilisateur.GetIdentifiant(), utilisateur.GetEstActif(), utilisateur.GetGroupe().GetNom());
            }
        }

        /// <summary>
        /// Gestion de l'évènement click sur le bouton Créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            
            if (this.utilisateurSelectionne != null)
            {
                MessageBox.Show("Cet utilisateur existe déjà, veuillez le modifier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (this.employeSelectionne == null)
                {
                    MessageBox.Show("Veuillez sélectionner un salarié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (txtIdentifiant.Text == "" || txtMDP.Text == "" || comboBoxGroupe.Text == "")
                    {
                        MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        try {
                            Utilisateur utilisateur = new Utilisateur(0, this.employeSelectionne, txtIdentifiant.Text, txtMDP.Text, checkBoxActif.Checked, (GroupeUtilisateur)comboBoxGroupe.SelectedItem);
                            int nbRows = utilisateurManager.CreerUtilisateur(utilisateur);

                            if (nbRows > 0) {
                                MessageBox.Show("Utilisateur créé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AfficherUtilisateur();
                            }
                            else { MessageBox.Show("Erreur lors de la création de l'utilisateur : Aucune ligne n'a été insérée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        catch (Exception ex) { MessageBox.Show("Erreur lors de la création de l'utilisateur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }

            }
        }

        /// <summary>
        /// Gestion de l'évènement click sur le bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (this.utilisateurSelectionne == null)
            {
                DialogResult result = MessageBox.Show("Cet utilisateur n'existe pas encore, voulez vous le créer ? ", "Creer un nouvel utilisateur", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    btCreer_Click(sender, e);
                }
            }
            else
            {
                if (this.employeSelectionne == null)
                {
                    MessageBox.Show("Veuillez sélectionner un salarié", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (txtIdentifiant.Text == "" || txtMDP.Text == "" || comboBoxGroupe.Text == "")
                    {
                        MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        try
                        {
                            this.utilisateurSelectionne.SetIdentifiant(txtIdentifiant.Text);
                            this.utilisateurSelectionne.SetMotDePasse(txtMDP.Text);
                            this.utilisateurSelectionne.SetEstActif(checkBoxActif.Checked);
                            this.utilisateurSelectionne.SetGroupe((GroupeUtilisateur)comboBoxGroupe.SelectedItem);
                          
                            int nbRows = utilisateurManager.ModifierUtilisateur(this.utilisateurSelectionne);

                            if (nbRows > 0)
                            {
                                MessageBox.Show("Utilisateur modifié", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AfficherUtilisateur();
                            }
                            else { MessageBox.Show("Erreur lors de la modification de l'utilisateur : Aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        catch (Exception ex) { MessageBox.Show("Erreur lors de la modification de l'utilisateur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                }

            }

        }

        /// <summary>
        /// Gestions de l'évènement click sur le bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer l'utilisateur" + this.utilisateurSelectionne.ToString() + " ?", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int nbRows = utilisateurManager.SupprimerUtilisateur(this.utilisateurSelectionne.GetID());

                        if (nbRows > 0)
                        {
                            MessageBox.Show("Utilisateur supprimé", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherUtilisateur();
                        }
                        else { MessageBox.Show("Erreur lors de la suppression de l'utilisateur : Aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    catch (Exception ex) { MessageBox.Show("Erreur lors de la suppression de l'utilisateur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
