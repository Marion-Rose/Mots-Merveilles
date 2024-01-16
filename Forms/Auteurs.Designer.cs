namespace Mots_Merveilles.Forms
{
    partial class Auteurs
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtNomAuteur = new TextBox();
            lbNomAuteur = new Label();
            lbPrenomAuteur = new Label();
            txtPrenomAuteur = new TextBox();
            btSupprimer = new Button();
            btModifier = new Button();
            btCreer = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNomAuteur
            // 
            txtNomAuteur.BackColor = Color.White;
            txtNomAuteur.BorderStyle = BorderStyle.FixedSingle;
            txtNomAuteur.Location = new Point(531, 185);
            txtNomAuteur.Name = "txtNomAuteur";
            txtNomAuteur.Size = new Size(271, 29);
            txtNomAuteur.TabIndex = 7;
            // 
            // lbNomAuteur
            // 
            lbNomAuteur.AutoSize = true;
            lbNomAuteur.Location = new Point(459, 187);
            lbNomAuteur.Name = "lbNomAuteur";
            lbNomAuteur.Size = new Size(57, 21);
            lbNomAuteur.TabIndex = 8;
            lbNomAuteur.Text = "Nom";
            lbNomAuteur.Click += label2_Click;
            // 
            // lbPrenomAuteur
            // 
            lbPrenomAuteur.AutoSize = true;
            lbPrenomAuteur.Location = new Point(874, 187);
            lbPrenomAuteur.Name = "lbPrenomAuteur";
            lbPrenomAuteur.Size = new Size(93, 21);
            lbPrenomAuteur.TabIndex = 10;
            lbPrenomAuteur.Text = "Prénom";
            // 
            // txtPrenomAuteur
            // 
            txtPrenomAuteur.BackColor = Color.White;
            txtPrenomAuteur.BorderStyle = BorderStyle.FixedSingle;
            txtPrenomAuteur.Location = new Point(983, 185);
            txtPrenomAuteur.Name = "txtPrenomAuteur";
            txtPrenomAuteur.Size = new Size(271, 29);
            txtPrenomAuteur.TabIndex = 9;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(1043, 284);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(272, 34);
            btSupprimer.TabIndex = 13;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(739, 284);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(272, 34);
            btModifier.TabIndex = 12;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(415, 284);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(272, 34);
            btCreer.TabIndex = 11;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FloralWhite;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(415, 354);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 487);
            dataGridView1.TabIndex = 23;
            // 
            // Auteurs
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 903);
            Controls.Add(dataGridView1);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbPrenomAuteur);
            Controls.Add(txtPrenomAuteur);
            Controls.Add(lbNomAuteur);
            Controls.Add(txtNomAuteur);
            Name = "Auteurs";
            Controls.SetChildIndex(txtNomAuteur, 0);
            Controls.SetChildIndex(lbNomAuteur, 0);
            Controls.SetChildIndex(txtPrenomAuteur, 0);
            Controls.SetChildIndex(lbPrenomAuteur, 0);
            Controls.SetChildIndex(btCreer, 0);
            Controls.SetChildIndex(btModifier, 0);
            Controls.SetChildIndex(btSupprimer, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomAuteur;
        private Label lbNomAuteur;
        private Label lbPrenomAuteur;
        private TextBox txtPrenomAuteur;
        private Button btSupprimer;
        private Button btModifier;
        private Button btCreer;
        private DataGridView dataGridView1;
    }
}