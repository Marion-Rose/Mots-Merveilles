namespace Mots_Merveilles.Forms
{
    partial class Employes
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
            lbMail = new Label();
            txtMail = new TextBox();
            lbTelephone = new Label();
            txtTelephone = new TextBox();
            btSupprimer = new Button();
            btModifier = new Button();
            btCreer = new Button();
            lbAdresse = new Label();
            txtAdresse = new TextBox();
            lbNom = new Label();
            txtNom = new TextBox();
            lbPrenom = new Label();
            txtPrenom = new TextBox();
            lbDate = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbGenre = new Label();
            comboBoxGenre = new ComboBox();
            lbVille = new Label();
            txtVille = new TextBox();
            comboBoxGroupe = new ComboBox();
            lbGroupe = new Label();
            comboBoxActif = new ComboBox();
            lbActif = new Label();
            lbMDP = new Label();
            txtMDP = new TextBox();
            lbIdentifiant = new Label();
            txtIdentifiant = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(680, 281);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(71, 21);
            lbMail.TabIndex = 38;
            lbMail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(771, 281);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(271, 29);
            txtMail.TabIndex = 37;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new Point(276, 281);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new Size(125, 21);
            lbTelephone.TabIndex = 36;
            lbTelephone.Text = "Téléphone";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = Color.White;
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Location = new Point(416, 279);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(211, 29);
            txtTelephone.TabIndex = 35;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(1045, 439);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(272, 34);
            btSupprimer.TabIndex = 33;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(741, 439);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(272, 34);
            btModifier.TabIndex = 32;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(417, 439);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(272, 34);
            btCreer.TabIndex = 31;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // lbAdresse
            // 
            lbAdresse.AutoSize = true;
            lbAdresse.Location = new Point(651, 218);
            lbAdresse.Name = "lbAdresse";
            lbAdresse.Size = new Size(100, 21);
            lbAdresse.TabIndex = 30;
            lbAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            txtAdresse.BackColor = Color.White;
            txtAdresse.BorderStyle = BorderStyle.FixedSingle;
            txtAdresse.Location = new Point(771, 216);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(271, 29);
            txtAdresse.TabIndex = 29;
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(344, 157);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(57, 21);
            lbNom.TabIndex = 28;
            lbNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.White;
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Location = new Point(417, 155);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(210, 29);
            txtNom.TabIndex = 27;
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(658, 157);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(93, 21);
            lbPrenom.TabIndex = 40;
            lbPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.White;
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Location = new Point(771, 155);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(230, 29);
            txtPrenom.TabIndex = 39;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(1030, 157);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(120, 21);
            lbDate.TabIndex = 41;
            lbDate.Text = "Naissance";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(1167, 155);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 29);
            dateTimePicker1.TabIndex = 42;
            // 
            // lbGenre
            // 
            lbGenre.AutoSize = true;
            lbGenre.Location = new Point(323, 218);
            lbGenre.Name = "lbGenre";
            lbGenre.Size = new Size(78, 21);
            lbGenre.TabIndex = 43;
            lbGenre.Text = "Genre";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Homme", "Femme" });
            comboBoxGenre.Location = new Point(417, 215);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(210, 29);
            comboBoxGenre.TabIndex = 44;
            // 
            // lbVille
            // 
            lbVille.AutoSize = true;
            lbVille.Location = new Point(1087, 218);
            lbVille.Name = "lbVille";
            lbVille.Size = new Size(63, 21);
            lbVille.TabIndex = 46;
            lbVille.Text = "Ville";
            // 
            // txtVille
            // 
            txtVille.BackColor = Color.White;
            txtVille.BorderStyle = BorderStyle.FixedSingle;
            txtVille.Location = new Point(1167, 215);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(188, 29);
            txtVille.TabIndex = 45;
            // 
            // comboBoxGroupe
            // 
            comboBoxGroupe.FormattingEnabled = true;
            comboBoxGroupe.Location = new Point(1167, 281);
            comboBoxGroupe.Name = "comboBoxGroupe";
            comboBoxGroupe.Size = new Size(188, 29);
            comboBoxGroupe.TabIndex = 48;
            // 
            // lbGroupe
            // 
            lbGroupe.AutoSize = true;
            lbGroupe.Location = new Point(1058, 284);
            lbGroupe.Name = "lbGroupe";
            lbGroupe.Size = new Size(92, 21);
            lbGroupe.TabIndex = 47;
            lbGroupe.Text = "Groupe";
            // 
            // comboBoxActif
            // 
            comboBoxActif.FormattingEnabled = true;
            comboBoxActif.Items.AddRange(new object[] { "Actif", "Inactif" });
            comboBoxActif.Location = new Point(1228, 365);
            comboBoxActif.Name = "comboBoxActif";
            comboBoxActif.Size = new Size(127, 29);
            comboBoxActif.TabIndex = 54;
            // 
            // lbActif
            // 
            lbActif.AutoSize = true;
            lbActif.Location = new Point(1140, 368);
            lbActif.Name = "lbActif";
            lbActif.Size = new Size(67, 21);
            lbActif.TabIndex = 53;
            lbActif.Text = "Actif";
            // 
            // lbMDP
            // 
            lbMDP.AutoSize = true;
            lbMDP.Location = new Point(680, 371);
            lbMDP.Name = "lbMDP";
            lbMDP.Size = new Size(150, 21);
            lbMDP.TabIndex = 52;
            lbMDP.Text = "Mot de passe";
            // 
            // txtMDP
            // 
            txtMDP.BackColor = Color.White;
            txtMDP.BorderStyle = BorderStyle.FixedSingle;
            txtMDP.Location = new Point(854, 366);
            txtMDP.Name = "txtMDP";
            txtMDP.PasswordChar = '*';
            txtMDP.Size = new Size(242, 29);
            txtMDP.TabIndex = 51;
            // 
            // lbIdentifiant
            // 
            lbIdentifiant.AutoSize = true;
            lbIdentifiant.Location = new Point(275, 373);
            lbIdentifiant.Name = "lbIdentifiant";
            lbIdentifiant.Size = new Size(126, 21);
            lbIdentifiant.TabIndex = 50;
            lbIdentifiant.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.BackColor = Color.White;
            txtIdentifiant.BorderStyle = BorderStyle.FixedSingle;
            txtIdentifiant.Location = new Point(417, 368);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(211, 29);
            txtIdentifiant.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridView1.Location = new Point(416, 499);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(900, 368);
            dataGridView1.TabIndex = 55;
            // 
            // Employes
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1567, 903);
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxActif);
            Controls.Add(lbActif);
            Controls.Add(lbMDP);
            Controls.Add(txtMDP);
            Controls.Add(lbIdentifiant);
            Controls.Add(txtIdentifiant);
            Controls.Add(comboBoxGroupe);
            Controls.Add(lbGroupe);
            Controls.Add(lbVille);
            Controls.Add(txtVille);
            Controls.Add(comboBoxGenre);
            Controls.Add(lbGenre);
            Controls.Add(dateTimePicker1);
            Controls.Add(lbDate);
            Controls.Add(lbPrenom);
            Controls.Add(txtPrenom);
            Controls.Add(lbMail);
            Controls.Add(txtMail);
            Controls.Add(lbTelephone);
            Controls.Add(txtTelephone);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbAdresse);
            Controls.Add(txtAdresse);
            Controls.Add(lbNom);
            Controls.Add(txtNom);
            Name = "Employes";
            Text = "Employes";
            Load += Employes_Load;
            Controls.SetChildIndex(txtNom, 0);
            Controls.SetChildIndex(lbNom, 0);
            Controls.SetChildIndex(txtAdresse, 0);
            Controls.SetChildIndex(lbAdresse, 0);
            Controls.SetChildIndex(btCreer, 0);
            Controls.SetChildIndex(btModifier, 0);
            Controls.SetChildIndex(btSupprimer, 0);
            Controls.SetChildIndex(txtTelephone, 0);
            Controls.SetChildIndex(lbTelephone, 0);
            Controls.SetChildIndex(txtMail, 0);
            Controls.SetChildIndex(lbMail, 0);
            Controls.SetChildIndex(txtPrenom, 0);
            Controls.SetChildIndex(lbPrenom, 0);
            Controls.SetChildIndex(lbDate, 0);
            Controls.SetChildIndex(dateTimePicker1, 0);
            Controls.SetChildIndex(lbGenre, 0);
            Controls.SetChildIndex(comboBoxGenre, 0);
            Controls.SetChildIndex(txtVille, 0);
            Controls.SetChildIndex(lbVille, 0);
            Controls.SetChildIndex(lbGroupe, 0);
            Controls.SetChildIndex(comboBoxGroupe, 0);
            Controls.SetChildIndex(txtIdentifiant, 0);
            Controls.SetChildIndex(lbIdentifiant, 0);
            Controls.SetChildIndex(txtMDP, 0);
            Controls.SetChildIndex(lbMDP, 0);
            Controls.SetChildIndex(lbActif, 0);
            Controls.SetChildIndex(comboBoxActif, 0);
            Controls.SetChildIndex(dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMail;
        private TextBox txtMail;
        private Label lbTelephone;
        private TextBox txtTelephone;
        private DataGridView dataGridView1;
        private Button btSupprimer;
        private Button btModifier;
        private Button btCreer;
        private Label lbAdresse;
        private TextBox txtAdresse;
        private Label lbNom;
        private TextBox txtNom;
        private Label lbPrenom;
        private TextBox txtPrenom;
        private Label lbDate;
        private DateTimePicker dateTimePicker1;
        private Label lbGenre;
        private ComboBox comboBoxGenre;
        private Label lbVille;
        private TextBox txtVille;
        private ComboBox comboBoxGroupe;
        private Label lbGroupe;
        private ComboBox comboBoxActif;
        private Label lbActif;
        private Label lbMDP;
        private TextBox txtMDP;
        private Label lbIdentifiant;
        private TextBox txtIdentifiant;
    }
}