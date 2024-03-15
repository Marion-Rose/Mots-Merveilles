using Mots_Merveilles.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mots_Merveilles.Forms
{
    public partial class Employes : Administration
    {
        ConnexionManager connexion;
        public Employes()
        {
            InitializeComponent();
            connexion = new ConnexionManager();
#pragma warning disable CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            this.Load += Employes_Load;
#pragma warning restore CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            AfficherEmployes();
            ChargerComboBox();
        }

        private void Employes_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
#pragma warning restore CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
        }

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
                comboBoxGroupe.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
                txtIdentifiant.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                txtMDP.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                comboBoxActif.Text = (dataGridView1.SelectedRows[0].Cells[11].Value?.ToString() == "True") ? "Actif" : "Inactif";

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
                comboBoxGroupe.Text = "";
                txtIdentifiant.Text = "";
                txtMDP.Text = "";
                comboBoxActif.Text = "";
            }
        }

        private void ChargerComboBox()
        {
            // Assigner les données de la BD aux ComboBox
            string queryGroupe = "SELECT * FROM GroupeUtilisateur;";
            DataTable dataGroupe = connexion.RecupererDonnees(queryGroupe);
            comboBoxGroupe.DataSource = dataGroupe;
            comboBoxGroupe.DisplayMember = "nom";
        }
        private void AfficherEmployes()
        {
            string query = "SELECT e.ID_employe, e.nom, e.prenom, e.date_naissance, e.genre, e.adresse, e.ville, e.telephone, e.mail, e.identifiant, e.mot_de_passe, e.est_actif, g.nom AS groupe " +
                "FROM Employe e " +
                "INNER JOIN GroupeUtilisateur g ON e.groupe = g.ID_groupe ;";
            dataGridView1.DataSource = connexion.RecupererDonnees(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// Ajustez la largeur des colonnes pour remplir la grille
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Sélectionnez toute la ligne au lieu d'une cellule
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;// Changez la couleur des en-têtes de colonnes
            dataGridView1.EnableHeadersVisualStyles = false;//Annule le style par défaut des en-têtes de colonnes
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;// Changez la couleur des lignes alternatives
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Tan;// Changez la couleur de fond de la ligne sélectionnée
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustez la largeur des colonnes à leur contenu
            dataGridView1.ScrollBars = ScrollBars.Horizontal;// Ajoutez une barre de défilement horizontal
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtIdentifiant.Text != "" && txtMDP.Text != "")
            {
                try
                {
                    {
                        string query = "INSERT INTO Employe (nom, prenom, date_naissance, genre, adresse, ville, telephone, mail, identifiant, mot_de_passe, est_actif, groupe) " +
                            "VALUES (@nom, @prenom, @date_naissance, @genre, @adresse, @ville, @telephone, @mail, @identifiant, @mot_de_passe, @est_actif, @groupe)";
                        DataRowView selectedRow = (DataRowView)comboBoxGroupe.SelectedItem;
                        int selectedGroupeID = Convert.ToInt32(selectedRow["ID_Groupe"]);
                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = txtNom.Text },
                            new SqlParameter("@prenom", SqlDbType.VarChar) { Value = txtPrenom.Text },
                            new SqlParameter("@date_naissance", SqlDbType.Date) { Value = dateTimePicker1.Value },
                            new SqlParameter("@genre", SqlDbType.VarChar) { Value = comboBoxGenre.Text },
                            new SqlParameter("@adresse", SqlDbType.VarChar) { Value = txtAdresse.Text },
                            new SqlParameter("@ville", SqlDbType.VarChar) { Value = txtVille.Text },
                            new SqlParameter("@telephone", SqlDbType.VarChar) { Value = txtTelephone.Text },
                            new SqlParameter("@mail", SqlDbType.VarChar) { Value = txtMail.Text },
                            new SqlParameter("@identifiant", SqlDbType.VarChar) { Value = txtIdentifiant.Text },
                            new SqlParameter("@mot_de_passe", SqlDbType.VarChar) { Value = txtMDP.Text },
                            new SqlParameter("@est_actif", SqlDbType.Bit) { Value = (comboBoxActif.Text == "Actif") ? 1 : 0 },
                            new SqlParameter("@groupe", SqlDbType.Int) { Value = selectedGroupeID }
                        };

                        connexion.EnvoyerDonnees(query, parameters);
                    }

                    MessageBox.Show("L'employé a bien été créé", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfficherEmployes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création de l'employé: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtIdentifiant.Text != "" && txtMDP.Text != "")
            {
                try
                {

                    string query = "UPDATE Employe SET nom=@nom, prenom=@prenom, date_naissance=@date_naissance, genre=@genre, adresse=@adresse, ville=@ville, telephone=@telephone, mail=@mail, identifiant=@identifiant, mot_de_passe=@mot_de_passe, est_actif=@est_actif, groupe=@groupe WHERE ID_employe =@id;";
                    DataRowView selectedRow = (DataRowView)comboBoxGroupe.SelectedItem;
                    int selectedGroupeID = Convert.ToInt32(selectedRow["ID_Groupe"]);
                    // Définissez les paramètres
                    SqlParameter[] parameters = {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = txtNom.Text },
                            new SqlParameter("@prenom", SqlDbType.VarChar) { Value = txtPrenom.Text },
                            new SqlParameter("@date_naissance", SqlDbType.Date) { Value = dateTimePicker1.Value },
                            new SqlParameter("@genre", SqlDbType.VarChar) { Value = comboBoxGenre.Text },
                            new SqlParameter("@adresse", SqlDbType.VarChar) { Value = txtAdresse.Text },
                            new SqlParameter("@ville", SqlDbType.VarChar) { Value = txtVille.Text },
                            new SqlParameter("@telephone", SqlDbType.VarChar) { Value = txtTelephone.Text },
                            new SqlParameter("@mail", SqlDbType.VarChar) { Value = txtMail.Text },
                            new SqlParameter("@identifiant", SqlDbType.VarChar) { Value = txtIdentifiant.Text },
                            new SqlParameter("@mot_de_passe", SqlDbType.VarChar) { Value = txtMDP.Text },
                            new SqlParameter("@est_actif", SqlDbType.Bit) { Value = (comboBoxActif.Text == "Actif") ? 1 : 0 },
                            new SqlParameter("@groupe", SqlDbType.Int) { Value = selectedGroupeID },
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}
                        };
                    connexion.EnvoyerDonnees(query, parameters);

                    MessageBox.Show("L'employé a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfficherEmployes();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de l'employé : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Affichez une boîte de dialogue de confirmation
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'employé : " + txtNom.Text + " " + txtPrenom.Text, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur "Oui", supprimez l'auteur
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        string query = "DELETE FROM Employe WHERE ID_employe=@id;";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = dataGridView1.SelectedRows[0].Cells["ID_employe"].Value.ToString() }
                        };

                        connexion.EnvoyerDonnees(query, parameters);

                        MessageBox.Show("L'employé a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherEmployes();
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
