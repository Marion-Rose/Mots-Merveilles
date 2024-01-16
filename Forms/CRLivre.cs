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
    public partial class CRLivre : Form
    {
        ConnexionManager connexion;
        private int idLivreToModify;
        public CRLivre(bool param, int? idLivre = null)
        {
            InitializeComponent();
            connexion = new ConnexionManager();
            ChargerComboBox();
            if (idLivre != null) { this.idLivreToModify = (int)idLivre; }

            // Si param est true, bouton créer est visible, sinon bouton modifier est visible
            if (param)
            {
                btModifier.Hide();
            }
            else
            {
                PreremplirChamps();
                btCreer.Hide();
            }

        }

        private void PreremplirChamps()
        {
            try
            {
                string query = "SELECT l.ID_livre, l.titre, CONCAT(a.nom, ' ', a.prenom) AS auteur, e.nom AS editeur, l.ISBN, t.type AS type, l.prix, l.quantite " +
                "FROM Livre l " +
                "INNER JOIN Auteur a ON l.ID_auteur = a.ID_auteur " +
                "INNER JOIN Editeur e ON l.ID_editeur = e.ID_editeur " +
                "INNER JOIN TypeLivre t ON l.ID_type = t.ID_type " +
                "WHERE l.ID_livre = " + this.idLivreToModify + "; ";
                DataTable DataSource = connexion.RecupererDonnees(query);
                txtTitre.Text = DataSource.Rows[0]["titre"].ToString();
                comboBoxAuteur.Text = DataSource.Rows[0]["auteur"].ToString();
                comboBoxEditeur.Text = DataSource.Rows[0]["editeur"].ToString();
                comboBoxType.Text = DataSource.Rows[0]["type"].ToString();
                txtIsbn.Text = DataSource.Rows[0]["ISBN"].ToString();
                txtPrix.Text = DataSource.Rows[0]["prix"].ToString();
                txtQuantite.Text = DataSource.Rows[0]["quantite"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChargerComboBox()
        {
            // Assigner les données de la BD aux ComboBox
            string queryAuteur = "SELECT CONCAT(a.nom, ' ', a.prenom) AS Auteur, a.ID_auteur FROM Auteur a;";
            DataTable dataAuteur = connexion.RecupererDonnees(queryAuteur);
            comboBoxAuteur.DataSource = dataAuteur;
            comboBoxAuteur.DisplayMember = "Auteur";

            string queryEditeur = "SELECT e.nom AS Editeur, e.ID_editeur FROM Editeur e;";
            DataTable dataEditeur = connexion.RecupererDonnees(queryEditeur);
            comboBoxEditeur.DataSource = dataEditeur;
            comboBoxEditeur.DisplayMember = "Editeur";

            string queryType = "SELECT t.type AS Type, t.ID_type FROM TypeLivre t;";
            DataTable dataType = connexion.RecupererDonnees(queryType);
            comboBoxType.DataSource = dataType;
            comboBoxType.DisplayMember = "Type";
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (txtTitre.Text != "" && txtIsbn.Text != "" && txtPrix.Text != "" && txtQuantite.Text != "")
            {
                try
                {
                    {
                        comboBoxAuteur.ValueMember = "ID_auteur";
                        comboBoxEditeur.ValueMember = "ID_editeur";
                        comboBoxType.ValueMember = "ID_type";
                        int idAuteurSelectionne = (int)comboBoxAuteur.SelectedValue;
                        int idEditeurSelectionne = (int)comboBoxEditeur.SelectedValue;
                        int idTypeSelectionne = (int)comboBoxType.SelectedValue;

                        string query = "INSERT INTO Livre (titre, ID_auteur, Id_editeur, ISBN, ID_type, prix, quantite) VALUES (@titre, @auteur, @editeur, @isbn, @type, @prix, @quantite)";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@titre", SqlDbType.VarChar) { Value = txtTitre.Text },
                            new SqlParameter("@auteur", SqlDbType.VarChar) { Value = idAuteurSelectionne },
                            new SqlParameter("@editeur", SqlDbType.VarChar) { Value = idEditeurSelectionne },
                            new SqlParameter("@isbn", SqlDbType.VarChar) { Value = txtIsbn.Text },
                            new SqlParameter("@type", SqlDbType.VarChar) { Value = idTypeSelectionne },
                            new SqlParameter("@prix", SqlDbType.VarChar) { Value = txtPrix.Text },
                            new SqlParameter("@quantite", SqlDbType.VarChar) { Value = txtQuantite.Text }
                        };

                        connexion.EnvoyerDonnees(query, parameters);
                    }

                    MessageBox.Show("Le livre a bien été ajouté", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création du livre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtTitre.Text != "" && txtIsbn.Text != "" && txtPrix.Text != "" && txtQuantite.Text != "")
            {
                try
                {
                    comboBoxAuteur.ValueMember = "ID_auteur";
                    comboBoxEditeur.ValueMember = "ID_editeur";
                    comboBoxType.ValueMember = "ID_type";
                    int idAuteurSelectionne = (int)comboBoxAuteur.SelectedValue;
                    int idEditeurSelectionne = (int)comboBoxEditeur.SelectedValue;
                    int idTypeSelectionne = (int)comboBoxType.SelectedValue;

                    string query = "UPDATE Livre SET titre=@titre, ID_auteur=@auteur, Id_editeur=@editeur, ISBN=@isbn, ID_type=@type, prix=@prix, quantite=@quantite WHERE ID_livre =@id;";

                    // Définissez les paramètres
                    SqlParameter[] parameters =
                    {
                            new SqlParameter("@titre", SqlDbType.VarChar) { Value = txtTitre.Text },
                            new SqlParameter("@auteur", SqlDbType.VarChar) { Value = idAuteurSelectionne },
                            new SqlParameter("@editeur", SqlDbType.VarChar) { Value = idEditeurSelectionne },
                            new SqlParameter("@isbn", SqlDbType.VarChar) { Value = txtIsbn.Text },
                            new SqlParameter("@type", SqlDbType.VarChar) { Value = idTypeSelectionne },
                            new SqlParameter("@prix", SqlDbType.VarChar) { Value = txtPrix.Text },
                            new SqlParameter("@quantite", SqlDbType.VarChar) { Value = txtQuantite.Text },
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = this.idLivreToModify}
                        };
                    connexion.EnvoyerDonnees(query, parameters);

                    MessageBox.Show("Le livre a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification du livre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
