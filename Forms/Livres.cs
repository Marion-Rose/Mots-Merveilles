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
    public partial class Livres : Accueil
    {
        ConnexionManager connexion;
        public Livres()
        {
            InitializeComponent();
            connexion = new ConnexionManager();
            AfficherLivres();
        }

        private void AfficherLivres()
        {
            string query = "SELECT l.ID_livre, l.titre, CONCAT(a.nom, ' ', a.prenom) AS auteur, e.nom AS editeur, l.ISBN, t.type AS type, l.prix, l.quantite " +
                "FROM Livre l " +
                "INNER JOIN Auteur a ON l.ID_auteur = a.ID_auteur " +
                "INNER JOIN Editeur e ON l.ID_editeur = e.ID_editeur " +
                "INNER JOIN TypeLivre t ON l.ID_type = t.ID_type;";
            dataGridView1.DataSource = connexion.RecupererDonnees(query);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;// Ajustez la largeur des colonnes pour remplir la grille
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;//Sélectionnez toute la ligne au lieu d'une cellule
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;// Changez la couleur des en-têtes de colonnes
            dataGridView1.EnableHeadersVisualStyles = false;//Annule le style par défaut des en-têtes de colonnes
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FloralWhite;// Changez la couleur des lignes alternatives
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Tan;// Changez la couleur de fond de la ligne sélectionnée
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;// Ajustez la largeur des colonnes à leur contenu
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            CRLivre Obj = new CRLivre(true);
            Obj.ShowDialog();
            this.Show();
            AfficherLivres();
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CRLivre Obj = new CRLivre(false, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                Obj.ShowDialog();
                this.Show();
                AfficherLivres();
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
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer le livre : " + dataGridView1.SelectedRows[0].Cells[1].Value, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Si l'utilisateur clique sur "Oui", supprimez l'auteur
                if (result == DialogResult.Yes)
                {

                    try
                    {
                        string query = "DELETE FROM Livre WHERE ID_livre=@id;";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = dataGridView1.SelectedRows[0].Cells["ID_livre"].Value.ToString() }
                        };

                        connexion.EnvoyerDonnees(query, parameters);

                        MessageBox.Show("Le livre a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        AfficherLivres();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression du livre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
