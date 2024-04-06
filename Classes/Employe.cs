using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe Employe
    /// </summary>
    public class Employe
    {
        private int idEmploye;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string genre;
        private string telephone;
        private string adresse;
        private string ville;
        private string mail;

        public Employe(int idEmploye, string nom, string prenom, DateTime dateNaissance, string genre, string adresse, string ville, string telephone, string mail)
        {
            this.idEmploye = idEmploye;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.genre = genre;
            this.telephone = telephone;
            this.adresse = adresse;
            this.ville = ville;
            this.mail = mail;
        }

        public void SetIdEmploye(int idEmploye){ this.idEmploye = idEmploye;}
        public int GetIdEmploye() { return idEmploye;}
        public void SetNom(string nom) { this.nom = nom;}
        public string GetNom() { return nom;}
        public void SetPrenom(string prenom) { this.prenom = prenom;}  
        public string GetPrenom() { return prenom;}
        public void SetDateNaissance(DateTime dateNaissance) { this.dateNaissance = dateNaissance;}
        public DateTime GetDateNaissance() { return dateNaissance;}
        public void SetGenre(string genre) { this.genre = genre;}
        public string GetGenre() { return genre;}
        public void SetTelephone(string telephone) { this.telephone = telephone;}
        public string GetTelephone() { return telephone;}
        public void SetAdresse(string adresse) { this.adresse = adresse;}
        public string GetAdresse() { return adresse;}
        public void SetVille(string ville) { this.ville = ville;}
        public string GetVille() { return ville;}
        public void SetMail(string mail) { this.mail = mail;}
        public string GetMail() { return mail;}
        public void SetPhone(string phone){ this.telephone = phone;}
        public string GetPhone() { return telephone;}
        public override string ToString() { return nom + " " + prenom; }
    }
}
