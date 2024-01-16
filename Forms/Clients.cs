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
    public partial class Clients : Accueil
    {
        ConnexionManager connexion;
        public Clients()
        {
            InitializeComponent();
            connexion = new ConnexionManager();
            AfficherClients();
        }

        private void AfficherClients()
        {
            string query = "SELECT * FROM Client; ";
            dataGridView1.DataSource = connexion.RecupererDonnees(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// Ajustez la largeur des colonnes pour remplir la grille
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Sélectionnez toute la ligne au lieu d'une cellule
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;// Changez la couleur des en-têtes de colonnes
            dataGridView1.EnableHeadersVisualStyles = false;//Annule le style par défaut des en-têtes de colonnes
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;// Changez la couleur des lignes alternatives
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Tan;// Changez la couleur de fond de la ligne sélectionnée
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustez la largeur des colonnes à leur contenu
        }

        private void lbTitre_Click(object sender, EventArgs e)
        {

        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            CRClient Obj = new CRClient(true);
            Obj.ShowDialog();
            this.Show();
            AfficherClients();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CRClient Obj = new CRClient(false, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                Obj.ShowDialog();
                this.Show();
                AfficherClients();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Affichez une boîte de dialogue de confirmation
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer le client : " + dataGridView1.SelectedRows[0].Cells[1].Value + " " + dataGridView1.SelectedRows[0].Cells[2].Value, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur "Oui", supprimez l'auteur
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        string query = "DELETE FROM Client WHERE ID_client=@id;";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = dataGridView1.SelectedRows[0].Cells["ID_client"].Value.ToString() }
                        };

                        connexion.EnvoyerDonnees(query, parameters);

                        MessageBox.Show("Le client a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherClients();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
