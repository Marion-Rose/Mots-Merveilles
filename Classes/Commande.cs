﻿using Mots_Merveilles.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mots_Merveilles.Classes
{
    /// <summary>
    /// Classe commande
    /// </summary>
    public class Commande
    {
        private int idCommande;
        private Editeur editeur;
        private DateTime dateCommande;
        private string statut;
        private Dictionary<Livre, int> livresCommandes;

        /// <summary>
        /// Constructeur de la classe Commande
        /// </summary>
        /// <param name="idCommande"></param>
        /// <param name="Editeur"></param>
        /// <param name="dateCommande"></param>
        /// <param name="statut"></param>
        /// <param name="livresCommandes"></param>
        public Commande(int idCommande, Editeur editeur, DateTime dateCommande, string statut, Dictionary<Livre, int> livresCommandes)
        {
            this.idCommande = idCommande;
            this.editeur = editeur;
            this.dateCommande = dateCommande;
            this.statut = statut;
            this.livresCommandes = livresCommandes;
        }

        public void SetIdCommande(int idCommande) { this.idCommande = idCommande; }
        public int GetIdCommande() { return idCommande;}
        public void SetEditeur(Editeur editeur) { this.editeur = editeur;}
        public Editeur GetEditeur() { return editeur;}
        public void SetDateCommande(DateTime dateCommande) { this.dateCommande = dateCommande;}
        public DateTime GetDateCommande() { return dateCommande;}
        public void SetStatut(string statut) { this.statut = statut;}
        public string GetStatut() { return statut;}
        public void SetLivresCommandes(Dictionary<Livre, int> livresCommandes) { this.livresCommandes = livresCommandes;}
        public Dictionary<Livre, int> GetLivresCommandes() { return livresCommandes;}
        public override string ToString()
        {
            return "Commande n°" + this.idCommande + " du " + this.dateCommande + " pour l'éditeur n°" + this.editeur.GetNom() + " - " + this.statut;
        }

    }
}
