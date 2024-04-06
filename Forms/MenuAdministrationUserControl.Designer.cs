namespace Mots_Merveilles.Forms
{
    partial class MenuAdministrationUserControl
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
            btAuteurs = new Button();
            btEditeurs = new Button();
            btTypeLivre = new Button();
            btEmployes = new Button();
            lbTitre = new Label();
            panelContenu = new Panel();
            btnUtilisateurs = new Button();
            SuspendLayout();
            // 
            // btAuteurs
            // 
            btAuteurs.BackColor = Color.FromArgb(107, 59, 59);
            btAuteurs.ForeColor = Color.FloralWhite;
            btAuteurs.Location = new Point(18, 161);
            btAuteurs.Margin = new Padding(2, 3, 2, 3);
            btAuteurs.Name = "btAuteurs";
            btAuteurs.Size = new Size(169, 47);
            btAuteurs.TabIndex = 2;
            btAuteurs.Text = "Auteurs";
            btAuteurs.UseVisualStyleBackColor = false;
            btAuteurs.Click += btAuteurs_Click;
            btAuteurs.MouseEnter += lbMenu_MouseEnter;
            btAuteurs.MouseLeave += lbMenu_MouseLeave;
            // 
            // btEditeurs
            // 
            btEditeurs.BackColor = Color.FromArgb(107, 59, 59);
            btEditeurs.ForeColor = Color.FloralWhite;
            btEditeurs.Location = new Point(18, 240);
            btEditeurs.Margin = new Padding(2, 3, 2, 3);
            btEditeurs.Name = "btEditeurs";
            btEditeurs.Size = new Size(169, 47);
            btEditeurs.TabIndex = 3;
            btEditeurs.Text = "Editeurs";
            btEditeurs.UseVisualStyleBackColor = false;
            btEditeurs.Click += btEditeurs_Click;
            btEditeurs.MouseEnter += lbMenu_MouseEnter;
            btEditeurs.MouseLeave += lbMenu_MouseLeave;
            // 
            // btTypeLivre
            // 
            btTypeLivre.BackColor = Color.FromArgb(107, 59, 59);
            btTypeLivre.ForeColor = Color.FloralWhite;
            btTypeLivre.Location = new Point(18, 319);
            btTypeLivre.Margin = new Padding(2, 3, 2, 3);
            btTypeLivre.Name = "btTypeLivre";
            btTypeLivre.Size = new Size(169, 47);
            btTypeLivre.TabIndex = 4;
            btTypeLivre.Text = "Type de Livre";
            btTypeLivre.UseVisualStyleBackColor = false;
            btTypeLivre.Click += btTypeLivre_Click;
            btTypeLivre.MouseEnter += lbMenu_MouseEnter;
            btTypeLivre.MouseLeave += lbMenu_MouseLeave;
            // 
            // btEmployes
            // 
            btEmployes.BackColor = Color.FromArgb(107, 59, 59);
            btEmployes.ForeColor = Color.FloralWhite;
            btEmployes.Location = new Point(18, 498);
            btEmployes.Margin = new Padding(2, 3, 2, 3);
            btEmployes.Name = "btEmployes";
            btEmployes.Size = new Size(169, 47);
            btEmployes.TabIndex = 5;
            btEmployes.Text = "Employés";
            btEmployes.UseVisualStyleBackColor = false;
            btEmployes.Click += btEmployes_Click;
            btEmployes.MouseEnter += lbMenu_MouseEnter;
            btEmployes.MouseLeave += lbMenu_MouseLeave;
            // 
            // lbTitre
            // 
            lbTitre.AutoSize = true;
            lbTitre.Font = new Font("Copperplate Gothic Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitre.ForeColor = Color.FromArgb(107, 59, 59);
            lbTitre.Location = new Point(686, 10);
            lbTitre.Margin = new Padding(2, 0, 2, 0);
            lbTitre.Name = "lbTitre";
            lbTitre.Size = new Size(239, 30);
            lbTitre.TabIndex = 8;
            lbTitre.Text = "Administration";
            // 
            // panelContenu
            // 
            panelContenu.Location = new Point(236, 64);
            panelContenu.Name = "panelContenu";
            panelContenu.Size = new Size(1204, 607);
            panelContenu.TabIndex = 9;
            // 
            // btnUtilisateurs
            // 
            btnUtilisateurs.BackColor = Color.FromArgb(107, 59, 59);
            btnUtilisateurs.ForeColor = Color.FloralWhite;
            btnUtilisateurs.Location = new Point(18, 572);
            btnUtilisateurs.Margin = new Padding(2, 3, 2, 3);
            btnUtilisateurs.Name = "btnUtilisateurs";
            btnUtilisateurs.Size = new Size(169, 47);
            btnUtilisateurs.TabIndex = 10;
            btnUtilisateurs.Text = "Utilisateurs";
            btnUtilisateurs.UseVisualStyleBackColor = false;
            btnUtilisateurs.Click += btnUtilisateurs_Click;
            // 
            // MenuAdministrationUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.Control;
            Controls.Add(btnUtilisateurs);
            Controls.Add(panelContenu);
            Controls.Add(lbTitre);
            Controls.Add(btEmployes);
            Controls.Add(btTypeLivre);
            Controls.Add(btEditeurs);
            Controls.Add(btAuteurs);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MenuAdministrationUserControl";
            Size = new Size(1459, 685);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btAuteurs;
        private Button btEditeurs;
        private Button btTypeLivre;
        private Button btEmployes;
        private Label lbTitre;
        private Panel panelContenu;
        private Button btnUtilisateurs;
    }
}