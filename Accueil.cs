using Mots_Merveilles.Forms;

namespace Mots_Merveilles
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbMenuLivre_Click(object sender, EventArgs e)
        {
            Livres Obj = new Livres();
            Obj.Show();
            this.Hide();
        }

        private void lbMenuClients_Click(object sender, EventArgs e)
        {
            Clients Obj = new Clients();
            Obj.Show();
            this.Hide();
        }

        private void lbMenuCommandes_Click(object sender, EventArgs e)
        {
            Commandes Obj = new Commandes();
            Obj.Show();
            this.Hide();
        }

        private void lbMenuAdministration_Click(object sender, EventArgs e)
        {
            Administration Obj = new Administration();
            Obj.Show();
            this.Hide();
        }
    }
}