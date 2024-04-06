using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mots_Merveilles.Classes;

namespace Mots_Merveilles.Managers
{
    /// <summary>
    /// Classe AuteurManager
    /// </summary>
    public class AuteurManager
    {
        ConnexionManager connexion;

        /// <summary>
        /// Constructeur de la classe AuteurManager
        /// </summary>
        public AuteurManager()
        {
            connexion = new ConnexionManager();
        }

        /// <summary>
        /// Récupère la liste des auteurs dans la base de données
        /// </summary>
        /// <returns>Liste auteurs</returns>
        public List<Auteur> RecupererListeAuteur()
        {
            List<Auteur> listeAuteurs = new List<Auteur>();

            string query = "SELECT * FROM Auteur;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Auteur auteur = new Auteur(Convert.ToInt32(row["Id_Auteur"]), row["nom"].ToString(), row["prenom"].ToString());
                listeAuteurs.Add(auteur);
            }

            return listeAuteurs;
        }

        /// <summary>
        /// Crée un auteur dans la base de données
        /// </summary>
        /// <param name="auteur"></param>
        /// <returns>nombre de lignes insérées</returns>
        public int CreerAuteur(Auteur auteur)
        {
            string query = "INSERT INTO Auteur (nom, prenom) " +
                "VALUES (@nom, @prenom);";

            SqlParameter[] parameters =
            {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = auteur.GetNom() },
                            new SqlParameter("@prenom", SqlDbType.VarChar) { Value = auteur.GetPrenom() }
            };

           return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Modifie un auteur dans la base de données
        /// </summary>
        /// <param name="auteur"></param>
        /// <returns>nombre de lignes modifiées</returns>
        public int ModifierAuteur(Auteur auteur)
        {
            string query = "UPDATE Auteur SET Nom = @Nom, Prenom = @Prenom WHERE ID_Auteur = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Nom", SqlDbType.VarChar, 50) { Value = auteur.GetNom() },
                new SqlParameter("@Prenom", SqlDbType.VarChar, 50) { Value = auteur.GetPrenom() },
                new SqlParameter("@Id", SqlDbType.Int) { Value = auteur.GetIdAuteur() }
            };
            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Supprime un auteur de la base de données
        /// </summary>
        /// <param name="idAuteur"></param>
        /// <returns>nombre de lignes supprimées</returns>
        public int SupprimerAuteur(int idAuteur)
        {
            string query = "DELETE FROM Auteur WHERE ID_Auteur = @Id";
            SqlParameter[] parameters = {
                new SqlParameter("@Id", SqlDbType.Int) { Value = idAuteur}
            };
            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Vérifie si un auteur existe déjà dans la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <returns>Vrai si il existe déjà</returns>
        public bool EntreeExisteDeja(string nom, string prenom)
        {
            string query = "SELECT COUNT(*) FROM Auteur WHERE nom = @nom AND prenom=@prenom";

            SqlParameter[] parameters = {
                new SqlParameter("@nom", SqlDbType.VarChar) { Value = nom },
                new SqlParameter("@prenom", SqlDbType.VarChar) { Value = prenom }
            };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);

            return nombreOccurrences > 0;
        }

        /// <summary>
        /// Verifie si un livre est associé à un auteur
        /// </summary>
        /// <param name="idAuteur"></param>
        /// <returns>Vrai si un livre est associé à cet auteur</returns>
        public bool LivreAssocie(int idAuteur)
        {
            string query = "SELECT COUNT(*) FROM Livre WHERE ID_auteur = @idAuteur";

            SqlParameter[] parameters =
            {
                new SqlParameter("@idAuteur", SqlDbType.Int) { Value = idAuteur }
            };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);

            return nombreOccurrences > 0;
        }
    }
}
