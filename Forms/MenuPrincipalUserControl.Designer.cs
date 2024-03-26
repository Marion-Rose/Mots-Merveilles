namespace Mots_Merveilles.Forms
{
    partial class MenuPrincipalUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipalUserControl));
            lbBienvenue = new Label();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbBienvenue
            // 
            lbBienvenue.AutoSize = true;
            lbBienvenue.Font = new Font("Copperplate Gothic Bold", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lbBienvenue.Location = new Point(558, 63);
            lbBienvenue.Name = "lbBienvenue";
            lbBienvenue.Size = new Size(280, 44);
            lbBienvenue.TabIndex = 7;
            lbBienvenue.Text = "Bienvenue !";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(342, 173);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(701, 424);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // MenuPrincipalUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(lbBienvenue);
            Controls.Add(pictureBox3);
            Name = "MenuPrincipalUserControl";
            Size = new Size(1226, 685);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBienvenue;
        private PictureBox pictureBox3;
    }
}
