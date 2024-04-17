namespace Mots_Merveilles.Forms
{
    partial class CRCommande
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
            btModifier = new Button();
            btCreer = new Button();
            lbStatut = new Label();
            lbDate = new Label();
            comboBoxEditeur = new ComboBox();
            lbEditeur = new Label();
            lbNumero = new Label();
            txtNumero = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBoxStatut = new ComboBox();
            lbLivres = new Label();
            lbQuantite = new Label();
            comboBoxLivre = new ComboBox();
            numUpDown = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnAjouter = new Button();
            ((System.ComponentModel.ISupportInitialize)numUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btModifier.Location = new Point(360, 419);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(181, 49);
            btModifier.TabIndex = 8;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCreer.Location = new Point(360, 419);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(181, 49);
            btCreer.TabIndex = 42;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // lbStatut
            // 
            lbStatut.AutoSize = true;
            lbStatut.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbStatut.Location = new Point(456, 90);
            lbStatut.Name = "lbStatut";
            lbStatut.Size = new Size(83, 21);
            lbStatut.TabIndex = 35;
            lbStatut.Text = "Statut";
            // 
            // lbDate
            // 
            lbDate.AutoSize = true;
            lbDate.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbDate.Location = new Point(50, 86);
            lbDate.Name = "lbDate";
            lbDate.Size = new Size(61, 21);
            lbDate.TabIndex = 32;
            lbDate.Text = "Date";
            // 
            // comboBoxEditeur
            // 
            comboBoxEditeur.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEditeur.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEditeur.FormattingEnabled = true;
            comboBoxEditeur.Location = new Point(548, 35);
            comboBoxEditeur.Name = "comboBoxEditeur";
            comboBoxEditeur.Size = new Size(271, 28);
            comboBoxEditeur.TabIndex = 2;
            comboBoxEditeur.SelectedIndexChanged += comboBoxEditeur_SelectedIndexChanged;
            // 
            // lbEditeur
            // 
            lbEditeur.AutoSize = true;
            lbEditeur.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEditeur.Location = new Point(447, 37);
            lbEditeur.Name = "lbEditeur";
            lbEditeur.Size = new Size(92, 21);
            lbEditeur.TabIndex = 30;
            lbEditeur.Text = "Editeur";
            // 
            // lbNumero
            // 
            lbNumero.AutoSize = true;
            lbNumero.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbNumero.Location = new Point(19, 37);
            lbNumero.Name = "lbNumero";
            lbNumero.Size = new Size(95, 21);
            lbNumero.TabIndex = 29;
            lbNumero.Text = "Numero";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.White;
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtNumero.Location = new Point(125, 34);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(271, 27);
            txtNumero.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(125, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // comboBoxStatut
            // 
            comboBoxStatut.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatut.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatut.FormattingEnabled = true;
            comboBoxStatut.Items.AddRange(new object[] { "En attente", "En cours", "Effectuée", "Payée", "Réceptionnée", "Clôturée" });
            comboBoxStatut.Location = new Point(548, 88);
            comboBoxStatut.Name = "comboBoxStatut";
            comboBoxStatut.Size = new Size(271, 28);
            comboBoxStatut.TabIndex = 4;
            comboBoxStatut.SelectedIndexChanged += comboBoxStatut_SelectedIndexChanged;
            // 
            // lbLivres
            // 
            lbLivres.AutoSize = true;
            lbLivres.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbLivres.Location = new Point(153, 171);
            lbLivres.Name = "lbLivres";
            lbLivres.Size = new Size(66, 21);
            lbLivres.TabIndex = 46;
            lbLivres.Text = "Livre";
            // 
            // lbQuantite
            // 
            lbQuantite.AutoSize = true;
            lbQuantite.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuantite.Location = new Point(447, 171);
            lbQuantite.Name = "lbQuantite";
            lbQuantite.Size = new Size(106, 21);
            lbQuantite.TabIndex = 47;
            lbQuantite.Text = "Quantité";
            // 
            // comboBoxLivre
            // 
            comboBoxLivre.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLivre.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxLivre.FormattingEnabled = true;
            comboBoxLivre.Items.AddRange(new object[] { "En attente", "En cours", "Effectuée", "Payée", "Réceptionnée", "Clôturée" });
            comboBoxLivre.Location = new Point(50, 216);
            comboBoxLivre.Name = "comboBoxLivre";
            comboBoxLivre.Size = new Size(363, 28);
            comboBoxLivre.TabIndex = 5;
            // 
            // numUpDown
            // 
            numUpDown.Location = new Point(477, 216);
            numUpDown.Name = "numUpDown";
            numUpDown.Size = new Size(62, 27);
            numUpDown.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 264);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(822, 136);
            dataGridView1.TabIndex = 50;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FloralWhite;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAjouter.ForeColor = Color.SaddleBrown;
            btnAjouter.Location = new Point(621, 203);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(143, 40);
            btnAjouter.TabIndex = 7;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // CRCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 488);
            Controls.Add(btnAjouter);
            Controls.Add(dataGridView1);
            Controls.Add(numUpDown);
            Controls.Add(comboBoxLivre);
            Controls.Add(lbQuantite);
            Controls.Add(lbLivres);
            Controls.Add(comboBoxStatut);
            Controls.Add(dateTimePicker1);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbStatut);
            Controls.Add(lbDate);
            Controls.Add(comboBoxEditeur);
            Controls.Add(lbEditeur);
            Controls.Add(lbNumero);
            Controls.Add(txtNumero);
            Name = "CRCommande";
            Text = "CRCommande";
            ((System.ComponentModel.ISupportInitialize)numUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btModifier;
        private Button btCreer;
        private Label lbStatut;
        private Label lbDate;
        private ComboBox comboBoxEditeur;
        private Label lbEditeur;
        private Label lbNumero;
        private TextBox txtNumero;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxStatut;
        private Label lbLivres;
        private Label lbQuantite;
        private ComboBox comboBoxLivre;
        private NumericUpDown numUpDown;
        private DataGridView dataGridView1;
        private Button btnAjouter;
    }
}