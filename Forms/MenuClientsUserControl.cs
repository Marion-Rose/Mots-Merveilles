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
    /// Controle utilisateur pour la gestion des clients
    /// </summary>
    public partial class MenuClientsUserControl : UserControl
    {
        private ClientManager clientManager;

        /// <summary>
        /// Constructeur de la classe MenuClientsUserControl
        /// </summary>
        public MenuClientsUserControl()
        {
            InitializeComponent();
            this.clientManager = new ClientManager();
            this.Load += MenuClientsUserControl_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuClientsUserControl_Load(object sender, EventArgs e)
        {
            AfficherClients();
        }

        /// <summary>
        /// Affiche les clients dans le dataGridView
        /// </summary>
        private void AfficherClients()
        {
            List<Client> listeClients = clientManager.RecupererListeClient();
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID_client", "ID");
                dataGridView1.Columns.Add("Nom", "Nom");
                dataGridView1.Columns.Add("Prénom", "Prénom");
                dataGridView1.Columns.Add("Date de naissance", "Date de naissance");
                dataGridView1.Columns.Add("Sexe", "Sexe");
                dataGridView1.Columns.Add("Adresse", "Adresse");
                dataGridView1.Columns.Add("Code postal", "Code postal");
                dataGridView1.Columns.Add("Ville", "Ville");
                dataGridView1.Columns.Add("Téléphone", "Téléphone");
                dataGridView1.Columns.Add("Mail", "Mail");
            }

            foreach (Client client in listeClients)
            {
                dataGridView1.Rows.Add(client.GetIdClient(), client.GetNom(), client.GetPrenom(), client.GetDateNaissance().ToShortDateString(), client.GetSexe(), client.GetAdresse(), client.GetCodePostal(), client.GetVille(), client.GetTelephone(), client.GetEmail());
            }

        }

        /// <summary>
        /// Gestion du bouton créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            CRClient Obj = new CRClient(true);
            Obj.ShowDialog();
            this.Show();
            AfficherClients();
        }

        /// <summary>
        /// Gestion du bouton modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CRClient Obj = new CRClient(false, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                Obj.ShowDialog();
                this.Show();
                AfficherClients();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
        }

        /// <summary>
        /// Gestions du bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer le client : " + dataGridView1.SelectedRows[0].Cells[1].Value + " " + dataGridView1.SelectedRows[0].Cells[2].Value, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        int idClient = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_client"].Value);
                        int nbRows = clientManager.SupprimerClient(idClient);

                        if (nbRows > 0)
                        {
                            MessageBox.Show("Le client a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AfficherClients();
                        }
                        else { MessageBox.Show("Erreur lors de la suppression du livre : Aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur lors de la suppression du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
