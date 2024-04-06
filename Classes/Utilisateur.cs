using System;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe Utilisateur
    /// </summary>
    public class Utilisateur
    {
        private int ID;
        private Employe employe;
        private string identifiant;
        private string motDePasse;
        private bool estActif;
        private GroupeUtilisateur groupe;

        /// <summary>
        /// Constructeur de la classe Utilisateur
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="employe"></param>
        /// <param name="identifiant"></param>
        /// <param name="motDePasse"></param>
        /// <param name="estActif"></param>
        /// <param name="groupe"></param>
        public Utilisateur(int ID, Employe employe, string identifiant, string motDePasse, bool estActif, GroupeUtilisateur groupe)
        {
            this.ID = ID;
            this.employe = employe;
            this.identifiant = identifiant;
            this.motDePasse = motDePasse;
            this.estActif = estActif;
            this.groupe = groupe;
        }
        
        public void SetID(int ID) { this.ID = ID; }
        public int GetID() { return this.ID; }
        public void SetEmploye(Employe employe) { this.employe = employe; }
        public Employe GetEmploye() { return this.employe; }
        public void SetIdentifiant(string identifiant) { this.identifiant = identifiant; }
        public string GetIdentifiant() { return this.identifiant; }
        public void SetMotDePasse(string motDePasse) { this.motDePasse = motDePasse; }
        public string GetMotDePasse() { return this.motDePasse; }
        public void SetEstActif(bool estActif) { this.estActif = estActif; }
        public bool GetEstActif() { return this.estActif; }
        public void SetGroupe(GroupeUtilisateur groupe) { this.groupe = groupe; }
        public GroupeUtilisateur GetGroupe() { return this.groupe; }
        public override string ToString() { return this.employe.GetNom() + " " + this.employe.GetPrenom(); }
    }
}
