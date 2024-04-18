using Mots_Merveilles.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mots_Merveilles.Forms
{
    public partial class Connexion : Form
    {
        /// <summary>
        /// Formulaire de connexion
        /// </summary>
        public Connexion()
        {
            InitializeComponent();
            MessageBox.Show("Voici les utilisateurs enregistrés : \nm.tulipe m.tulipe Administrateur\nj.dubois j.dubois Manageur\nm.martin m.martin Employé");
        }

        /// <summary>
        /// Gestion de la connexion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (Authentification.Instance().Authentication(this.txtIdentifiant.Text, this.txtMDP.Text))
            {
                this.Hide();
                Accueil home = new Accueil();
                home.ShowDialog();
            }

        }

        /// <summary>
        /// Réinitialisation des champs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btReinitialiser_Click(object sender, EventArgs e)
        {
            txtIdentifiant.Text = "";
            txtMDP.Text = "";
        }
    }
}
