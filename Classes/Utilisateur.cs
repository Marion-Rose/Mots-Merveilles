using System;

namespace Mots_Merveilles.Classes
{
    public class Utilisateur
    {
        private int ID;
        private string nom;
        private string prenom;
        private string identifiant;
        private bool estActif;
        private int groupe;

        public Utilisateur(int ID, string nom, string prenom, string identifiant, bool estActif, int groupe)
        {
            this.ID = ID;
            this.nom = nom;
            this.prenom = prenom;
            this.identifiant = identifiant;
            this.estActif = estActif;
            this.groupe = groupe;
        }

        public void SetID(int ID)
        {
            this.ID = ID;
        }
        public int GetID()
        {
            return ID;
        }
        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public string GetNom()
        {
            return nom;
        }
        public void SetPrenom(string prenom)
        {
            this.prenom = prenom;
        }
        public string GetPrenom()
        {
            return prenom;
        }
        public void SetIdentifiant(string identifiant)
        {
            this.identifiant = identifiant;
        }
        public string GetIdentifiant()
        {
            return identifiant;
        }
        public void SetEstActif(bool estActif)
        {
            this.estActif = estActif;
        }
        public bool GetEstActif()
        {
            return estActif;
        }
        public void SetGroupe(int groupe)
        {
            this.groupe = groupe;
        }
        public int GetGroupe()
        {
            return groupe;
        }
        public override string ToString()
        {
            return "ID :" + this.ID + ", nom: " + this.nom + ", prenom: " + this.prenom + ", Identifiant: " + this.identifiant + ", estActif : " + this.estActif + ", groupe : " + groupe;
        }
    }
}
