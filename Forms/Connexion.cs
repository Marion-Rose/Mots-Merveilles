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
        public Connexion()
        {
            InitializeComponent();
        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            if (Authentification.Instance().Authentication(this.txtIdentifiant.Text, this.txtMDP.Text))
            {
                this.Hide();
                Accueil home = new Accueil();
                home.ShowDialog();
            }
           
        }
    }
}
