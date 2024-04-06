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
    /// Classe TypeLivreManager
    /// </summary>
    public class TypeLivreManager
    {
        ConnexionManager connexion;

        /// <summary>
        /// Constructeur de la classe TypeLivreManager
        /// </summary>
        public TypeLivreManager() { 
            connexion = new ConnexionManager();
        }

        /// <summary>
        /// Récupère la liste des types de livre dans la base de données
        /// </summary>
        /// <returns>Liste des types de livre</returns>
        public List<TypeLivre> RecupererListeTypeLivre()
        {
            List<TypeLivre> listeTypeLivre = new List<TypeLivre>();

            string query = "SELECT * FROM TypeLivre;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                TypeLivre typeLivre = new TypeLivre(Convert.ToInt32(row["ID_type"]), row["type"].ToString());
                listeTypeLivre.Add(typeLivre);
            }

            return listeTypeLivre;
        }

        /// <summary>
        /// Crée un type de livre dans la base de données
        /// </summary>
        /// <param name="typeLivre"></param>
        /// <returns>Nombre de lignes ajoutées</returns>
        public int CreerTypeLivre(TypeLivre typeLivre)
        {
            string query = "INSERT INTO TypeLivre (type) " +
                "VALUES (@type);";

            SqlParameter[] parameters =
            {
                new SqlParameter("@type", SqlDbType.VarChar) { Value = typeLivre.GetLibelle() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Modfie un type de livre dans la base de données
        /// </summary>
        /// <param name="typeLivre"></param>
        /// <returns>Nombre de lignes modifiées</returns>
        public int ModifierTypeLivre(TypeLivre typeLivre)
        {
            string query = "UPDATE TypeLivre SET type = @type WHERE ID_type = @idType;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@type", SqlDbType.VarChar) { Value = typeLivre.GetLibelle() },
                new SqlParameter("@idType", SqlDbType.Int) { Value = typeLivre.GetIdTypeLivre() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Supprime un type de livre dans la base de données
        /// </summary>
        /// <param name="idTypeLivre"></param>
        /// <returns>Nombre de lignes supprimées</returns>
        public int SupprimerTypeLivre(int idTypeLivre)
        {
            string query = "DELETE FROM TypeLivre WHERE ID_type = @idType;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@idType", SqlDbType.Int) { Value = idTypeLivre }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Vérifie si un type de livre existe dans la base de données
        /// </summary>
        /// <param name="libelle"></param>
        /// <returns>Vrai si le type existe déja</returns>
        public bool TypeLivreExiste(string libelle)
        {
            string query = "SELECT COUNT(*) FROM TypeLivre WHERE type = @type;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@type", SqlDbType.VarChar) { Value = libelle }
            };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);

            return nombreOccurrences > 0;
        }

        /// <summary>
        /// Verifie qu'aucun livre n'est associé à un type de livre
        /// </summary>
        /// <param name="idTypeLivre"></param>
        /// <returns>Vrai si un livre est associé à ce type</returns>
        public bool LivreAssocie(int idTypeLivre)
        {
            string query = "SELECT COUNT(*) FROM Livre WHERE ID_type = @idType;";

            SqlParameter[] parameters =
            {
                new SqlParameter("@idType", SqlDbType.Int) { Value = idTypeLivre }
            };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);

            return nombreOccurrences > 0;
        }
    }
}
