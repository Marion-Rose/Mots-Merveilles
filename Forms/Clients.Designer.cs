namespace Mots_Merveilles.Forms
{
    partial class Clients
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
            lbTitre = new Label();
            dataGridView1 = new DataGridView();
            btSupprimer = new Button();
            btModifier = new Button();
            btCreer = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbTitre
            // 
            lbTitre.AutoSize = true;
            lbTitre.Font = new Font("Copperplate Gothic Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitre.ForeColor = Color.FromArgb(107, 59, 59);
            lbTitre.Location = new Point(723, 159);
            lbTitre.Name = "lbTitre";
            lbTitre.Size = new Size(271, 30);
            lbTitre.TabIndex = 12;
            lbTitre.Text = "Liste des Clients";
            lbTitre.Click += lbTitre_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FloralWhite;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(272, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(1217, 634);
            dataGridView1.TabIndex = 11;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(49, 572);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(181, 49);
            btSupprimer.TabIndex = 10;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(49, 449);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(181, 49);
            btModifier.TabIndex = 9;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(49, 329);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(181, 49);
            btCreer.TabIndex = 8;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // Clients
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            ClientSize = new Size(1567, 903);
            Controls.Add(lbTitre);
            Controls.Add(dataGridView1);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Name = "Clients";
            Controls.SetChildIndex(btCreer, 0);
            Controls.SetChildIndex(btModifier, 0);
            Controls.SetChildIndex(btSupprimer, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(lbTitre, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTitre;
        private DataGridView dataGridView1;
        private Button btSupprimer;
        private Button btModifier;
        private Button btCreer;
    }
}