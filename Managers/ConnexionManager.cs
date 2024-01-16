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

    internal class ConnexionManager
    {
        private SqlConnection connexion; //Connexion à la base de données
        private SqlCommand cmd; //Commande SQL à éxécuter
        private DataTable dt;//Tableau de données, où seront stockées les données récupérées
        private SqlDataAdapter sda;//transforme les données SQL en données C#
        private string strConnection;//stocke la chaine de connexion à la base de données
        //private static ConnexionManager instance;
        //private User userCo;
        //private string strConnection;

        public ConnexionManager() //Constructeur
        {
            this.strConnection = "Data Source=PC-MARION\\SQLEXPRESS;Initial Catalog=library;Integrated Security=True";
            this.connexion = new SqlConnection(strConnection);
            this.cmd = new SqlCommand();
            cmd.Connection = connexion;
        //    this.strConnection = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
        }

        public DataTable RecupererDonnees(string query)
        {
            dt = new DataTable();
            using (SqlConnection connection = new SqlConnection(strConnection))
            {
                try
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter(query, connection))
                    {
                        connection.Open();
                        sda.Fill(dt);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return dt;
        
        }

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

        //public static ConnexionManager Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new ConnexionManager();
        //        }
        //        return instance;
        //    }
        //}

        //public User UserCo
        //{
        //    get { return userCo; }
        //    set { userCo = value; }
        //}

        //public bool Authentication(string username, string password)
        //{
        //    using MySqlConnection connection = new(strConnection);

        //    try
        //    {
        //        connection.Open();
        //        string query = "SELECT * FROM staff WHERE username=@login AND password=@password;";
        //        using MySqlCommand cmd = new MySqlCommand(query, connection);
        //        cmd.Parameters.AddWithValue("@login", username);
        //        cmd.Parameters.AddWithValue("@password", password);
        //        using MySqlDataReader reader = cmd.ExecuteReader();

        //        if (reader.Read())
        //        {
        //            int id = reader.GetInt32("ID_staff");
        //            string lastName = reader.GetString("last_name");
        //            string firstName = reader.GetString("first_name");
        //            bool isActif = reader.GetBoolean("is_active");
        //            string userGroup = reader.GetString("user_group");
        //            UserCo = new User(id, lastName, firstName, username, isActif, userGroup);
        //            MessageBox.Show("Connection réussie !");
        //            return true;

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message.ToString(), "ERROR");
        //    }
        //    return false;

        //}
    }
}
