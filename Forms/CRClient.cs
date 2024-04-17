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
    /// Formulaire de création et de modification de client
    /// </summary>
    public partial class CRClient : Form
    {
        private ClientManager clientManager;
        private int idClient;
        private bool param;

        /// <summary>
        /// Constructeur de la classe CRClient
        /// </summary>
        /// <param name="param"></param>
        /// <param name="idClient"></param>
        public CRClient(bool param, int? idClient = null)
        {
            InitializeComponent();
            this.clientManager = new ClientManager();
            this.param = param;
            if (idClient != null) { this.idClient = (int)idClient; }
            this.Load += CRClient_Load;
        }

        /// <summary>
        /// Chargement du formulaire
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CRClient_Load(object sender, EventArgs e)
        {
            // Si param est true, bouton créer est visible, sinon bouton modifier est visible
            if (param)
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
            textBox.Text = ControleEntree.FormaterTexteNom(text);
            textBox.SelectionStart = text.Length;
            
        }

        /// <summary>
        /// Préremplissage des champs en cas de modification
        /// </summary>
        private void PreremplirChamps()
        {
            try
            {
                Client clientAModifier = clientManager.AfficherClient(this.idClient);
                txtNom.Text = clientAModifier.GetNom();
                txtPrenom.Text = clientAModifier.GetPrenom();
                dateTimePicker1.Value = clientAModifier.GetDateNaissance();
                comboBoxGenre.Text = clientAModifier.GetSexe();
                txtAdresse.Text = clientAModifier.GetAdresse();
                txtCP.Text = clientAModifier.GetCodePostal();
                txtVille.Text = clientAModifier.GetVille();
                txtTelephone.Text = clientAModifier.GetTelephone();
                txtMail.Text = clientAModifier.GetEmail();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des données : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestion du bouton de création de client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btCreer_Click(object sender, EventArgs e)
        {
            //Verifie la conformité des champs
            if (txtNom.Text !="" && txtPrenom.Text !="" && txtAdresse.Text != "" && txtCP.Text !="" && txtVille.Text !="" && txtTelephone.Text !="" && txtMail.Text != "" 
                && ControleEntree.VerifierTexteNom(txtNom.Text) && ControleEntree.VerifierTexteNom(txtPrenom.Text) && ControleEntree.VerifierTexteNom(txtVille.Text) && ControleEntree.VerifierTexteTelephone(txtTelephone.Text) && ControleEntree.VerifierTexteMail(txtMail.Text) && ControleEntree.VerifierCodePostal(txtCP.Text))
            {
                //Verifie si le client existe déjà
                if(!clientManager.ClientExiste(txtNom.Text, txtPrenom.Text, dateTimePicker1.Value))
                {
                    try
                    {
                        Client nouveauClient = new Client(0, txtNom.Text, txtPrenom.Text, dateTimePicker1.Value, comboBoxGenre.Text, txtAdresse.Text, txtCP.Text, txtVille.Text, txtTelephone.Text, txtMail.Text);
                        int nbRows = clientManager.CreerClient(nouveauClient);

                        if(nbRows > 0)
                        {
                            MessageBox.Show("Le client a bien été ajouté", "Création réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Close();
                        }
                        else
                        { MessageBox.Show("Erreur lors de la création du client : Aucune ligne n'a été insérée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                    }
                    catch (Exception ex) { MessageBox.Show("Erreur lors de la création du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
                }
                else { MessageBox.Show("Ce client existe déjà", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }   
            }
            else
            {
                MessageBox.Show("Veuillez remplir correctement tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gestion du bouton de modification de client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btModifier_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "" && txtPrenom.Text != "" && txtAdresse.Text != "" && txtCP.Text != "" && txtVille.Text != "" && txtTelephone.Text != "" && txtMail.Text != ""
                && ControleEntree.VerifierTexteNom(txtNom.Text) ==true && ControleEntree.VerifierTexteNom(txtPrenom.Text) == true && ControleEntree.VerifierTexteNom(txtVille.Text) == true && ControleEntree.VerifierTexteTelephone(txtTelephone.Text) == true && ControleEntree.VerifierTexteMail(txtMail.Text) == true && ControleEntree.VerifierCodePostal(txtCP.Text) == true)
            {
                try
                {
                   Client clientAModifier = clientManager.AfficherClient(this.idClient);
                    clientAModifier.SetNom(txtNom.Text);
                    clientAModifier.SetPrenom(txtPrenom.Text);
                    clientAModifier.SetDateNaissance(dateTimePicker1.Value);
                    clientAModifier.SetSexe(comboBoxGenre.Text);
                    clientAModifier.SetAdresse(txtAdresse.Text);
                    clientAModifier.SetCodePostal(txtCP.Text);
                    clientAModifier.SetVille(txtVille.Text);
                    clientAModifier.SetTelephone(txtTelephone.Text);
                    clientAModifier.SetEmail(txtMail.Text);

                    int nbRows = clientManager.ModifierClient(clientAModifier);

                    if (nbRows > 0)
                    {
                        MessageBox.Show("Le client a bien été modifié.", "Modification réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else { MessageBox.Show("Erreur lors de la modification du client : Aucune ligne n'a été modifiée", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                }
                catch (Exception ex) { MessageBox.Show("Erreur lors de la modification du client : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else
            {
                MessageBox.Show("Veuillez remplir correctement tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
