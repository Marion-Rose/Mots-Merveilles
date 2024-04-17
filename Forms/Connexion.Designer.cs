namespace Mots_Merveilles.Forms
{
    partial class Connexion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            pictureBox1 = new PictureBox();
            lbIdentifiant = new Label();
            lbMDP = new Label();
            txtIdentifiant = new TextBox();
            txtMDP = new TextBox();
            btConnexion = new Button();
            btReinitialiser = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(234, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbIdentifiant
            // 
            lbIdentifiant.AutoSize = true;
            lbIdentifiant.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbIdentifiant.Location = new Point(249, 251);
            lbIdentifiant.Name = "lbIdentifiant";
            lbIdentifiant.Size = new Size(126, 21);
            lbIdentifiant.TabIndex = 3;
            lbIdentifiant.Text = "Identifiant";
            // 
            // lbMDP
            // 
            lbMDP.AutoSize = true;
            lbMDP.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbMDP.Location = new Point(225, 301);
            lbMDP.Name = "lbMDP";
            lbMDP.Size = new Size(150, 21);
            lbMDP.TabIndex = 4;
            lbMDP.Text = "Mot de passe";
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.BorderStyle = BorderStyle.FixedSingle;
            txtIdentifiant.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtIdentifiant.Location = new Point(384, 251);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(200, 29);
            txtIdentifiant.TabIndex = 5;
            // 
            // txtMDP
            // 
            txtMDP.BorderStyle = BorderStyle.FixedSingle;
            txtMDP.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMDP.Location = new Point(384, 301);
            txtMDP.Name = "txtMDP";
            txtMDP.PasswordChar = '*';
            txtMDP.Size = new Size(200, 29);
            txtMDP.TabIndex = 6;
            // 
            // btConnexion
            // 
            btConnexion.BackColor = Color.FromArgb(107, 59, 59);
            btConnexion.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btConnexion.ForeColor = Color.FloralWhite;
            btConnexion.Location = new Point(440, 368);
            btConnexion.Name = "btConnexion";
            btConnexion.Size = new Size(213, 46);
            btConnexion.TabIndex = 7;
            btConnexion.Text = "Se connecter";
            btConnexion.UseVisualStyleBackColor = false;
            btConnexion.Click += btConnexion_Click;
            // 
            // btReinitialiser
            // 
            btReinitialiser.BackColor = Color.FloralWhite;
            btReinitialiser.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btReinitialiser.ForeColor = Color.FromArgb(107, 59, 59);
            btReinitialiser.Location = new Point(162, 368);
            btReinitialiser.Name = "btReinitialiser";
            btReinitialiser.Size = new Size(213, 46);
            btReinitialiser.TabIndex = 8;
            btReinitialiser.Text = "Réinitialiser";
            btReinitialiser.UseVisualStyleBackColor = false;
            btReinitialiser.Click += btReinitialiser_Click;
            // 
            // Connexion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(800, 450);
            Controls.Add(btReinitialiser);
            Controls.Add(btConnexion);
            Controls.Add(txtMDP);
            Controls.Add(txtIdentifiant);
            Controls.Add(lbMDP);
            Controls.Add(lbIdentifiant);
            Controls.Add(pictureBox1);
            Name = "Connexion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mots & Merveilles";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbIdentifiant;
        private Label lbMDP;
        private TextBox txtIdentifiant;
        private TextBox txtMDP;
        private Button btConnexion;
        private Button btReinitialiser;
    }
}