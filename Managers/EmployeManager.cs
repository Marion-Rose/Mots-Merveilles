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
    /// Classe EmployeManager
    /// </summary>
    public class EmployeManager
    {
        ConnexionManager connexion;

        /// <summary>
        /// Constructeur de la classe EmployeManager
        /// </summary>
        public EmployeManager()
        {
            connexion = new ConnexionManager();
        }

        /// <summary>
        /// Récupère la liste des employés dans la base de données
        /// </summary>
        /// <returns></returns>
        public List<Employe> RecupererListeEmploye()
        {
            List<Employe> listeEmployes = new List<Employe>();

            string query = "SELECT * FROM Employe;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Employe employe = new Employe(Convert.ToInt32(row["ID_employe"]), row["nom"].ToString(), row["prenom"].ToString(), Convert.ToDateTime(row["date_naissance"]), row["genre"].ToString(), row["adresse"].ToString(), row["ville"].ToString(), row["telephone"].ToString(), row["mail"].ToString());
                listeEmployes.Add(employe);
            }

            return listeEmployes;
        }

        /// <summary>
        /// Récupère un employé dans la base de données
        /// </summary>
        /// <param name="idEmploye"></param>
        /// <returns></returns>
        public Employe AfficherEmploye(int idEmploye)
        {
            string query = "SELECT * FROM Employe WHERE ID_employe = @idEmploye;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@idEmploye", SqlDbType.Int) { Value = idEmploye }
            };

            DataTable dataTable = connexion.RecupererDonnees(query, parameters);

            if (dataTable.Rows.Count == 0)
            {
                return null;
            }

            DataRow row = dataTable.Rows[0];
            Employe employe = new Employe(Convert.ToInt32(row["ID_employe"]), row["nom"].ToString(), row["prenom"].ToString(), Convert.ToDateTime(row["date_naissance"]), row["genre"].ToString(), row["adresse"].ToString(), row["ville"].ToString(), row["telephone"].ToString(), row["mail"].ToString());

            return employe;
        }

        /// <summary>
        /// Créer un employé dans la base de données
        /// </summary>
        /// <param name="employe"></param>
        /// <returns>Nombre de lignes insérées</returns>
        public int CreerEmploye(Employe employe)
        {
            string query = "INSERT INTO Employe (nom, prenom, date_naissance, genre, adresse, ville, telephone, mail) VALUES (@nom, @prenom, @dateNaissance, @genre, @adresse, @ville, @telephone, @mail);";
            SqlParameter[] parameters =
            {
                new SqlParameter("@nom", SqlDbType.VarChar) { Value = employe.GetNom() },
                new SqlParameter("@prenom", SqlDbType.VarChar) { Value = employe.GetPrenom() },
                new SqlParameter("@dateNaissance", SqlDbType.DateTime) { Value = employe.GetDateNaissance() },
                new SqlParameter("@genre", SqlDbType.VarChar) { Value = employe.GetGenre() },
                new SqlParameter("@adresse", SqlDbType.VarChar) { Value = employe.GetAdresse() },
                new SqlParameter("@ville", SqlDbType.VarChar) { Value = employe.GetVille() },
                new SqlParameter("@telephone", SqlDbType.VarChar) { Value = employe.GetTelephone() },
                new SqlParameter("@mail", SqlDbType.VarChar) { Value = employe.GetMail() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Modifier un employé dans la base de données
        /// </summary>
        /// <param name="employe"></param>
        /// <returns>Nombre de lignes modifiées</returns>
        public int ModifierEmploye(Employe employe)
        {
            string query = "UPDATE Employe SET nom = @nom, prenom = @prenom, date_naissance = @dateNaissance, genre = @genre, adresse = @adresse, ville = @ville, telephone = @telephone, mail = @mail WHERE ID_employe = @idEmploye;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@nom", SqlDbType.VarChar) { Value = employe.GetNom() },
                new SqlParameter("@prenom", SqlDbType.VarChar) { Value = employe.GetPrenom() },
                new SqlParameter("@dateNaissance", SqlDbType.DateTime) { Value = employe.GetDateNaissance() },
                new SqlParameter("@genre", SqlDbType.VarChar) { Value = employe.GetGenre() },
                new SqlParameter("@adresse", SqlDbType.VarChar) { Value = employe.GetAdresse() },
                new SqlParameter("@ville", SqlDbType.VarChar) { Value = employe.GetVille() },
                new SqlParameter("@telephone", SqlDbType.VarChar) { Value = employe.GetTelephone() },
                new SqlParameter("@mail", SqlDbType.VarChar) { Value = employe.GetMail() },
                new SqlParameter("@idEmploye", SqlDbType.Int) { Value = employe.GetIdEmploye() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Supprimer un employé dans la base de données
        /// </summary>
        /// <param name="idEmploye"></param>
        /// <returns></returns>
        public int SupprimerEmploye(int idEmploye)
        {
            string query = "DELETE FROM Employe WHERE ID_employe = @idEmploye;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@idEmploye", SqlDbType.Int) { Value = idEmploye }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Verifie si un employe existe déjà dans la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        /// <returns></returns>
        public bool EmployeExiste(string nom, string prenom, DateTime dateNaissance)
        {
            string query = "SELECT * FROM Employe WHERE nom = @nom AND prenom = @prenom AND dateNaissance = @dateNaissance;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@nom", SqlDbType.VarChar) { Value = nom },
                new SqlParameter("@prenom", SqlDbType.VarChar) { Value = prenom },
                new SqlParameter("@dateNaissance", SqlDbType.Date) { Value = dateNaissance }
            };

            DataTable dataTable = connexion.RecupererDonnees(query, parameters);

            return dataTable.Rows.Count > 0;
        }
    }
}
