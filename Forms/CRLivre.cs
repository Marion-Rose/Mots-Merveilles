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
    /// Formulaire de création et de modification de livre
    /// </summary>
    public partial class CRLivre : Form
    {
        private LivreManager livreManager;
        private int idLivre;
        private bool param;

        /// <summary>
        /// Constructeur de la classe CRLivre
        /// </summary>
        /// <param name="param">Indique le mode création ou modififation</param>
        /// <param name="idLivre">Indique l'id du livre à modifier (facultatif)</param>
        public CRLivre(bool param, int? idLivre = null)
        {
            InitializeComponent();
            this.livreManager = new LivreManager();
            this.param = param;
            if (idLivre != null) { this.idLivre = (int)idLivre; }
            this.Load += CRLivre_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRLivre_Load(object sender, EventArgs e)
        {
            ChargerComboBox();

            // Si param est true, bouton créer est visible, sinon bouton modifier est visible
            if (this.param)
            {
                btModifier.Hide();
            }
            else
            {
                PreremplirChamps();
                btCreer.Hide();
            }
        }

        /// <summary>
        /// Gestion de la modification du texte dans les textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string text = textBox.Text;
            // Mise en forme de la première lettre en majuscule et le reste en minuscule
            textBox.Text = ControleEntree.FormaterTextePrix(text);
            textBox.SelectionStart = text.Length;
        }

        /// <summary>
        /// Préremplie les champs du formulaire en cas de modification
        /// </summary>
        private void PreremplirChamps()
        {
            try
            {
                Livre livreAModifier = livreManager.AfficherLivre(this.idLivre);
                txtTitre.Text = livreAModifier.GetTitre();
                comboBoxAuteur.Text = livreAModifier.GetAuteur().ToString();
                comboBoxEditeur.Text = livreAModifier.GetEditeur().GetNom();
                comboBoxType.Text = livreAModifier.GetType().GetLibelle();
                txtIsbn.Text = livreAModifier.GetIsbn();
                txtPrix.Text = livreAModifier.GetPrix().ToString("0.00");
                txtQuantite.Text = livreAModifier.GetQuantite().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Remplit les ComboBox avec les données de la base de données
        /// </summary>
        private void ChargerComboBox()
        {
            // Assigner les données de la BD aux ComboBox
            AuteurManager auteurManager = new AuteurManager();
            List<Auteur> listeAuteurs = auteurManager.RecupererListeAuteur();
            comboBoxAuteur.DataSource = listeAuteurs;
            comboBoxAuteur.DisplayMember = "Auteur";

            EditeurManager editeurManager = new EditeurManager();
            List<Editeur> listeEditeurs = editeurManager.RecupererListeEditeur();
            comboBoxEditeur.DataSource = listeEditeurs;
            comboBoxEditeur.DisplayMember = "Editeur";

            TypeLivreManager typeLivreManager = new TypeLivreManager();
            List<TypeLivre> listeTypes = typeLivreManager.RecupererListeTypeLivre();
            comboBoxType.DataSource = listeTypes;
            comboBoxType.DisplayMember = "Type";
        }

        /// <summary>
        /// Gestion du bouton créer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            //Verifie la conformité des champs
            if (txtTitre.Text != "" && txtIsbn.Text != "" && txtPrix.Text != "" && txtQuantite.Text != ""
                && ControleEntree.VerifierIsbn(txtIsbn.Text) && ControleEntree.VerifierTextePrix(txtPrix.Text) && ControleEntree.VerifierTexteQuantite(txtQuantite.Text))
            {
                // Vérifie si le livre existe déjà
                if(!livreManager.LivreExiste(txtIsbn.Text))
                {
                    //Verifie si le livre est associé à une commande
                    // if (!livreManager.CommandeAssocie())
                    // {
                        try
                        {
                            Livre nouveauLivre = new Livre(0, txtTitre.Text, (Auteur)comboBoxAuteur.SelectedItem, (Editeur)comboBoxEditeur.SelectedItem, txtIsbn.Text, (TypeLivre)comboBoxType.SelectedItem, Convert.ToDecimal(txtPrix.Text), Convert.ToInt32(txtQuantite.Text));
                            int nbRows = livreManager.CreerLivre(nouveauLivre);
                            
                            if (nbRows > 0)
                            {
                                MessageBox.Show("Le livre a bien été ajouté", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Close();
                            }
                            else
                            { MessageBox.Show("Erreur lors de la création du livre : Aucune ligne n'a été insérée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}

                        }
                        catch (Exception ex) { MessageBox.Show("Erreur lors de la création du livre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                    // }
                    // else { MessageBox.Show("Le livre est associé à une commande, il ne peut pas être supprimé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                else { MessageBox.Show("Il existe déjà un livre avec le même ISBN.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            { MessageBox.Show("Veuillez remplir tous les champs sous la forme attendue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }

        /// <summary>
        /// Gestion du bouton modifier
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtTitre.Text != "" && txtIsbn.Text != "" && txtPrix.Text != "" && txtQuantite.Text != ""
                && ControleEntree.VerifierIsbn(txtIsbn.Text) && ControleEntree.VerifierTextePrix(txtPrix.Text) && ControleEntree.VerifierTexteQuantite(txtQuantite.Text))
            {
                try
                {
                    Livre livreAModifier = livreManager.AfficherLivre(this.idLivre);
                    livreAModifier.SetTitre(txtTitre.Text);
                    livreAModifier.SetAuteur((Auteur)comboBoxAuteur.SelectedItem);
                    livreAModifier.SetEditeur((Editeur)comboBoxEditeur.SelectedItem);
                    livreAModifier.SetIsbn(txtIsbn.Text);
                    livreAModifier.SetType((TypeLivre)comboBoxType.SelectedItem);
                    livreAModifier.SetPrix(Convert.ToDecimal(txtPrix.Text));
                    livreAModifier.SetQuantite(Convert.ToInt32(txtQuantite.Text));

                    int nbRows = livreManager.ModifierLivre(livreAModifier);

                    if (nbRows > 0)
                    {
                        MessageBox.Show("Le livre a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else { MessageBox.Show("Erreur lors de la modification du livre : Aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception ex) { MessageBox.Show("Erreur lors de la modification du livre : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else
            { MessageBox.Show("Veuillez remplir tous les champs sous la forme attendue", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
    }
}
