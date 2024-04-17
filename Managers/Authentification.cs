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
    /// <summary>
    /// Classe permettant de gérer l'authentification des utilisateurs
    /// </summary>
    public class Authentification
    {
        private static Authentification instance;
        private Utilisateur utilisateurCo;
        private EmployeManager employeManager;
        private GroupeUtilisateurManager groupeUtilisateurManager;
        ConnexionManager connexion;

        /// <summary>
        /// Constructeur de la classe Authentification
        /// </summary>
        private Authentification()
        {
            connexion = new ConnexionManager();
            employeManager = new EmployeManager();
            groupeUtilisateurManager = new GroupeUtilisateurManager();
        }

        /// <summary>
        /// Méthode permettant de récupérer l'instance de la classe Authentification
        /// </summary>
        /// <returns>Istance d'authentification</returns>
        public static Authentification Instance()
        {
            if (instance == null)
            {
                instance = new Authentification();
            }
            return instance;
        }

        /// <summary>
        /// Propriété permettant de récupérer/modifier l'utilisateur connecté
        /// </summary>
        public Utilisateur UtilisateurCo
        {
            get { return utilisateurCo; }
            set { utilisateurCo = value; }
        }

        /// <summary>
        /// Méthode permettant de vérifier l'authentification d'un utilisateur
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <param name="motDePasseUtilise"></param>
        /// <returns>Vrai si authentification réussie</returns>
        public bool Authentication(string utilisateur, string motDePasseUtilise)
        {
            try
            {
                string strConnection = "Data Source=PC-MARION\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";

                using (SqlConnection connection = new SqlConnection(strConnection))
                {
                    connection.Open();

                    string query = "SELECT * FROM Utilisateur WHERE identifiant=@utilisateur";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@utilisateur", utilisateur);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Si l'utilisateur existe
                            if (reader.Read())
                            {
                                // Si le mot de passe est correct
                                if(HashageMotDePasse.VerifierMotDePasse(motDePasseUtilise, reader.GetString(reader.GetOrdinal("mot_de_passe")), reader.GetString(reader.GetOrdinal("sel"))))
                                {
                                    bool estActif = reader.GetBoolean(reader.GetOrdinal("est_actif"));
                                    // Si l'utilisateur est actif
                                    if (!estActif)
                                    {
                                        MessageBox.Show("Votre compte est désactivé.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return false;
                                    }
                                    else {
                                        int id = reader.GetInt32(reader.GetOrdinal("ID_utilisateur"));
                                        int idEmploye = reader.GetInt32(reader.GetOrdinal("ID_employe"));
                                        string identifiant = reader.GetString(reader.GetOrdinal("identifiant"));
                                        string motDePasse = reader.GetString(reader.GetOrdinal("mot_de_passe"));
                                        int groupe = reader.GetInt32(reader.GetOrdinal("groupe"));

                                        Employe employe = employeManager.AfficherEmploye(idEmploye);
                                        GroupeUtilisateur groupeUtilisateur = groupeUtilisateurManager.AfficherGroupeUtilisateur(groupe);

                                        utilisateurCo = new Utilisateur(id, employe, identifiant, motDePasse, estActif, groupeUtilisateur);
                                        return true;
                                    }
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur d'authentification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return false;
                                }
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
