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
    /// Classe CommandeManager
    /// </summary>
    public class CommandeManager
    {
        ConnexionManager connexion;
        LivreManager livreManager;
        EditeurManager editeurManager;

        /// <summary>
        /// Constructeur de la classe CommandeManager
        /// </summary>
        public CommandeManager()
        {
            connexion = new ConnexionManager();
            livreManager = new LivreManager();
            editeurManager = new EditeurManager();
        }

        /// <summary>
        /// Recupère la liste des commandes dans la base de données
        /// </summary>
        /// <returns></returns>
        public List<Commande> RecupererListeCommande()
        {
            List<Commande> listeCommandes = new List<Commande>();

            string query = "SELECT c.ID_commande, c.ID_editeur, e.nom AS editeur, c.date_commande, c.statut_commande " +
                "FROM Commande c " +
                "INNER JOIN Editeur e ON c.ID_editeur = e.ID_editeur;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Editeur editeur = editeurManager.RecupererListeEditeur().Find(editeur => editeur.GetIdEditeur() == Convert.ToInt32(row["ID_editeur"]));
                Dictionary<Livre, int> livresCommandes = new Dictionary<Livre, int>();
                string query2 = "SELECT ID_livre, quantite_commande FROM Ligne_Commande WHERE ID_commande = " + Convert.ToInt32(row["ID_commande"]) + ";";
                DataTable dataTable2 = connexion.RecupererDonnees(query2);
                foreach (DataRow row2 in dataTable2.Rows)
                {
                    Livre livre = livreManager.RecupererListeLivre().Find(livre => livre.GetIdLivre() == Convert.ToInt32(row2["ID_livre"]));
                    livresCommandes.Add(livre, Convert.ToInt32(row2["quantite_commande"]));
                }
                Commande commande = new Commande(Convert.ToInt32(row["ID_commande"]), editeur, Convert.ToDateTime(row["date_commande"]), row["statut_commande"].ToString(), livresCommandes);
                listeCommandes.Add(commande);
            }
            return listeCommandes;
        }

        /// <summary>
        /// Affiche une commande
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns>Commande</returns>
        public Commande AfficherCommande(int idCommande)
        {
            string query = "SELECT c.ID_commande, c.ID_editeur, e.nom AS editeur, c.date_commande, c.statut_commande " +
                "FROM Commande c " +
                "INNER JOIN Editeur e ON c.ID_editeur = e.ID_editeur " +
                "WHERE c.ID_commande = @idCommande;";
            SqlParameter[] parameters =
            {
                  new SqlParameter("@idCommande", SqlDbType.VarChar) { Value = idCommande },
            };
            DataTable dataTable = connexion.RecupererDonnees(query, parameters);

            Commande commande = null;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0];
                Editeur editeur = editeurManager.RecupererListeEditeur().Find(editeur => editeur.GetIdEditeur() == Convert.ToInt32(row["ID_editeur"]));
                Dictionary<Livre, int> livresCommandes = new Dictionary<Livre, int>();
                string query2 = "SELECT ID_livre, quantite_commande FROM Ligne_Commande WHERE ID_commande = " + Convert.ToInt32(row["ID_commande"]) + ";";
                DataTable dataTable2 = connexion.RecupererDonnees(query2);

                foreach (DataRow row2 in dataTable2.Rows)
                {
                    Livre livre = livreManager.RecupererListeLivre().Find(livre => livre.GetIdLivre() == Convert.ToInt32(row2["ID_livre"]));
                    livresCommandes.Add(livre, Convert.ToInt32(row2["quantite_commande"]));
                }
                commande = new Commande(Convert.ToInt32(row["ID_commande"]), editeur, Convert.ToDateTime(row["date_commande"]), row["statut_commande"].ToString(), livresCommandes);
            }
            
            return commande;
        }

        /// <summary>
        /// Créer une commande
        /// </summary>
        /// <param name="commande"></param>
        /// <returns>Nombre de lignes insérées</returns>
        public int CreerCommande(Commande commande)
        {
            int nbRows = 0;
            string query = "INSERT INTO Commande (ID_editeur, date_commande, statut_commande) VALUES (@idEditeur, @dateCommande, @statutCommande);SELECT SCOPE_IDENTITY();";
            SqlParameter[] parameters =
            {
                new SqlParameter("@idEditeur", SqlDbType.Int) { Value = commande.GetEditeur().GetIdEditeur() },
                new SqlParameter("@dateCommande", SqlDbType.DateTime) { Value = commande.GetDateCommande() },
                new SqlParameter("@statutCommande", SqlDbType.VarChar) { Value = commande.GetStatut() },
            };
            int idCommande = Convert.ToInt32(connexion.EnvoyerDonnees(query, parameters));

            string query2 = "INSERT INTO Ligne_Commande (ID_commande, ID_livre, quantite_commande) VALUES (@idCommande, @idLivre, @quantite);";
            foreach (KeyValuePair<Livre, int> ligneCommande in commande.GetLivresCommandes())
            {
                SqlParameter[] parameters2 =
                {
                    new SqlParameter("@idCommande", SqlDbType.Int) { Value = idCommande },
                    new SqlParameter("@idLivre", SqlDbType.Int) { Value = ligneCommande.Key.GetIdLivre() },
                    new SqlParameter("@quantite", SqlDbType.Int) { Value = ligneCommande.Value },
                };
                connexion.EnvoyerDonnees(query2, parameters2);
                nbRows++;
            }
            return nbRows;
        }

        /// <summary>
        /// Recupère l'id de la prochaine commande
        /// </summary>
        /// <returns></returns>
        public int RecupererIdProchaineCommande()
        {
            string query = "SELECT MAX(ID_commande) FROM Commande;";
            DataTable dataTable = connexion.RecupererDonnees(query);
            // Vérifie si la valeur retournée est DBNull ou null
            object maxId = dataTable.Rows[0][0];
            if (maxId != DBNull.Value && maxId != null)
            {
                return Convert.ToInt32(maxId) + 1;
            }
            else
            {
                // Si la valeur est DBNull ou null, retourne 1 comme premier ID de commande
                return 1;
            }
        }

        /// <summary>
        /// Modifier une commande
        /// </summary>
        /// <param name="commande"></param>
        /// <returns>Nombre de lignes modifiées</returns>
        public int ModifierCommande(Commande commande)
        {
            int nbRows = 0;
            string query = "UPDATE Commande SET date_commande = @dateCommande, statut_commande = @statutCommande WHERE ID_commande = @idCommande;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@dateCommande", SqlDbType.DateTime) { Value = commande.GetDateCommande() },
                new SqlParameter("@statutCommande", SqlDbType.VarChar) { Value = commande.GetStatut() },
                new SqlParameter("@idCommande", SqlDbType.Int) { Value = commande.GetIdCommande() },
            };
            nbRows += connexion.EnvoyerDonnees(query, parameters);

            string query2 = "DELETE FROM Ligne_Commande WHERE ID_commande = @idCommande;";
            SqlParameter[] parameters2 =
            {
                new SqlParameter("@idCommande", SqlDbType.Int) { Value = commande.GetIdCommande() },
            };
            connexion.EnvoyerDonnees(query2, parameters2);

            string query3 = "INSERT INTO Ligne_Commande (ID_commande, ID_livre, quantite_commande) VALUES (@idCommande, @idLivre, @quantite);";
            foreach (KeyValuePair<Livre, int> ligneCommande in commande.GetLivresCommandes())
            {
                SqlParameter[] parameters3 =
                {
                    new SqlParameter("@idCommande", SqlDbType.Int) { Value = commande.GetIdCommande() },
                    new SqlParameter("@idLivre", SqlDbType.Int) { Value = ligneCommande.Key.GetIdLivre() },
                    new SqlParameter("@quantite", SqlDbType.Int) { Value = ligneCommande.Value },
                };
                connexion.EnvoyerDonnees(query3, parameters3);
                nbRows++;
            }
            return nbRows;
        }

        /// <summary>
        /// Supprimer une commande de la base de données
        /// </summary>
        /// <param name="idCommande"></param>
        /// <returns></returns>
        public int SupprimerCommande(int idCommande)
        {
            int nbRows = 0;
            string query = "DELETE FROM Ligne_Commande WHERE ID_commande = @idCommande;";
            SqlParameter[] parameters =
            {
                new SqlParameter("@idCommande", SqlDbType.Int) { Value = idCommande },
            };
            connexion.EnvoyerDonnees(query, parameters);

            string query2 = "DELETE FROM Commande WHERE ID_commande = @idCommande;";
            nbRows += connexion.EnvoyerDonnees(query2, parameters);
            return nbRows;
        }
    }
}
