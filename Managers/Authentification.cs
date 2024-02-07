using Mots_Merveilles.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Mots_Merveilles.Managers
{
    public class Authentification
    {
        private static Authentification instance;
        private Utilisateur utilisateurCo;
        ConnexionManager connexion;


        private Authentification()
        {
            connexion = new ConnexionManager();
        }

        public static Authentification Instance()
        {
            if (instance == null)
            {
                instance = new Authentification();
            }
            return instance;
        }

        public Utilisateur UtilisateurCo
        {
            get { return utilisateurCo; }
            set { utilisateurCo = value; }
        }

        public bool Authentication(string utilisateur, string motDePasse)
        {
            try
            {
                string strConnection = "Data Source=PC-MARION\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(strConnection))
                {
                    connection.Open();

                    string query = "SELECT * FROM employe WHERE identifiant=@utilisateur AND mot_de_passe=@motDePasse;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Définissez les paramètres
                        command.Parameters.AddWithValue("@utilisateur", utilisateur);
                        command.Parameters.AddWithValue("@motDePasse", motDePasse);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(reader.GetOrdinal("ID_employe"));
                                string nom = reader.GetString(reader.GetOrdinal("nom"));
                                string prenom = reader.GetString(reader.GetOrdinal("prenom"));
                                string identifiant = reader.GetString(reader.GetOrdinal("identifiant"));
                                bool estActif = reader.GetBoolean(reader.GetOrdinal("est_actif"));
                                int groupe = reader.GetInt32(reader.GetOrdinal("groupe"));
                                utilisateurCo = new Utilisateur(id, nom, prenom, identifiant, estActif, groupe);
                                MessageBox.Show("Connexion réussie !");
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur");
            }

            return false;

        }
    }
}
