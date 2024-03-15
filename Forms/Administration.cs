using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mots_Merveilles.Forms
{
    public partial class Administration : Accueil
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void btAuteurs_Click(object sender, EventArgs e)
        {
            Auteurs Obj = new Auteurs();
            Obj.Show();
            this.Hide();
        }

        private void btEditeurs_Click(object sender, EventArgs e)
        {
            Editeurs Obj = new Editeurs();
            Obj.Show();
            this.Hide();
        }

        private void btTypeLivre_Click(object sender, EventArgs e)
        {
            TypesLivre Obj = new TypesLivre();
            Obj.Show();
            this.Hide();
        }

        private void btEmployes_Click(object sender, EventArgs e)
        {
            Employes Obj = new Employes();
            Obj.Show();
            this.Hide();
        }
    }
}
