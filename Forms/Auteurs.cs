using Mots_Merveilles.Managers;
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
    public partial class Auteurs : Administration
    {
        ConnexionManager connexion;
        public Auteurs()
        {
            InitializeComponent();
            connexion = new ConnexionManager();
#pragma warning disable CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            this.Load += Auteurs_Load;
#pragma warning restore CS8622 // La nullabilité des types référence dans le type du paramètre ne correspond pas au délégué cible (probablement en raison des attributs de nullabilité).
            AfficherAuteurs();
        }

        private void Auteurs_Load(object sender, EventArgs e)
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
                txtNomAuteur.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtPrenomAuteur.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            }
            else
            {
                // Effacez les zones de texte s'il n'y a pas de ligne sélectionnée
                txtNomAuteur.Text = "";
                txtPrenomAuteur.Text = "";
            }
        }
        private void AfficherAuteurs()
        {
            string query = "SELECT * FROM Auteur";
            dataGridView1.DataSource = connexion.RecupererDonnees(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// Ajustez la largeur des colonnes pour remplir la grille
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Sélectionnez toute la ligne au lieu d'une cellule
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;// Changez la couleur des en-têtes de colonnes
            dataGridView1.EnableHeadersVisualStyles = false;//Annule le style par défaut des en-têtes de colonnes
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;// Changez la couleur des lignes alternatives
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Tan;// Changez la couleur de fond de la ligne sélectionnée
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (txtNomAuteur.Text != "" && txtPrenomAuteur.Text != "")
            {
                try
                {
                    {
                        string query = "INSERT INTO Auteur (nom, prenom) VALUES (@nom, @prenom)";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = txtNomAuteur.Text },
                            new SqlParameter("@prenom", SqlDbType.VarChar) { Value = txtPrenomAuteur.Text }
                        };

                        connexion.EnvoyerDonnees(query, parameters);
                    }

                    MessageBox.Show("L'auteur a bien été créé", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfficherAuteurs();
                    txtNomAuteur.Text = "";
                    txtPrenomAuteur.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création de l'auteur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtNomAuteur.Text != "" && txtPrenomAuteur.Text != "")
            {
                try
                {
                    {
                        string query = "UPDATE Auteur SET nom=@nom, prenom=@prenom WHERE ID_Auteur =@id;";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = txtNomAuteur.Text },
                            new SqlParameter("@prenom", SqlDbType.VarChar) { Value = txtPrenomAuteur.Text },
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()}
                        };
                        connexion.EnvoyerDonnees(query, parameters);
                    }
                    MessageBox.Show("L'auteur a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    AfficherAuteurs();
                    txtNomAuteur.Text = "";
                    txtPrenomAuteur.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de l'auteur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer l'auteur : " + txtNomAuteur.Text + " " + txtPrenomAuteur.Text, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur "Oui", supprimez l'auteur
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        string query = "DELETE FROM Auteur WHERE ID_Auteur=@id;";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = dataGridView1.SelectedRows[0].Cells["ID_Auteur"].Value.ToString() }
                        };

                        connexion.EnvoyerDonnees(query, parameters);

                        MessageBox.Show("L'auteur a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherAuteurs();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de l'auteur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
