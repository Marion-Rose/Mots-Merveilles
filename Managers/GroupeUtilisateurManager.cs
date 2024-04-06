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
    /// Classe GroupeUtilisateurManager
    /// </summary>
    public class GroupeUtilisateurManager
    {
        ConnexionManager connexion;

        /// <summary>
        /// Constructeur de la classe GroupeUtilisateurManager
        /// </summary>
        public GroupeUtilisateurManager()
        {
            connexion = new ConnexionManager();
        }

        /// <summary>
        /// Récupère la liste des groupes d'utilisateurs dans la base de données
        /// </summary>
        /// <returns></returns>
        public List<GroupeUtilisateur> RecupererListeGroupeUtilisateur()
        {
            List<GroupeUtilisateur> listeGroupeUtilisateurs = new List<GroupeUtilisateur>();

            string query = "SELECT * FROM GroupeUtilisateur;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                GroupeUtilisateur groupeUtilisateur = new GroupeUtilisateur(Convert.ToInt32(row["ID_groupe"]), row["nom"].ToString(), Convert.ToBoolean(row["est_admin"]));
                listeGroupeUtilisateurs.Add(groupeUtilisateur);
            }

            return listeGroupeUtilisateurs;
        }

        /// <summary>
        /// Récupère un groupe d'utilisateur dans la base de données
        /// </summary>
        /// <param name="idGroupeUtilisateur"></param>
        /// <returns></returns>
        public GroupeUtilisateur AfficherGroupeUtilisateur(int idGroupeUtilisateur)
        {
            string query = "SELECT * FROM GroupeUtilisateur WHERE ID_groupe = @idGroupeUtilisateur;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@idGroupeUtilisateur", SqlDbType.Int) { Value = idGroupeUtilisateur }
            };

            DataTable dataTable = connexion.RecupererDonnees(query, parameters);
            DataRow row = dataTable.Rows[0];
            GroupeUtilisateur groupeUtilisateur = new GroupeUtilisateur(Convert.ToInt32(row["ID_groupe"]), row["nom"].ToString(), Convert.ToBoolean(row["est_admin"]));

            return groupeUtilisateur;
        }
    }
}
