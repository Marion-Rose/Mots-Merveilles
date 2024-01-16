namespace Mots_Merveilles.Forms
{
    partial class Editeurs
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
            dataGridView1 = new DataGridView();
            btSupprimer = new Button();
            btModifier = new Button();
            btCreer = new Button();
            lbAdresseEditeur = new Label();
            txtAdresse = new TextBox();
            lbNomEditeur = new Label();
            txtNomEditeur = new TextBox();
            lbMail = new Label();
            txtMail = new TextBox();
            lbTelephone = new Label();
            txtTelephone = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
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
            dataGridView1.Location = new Point(415, 373);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 486);
            dataGridView1.TabIndex = 22;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(1043, 285);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(272, 34);
            btSupprimer.TabIndex = 21;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(739, 285);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(272, 34);
            btModifier.TabIndex = 20;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(415, 285);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(272, 34);
            btCreer.TabIndex = 19;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // lbAdresseEditeur
            // 
            lbAdresseEditeur.AutoSize = true;
            lbAdresseEditeur.Location = new Point(844, 158);
            lbAdresseEditeur.Name = "lbAdresseEditeur";
            lbAdresseEditeur.Size = new Size(100, 21);
            lbAdresseEditeur.TabIndex = 18;
            lbAdresseEditeur.Text = "Adresse";
            // 
            // txtAdresse
            // 
            txtAdresse.BackColor = Color.White;
            txtAdresse.BorderStyle = BorderStyle.FixedSingle;
            txtAdresse.Location = new Point(959, 150);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(340, 29);
            txtAdresse.TabIndex = 17;
            // 
            // lbNomEditeur
            // 
            lbNomEditeur.AutoSize = true;
            lbNomEditeur.Location = new Point(462, 158);
            lbNomEditeur.Name = "lbNomEditeur";
            lbNomEditeur.Size = new Size(57, 21);
            lbNomEditeur.TabIndex = 16;
            lbNomEditeur.Text = "Nom";
            // 
            // txtNomEditeur
            // 
            txtNomEditeur.BackColor = Color.White;
            txtNomEditeur.BorderStyle = BorderStyle.FixedSingle;
            txtNomEditeur.Location = new Point(534, 156);
            txtNomEditeur.Name = "txtNomEditeur";
            txtNomEditeur.Size = new Size(271, 29);
            txtNomEditeur.TabIndex = 15;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(873, 226);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(71, 21);
            lbMail.TabIndex = 26;
            lbMail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(959, 224);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(340, 29);
            txtMail.TabIndex = 25;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new Point(394, 226);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new Size(125, 21);
            lbTelephone.TabIndex = 24;
            lbTelephone.Text = "Téléphone";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = Color.White;
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Location = new Point(534, 224);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(271, 29);
            txtTelephone.TabIndex = 23;
            // 
            // Editeurs
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 903);
            Controls.Add(lbMail);
            Controls.Add(txtMail);
            Controls.Add(lbTelephone);
            Controls.Add(txtTelephone);
            Controls.Add(dataGridView1);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbAdresseEditeur);
            Controls.Add(txtAdresse);
            Controls.Add(lbNomEditeur);
            Controls.Add(txtNomEditeur);
            Name = "Editeurs";
            Controls.SetChildIndex(txtNomEditeur, 0);
            Controls.SetChildIndex(lbNomEditeur, 0);
            Controls.SetChildIndex(txtAdresse, 0);
            Controls.SetChildIndex(lbAdresseEditeur, 0);
            Controls.SetChildIndex(btCreer, 0);
            Controls.SetChildIndex(btModifier, 0);
            Controls.SetChildIndex(btSupprimer, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            Controls.SetChildIndex(txtTelephone, 0);
            Controls.SetChildIndex(lbTelephone, 0);
            Controls.SetChildIndex(txtMail, 0);
            Controls.SetChildIndex(lbMail, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btSupprimer;
        private Button btModifier;
        private Button btCreer;
        private Label lbAdresseEditeur;
        private TextBox txtAdresse;
        private Label lbNomEditeur;
        private TextBox txtNomEditeur;
        private Label lbMail;
        private TextBox txtMail;
        private Label lbTelephone;
        private TextBox txtTelephone;
    }
}