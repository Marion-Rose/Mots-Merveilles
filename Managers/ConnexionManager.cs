using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Managers
{
    /// <summary>
    /// Classe permettant de gérer la connexion à la base de données
    /// </summary>
    public class ConnexionManager
    {
        private SqlConnection connexion; //Connexion à la base de données
        private SqlCommand cmd; //Commande SQL à éxécuter
        private DataTable dt;//Tableau de données, où seront stockées les données récupérées
        private SqlDataAdapter sda;//transforme les données SQL en données C#
        private string strConnection;//stocke la chaine de connexion à la base de données

        /// <summary>
        /// Constructeur de la classe ConnexionManager
        /// </summary>
        public ConnexionManager()
        {
            this.strConnection = "Data Source=PC-MARION\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            this.connexion = new SqlConnection(strConnection);
            this.cmd = new SqlCommand();
            cmd.Connection = connexion;
        }

        /// <summary>
        /// Méthode permettant de récupérer des données de la base de données
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns>Table de données</returns>
        public DataTable RecupererDonnees(string query, SqlParameter[]? parameters = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        if (parameters != null)
                        {
                            cmd.Parameters.AddRange(parameters);
                        }

                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            connection.Open();
                            sda.Fill(dt);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return dt;
        }

        /// <summary>
        /// Méthode permettant d'envoyer des données à la base de données
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns>Nombre de lignes exécutées</returns>
        public int EnvoyerDonnees(string query, SqlParameter[] parameters)
        {
            int nbRow = 0;
            try
            {
                if (connexion.State == ConnectionState.Closed)
                {
                    connexion.Open();
                }
                cmd.CommandText = query;
                // Ajoutez les paramètres à la commande
                if (parameters != null)
                {
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddRange(parameters);
                }
                nbRow = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'envoie des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            return nbRow;
        }

    }
}
