using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe Editeur
    /// </summary>
    public class Editeur
    {
        private int idEditeur;
        private string nom;
        private string adresse;
        private string telephone;
        private string email;

        /// <summary>
        /// Constructeur de la classe Editeur
        /// </summary>
        /// <param name="idEditeur"></param>
        /// <param name="nom"></param>
        /// <param name="adresse"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        public Editeur(int idEditeur, string nom, string adresse, string telephone, string email)
        {
            this.idEditeur = idEditeur;
            this.nom = nom;
            this.adresse = adresse;
            this.telephone = telephone;
            this.email = email;
        }
                                                                                                                                     
        public void SetIdEditeur(int idEditeur) { this.idEditeur = idEditeur; }
        public int GetIdEditeur() { return this.idEditeur;}
        public void SetNom(string nom) { this.nom = nom;}
        public string GetNom() { return this.nom;}
        public void SetAdresse(string adresse) { this.adresse = adresse;}
        public string GetAdresse() { return this.adresse;}
        public void SetTelephone(string telephone) { this.telephone = telephone;}
        public string GetTelephone() { return this.telephone;}
        public void SetEmail(string email) { this.email = email;}
        public string GetEmail() { return this.email;}
        public override string ToString()
        {
            return this.nom;
        }

    }
}
