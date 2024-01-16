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
    public partial class CRClient : Form
    {
        ConnexionManager connexion;
        private int idClientToModify;

        public CRClient(bool param, int? idClient = null)
        {
            InitializeComponent();
            connexion = new ConnexionManager();
            if (idClient != null) { this.idClientToModify = (int)idClient; }

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
                string query = "SELECT * FROM Client " + "WHERE ID_client = " + this.idClientToModify + "; ";
                DataTable DataSource = connexion.RecupererDonnees(query);
                txtNom.Text = DataSource.Rows[0]["nom"].ToString();
                txtPrenom.Text = DataSource.Rows[0]["prenom"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(DataSource.Rows[0]["dateNaissance"]);
                comboBoxGenre.Text = DataSource.Rows[0]["sexe"].ToString();
                txtAdresse.Text = DataSource.Rows[0]["adresse"].ToString();
                txtCP.Text = DataSource.Rows[0]["codePostal"].ToString();
                txtVille.Text = DataSource.Rows[0]["ville"].ToString();
                txtTelephone.Text = DataSource.Rows[0]["telephone"].ToString();
                txtMail.Text = DataSource.Rows[0]["mail"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            if (txtNom.Text !="" && txtPrenom.Text !="" && txtAdresse.Text != "" && txtCP.Text !="" && txtVille.Text !="" && txtTelephone.Text !="" && txtMail.Text != "" )
            {
                try
                {
                    {
                        string query = "INSERT INTO Client (nom, prenom, dateNaissance, sexe, adresse, codePostal, ville, telephone, mail) " +
                            "VALUES (@nom, @prenom, @dateNaissance, @sexe, @adresse, @codePostal, @ville, @telephone, @mail);";

                        // Définissez les paramètres
                        SqlParameter[] parameters = {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = txtNom.Text },
                            new SqlParameter("@prenom", SqlDbType.VarChar) { Value = txtPrenom.Text },
                            new SqlParameter("@dateNaissance", SqlDbType.Date) { Value = dateTimePicker1.Value },
                            new SqlParameter("@sexe", SqlDbType.VarChar) { Value = comboBoxGenre.Text },
                            new SqlParameter("@adresse", SqlDbType.VarChar) { Value = txtAdresse.Text },
                            new SqlParameter("@codePostal", SqlDbType.VarChar) { Value = txtCP.Text },
                            new SqlParameter("@ville", SqlDbType.VarChar) { Value = txtVille.Text },
                            new SqlParameter("@telephone", SqlDbType.VarChar) { Value = txtTelephone.Text },
                            new SqlParameter("@mail", SqlDbType.VarChar) { Value = txtMail.Text }
                            
                        };

                        connexion.EnvoyerDonnees(query, parameters);
                    }

                    MessageBox.Show("Le client a bien été ajouté", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtAdresse.Text != "" && txtCP.Text != "" && txtVille.Text != "" && txtTelephone.Text != "" && txtMail.Text != "")
            {
                try
                {
                    string query = "UPDATE Client SET nom=@nom, prenom=@prenom, dateNaissance=@dateNaissance, sexe=@sexe, adresse=@adresse, codePostal=@codePostal, ville=@ville, telephone=@telephone, mail=@mail WHERE ID_client =@id;";

                    // Définissez les paramètres
                    SqlParameter[] parameters =
                    {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = txtNom.Text },
                            new SqlParameter("@prenom", SqlDbType.VarChar) { Value = txtPrenom.Text },
                            new SqlParameter("@dateNaissance", SqlDbType.Date) { Value = dateTimePicker1.Value },
                            new SqlParameter("@sexe", SqlDbType.VarChar) { Value = comboBoxGenre.Text },
                            new SqlParameter("@adresse", SqlDbType.VarChar) { Value = txtAdresse.Text },
                            new SqlParameter("@codePostal", SqlDbType.VarChar) { Value = txtCP.Text },
                            new SqlParameter("@ville", SqlDbType.VarChar) { Value = txtVille.Text },
                            new SqlParameter("@telephone", SqlDbType.VarChar) { Value = txtTelephone.Text },
                            new SqlParameter("@mail", SqlDbType.VarChar) { Value = txtMail.Text },
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = this.idClientToModify }
                        };
                    connexion.EnvoyerDonnees(query, parameters);

                    MessageBox.Show("Le client a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
