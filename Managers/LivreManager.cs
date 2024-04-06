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
    /// Classe LivreManager
    /// </summary>
    public class LivreManager
    {
        ConnexionManager connexion;
        AuteurManager auteurManager;
        EditeurManager editeurManager;
        TypeLivreManager typeLivreManager;

        /// <summary>
        /// Constructeur de la classe LivreManager
        /// </summary>
        public LivreManager()
        {
            connexion = new ConnexionManager();
            auteurManager = new AuteurManager();
            editeurManager = new EditeurManager();
            typeLivreManager = new TypeLivreManager();
        }

        /// <summary>
        /// Récupère la liste des livres dans la base de données
        /// </summary>
        /// <returns>Liste des livres</returns>
        public List<Livre> RecupererListeLivre()
        {
            List<Livre> listeLivres = new List<Livre>();

            string query = "SELECT l.ID_livre, l.titre, l.ID_auteur, CONCAT(a.nom, ' ', a.prenom) AS auteur, l.ID_editeur, e.nom AS editeur, l.ISBN, t.ID_type, t.type AS type, l.prix, l.quantite " +
                "FROM Livre l " +
                "INNER JOIN Auteur a ON l.ID_auteur = a.ID_auteur " +
                "INNER JOIN Editeur e ON l.ID_editeur = e.ID_editeur " +
                "INNER JOIN TypeLivre t ON l.ID_type = t.ID_type;";
            DataTable dataTable = connexion.RecupererDonnees(query);

            foreach (DataRow row in dataTable.Rows)
            {
                Auteur auteur = auteurManager.RecupererListeAuteur().Find(auteur => auteur.GetIdAuteur() == Convert.ToInt32(row["ID_auteur"]));
                Editeur editeur = editeurManager.RecupererListeEditeur().Find(editeur => editeur.GetIdEditeur() == Convert.ToInt32(row["ID_editeur"]));
                TypeLivre typeLivre = typeLivreManager.RecupererListeTypeLivre().Find(type => type.GetIdTypeLivre() == Convert.ToInt32(row["ID_type"]));
                Livre livre = new Livre(Convert.ToInt32(row["ID_livre"]), row["titre"].ToString(), auteur, editeur, row["ISBN"].ToString(), new TypeLivre(0, row["type"].ToString()), Convert.ToDecimal(row["prix"]), Convert.ToInt32(row["quantite"])); 
                listeLivres.Add(livre);
            }
            return listeLivres;
        }

        /// <summary>
        /// Récupère la liste des livres selon un Editeur
        /// </summary>
        /// <param name="idEditeur"></param>
        /// <returns></returns>
        public List<Livre> RecupererLivresSelonEditeur(int idEditeur)
        {
            List<Livre> listeLivres = new List<Livre>();

            string query = "SELECT l.ID_livre, l.titre, l.ID_auteur, CONCAT(a.nom, ' ', a.prenom) AS auteur, l.ID_editeur, e.nom AS editeur, l.ISBN, t.ID_type, t.type AS type, l.prix, l.quantite " +
                "FROM Livre l " +
                "INNER JOIN Auteur a ON l.ID_auteur = a.ID_auteur " +
                "INNER JOIN Editeur e ON l.ID_editeur = e.ID_editeur " +
                "INNER JOIN TypeLivre t ON l.ID_type = t.ID_type " +
                "WHERE l.ID_editeur = @idEditeur;";
            SqlParameter[] parameters =
            {
                  new SqlParameter("@idEditeur", SqlDbType.VarChar) { Value = idEditeur },
            };
            DataTable dataTable = connexion.RecupererDonnees(query, parameters);

            foreach (DataRow row in dataTable.Rows)
            {
                Auteur auteur = auteurManager.RecupererListeAuteur().Find(auteur => auteur.GetIdAuteur() == Convert.ToInt32(row["ID_auteur"]));
                Editeur editeur = editeurManager.RecupererListeEditeur().Find(editeur => editeur.GetIdEditeur() == Convert.ToInt32(row["ID_editeur"]));
                TypeLivre typeLivre = typeLivreManager.RecupererListeTypeLivre().Find(type => type.GetIdTypeLivre() == Convert.ToInt32(row["ID_type"]));
                Livre livre = new Livre(Convert.ToInt32(row["ID_livre"]), row["titre"].ToString(), auteur, editeur, row["ISBN"].ToString(), new TypeLivre(0, row["type"].ToString()), Convert.ToDecimal(row["prix"]), Convert.ToInt32(row["quantite"]));
                listeLivres.Add(livre);
            }
            return listeLivres;
        }

        /// <summary>
        /// Récupère un livre dans la base de données
        /// </summary>
        /// <param name="idLivre"></param>
        /// <returns>Livre</returns>
        public Livre AfficherLivre(int idLivre)
        {
            string query = "SELECT l.ID_livre, l.titre, l.ID_auteur, CONCAT(a.nom, ' ', a.prenom) AS auteur, l.ID_editeur, e.nom AS editeur, l.ISBN, l.ID_type, t.type AS type, l.prix, l.quantite " +
                "FROM Livre l " +
                "INNER JOIN Auteur a ON l.ID_auteur = a.ID_auteur " +
                "INNER JOIN Editeur e ON l.ID_editeur = e.ID_editeur " +
                "INNER JOIN TypeLivre t ON l.ID_type = t.ID_type " +
                "WHERE l.ID_livre = @id ;";
            SqlParameter[] parameters =
            {
                  new SqlParameter("@id", SqlDbType.VarChar) { Value = idLivre },
            };
            DataTable dataTable = connexion.RecupererDonnees(query, parameters);

            Livre livre = null;

            if (dataTable.Rows.Count > 0)
            {
                DataRow row = dataTable.Rows[0]; // Accédez à la première ligne du DataTable
                Auteur auteur = auteurManager.RecupererListeAuteur().Find(auteur => auteur.GetIdAuteur() == Convert.ToInt32(row["ID_auteur"]));
                Editeur editeur = editeurManager.RecupererListeEditeur().Find(editeur => editeur.GetIdEditeur() == Convert.ToInt32(row["ID_editeur"]));
                TypeLivre typeLivre = typeLivreManager.RecupererListeTypeLivre().Find(type => type.GetIdTypeLivre() == Convert.ToInt32(row["ID_type"]));
                livre = new Livre(Convert.ToInt32(row["ID_livre"]), row["titre"].ToString(), auteur, editeur, row["ISBN"].ToString(), new TypeLivre(0, row["type"].ToString()), Convert.ToDecimal(row["prix"]), Convert.ToInt32(row["quantite"]));
            }

            return livre;
        }

        /// <summary>
        /// Crée un livre dans la base de données
        /// </summary>
        /// <param name="livre"></param>
        /// <returns>Nombre de lignes insérées</returns>
        public int CreerLivre(Livre livre)
        {
            string query = "INSERT INTO Livre (titre, ID_auteur, ID_editeur, ISBN, ID_type, prix, quantite) " +
                "VALUES (@titre, @ID_auteur, @ID_editeur, @ISBN, @ID_type, @prix, @quantite);";

            SqlParameter[] parameters = {
                            new SqlParameter("@titre", SqlDbType.VarChar) { Value = livre.GetTitre() },
                            new SqlParameter("@auteur", SqlDbType.VarChar) { Value = livre.GetAuteur().GetIdAuteur() },
                            new SqlParameter("@editeur", SqlDbType.VarChar) { Value = livre.GetEditeur().GetIdEditeur()},
                            new SqlParameter("@isbn", SqlDbType.VarChar) { Value = livre.GetIsbn()},
                            new SqlParameter("@type", SqlDbType.VarChar) { Value = livre.GetType() },
                            new SqlParameter("@prix", SqlDbType.Money) { Value = livre.GetPrix() },
                            new SqlParameter("@quantite", SqlDbType.VarChar) { Value = livre.GetQuantite() }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Modifie un livre dans la base de données
        /// </summary>
        /// <param name="livre"></param>
        /// <returns>Nombre de lignes modifiées</returns>
        public int ModifierLivre (Livre livre)
        {
            string query = "UPDATE Livre SET titre=@titre, ID_auteur=@auteur, Id_editeur=@editeur, ISBN=@isbn, ID_type=@type, prix=@prix, quantite=@quantite WHERE ID_livre =@id;";

            SqlParameter[] parameters =
            {
                            new SqlParameter("@titre", SqlDbType.VarChar) { Value = livre.GetTitre() },
                            new SqlParameter("@auteur", SqlDbType.VarChar) { Value = livre.GetAuteur().GetIdAuteur() },
                            new SqlParameter("@editeur", SqlDbType.VarChar) { Value = livre.GetEditeur().GetIdEditeur()},
                            new SqlParameter("@isbn", SqlDbType.VarChar) { Value = livre.GetIsbn()},
                            new SqlParameter("@type", SqlDbType.VarChar) { Value = livre.GetType().GetIdTypeLivre() },
                            new SqlParameter("@prix", SqlDbType.Money) { Value = livre.GetPrix() },
                            new SqlParameter("@quantite", SqlDbType.VarChar) { Value = livre.GetQuantite() },
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = livre.GetIdLivre()}
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Supprime un livre de la base de données
        /// </summary>
        /// <param name="livre"></param>
        /// <returns>Nombre de lignes supprimées</returns>
        public int SupprimerLivre(int idLivre)
        {
            string query = "DELETE FROM Livre WHERE ID_livre=@id;";

            SqlParameter[] parameters =
            {
                            new SqlParameter("@id", SqlDbType.VarChar) { Value = idLivre }
            };

            return connexion.EnvoyerDonnees(query, parameters);
        }

        /// <summary>
        /// Vérifie si un livre existe dans la base de données
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns>Vrai si le livre existe</returns>
        public bool LivreExiste(string isbn)
        {
            string query = "SELECT COUNT(*) FROM Livre WHERE ISBN = @isbn;";
            SqlParameter[] parameters = { new SqlParameter("@isbn", SqlDbType.VarChar) { Value = isbn } };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);
            return nombreOccurrences > 0;
        }

        /// <summary>
        /// Vérifie si un livre est associé à une commande avant de le supprimer
        /// </summary>
        /// <param name="idLivre"></param>
        /// <returns></returns>
        public bool CommandeAssociee(int idLivre)
        {
            string query = "SELECT COUNT(*) FROM Ligne_Commande WHERE ID_livre = @idLivre;";
            SqlParameter[] parameters = { new SqlParameter("@idLivre", SqlDbType.VarChar) { Value = idLivre } };

            int nombreOccurrences = Convert.ToInt32(connexion.RecupererDonnees(query, parameters).Rows[0][0]);
            return nombreOccurrences > 0;
        }
    }
}
