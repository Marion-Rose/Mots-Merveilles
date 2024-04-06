using Mots_Merveilles.Forms;
using Mots_Merveilles.Managers;

namespace Mots_Merveilles
{
    public partial class Accueil : Form
    {
        private UserControl menuPrincipal;
        private UserControl menuLivres;
        private UserControl menuClients;
        private UserControl menuCommandes;
        private UserControl menuAdministration;
        private UserControl menuCRUD;

        public Accueil()
        {
            InitializeComponent();
            linkLbUtilisateur.Text = Authentification.Instance().UtilisateurCo.ToString();
            this.menuPrincipal = new MenuPrincipalUserControl();
            ChargerContenu(this.menuPrincipal);
            this.menuLivres = new MenuLivresUserControl();
            this.menuClients = new MenuClientsUserControl();
            this.menuCommandes = new MenuCommandesUserControl();
            this.menuAdministration = new MenuAdministrationUserControl();
        }

        private void Accueil_Load(object sender, EventArgs e) { ChargerContenu(this.menuPrincipal); }
        private void lbMenuLivre_Click(object sender, EventArgs e) { ChargerContenu(this.menuLivres); }
        private void lbMenuClients_Click(object sender, EventArgs e) { ChargerContenu(this.menuClients); }
        private void lbMenuCommandes_Click(object sender, EventArgs e) { ChargerContenu(this.menuCommandes); }
        private void lbMenuAdministration_Click(object sender, EventArgs e)
        {

            if (Authentification.Instance().UtilisateurCo.GetGroupe().GetIdGroupeUtilisateur() == 1 || Authentification.Instance().UtilisateurCo.GetGroupe().GetIdGroupeUtilisateur() == 2)
            {
                ChargerContenu(this.menuAdministration);
            }
            else { MessageBox.Show("Vous n'avez pas les droits pour accéder à cette fonctionnalité."); }
        }

        private void lbMenu_MouseEnter(object sender, EventArgs e) { Cursor = Cursors.Hand; }
        private void lbMenu_MouseLeave(object sender, EventArgs e) { Cursor = Cursors.Default; }

        private void ChargerContenu(UserControl contenu)
        {
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(contenu);
        }

        private void lbDeconnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion Obj = new Connexion();
            Obj.Show();
            this.Close();

        }
    }
}