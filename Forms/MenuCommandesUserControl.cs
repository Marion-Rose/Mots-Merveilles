using Mots_Merveilles.Managers;
using Mots_Merveilles.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mots_Merveilles.Forms
{
    /// <summary>
    /// Controle utilisateur pour la gestion des commandes
    /// </summary>
    public partial class MenuCommandesUserControl : UserControl
    {
        private CommandeManager commandeManager;

        /// <summary>
        /// Constructeur de la classe MenuCommandesUserControl
        /// </summary>
        public MenuCommandesUserControl()
        {
            InitializeComponent();
            this.commandeManager = new CommandeManager();
            this.Load += MenuCommandesUserControl_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuCommandesUserControl_Load(object sender, EventArgs e)
        {
            AfficherCommandes();
        }

        /// <summary>
        /// Affiche les commandes dans le dataGridView
        /// </summary>
        private void AfficherCommandes()
        {
            List<Commande> listeCommandes = commandeManager.RecupererListeCommande();
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID_commande", "ID_commande");
                dataGridView1.Columns.Add("Editeur", "Editeur");
                dataGridView1.Columns.Add("Date", "Date");
                dataGridView1.Columns.Add("Statut", "Statut");
            }

            foreach (Commande commande in listeCommandes)
            {
                dataGridView1.Rows.Add(commande.GetIdCommande(), commande.GetEditeur().GetNom(), commande.GetDateCommande().ToShortDateString(), commande.GetStatut());
            }
        }

        /// <summary>
        /// Gestion du clic sur le bouton Créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            CRCommande Obj = new CRCommande(true);
            Obj.ShowDialog();
            this.Show();
            AfficherCommandes();
        }

        /// <summary>
        /// Gestion du clic sur le bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            CRCommande Obj = new CRCommande(false, Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            Obj.ShowDialog();
            this.Show();
            AfficherCommandes();
        }

        /// <summary>
        /// Gestion du clic sur le bouton Supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer la commande chez : " + dataGridView1.SelectedRows[0].Cells[1].Value, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int idCommande = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_commande"].Value);
                        int nbRows = commandeManager.SupprimerCommande(idCommande);

                        if (nbRows > 0)
                        {
                            MessageBox.Show("La commande a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherCommandes();
                        }
                        else { MessageBox.Show("Erreur lors de la suppression de la commande : Aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression de la commande : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
