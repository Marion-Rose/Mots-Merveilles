using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe Client
    /// </summary>
    public class Client
    {
        private int idClient;
        private string nom;
        private string prenom;
        private DateTime dateNaissance;
        private string sexe;
        private string adresse;
        private string codePostal;
        private string ville;
        private string telephone;
        private string email;

        /// <summary>
        /// Constructeur de la classe Client
        /// </summary>
        /// <param name="idClient"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="dateNaissance"></param>
        /// <param name="sexe"></param>
        /// <param name="adresse"></param>
        /// <param name="codePostal"></param>
        /// <param name="ville"></param>
        /// <param name="telephone"></param>
        /// <param name="email"></param>
        public Client(int idClient, string nom, string prenom, DateTime dateNaissance, string sexe, string adresse, string codePostal, string ville, string telephone, string email)
        {
            this.idClient = idClient;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.sexe = sexe;
            this.adresse = adresse;
            this.codePostal = codePostal;
            this.ville = ville;
            this.telephone = telephone;
            this.email = email;
        }
        public void SetIdClient(int idClient) { this.idClient = idClient; }
        public int GetIdClient() { return this.idClient;}
        public void SetNom(string nom) { this.nom = nom;}
        public string GetNom() { return this.nom;}   
        public void SetPrenom(string prenom) { this.prenom = prenom;}
        public string GetPrenom() { return this.prenom;}
        public void SetDateNaissance(DateTime dateNaissance) { this.dateNaissance = dateNaissance;}
        public DateTime GetDateNaissance() { return this.dateNaissance;}
        public void SetSexe(string sexe) { this.sexe = sexe;}
        public string GetSexe() { return this.sexe;}
        public void SetAdresse(string adresse) { this.adresse = adresse;}
        public string GetAdresse() { return this.adresse;}
        public void SetCodePostal(string codePostal) { this.codePostal = codePostal;}
        public string GetCodePostal() { return this.codePostal;}
        public void SetVille(string ville) { this.ville = ville;}
        public string GetVille() { return this.ville;}
        public void SetTelephone(string telephone) { this.telephone = telephone;}
        public string GetTelephone() { return this.telephone;}
        public void SetEmail(string email) { this.email = email;}
        public string GetEmail() { return this.email;}
        public override string ToString()
        { return this.nom + " " + this.prenom;}
    }
}
