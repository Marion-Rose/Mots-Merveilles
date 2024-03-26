namespace Mots_Merveilles.Forms
{
    partial class MenuLivresUserControl
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
            btCreer = new Button();
            btModifier = new Button();
            btSupprimer = new Button();
            dataGridView1 = new DataGridView();
            lbTitre = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(22, 255);
            btCreer.Margin = new Padding(2, 3, 2, 3);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(139, 47);
            btCreer.TabIndex = 2;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(22, 370);
            btModifier.Margin = new Padding(2, 3, 2, 3);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(139, 47);
            btModifier.TabIndex = 3;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(22, 487);
            btSupprimer.Margin = new Padding(2, 3, 2, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(139, 47);
            btSupprimer.TabIndex = 4;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(210, 122);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1223, 538);
            dataGridView1.TabIndex = 6;
            // 
            // lbTitre
            // 
            lbTitre.AutoSize = true;
            lbTitre.Font = new Font("Copperplate Gothic Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitre.ForeColor = Color.FromArgb(107, 59, 59);
            lbTitre.Location = new Point(645, 28);
            lbTitre.Margin = new Padding(2, 0, 2, 0);
            lbTitre.Name = "lbTitre";
            lbTitre.Size = new Size(250, 30);
            lbTitre.TabIndex = 7;
            lbTitre.Text = "Liste des Livres";
            // 
            // MenuLivresUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            BackColor = SystemColors.Control;
            Controls.Add(lbTitre);
            Controls.Add(dataGridView1);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Margin = new Padding(2, 3, 2, 3);
            Name = "MenuLivresUserControl";
            Size = new Size(1459, 685);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btCreer;
        private Button btModifier;
        private Button btSupprimer;
        private DataGridView dataGridView1;
        private Label lbTitre;
    }
}