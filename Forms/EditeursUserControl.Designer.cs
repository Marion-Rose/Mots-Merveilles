namespace Mots_Merveilles.Forms
{
    partial class EditeursUserControl
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FloralWhite;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Tan;
            dataGridViewCellStyle2.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Copperplate Gothic Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Tan;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(54, 222);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1098, 275);
            dataGridView1.TabIndex = 22;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(703, 157);
            btSupprimer.Margin = new Padding(2, 3, 2, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(155, 32);
            btSupprimer.TabIndex = 7;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(529, 157);
            btModifier.Margin = new Padding(2, 3, 2, 3);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(155, 32);
            btModifier.TabIndex = 6;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(344, 157);
            btCreer.Margin = new Padding(2, 3, 2, 3);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(155, 32);
            btCreer.TabIndex = 5;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // lbAdresseEditeur
            // 
            lbAdresseEditeur.AutoSize = true;
            lbAdresseEditeur.Location = new Point(613, 29);
            lbAdresseEditeur.Margin = new Padding(2, 0, 2, 0);
            lbAdresseEditeur.Name = "lbAdresseEditeur";
            lbAdresseEditeur.Size = new Size(61, 20);
            lbAdresseEditeur.TabIndex = 18;
            lbAdresseEditeur.Text = "Adresse";
            // 
            // txtAdresse
            // 
            txtAdresse.BackColor = Color.White;
            txtAdresse.BorderStyle = BorderStyle.FixedSingle;
            txtAdresse.Location = new Point(726, 26);
            txtAdresse.Margin = new Padding(2, 3, 2, 3);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(284, 27);
            txtAdresse.TabIndex = 2;
            // 
            // lbNomEditeur
            // 
            lbNomEditeur.AutoSize = true;
            lbNomEditeur.Location = new Point(256, 28);
            lbNomEditeur.Margin = new Padding(2, 0, 2, 0);
            lbNomEditeur.Name = "lbNomEditeur";
            lbNomEditeur.Size = new Size(42, 20);
            lbNomEditeur.TabIndex = 16;
            lbNomEditeur.Text = "Nom";
            // 
            // txtNomEditeur
            // 
            txtNomEditeur.BackColor = Color.White;
            txtNomEditeur.BorderStyle = BorderStyle.FixedSingle;
            txtNomEditeur.Location = new Point(348, 27);
            txtNomEditeur.Margin = new Padding(2, 3, 2, 3);
            txtNomEditeur.Name = "txtNomEditeur";
            txtNomEditeur.Size = new Size(219, 27);
            txtNomEditeur.TabIndex = 1;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(622, 86);
            lbMail.Margin = new Padding(2, 0, 2, 0);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(52, 20);
            lbMail.TabIndex = 26;
            lbMail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.CharacterCasing = CharacterCasing.Lower;
            txtMail.Location = new Point(726, 84);
            txtMail.Margin = new Padding(2, 3, 2, 3);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(284, 27);
            txtMail.TabIndex = 4;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new Point(220, 87);
            lbTelephone.Margin = new Padding(2, 0, 2, 0);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new Size(78, 20);
            lbTelephone.TabIndex = 24;
            lbTelephone.Text = "Téléphone";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = Color.White;
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Location = new Point(348, 85);
            txtTelephone.Margin = new Padding(2, 3, 2, 3);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(219, 27);
            txtTelephone.TabIndex = 3;
            // 
            // EditeursUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "EditeursUserControl";
            Size = new Size(1204, 558);
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