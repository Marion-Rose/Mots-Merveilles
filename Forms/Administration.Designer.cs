namespace Mots_Merveilles.Forms
{
    partial class Administration
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
            SuspendLayout();
            // 
            // btAuteurs
            // 
            btAuteurs.BackColor = Color.FromArgb(107, 59, 59);
            btAuteurs.ForeColor = Color.FloralWhite;
            btAuteurs.Location = new Point(31, 256);
            btAuteurs.Name = "btAuteurs";
            btAuteurs.Size = new Size(206, 46);
            btAuteurs.TabIndex = 2;
            btAuteurs.Text = "Auteurs";
            btAuteurs.UseVisualStyleBackColor = false;
            btAuteurs.Click += button1_Click;
            // 
            // btEditeurs
            // 
            btEditeurs.BackColor = Color.FromArgb(107, 59, 59);
            btEditeurs.ForeColor = Color.FloralWhite;
            btEditeurs.Location = new Point(31, 354);
            btEditeurs.Name = "btEditeurs";
            btEditeurs.Size = new Size(206, 46);
            btEditeurs.TabIndex = 3;
            btEditeurs.Text = "Editeurs";
            btEditeurs.UseVisualStyleBackColor = false;
            btEditeurs.Click += btEditeurs_Click;
            // 
            // btTypeLivre
            // 
            btTypeLivre.BackColor = Color.FromArgb(107, 59, 59);
            btTypeLivre.ForeColor = Color.FloralWhite;
            btTypeLivre.Location = new Point(31, 453);
            btTypeLivre.Name = "btTypeLivre";
            btTypeLivre.Size = new Size(206, 46);
            btTypeLivre.TabIndex = 4;
            btTypeLivre.Text = "Type de Livre";
            btTypeLivre.UseVisualStyleBackColor = false;
            btTypeLivre.Click += btTypeLivre_Click;
            // 
            // btEmployes
            // 
            btEmployes.BackColor = Color.FromArgb(107, 59, 59);
            btEmployes.ForeColor = Color.FloralWhite;
            btEmployes.Location = new Point(31, 550);
            btEmployes.Name = "btEmployes";
            btEmployes.Size = new Size(206, 46);
            btEmployes.TabIndex = 5;
            btEmployes.Text = "Employés";
            btEmployes.UseVisualStyleBackColor = false;
            btEmployes.Click += btEmployes_Click;
            // 
            // Administration
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1567, 903);
            Controls.Add(btEmployes);
            Controls.Add(btTypeLivre);
            Controls.Add(btEditeurs);
            Controls.Add(btAuteurs);
            Name = "Administration";
            Text = "Mots & Merveilles";
            Controls.SetChildIndex(btAuteurs, 0);
            Controls.SetChildIndex(btEditeurs, 0);
            Controls.SetChildIndex(btTypeLivre, 0);
            Controls.SetChildIndex(btEmployes, 0);
            ResumeLayout(false);
        }

        #endregion

        private Button btAuteurs;
        private Button btEditeurs;
        private Button btTypeLivre;
        private Button btEmployes;
    }
}