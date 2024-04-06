namespace Mots_Merveilles
{
    partial class Accueil
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            pnlMenu = new Panel();
            lbMenuAdministration = new Label();
            lbMenuCommandes = new Label();
            lbMenuClients = new Label();
            lbMenuLivre = new Label();
            pictureBox1 = new PictureBox();
            linkLbUtilisateur = new LinkLabel();
            pictureBox2 = new PictureBox();
            panelContenu = new Panel();
            lbDeconnexion = new LinkLabel();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(107, 59, 59);
            pnlMenu.BorderStyle = BorderStyle.FixedSingle;
            pnlMenu.Controls.Add(lbMenuAdministration);
            pnlMenu.Controls.Add(lbMenuCommandes);
            pnlMenu.Controls.Add(lbMenuClients);
            pnlMenu.Controls.Add(lbMenuLivre);
            pnlMenu.Location = new Point(298, 51);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(939, 73);
            pnlMenu.TabIndex = 0;
            // 
            // lbMenuAdministration
            // 
            lbMenuAdministration.AutoSize = true;
            lbMenuAdministration.ForeColor = Color.FloralWhite;
            lbMenuAdministration.Location = new Point(726, 24);
            lbMenuAdministration.Name = "lbMenuAdministration";
            lbMenuAdministration.Size = new Size(171, 21);
            lbMenuAdministration.TabIndex = 3;
            lbMenuAdministration.Text = "Administration";
            lbMenuAdministration.Click += lbMenuAdministration_Click;
            lbMenuAdministration.MouseEnter += lbMenu_MouseEnter;
            lbMenuAdministration.MouseLeave += lbMenu_MouseLeave;
            // 
            // lbMenuCommandes
            // 
            lbMenuCommandes.AutoSize = true;
            lbMenuCommandes.ForeColor = Color.FloralWhite;
            lbMenuCommandes.Location = new Point(490, 24);
            lbMenuCommandes.Name = "lbMenuCommandes";
            lbMenuCommandes.Size = new Size(136, 21);
            lbMenuCommandes.TabIndex = 3;
            lbMenuCommandes.Text = "Commandes";
            lbMenuCommandes.Click += lbMenuCommandes_Click;
            lbMenuCommandes.MouseEnter += lbMenu_MouseEnter;
            lbMenuCommandes.MouseLeave += lbMenu_MouseLeave;
            // 
            // lbMenuClients
            // 
            lbMenuClients.AutoSize = true;
            lbMenuClients.ForeColor = Color.FloralWhite;
            lbMenuClients.Location = new Point(273, 24);
            lbMenuClients.Name = "lbMenuClients";
            lbMenuClients.Size = new Size(92, 21);
            lbMenuClients.TabIndex = 3;
            lbMenuClients.Text = "Clients";
            lbMenuClients.Click += lbMenuClients_Click;
            lbMenuClients.MouseEnter += lbMenu_MouseEnter;
            lbMenuClients.MouseLeave += lbMenu_MouseLeave;
            // 
            // lbMenuLivre
            // 
            lbMenuLivre.AutoSize = true;
            lbMenuLivre.ForeColor = Color.FloralWhite;
            lbMenuLivre.Location = new Point(76, 24);
            lbMenuLivre.Name = "lbMenuLivre";
            lbMenuLivre.Size = new Size(78, 21);
            lbMenuLivre.TabIndex = 3;
            lbMenuLivre.Text = "Livres";
            lbMenuLivre.Click += lbMenuLivre_Click;
            lbMenuLivre.MouseEnter += lbMenu_MouseEnter;
            lbMenuLivre.MouseLeave += lbMenu_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(225, 145);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // linkLbUtilisateur
            // 
            linkLbUtilisateur.BackColor = SystemColors.Control;
            linkLbUtilisateur.ForeColor = SystemColors.Control;
            linkLbUtilisateur.LinkColor = Color.FromArgb(107, 57, 57);
            linkLbUtilisateur.Location = new Point(1253, 59);
            linkLbUtilisateur.Name = "linkLbUtilisateur";
            linkLbUtilisateur.Size = new Size(174, 54);
            linkLbUtilisateur.TabIndex = 2;
            linkLbUtilisateur.TabStop = true;
            linkLbUtilisateur.Text = "Utilisateur connecté";
            linkLbUtilisateur.TextAlign = ContentAlignment.MiddleRight;
            linkLbUtilisateur.VisitedLinkColor = Color.FromArgb(107, 57, 57);
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._7407996_icone_utilisateur_icone_personne_symbole_client_connexion_tete_signe_icone_conception_vectoriel;
            pictureBox2.Location = new Point(1433, 51);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(91, 73);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // panelContenu
            // 
            panelContenu.Location = new Point(50, 178);
            panelContenu.Name = "panelContenu";
            panelContenu.Size = new Size(1459, 685);
            panelContenu.TabIndex = 6;
            // 
            // lbDeconnexion
            // 
            lbDeconnexion.BackColor = SystemColors.Control;
            lbDeconnexion.Font = new Font("Copperplate Gothic Light", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbDeconnexion.ForeColor = SystemColors.Control;
            lbDeconnexion.LinkColor = Color.FromArgb(107, 57, 57);
            lbDeconnexion.Location = new Point(1340, 9);
            lbDeconnexion.Name = "lbDeconnexion";
            lbDeconnexion.Size = new Size(205, 39);
            lbDeconnexion.TabIndex = 7;
            lbDeconnexion.TabStop = true;
            lbDeconnexion.Text = "Se déconnecter";
            lbDeconnexion.TextAlign = ContentAlignment.MiddleRight;
            lbDeconnexion.VisitedLinkColor = Color.FromArgb(107, 57, 57);
            lbDeconnexion.LinkClicked += lbDeconnexion_LinkClicked;
            // 
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 903);
            Controls.Add(lbDeconnexion);
            Controls.Add(panelContenu);
            Controls.Add(pictureBox2);
            Controls.Add(linkLbUtilisateur);
            Controls.Add(pictureBox1);
            Controls.Add(pnlMenu);
            Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "Accueil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mots & Merveilles";
            pnlMenu.ResumeLayout(false);
            pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private PictureBox pictureBox1;
        private Label lbMenuAdministration;
        private Label lbMenuCommandes;
        private Label lbMenuClients;
        private Label lbMenuLivre;
        private LinkLabel linkLbUtilisateur;
        private PictureBox pictureBox2;
        private Panel panelContenu;
        private LinkLabel lbDeconnexion;
    }
}