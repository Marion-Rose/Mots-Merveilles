using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe TypeLivre
    /// </summary>
    public class TypeLivre {

        private int idTypeLivre;
        private string libelle;

        /// <summary>
        /// Constructeur de la classe TypeLivre
        /// </summary>
        /// <param name="idTypeLivre"></param>
        /// <param name="libelle"></param>
        public TypeLivre(int idTypeLivre, string libelle)
        {
            this.idTypeLivre = idTypeLivre;
            this.libelle = libelle;
        }

        public void SetIdTypeLivre(int idTypeLivre) { this.idTypeLivre = idTypeLivre; }
        public int GetIdTypeLivre() { return this.idTypeLivre; }
        public void SetLibelle(string libelle) { this.libelle = libelle; }
        public string GetLibelle() { return this.libelle; }
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
