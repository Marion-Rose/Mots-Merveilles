﻿using System;
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
    public partial class MenuAdministrationUserControl : UserControl
    {
        private UserControl auteurs;
        private UserControl editeurs;
        private UserControl typesLivre;
        private UserControl employes;

        public MenuAdministrationUserControl()
        {
            InitializeComponent();
            this.auteurs = new AuteursUserControl();
            this.editeurs = new EditeursUserControl();
            this.typesLivre = new TypesLivreUserControl();
            this.employes = new EmployesUserControl();
        }

        private void btAuteurs_Click(object sender, EventArgs e) { ChargerContenu(this.auteurs);}
        private void btEditeurs_Click(object sender, EventArgs e) { ChargerContenu(this.editeurs);}
        private void btTypeLivre_Click(object sender, EventArgs e) { ChargerContenu(this.typesLivre);}
        private void btEmployes_Click(object sender, EventArgs e) { ChargerContenu(this.employes);}

        private void lbMenu_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void lbMenu_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Default; }

        private void ChargerContenu(UserControl contenu)
        {
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(contenu);
        }
    }
}
