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
    /// Controle utilisateur pour la gestion des livres
    /// </summary>
    public partial class MenuLivresUserControl : UserControl
    {
        private LivreManager livreManager;

        /// <summary>
        /// Constructeur de la classe MenuLivresUserControl
        /// </summary>
        public MenuLivresUserControl()
        {
            InitializeComponent();
            this.livreManager = new LivreManager();
            this.Load += MenuLivresUserControl_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuLivresUserControl_Load(object sender, EventArgs e)
        {
            AfficherLivres();
        }

        /// <summary>
        /// Affiche les livres dans le dataGridView
        /// </summary>
        private void AfficherLivres()
        {
            List<Livre> listeLivres = livreManager.RecupererListeLivre();
            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("ID_livre", "ID");
                dataGridView1.Columns.Add("Titre", "Titre");
                dataGridView1.Columns.Add("Auteur", "Auteur");
                dataGridView1.Columns.Add("Editeur", "Editeur");
                dataGridView1.Columns.Add("ISBN", "ISBN");
                dataGridView1.Columns.Add("Type", "Type");
                dataGridView1.Columns.Add("Prix", "Prix");
                dataGridView1.Columns.Add("Quantite", "Quantité");
                dataGridView1.Columns["Prix"].DefaultCellStyle.Format = "0.00";
            }

            foreach (Livre livre in listeLivres)
            {
                dataGridView1.Rows.Add(livre.GetIdLivre(), livre.GetTitre(), livre.GetAuteur().ToString(), livre.GetEditeur().GetNom(), livre.GetIsbn(), livre.GetType().GetLibelle(), livre.GetPrix(), livre.GetQuantite());
            }
        }

        /// <summary>
        /// Gestion du bouton créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            CRLivre Obj = new CRLivre(true);
            Obj.ShowDialog();
            //Obj.Show();
            AfficherLivres();
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
                CRLivre Obj = new CRLivre(false, Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
                Obj.ShowDialog();
                //Obj.Show();
                AfficherLivres();
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne");
            }
        }

        /// <summary>
        /// Gestion du bouton supprimer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer le livre : " + dataGridView1.SelectedRows[0].Cells[1].Value, "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (!livreManager.CommandeAssociee(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_livre"].Value)))
                    {
                        try
                        {
                            int idLivre = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ID_livre"].Value);
                            int nbRows = livreManager.SupprimerLivre(idLivre);

                            if (nbRows > 0)
                            {
                                MessageBox.Show("Le livre a bien été supprimé.", "Suppression réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AfficherLivres();
                            }
                            else { MessageBox.Show("Erreur lors de la suppression du livre : Aucune ligne n'a été supprimée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erreur lors de la suppression du livre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Impossible de supprimer le livre : une commande est associée à ce livre", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }
}
