using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe Auteur
    /// </summary>
    public class Auteur
    {
        private int idAuteur;
        private string nom;
        private string prenom;

        /// <summary>
        /// Constructeur de la classe Auteur
        /// </summary>
        /// <param name="idAuteur"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        public Auteur(int idAuteur, string nom, string prenom)
        {
            this.idAuteur = idAuteur;
            this.nom = nom;
            this.prenom = prenom;
        }

        public int GetIdAuteur() { return this.idAuteur; }
        public void SetIdAuteur(int idAuteur) { this.idAuteur = idAuteur; }
        public string GetNom() { return this.nom; }
        public void SetNom(string nom) { this.nom = nom; }
        public string GetPrenom() { return this.prenom; }
        public void SetPrenom(string prenom) { this.prenom = prenom; }
        public override string ToString() { return this.nom + " " + this.prenom;}
    }
}
