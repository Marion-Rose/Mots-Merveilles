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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            txtMail.CharacterCasing = CharacterCasing.Lower;
            txtMail.Location = new Point(576, 117);
            txtMail.Margin = new Padding(2, 3, 2, 3);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(188, 27);
            txtMail.TabIndex = 8;
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
            txtTelephone.TabIndex = 7;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(722, 194);
            btSupprimer.Margin = new Padding(2, 3, 2, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(155, 32);
            btSupprimer.TabIndex = 11;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(537, 194);
            btModifier.Margin = new Padding(2, 3, 2, 3);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(155, 32);
            btModifier.TabIndex = 10;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(352, 194);
            btCreer.Margin = new Padding(2, 3, 2, 3);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(155, 32);
            btCreer.TabIndex = 9;
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
            txtAdresse.TabIndex = 5;
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
            txtNom.TabIndex = 1;
            txtNom.TextChanged += txtBox_TextChanged;
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
            txtPrenom.TabIndex = 2;
            txtPrenom.TextChanged += txtBox_TextChanged;
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
            dateTimePicker1.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 27);
            dateTimePicker1.TabIndex = 3;
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
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Items.AddRange(new object[] { "Homme", "Femme" });
            comboBoxGenre.Location = new Point(153, 63);
            comboBoxGenre.Margin = new Padding(2, 3, 2, 3);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(188, 28);
            comboBoxGenre.TabIndex = 4;
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
            txtVille.CharacterCasing = CharacterCasing.Upper;
            txtVille.Location = new Point(980, 66);
            txtVille.Margin = new Padding(2, 3, 2, 3);
            txtVille.Name = "txtVille";
            txtVille.Size = new Size(188, 27);
            txtVille.TabIndex = 6;
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
            dataGridView1.Location = new Point(54, 259);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1098, 275);
            dataGridView1.TabIndex = 47;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // EmployesUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(dataGridView1);
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
            Load += EmployesUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMail;
        private TextBox txtMail;
        private Label lbTelephone;
        private TextBox txtTelephone;
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
        private DataGridView dataGridView1;
    }
}