namespace Mots_Merveilles.Forms
{
    partial class EmployesUserControl
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
            lbMail.Location = new Point(473, 119);
            lbMail.Margin = new Padding(2, 0, 2, 0);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(52, 20);
            lbMail.TabIndex = 38;
            lbMail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(576, 117);
            txtMail.Margin = new Padding(2, 3, 2, 3);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(188, 27);
            txtMail.TabIndex = 37;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new Point(18, 119);
            lbTelephone.Margin = new Padding(2, 0, 2, 0);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new Size(78, 20);
            lbTelephone.TabIndex = 36;
            lbTelephone.Text = "Téléphone";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = Color.White;
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Location = new Point(153, 117);
            txtTelephone.Margin = new Padding(2, 3, 2, 3);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(188, 27);
            txtTelephone.TabIndex = 35;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(722, 232);
            btSupprimer.Margin = new Padding(2, 3, 2, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(155, 32);
            btSupprimer.TabIndex = 33;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(537, 232);
            btModifier.Margin = new Padding(2, 3, 2, 3);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(155, 32);
            btModifier.TabIndex = 32;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(352, 232);
            btCreer.Margin = new Padding(2, 3, 2, 3);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(155, 32);
            btCreer.TabIndex = 31;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // lbAdresse
            // 
            lbAdresse.AutoSize = true;
            lbAdresse.Location = new Point(464, 68);
            lbAdresse.Margin = new Padding(2, 0, 2, 0);
            lbAdresse.Name = "lbAdresse";
            lbAdresse.Size = new Size(61, 20);
            lbAdresse.TabIndex = 30;
            lbAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            txtAdresse.BackColor = Color.White;
            txtAdresse.BorderStyle = BorderStyle.FixedSingle;
            txtAdresse.Location = new Point(576, 66);
            txtAdresse.Margin = new Padding(2, 3, 2, 3);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(188, 27);
            txtAdresse.TabIndex = 29;
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(54, 14);
            lbNom.Margin = new Padding(2, 0, 2, 0);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(42, 20);
            lbNom.TabIndex = 28;
            lbNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.White;
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Location = new Point(153, 12);
            txtNom.Margin = new Padding(2, 3, 2, 3);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(188, 27);
            txtNom.TabIndex = 27;
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(460, 14);
            lbPrenom.Margin = new Padding(2, 0, 2, 0);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(60, 20);
            lbPrenom.TabIndex = 40;
            lbPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.White;
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Location = new Point(576, 12);
            txtPrenom.Margin = new Padding(2, 3, 2, 3);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(188, 27);
            txtPrenom.TabIndex = 39;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(848, 14);
            lbDate.Margin = new Padding(2, 0, 2, 0);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(75, 20);
            lbDate.TabIndex = 41;
            lbDate.Text = "Naissance";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(980, 14);
            dateTimePicker1.Margin = new Padding(2, 3, 2, 3);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 27);
            dateTimePicker1.TabIndex = 42;
            // 
            // lbGenre
            // 
            lbGenre.AutoSize = true;
            lbGenre.Location = new Point(48, 66);
            lbGenre.Margin = new Padding(2, 0, 2, 0);
            lbGenre.Name = "lbGenre";
            lbGenre.Size = new Size(48, 20);
            lbGenre.TabIndex = 43;
            lbGenre.Text = "Genre";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Homme", "Femme" });
            comboBoxGenre.Location = new Point(153, 63);
            comboBoxGenre.Margin = new Padding(2, 3, 2, 3);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(188, 28);
            comboBoxGenre.TabIndex = 44;
            // 
            // lbVille
            // 
            lbVille.AutoSize = true;
            lbVille.Location = new Point(885, 68);
            lbVille.Margin = new Padding(2, 0, 2, 0);
            lbVille.Name = "lbVille";
            lbVille.Size = new Size(38, 20);
            lbVille.TabIndex = 46;
            lbVille.Text = "Ville";
            // 
            // txtVille
            // 
            txtVille.BackColor = Color.White;
            txtVille.BorderStyle = BorderStyle.FixedSingle;
            txtVille.Location = new Point(980, 66);
            txtVille.Margin = new Padding(2, 3, 2, 3);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(188, 27);
            txtVille.TabIndex = 45;
            // 
            // comboBoxGroupe
            // 
            comboBoxGroupe.FormattingEnabled = true;
            comboBoxGroupe.Location = new Point(980, 117);
            comboBoxGroupe.Margin = new Padding(2, 3, 2, 3);
            comboBoxGroupe.Name = "comboBoxGroupe";
            comboBoxGroupe.Size = new Size(188, 28);
            comboBoxGroupe.TabIndex = 48;
            // 
            // lbGroupe
            // 
            lbGroupe.AutoSize = true;
            lbGroupe.Location = new Point(865, 119);
            lbGroupe.Margin = new Padding(2, 0, 2, 0);
            lbGroupe.Name = "lbGroupe";
            lbGroupe.Size = new Size(58, 20);
            lbGroupe.TabIndex = 47;
            lbGroupe.Text = "Groupe";
            // 
            // comboBoxActif
            // 
            comboBoxActif.FormattingEnabled = true;
            comboBoxActif.Items.AddRange(new object[] { "Actif", "Inactif" });
            comboBoxActif.Location = new Point(980, 172);
            comboBoxActif.Margin = new Padding(2, 3, 2, 3);
            comboBoxActif.Name = "comboBoxActif";
            comboBoxActif.Size = new Size(188, 28);
            comboBoxActif.TabIndex = 54;
            // 
            // lbActif
            // 
            lbActif.AutoSize = true;
            lbActif.Location = new Point(881, 176);
            lbActif.Margin = new Padding(2, 0, 2, 0);
            lbActif.Name = "lbActif";
            lbActif.Size = new Size(40, 20);
            lbActif.TabIndex = 53;
            lbActif.Text = "Actif";
            // 
            // lbMDP
            // 
            lbMDP.AutoSize = true;
            lbMDP.Location = new Point(427, 177);
            lbMDP.Margin = new Padding(2, 0, 2, 0);
            lbMDP.Name = "lbMDP";
            lbMDP.Size = new Size(98, 20);
            lbMDP.TabIndex = 52;
            lbMDP.Text = "Mot de passe";
            // 
            // txtMDP
            // 
            txtMDP.BackColor = Color.White;
            txtMDP.BorderStyle = BorderStyle.FixedSingle;
            txtMDP.Location = new Point(577, 172);
            txtMDP.Margin = new Padding(2, 3, 2, 3);
            txtMDP.Name = "txtMDP";
            txtMDP.PasswordChar = '*';
            txtMDP.Size = new Size(187, 27);
            txtMDP.TabIndex = 51;
            // 
            // lbIdentifiant
            // 
            lbIdentifiant.AutoSize = true;
            lbIdentifiant.Location = new Point(19, 176);
            lbIdentifiant.Margin = new Padding(2, 0, 2, 0);
            lbIdentifiant.Name = "lbIdentifiant";
            lbIdentifiant.Size = new Size(77, 20);
            lbIdentifiant.TabIndex = 50;
            lbIdentifiant.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.BackColor = Color.White;
            txtIdentifiant.BorderStyle = BorderStyle.FixedSingle;
            txtIdentifiant.Location = new Point(153, 173);
            txtIdentifiant.Margin = new Padding(2, 3, 2, 3);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(188, 27);
            txtIdentifiant.TabIndex = 49;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
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
            dataGridView1.Location = new Point(13, 289);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.ScrollBars = ScrollBars.Horizontal;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1177, 266);
            dataGridView1.TabIndex = 55;
            // 
            // EmployesUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "EmployesUserControl";
            Size = new Size(1204, 558);
            Load += Employes_Load;
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