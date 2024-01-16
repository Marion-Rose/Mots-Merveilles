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
            lbMenuAccueil = new Label();
            pictureBox1 = new PictureBox();
            pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnlMenu.Controls.Add(lbMenuAccueil);
            pnlMenu.Location = new Point(266, 51);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(1066, 73);
            pnlMenu.TabIndex = 0;
            // 
            // lbMenuAdministration
            // 
            lbMenuAdministration.AutoSize = true;
            lbMenuAdministration.ForeColor = Color.FloralWhite;
            lbMenuAdministration.Location = new Point(838, 24);
            lbMenuAdministration.Name = "lbMenuAdministration";
            lbMenuAdministration.Size = new Size(171, 21);
            lbMenuAdministration.TabIndex = 3;
            lbMenuAdministration.Text = "Administration";
            lbMenuAdministration.Click += lbMenuAdministration_Click;
            // 
            // lbMenuCommandes
            // 
            lbMenuCommandes.AutoSize = true;
            lbMenuCommandes.ForeColor = Color.FloralWhite;
            lbMenuCommandes.Location = new Point(598, 24);
            lbMenuCommandes.Name = "lbMenuCommandes";
            lbMenuCommandes.Size = new Size(136, 21);
            lbMenuCommandes.TabIndex = 3;
            lbMenuCommandes.Text = "Commandes";
            lbMenuCommandes.Click += lbMenuCommandes_Click;
            // 
            // lbMenuClients
            // 
            lbMenuClients.AutoSize = true;
            lbMenuClients.ForeColor = Color.FloralWhite;
            lbMenuClients.Location = new Point(409, 24);
            lbMenuClients.Name = "lbMenuClients";
            lbMenuClients.Size = new Size(92, 21);
            lbMenuClients.TabIndex = 3;
            lbMenuClients.Text = "Clients";
            lbMenuClients.Click += lbMenuClients_Click;
            // 
            // lbMenuLivre
            // 
            lbMenuLivre.AutoSize = true;
            lbMenuLivre.ForeColor = Color.FloralWhite;
            lbMenuLivre.Location = new Point(233, 24);
            lbMenuLivre.Name = "lbMenuLivre";
            lbMenuLivre.Size = new Size(78, 21);
            lbMenuLivre.TabIndex = 3;
            lbMenuLivre.Text = "Livres";
            lbMenuLivre.Click += lbMenuLivre_Click;
            // 
            // lbMenuAccueil
            // 
            lbMenuAccueil.AutoSize = true;
            lbMenuAccueil.ForeColor = Color.FloralWhite;
            lbMenuAccueil.Location = new Point(40, 24);
            lbMenuAccueil.Name = "lbMenuAccueil";
            lbMenuAccueil.Size = new Size(94, 21);
            lbMenuAccueil.TabIndex = 2;
            lbMenuAccueil.Text = "Accueil";
            lbMenuAccueil.Click += label1_Click;
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
            // Accueil
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 903);
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
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMenu;
        private PictureBox pictureBox1;
        private Label lbMenuAccueil;
        private Label lbMenuAdministration;
        private Label lbMenuCommandes;
        private Label lbMenuClients;
        private Label lbMenuLivre;
    }
}