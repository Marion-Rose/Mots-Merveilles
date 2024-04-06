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
    /// Classe EditeurManager
    /// </summary>
    public class EditeurManager
    {
        ConnexionManager connexion;

        /// <summary>
        /// Constructeur de la classe EditeurManager
        /// </summary>
        public EditeurManager()
        {
            connexion = new ConnexionManager();
        }

        /// <summary>
        /// Récupère la liste des éditeurs dans la base de données
        /// </summary>
        /// <returns>Liste d'éditeurs</returns>
        public List<Editeur> RecupererListeEditeur()
        {
            List<Editeur> listeEditeurs = new List<Editeur>();

            string query = "SELECT * FROM Editeur;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Editeur editeur = new Editeur(Convert.ToInt32(row["ID_editeur"]), row["nom"].ToString(), row["adresse"].ToString(), row["telephone"].ToString(), row["mail"].ToString());
                listeEditeurs.Add(editeur);
            }

            return listeEditeurs;
        }

        /// <summary>
        /// Crée un éditeur dans la base de données
        /// </summary>
        /// <param name="editeur"></param>
        /// <returns>Nombre de lignes insérées</returns>
        public int CreerEditeur(Editeur editeur)
        {
            string query = "INSERT INTO Editeur (nom, adresse, telephone, mail) " +
                "VALUES (@nom, @adresse, @telephone, @mail);";

            SqlParameter[] parameters =
            {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = editeur.GetNom() },
                            new SqlParameter("@adresse", SqlDbType.VarChar) { Value = editeur.GetAdresse() },
                            new SqlParameter("@telephone", SqlDbType.VarChar) { Value = editeur.GetTelephone() },
                            new SqlParameter("@mail", SqlDbType.VarChar) { Value = editeur.GetEmail() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Modifie un éditeur dans la base de données
        /// </summary>
        /// <param name="editeur"></param>
        /// <returns>Nombre de lignes modifiées</returns>
        public int ModifierEditeur(Editeur editeur)
        {
            string query = "UPDATE Editeur SET nom = @nom, adresse = @adresse, telephone = @telephone, mail = @mail WHERE ID_editeur = @ID_editeur;";

            SqlParameter[] parameters =
            {
                            new SqlParameter("@ID_editeur", SqlDbType.Int) { Value = editeur.GetIdEditeur() },
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = editeur.GetNom() },
                            new SqlParameter("@adresse", SqlDbType.VarChar) { Value = editeur.GetAdresse() },
                            new SqlParameter("@telephone", SqlDbType.VarChar) { Value = editeur.GetTelephone() },
                            new SqlParameter("@mail", SqlDbType.VarChar) { Value = editeur.GetEmail() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Supprime un éditeur de la base de données
        /// </summary>
        /// <param name="idEditeur"></param>
        /// <returns>Nombre de lignes supprimées</returns>
        public int SupprimerEditeur(int idEditeur)
        {
            string query = "DELETE FROM Editeur WHERE ID_editeur = @ID_editeur;";

            SqlParameter[] parameters =
            {
                            new SqlParameter("@ID_editeur", SqlDbType.Int) { Value = idEditeur }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Vérifie si un éditeur existe déjà dans la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <returns>Vrai si il existe</returns>
        public bool EditeurExiste(string nom)
        {
            string query = "SELECT COUNT(*) FROM Editeur WHERE nom = @nom;";
            SqlParameter[] parameters =
            {
                            new SqlParameter("@nom", SqlDbType.VarChar) { Value = nom }
            };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);

            return nombreOccurrences > 0;
        }

        /// <summary>
        /// Vérifie si un éditeur est associé à un livre
        /// </summary>
        /// <param name="idEditeur"></param>
        /// <returns>Vrai si l'éditeur est associé à un livre</returns>
        public bool LivreAssocie(int idEditeur)
        {
            string query = "SELECT COUNT(*) FROM Livre WHERE ID_editeur = @idEditeur;";
            SqlParameter[] parameters =
            {
                   new SqlParameter("@idEditeur", SqlDbType.Int) { Value = idEditeur }
            };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);

            return nombreOccurrences > 0;
        }

        /// <summary>
        /// Vérifie si un éditeur est associé à une commande avant de le supprimer
        /// </summary>
        /// <param name="idEditeur"></param>
        /// <returns></returns>
        public bool CommandeAssociee(int idEditeur)
        {
            string query = "SELECT COUNT(*) FROM Commande WHERE ID_editeur = @idEditeur;";
            SqlParameter[] parameters =
            {
                   new SqlParameter("@idEditeur", SqlDbType.Int) { Value = idEditeur }
            };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);

            return nombreOccurrences > 0;
        }
    }
}
