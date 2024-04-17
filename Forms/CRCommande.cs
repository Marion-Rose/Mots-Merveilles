using System;
using System.Collections.Generic;
using Mots_Merveilles.Classes;
using Mots_Merveilles.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mots_Merveilles.Forms
{
    /// <summary>
    /// Formulaire de création et de modification de commande
    /// </summary>
    public partial class CRCommande : Form
    {
        private CommandeManager commandeManager;
        private Commande commande;
        private bool param;
        private LivreManager livreManager;
        private Dictionary<Livre, int> livresCommandes;

        /// <summary>
        /// Constructeur de la classe CRCommande
        /// </summary>
        public CRCommande(bool param, int? idCommande = null)
        {
            this.commandeManager = new CommandeManager();
            this.livreManager = new LivreManager();
            this.param = param;
            InitializeComponent();

            if (idCommande != null)
            {
                this.commande = commandeManager.AfficherCommande((int)idCommande);
                this.livresCommandes = commande.GetLivresCommandes();
            }
            else
            {
                livresCommandes = new Dictionary<Livre, int>();
                this.commande = new Commande(commandeManager.RecupererIdProchaineCommande(), null, DateTime.Now, null, livresCommandes);
            }
            
            this.Load += CRCommande_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRCommande_Load(object sender, EventArgs e)
        {
            txtNumero.Text = this.commande.GetIdCommande().ToString();
            txtNumero.ReadOnly = true;

            dataGridView1.Rows.Clear();
            if (dataGridView1.Columns.Count == 0)
            {
               dataGridView1.Columns.Add("ID_livre", "ID");
                dataGridView1.Columns.Add("Titre", "Titre");
                dataGridView1.Columns.Add("Auteur", "Auteur");
                dataGridView1.Columns.Add("ISBN", "ISBN");
                dataGridView1.Columns.Add("Prix", "Prix");
                dataGridView1.Columns.Add("Quantite", "Quantité");
            }

            // Si param est true, bouton créer est visible, sinon bouton modifier est visible
            if (this.param)
            {
                ChargerComboBox();
                btModifier.Hide();
            }
            else
            {
                PreremplirChamps();
                ChargerListeLivre();
                comboBoxEditeur.Enabled = false;
                btCreer.Hide();
            }
        }

        /// <summary>
        /// Préremplie les champs du formulaire en cas de modification
        /// </summary>
        private void PreremplirChamps()
        {
            try
            {
                List<Editeur> listeEditeurs = new List<Editeur>();
                listeEditeurs.Add(this.commande.GetEditeur());
                comboBoxEditeur.DataSource = listeEditeurs;
                comboBoxEditeur.DisplayMember = "Nom";
                comboBoxEditeur.SelectedItem = this.commande.GetEditeur().GetNom();

                dateTimePicker1.Value = this.commande.GetDateCommande();
                comboBoxStatut.Text = this.commande.GetStatut();
                dataGridView1.Rows.Clear();
                foreach (KeyValuePair<Livre, int> livre in this.commande.GetLivresCommandes())
                {
                    dataGridView1.Rows.Add(livre.Key.GetIdLivre(), livre.Key.GetTitre(), livre.Key.GetAuteur().ToString(), livre.Key.GetIsbn(), livre.Key.GetPrix().ToString("0.00"), livre.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Charge le comboBox Editeur
        /// </summary>
        private void ChargerComboBox()
        {
            EditeurManager editeurManager = new EditeurManager();
            List<Editeur> listeEditeurs = editeurManager.RecupererListeEditeur();
            comboBoxEditeur.DataSource = listeEditeurs;
            comboBoxEditeur.DisplayMember = "Nom";
        }

        /// <summary>
        /// Charge le comboBox Livre en fonction de l'éditeur sélectionné
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxEditeur_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.commande.SetEditeur((Editeur)comboBoxEditeur.SelectedItem);
            ChargerListeLivre();
        }

        /// <summary>
        /// Charge le comboBox Livre en fonction de l'éditeur sélectionné
        /// </summary>
        private void ChargerListeLivre()
        {
            List<Livre> livresAAfficher = new List<Livre>(this.livreManager.RecupererLivresSelonEditeur(this.commande.GetEditeur().GetIdEditeur()));

            //N'afficher que les livres qui ne sont pas déjà dans la commande
            List<Livre> livresARetirer = new List<Livre>();
            foreach (KeyValuePair<Livre, int> livreCommande in this.livresCommandes) // Parcourir les livres déjà dans la commande
            {
                foreach (Livre livre in livresAAfficher)
                {
                    if (livre.GetIdLivre() == livreCommande.Key.GetIdLivre())
                    {
                        livresARetirer.Add(livre); // Ajouter à la liste des livres à retirer
                    }
                }
            }

            // Retirer les livres à retirer de la liste des livres à afficher
            foreach (Livre livre in livresARetirer)
            {
                livresAAfficher.Remove(livre);
            }

            comboBoxLivre.DisplayMember = "Titre";
            comboBoxLivre.ValueMember = "idLivre";
            comboBoxLivre.DataSource = livresAAfficher;
        }

        /// <summary>
        /// Gestion du bouton Créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" && comboBoxEditeur.Text != "" && comboBoxStatut.Text != "")
            {
                try
                {
                    this.commande.SetLivresCommandes(this.livresCommandes);
                    int nbRows = commandeManager.CreerCommande(this.commande);

                    if (nbRows > 0)
                    {
                        MessageBox.Show("La commande a bien été créée.", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else { MessageBox.Show("Erreur lors de la création de la commande : Aucune ligne n'a été ajoutée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la création de la commande : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestion du bouton Modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text != "" && comboBoxEditeur.Text != "" && comboBoxStatut.Text != "")
            {
                try
                {
                    this.commande.SetLivresCommandes(this.livresCommandes);

                    int nbRows = commandeManager.ModifierCommande(this.commande);

                    if (nbRows > 0)
                    {
                        MessageBox.Show("La commande a bien été modifiée.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else { MessageBox.Show("Erreur lors de la modification de la commande : Aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification de la commande : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Ajouter un livre à la commande
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (comboBoxLivre.Text != "" && numUpDown.Value != 0)
            {
                Livre livreAjoute = (Livre)comboBoxLivre.SelectedItem;
                this.livresCommandes.Add(livreAjoute, Convert.ToInt32(numUpDown.Value));
                dataGridView1.Rows.Clear();
                foreach (KeyValuePair<Livre, int> livre in this.commande.GetLivresCommandes())
                {
                    dataGridView1.Rows.Add(livre.Key.GetIdLivre(), livre.Key.GetTitre(), livre.Key.GetAuteur().ToString(), livre.Key.GetIsbn(), livre.Key.GetPrix().ToString("0.00"), livre.Value);
                }
                ChargerListeLivre();
                numUpDown.Value = 0;
                comboBoxEditeur.Enabled = false;
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.commande.SetDateCommande(dateTimePicker1.Value);
        }

        private void comboBoxStatut_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.commande.SetStatut(comboBoxStatut.Text);
        }
    }
}
