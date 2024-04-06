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
        private EmployeManager employeManager;
        private GroupeUtilisateurManager groupeUtilisateurManager;
        ConnexionManager connexion;

        private Authentification()
        {
            connexion = new ConnexionManager();
            employeManager = new EmployeManager();
            groupeUtilisateurManager = new GroupeUtilisateurManager();
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

        public bool Authentication(string utilisateur, string motDePasseUtilise)
        {
            try
            {
                string strConnection = "Data Source=PC-MARION\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(strConnection))
                {
                    connection.Open();

                    string query = "SELECT * FROM Utilisateur WHERE identifiant=@utilisateur AND mot_de_passe=@motDePasse;";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Définissez les paramètres
                        command.Parameters.AddWithValue("@utilisateur", utilisateur);
                        command.Parameters.AddWithValue("@motDePasse", motDePasseUtilise);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int id = reader.GetInt32(reader.GetOrdinal("ID_utilisateur"));
                                int idEmploye = reader.GetInt32(reader.GetOrdinal("ID_employe"));
                                string identifiant = reader.GetString(reader.GetOrdinal("identifiant"));
                                string motDePasse = reader.GetString(reader.GetOrdinal("mot_de_passe"));
                                bool estActif = reader.GetBoolean(reader.GetOrdinal("est_actif"));
                                int groupe = reader.GetInt32(reader.GetOrdinal("groupe"));

                                Employe employe = employeManager.AfficherEmploye(idEmploye);
                                GroupeUtilisateur groupeUtilisateur = groupeUtilisateurManager.AfficherGroupeUtilisateur(groupe);

                                utilisateurCo = new Utilisateur(id, employe, identifiant, motDePasse, estActif, groupeUtilisateur);
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
