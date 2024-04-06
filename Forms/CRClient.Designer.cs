namespace Mots_Merveilles.Forms
{
    partial class CRClient
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
            lbVille = new Label();
            txtVille = new TextBox();
            comboBoxGenre = new ComboBox();
            lbGenre = new Label();
            dateTimePicker1 = new DateTimePicker();
            lbDate = new Label();
            lbPrenom = new Label();
            txtPrenom = new TextBox();
            lbMail = new Label();
            txtMail = new TextBox();
            lbTelephone = new Label();
            txtTelephone = new TextBox();
            lbAdresse = new Label();
            txtAdresse = new TextBox();
            lbNom = new Label();
            txtNom = new TextBox();
            lbCP = new Label();
            txtCP = new TextBox();
            btModifier = new Button();
            btCreer = new Button();
            SuspendLayout();
            // 
            // lbVille
            // 
            lbVille.AutoSize = true;
            lbVille.Location = new Point(58, 234);
            lbVille.Name = "lbVille";
            lbVille.Size = new Size(63, 21);
            lbVille.TabIndex = 70;
            lbVille.Text = "Ville";
            // 
            // txtVille
            // 
            txtVille.BackColor = Color.White;
            txtVille.BorderStyle = BorderStyle.FixedSingle;
            txtVille.CharacterCasing = CharacterCasing.Upper;
            txtVille.Location = new Point(142, 232);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(210, 29);
            txtVille.TabIndex = 69;
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Homme", "Femme" });
            comboBoxGenre.Location = new Point(580, 77);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(210, 29);
            comboBoxGenre.TabIndex = 68;
            // 
            // lbGenre
            // 
            lbGenre.AutoSize = true;
            lbGenre.Location = new Point(486, 80);
            lbGenre.Name = "lbGenre";
            lbGenre.Size = new Size(78, 21);
            lbGenre.TabIndex = 67;
            lbGenre.Text = "Genre";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(142, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(210, 29);
            dateTimePicker1.TabIndex = 66;
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Location = new Point(5, 74);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(120, 21);
            lbDate.TabIndex = 65;
            lbDate.Text = "Naissance";
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(466, 26);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(93, 21);
            lbPrenom.TabIndex = 64;
            lbPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.White;
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Location = new Point(580, 24);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(210, 29);
            txtPrenom.TabIndex = 63;
            txtPrenom.TextChanged += txtBox_TextChanged;
            // 
            // lbMail
            // 
            lbMail.AutoSize = true;
            lbMail.Location = new Point(489, 130);
            lbMail.Name = "lbMail";
            lbMail.Size = new Size(71, 21);
            lbMail.TabIndex = 62;
            lbMail.Text = "E-mail";
            // 
            // txtMail
            // 
            txtMail.BackColor = Color.White;
            txtMail.BorderStyle = BorderStyle.FixedSingle;
            txtMail.Location = new Point(580, 130);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(271, 29);
            txtMail.TabIndex = 61;
            txtMail.TextChanged += txtBox_TextChanged;
            // 
            // lbTelephone
            // 
            lbTelephone.AutoSize = true;
            lbTelephone.Location = new Point(2, 128);
            lbTelephone.Name = "lbTelephone";
            lbTelephone.Size = new Size(125, 21);
            lbTelephone.TabIndex = 60;
            lbTelephone.Text = "Téléphone";
            // 
            // txtTelephone
            // 
            txtTelephone.BackColor = Color.White;
            txtTelephone.BorderStyle = BorderStyle.FixedSingle;
            txtTelephone.Location = new Point(142, 126);
            txtTelephone.Name = "txtTelephone";
            txtTelephone.Size = new Size(211, 29);
            txtTelephone.TabIndex = 59;
            // 
            // lbAdresse
            // 
            lbAdresse.AutoSize = true;
            lbAdresse.Location = new Point(22, 180);
            lbAdresse.Name = "lbAdresse";
            lbAdresse.Size = new Size(100, 21);
            lbAdresse.TabIndex = 58;
            lbAdresse.Text = "Adresse";
            // 
            // txtAdresse
            // 
            txtAdresse.BackColor = Color.White;
            txtAdresse.BorderStyle = BorderStyle.FixedSingle;
            txtAdresse.Location = new Point(142, 178);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(271, 29);
            txtAdresse.TabIndex = 57;
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(69, 24);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(57, 21);
            lbNom.TabIndex = 56;
            lbNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.White;
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Location = new Point(142, 22);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(210, 29);
            txtNom.TabIndex = 55;
            // 
            // lbCP
            // 
            lbCP.AutoSize = true;
            lbCP.Location = new Point(426, 182);
            lbCP.Name = "lbCP";
            lbCP.Size = new Size(148, 21);
            lbCP.TabIndex = 80;
            lbCP.Text = "Code Postal";
            // 
            // txtCP
            // 
            txtCP.BackColor = Color.White;
            txtCP.BorderStyle = BorderStyle.FixedSingle;
            txtCP.Location = new Point(580, 180);
            txtCP.Name = "txtCP";
            txtCP.Size = new Size(147, 29);
            txtCP.TabIndex = 79;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btModifier.Location = new Point(350, 291);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(181, 49);
            btModifier.TabIndex = 82;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCreer.Location = new Point(350, 291);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(181, 49);
            btCreer.TabIndex = 81;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // CRClient
            // 
            AutoScaleDimensions = new SizeF(14F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(871, 368);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbCP);
            Controls.Add(txtCP);
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
            Controls.Add(lbAdresse);
            Controls.Add(txtAdresse);
            Controls.Add(lbNom);
            Controls.Add(txtNom);
            Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 3, 5, 3);
            Name = "CRClient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRClient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbVille;
        private TextBox txtVille;
        private ComboBox comboBoxGenre;
        private Label lbGenre;
        private DateTimePicker dateTimePicker1;
        private Label lbDate;
        private Label lbPrenom;
        private TextBox txtPrenom;
        private Label lbMail;
        private TextBox txtMail;
        private Label lbTelephone;
        private TextBox txtTelephone;
        private Label lbAdresse;
        private TextBox txtAdresse;
        private Label lbNom;
        private TextBox txtNom;
        private Label lbCP;
        private TextBox txtCP;
        private Button btModifier;
        private Button btCreer;
    }
}