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
    /// Classe ClientManager
    /// </summary>
    public class ClientManager
    {
        ConnexionManager connexion;

        /// <summary>
        /// Constructeur de la classe ClientManager
        /// </summary>
        public ClientManager()
        {
            connexion = new ConnexionManager();
        }
                                                     
        ///<summary>
        ///Récupère la liste des clients dans la base de données
        ///</summary>
        ///<returns>Liste des clients</returns>
        public List<Client> RecupererListeClient()
        {
            List<Client> listeClients = new List<Client>();
                                                     
            string query = "SELECT ID_client, nom, prenom, dateNaissance, sexe, adresse, codePostal, ville, telephone, mail FROM Client;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Client client = new Client(Convert.ToInt32(row["ID_client"]), row["nom"].ToString(), row["prenom"].ToString(), Convert.ToDateTime(row["dateNaissance"]), row["sexe"].ToString(), row["adresse"].ToString(), row["codePostal"].ToString(), row["ville"].ToString(), row["telephone"].ToString(), row["mail"].ToString());
                listeClients.Add(client);
            }
            return listeClients;
        }

        ///<summary>
        ///Recupère un client dans la base de données
        ///</summary>
        ///<returns>Client</returns>
        public Client AfficherClient(int idClient) 
        {      
            string query = "SELECT ID_client, nom, prenom, dateNaissance, sexe, adresse, codePostal, ville, telephone, mail FROM Client WHERE ID_client = @id;";
            SqlParameter[] parameters =
            {
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = idClient },
            };
            DataTable dataTable = connexion.RecupererDonnees(query, parameters);
            DataRow row = dataTable.Rows[0];
            Client client = new Client(Convert.ToInt32(row["ID_client"]), row["nom"].ToString(), row["prenom"].ToString(), Convert.ToDateTime(row["dateNaissance"]), row["sexe"].ToString(), row["adresse"].ToString(), row["codePostal"].ToString(), row["ville"].ToString(), row["telephone"].ToString(), row["mail"].ToString());
            return client;
        }

        /// <summary>
        /// Créer un client dans la base de données
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Nombre de lignes ajoutées</returns>
        public int CreerClient(Client client)
        {
            string query = "INSERT INTO Client (nom, prenom, dateNaissance, sexe, adresse, codePostal, ville, telephone, mail) VALUES (@nom, @prenom, @dateNaissance, @sexe, @adresse, @codePostal, @ville, @telephone, @mail);";
            SqlParameter[] parameters =
            {
                new SqlParameter("@nom", SqlDbType.VarChar) { Value = client.GetNom() },
                new SqlParameter("@prenom", SqlDbType.VarChar) { Value = client.GetPrenom() },
                new SqlParameter("@dateNaissance", SqlDbType.Date) { Value = client.GetDateNaissance() },
                new SqlParameter("@sexe", SqlDbType.VarChar) { Value = client.GetSexe() },
                new SqlParameter("@adresse", SqlDbType.VarChar) { Value = client.GetAdresse() },
                new SqlParameter("@codePostal", SqlDbType.VarChar) { Value = client.GetCodePostal() },
                new SqlParameter("@ville", SqlDbType.VarChar) { Value = client.GetVille() },
                new SqlParameter("@telephone", SqlDbType.VarChar) { Value = client.GetTelephone() },
                new SqlParameter("@mail", SqlDbType.VarChar) { Value = client.GetEmail() }
            };
            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Modifier un client dans la base de données
        /// </summary>
        /// <param name="client"></param>
        /// <returns>Nombre de lignes modifiées</returns>
        public int ModifierClient(Client client)
        {
            string query = "UPDATE Client SET nom = @nom, prenom = @prenom, dateNaissance = @dateNaissance, sexe = @sexe, adresse = @adresse, codePostal = @codePostal, ville = @ville, telephone = @telephone, mail = @mail WHERE ID_client = @id;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@nom", SqlDbType.VarChar) { Value = client.GetNom() },
                new SqlParameter("@prenom", SqlDbType.VarChar) { Value = client.GetPrenom() },
                new SqlParameter("@dateNaissance", SqlDbType.Date) { Value = client.GetDateNaissance() },
                new SqlParameter("@sexe", SqlDbType.VarChar) { Value = client.GetSexe() },
                new SqlParameter("@adresse", SqlDbType.VarChar) { Value = client.GetAdresse() },
                new SqlParameter("@codePostal", SqlDbType.VarChar) { Value = client.GetCodePostal() },
                new SqlParameter("@ville", SqlDbType.VarChar) { Value = client.GetVille() },
                new SqlParameter("@telephone", SqlDbType.VarChar) { Value = client.GetTelephone() },
                new SqlParameter("@mail", SqlDbType.VarChar) { Value = client.GetEmail() },
                new SqlParameter("@id", SqlDbType.VarChar) { Value = client.GetIdClient() }
            };
            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Supprimer un client dans la base de données
        /// </summary>
        /// <param name="idClient"></param>
        /// <returns>Nombre de lignes supprimées</returns>
        public int SupprimerClient(int idClient)
        {
            string query = "DELETE FROM Client WHERE ID_client = @id;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.VarChar) { Value = idClient }
            };
            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Vérifie si un client existe dans la base de données
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        /// <returns>Vrai si le client existe déjà</returns>
        public bool ClientExiste(string nom, string prenom, DateTime dateNaissance)
        {
            string query = "SELECT COUNT(*) FROM Client WHERE nom = @nom AND prenom = @prenom AND dateNaissance = @dateNaissance;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@nom", SqlDbType.VarChar) { Value = nom },
                new SqlParameter("@prenom", SqlDbType.VarChar) { Value = prenom },
                new SqlParameter("@dateNaissance", SqlDbType.Date) { Value = dateNaissance }
            };
            int nombreOccurences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);
            return nombreOccurences > 0;
        }
    }
}
