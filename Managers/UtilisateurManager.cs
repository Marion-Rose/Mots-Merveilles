using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mots_Merveilles.Classes;
using Mots_Merveilles.Forms;
namespace Mots_Merveilles.Managers
{
    /// <summary>
    /// Classe UtilisateurManager
    /// </summary>
    public class UtilisateurManager
    {
        ConnexionManager connexion;
        EmployeManager employeManager;
        GroupeUtilisateurManager groupeUtilisateurManager;

        /// <summary>
        /// Constructeur de la classe UtilisateurManager
        /// </summary>
        public UtilisateurManager()
        {
            connexion = new ConnexionManager();
            employeManager = new EmployeManager();
            groupeUtilisateurManager = new GroupeUtilisateurManager();
        }

        /// <summary>
        /// Récupère la liste des utilisateurs dans la base de données
        /// </summary>
        public List<Utilisateur> RecupererListeUtilisateur()
        {
            List<Utilisateur> listeUtilisateurs = new List<Utilisateur>();

            string query = "SELECT * FROM Utilisateur;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Employe employe = employeManager.AfficherEmploye(Convert.ToInt32(row["ID_employe"]));
                GroupeUtilisateur groupe = groupeUtilisateurManager.AfficherGroupeUtilisateur(Convert.ToInt32(row["groupe"]));
                Utilisateur utilisateur = new Utilisateur(Convert.ToInt32(row["ID_utilisateur"]), employe, row["identifiant"].ToString(), row["mot_de_passe"].ToString(), Convert.ToBoolean(row["est_actif"]), groupe);
                listeUtilisateurs.Add(utilisateur);
            }
            return listeUtilisateurs;
        }

        /// <summary>
        /// Récupère un utilisateur dans la base de données
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns>Utilisateur</returns>
        public Utilisateur AfficherUtilisateur(int idUtilisateur)
        {
            string query = "SELECT * FROM Utilisateur WHERE ID_utilisateur = @idUtilisateur;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@idUtilisateur", SqlDbType.Int) { Value = idUtilisateur }
            };

            DataTable dataTable = connexion.RecupererDonnees(query, parameters);
            DataRow row = dataTable.Rows[0];
            Employe employe = employeManager.AfficherEmploye(Convert.ToInt32(row["ID_employe"]));
            GroupeUtilisateur groupe = groupeUtilisateurManager.AfficherGroupeUtilisateur(Convert.ToInt32(row["groupe"]));
            Utilisateur utilisateur = new Utilisateur(Convert.ToInt32(row["ID_utilisateur"]), employe, row["identifiant"].ToString(), row["mot_de_passe"].ToString(), Convert.ToBoolean(row["est_actif"]), groupe);
            return utilisateur;
        }

        /// <summary>
        /// Créer un utilisateur dans la base de données
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <returns>Nombre de lignes insérées</returns>
        public int CreerUtilisateur(Utilisateur utilisateur)
        {
            string query = "INSERT INTO Utilisateur (ID_employe, identifiant, mot_de_passe, est_actif, groupe) VALUES (@ID_employe, @identifiant, @mot_de_passe, @est_actif, @ID_groupe);";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID_employe", SqlDbType.Int) { Value = utilisateur.GetEmploye().GetIdEmploye() },
                new SqlParameter("@identifiant", SqlDbType.VarChar) { Value = utilisateur.GetIdentifiant() },
                new SqlParameter("@mot_de_passe", SqlDbType.VarChar) { Value = utilisateur.GetMotDePasse() },
                new SqlParameter("@est_actif", SqlDbType.Bit) { Value = utilisateur.GetEstActif() },
                new SqlParameter("@ID_groupe", SqlDbType.Int) { Value = utilisateur.GetGroupe().GetIdGroupeUtilisateur() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Modifier un utilisateur dans la base de données
        /// </summary>
        /// <param name="utilisateur"></param>
        /// <returns>Nombre de lignes modifiées</returns>
        public int ModifierUtilisateur(Utilisateur utilisateur)
        {
            string query = "UPDATE Utilisateur SET ID_employe = @ID_employe, identifiant = @identifiant, mot_de_passe = @mot_de_passe, est_actif = @est_actif, groupe = @ID_groupe WHERE ID_utilisateur = @ID_utilisateur;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID_employe", SqlDbType.Int) { Value = utilisateur.GetEmploye().GetIdEmploye() },
                new SqlParameter("@identifiant", SqlDbType.VarChar) { Value = utilisateur.GetIdentifiant() },
                new SqlParameter("@mot_de_passe", SqlDbType.VarChar) { Value = utilisateur.GetMotDePasse() },
                new SqlParameter("@est_actif", SqlDbType.Bit) { Value = utilisateur.GetEstActif() },
                new SqlParameter("@ID_groupe", SqlDbType.Int) { Value = utilisateur.GetGroupe().GetIdGroupeUtilisateur() },
                new SqlParameter("@ID_utilisateur", SqlDbType.Int) { Value = utilisateur.GetID() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Supprimer un utilisateur dans la base de données
        /// </summary>
        /// <param name="idUtilisateur"></param>
        /// <returns>Nombre de lignes supprimées</returns>
        public int SupprimerUtilisateur(int idUtilisateur)
        {
            string query = "DELETE FROM Utilisateur WHERE ID_utilisateur = @ID_utilisateur;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@ID_utilisateur", SqlDbType.Int) { Value = idUtilisateur }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }
                
    }
}
