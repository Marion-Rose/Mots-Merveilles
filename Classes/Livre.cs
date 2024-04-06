using Mots_Merveilles.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe Livre
    /// </summary>
    public class Livre
    {
        private int idLivre;
        private string titre;
        private Auteur auteur;
        private Editeur editeur;
        private string isbn;
        private TypeLivre type;
        private decimal prix;
        private int quantite;

        /// <summary>
        /// Constructeur de la classe Livre
        /// </summary>
        /// <param name="idLivre"></param>
        /// <param name="titre"></param>
        /// <param name="auteur"></param>
        /// <param name="editeur"></param>
        /// <param name="isbn"></param>
        /// <param name="type"></param>
        /// <param name="prix"></param>
        /// <param name="quantite"></param>
        public Livre(int idLivre, string titre, Auteur auteur, Editeur editeur, string isbn, TypeLivre type, decimal prix, int quantite)
        {
            this.idLivre = idLivre;
            this.titre = titre;
            this.auteur = auteur;
            this.editeur = editeur;
            this.isbn = isbn;
            this.type = type;
            this.prix = prix;
            this.quantite = quantite;
        }


        public void SetIdLivre(int idLivre) { this.idLivre = idLivre; }
        public int GetIdLivre() { return this.idLivre;}
        public void SetTitre(string titre) { this.titre = titre;}
        public string GetTitre() { return this.titre;}
        public void SetAuteur(Auteur auteur) { this.auteur = auteur;}
        public Auteur GetAuteur() { return this.auteur;}
        public void SetEditeur(Editeur editeur) { this.editeur = editeur;}
        public Editeur GetEditeur() { return this.editeur;}
        public void SetIsbn(string isbn) { this.isbn = isbn;}
        public string GetIsbn() { return this.isbn;}
        public void SetType(TypeLivre type) { this.type = type;}
        public TypeLivre GetType() { return this.type;}
        public void SetPrix(decimal prix) { this.prix = prix;}
        public decimal GetPrix() { return this.prix;}
        public void SetQuantite(int quantite) { this.quantite = quantite;}
        public int GetQuantite() { return this.quantite;}
        public override string ToString() { return this.titre + " de " + this.auteur.GetNom() + " " + this.auteur.GetPrenom();}

    }
}
