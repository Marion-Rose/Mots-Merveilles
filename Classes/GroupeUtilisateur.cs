using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe GroupeUtilisateur
    /// </summary>
    public class GroupeUtilisateur
    {
        private int idGroupeUtilisateur;
        private string nom;
        private bool estAdmin;

        /// <summary>
        /// Constructeur de la classe GroupeUtilisateur
        /// </summary>
        /// <param name="idGroupeUtilisateur"></param>
        /// <param name="nom"></param>
        /// <param name="estAdmin"></param>
        public GroupeUtilisateur(int idGroupeUtilisateur, string nom, bool estAdmin)
        {
            this.idGroupeUtilisateur = idGroupeUtilisateur;
            this.nom = nom;
            this.estAdmin = estAdmin;
        }

        public void SetIdGroupeUtilisateur(int idGroupeUtilisateur) { this.idGroupeUtilisateur = idGroupeUtilisateur; }
        public int GetIdGroupeUtilisateur() { return this.idGroupeUtilisateur;}
        public void SetNom(string nom) { this.nom = nom;}
        public string GetNom() { return this.nom;}
        public void SetEstAdmin(bool estAdmin) { this.estAdmin = estAdmin;}
        public bool GetEstAdmin() { return this.estAdmin;}
        public override string ToString() { return this.nom;}
    }
}
