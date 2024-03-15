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
            dataGridView1 = new DataGridView();
            btAjouter = new Button();
            btEnlever = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btModifier.Location = new Point(346, 371);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(181, 49);
            btModifier.TabIndex = 43;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCreer.Location = new Point(346, 371);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(181, 49);
            btCreer.TabIndex = 42;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
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
            lbStatut.Click += lbISBN_Click;
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
            comboBoxEditeur.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEditeur.FormattingEnabled = true;
            comboBoxEditeur.Location = new Point(548, 35);
            comboBoxEditeur.Name = "comboBoxEditeur";
            comboBoxEditeur.Size = new Size(271, 28);
            comboBoxEditeur.TabIndex = 31;
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
            txtNumero.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(125, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(271, 27);
            dateTimePicker1.TabIndex = 44;
            // 
            // comboBoxStatut
            // 
            comboBoxStatut.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxStatut.FormattingEnabled = true;
            comboBoxStatut.Location = new Point(548, 88);
            comboBoxStatut.Name = "comboBoxStatut";
            comboBoxStatut.Size = new Size(271, 28);
            comboBoxStatut.TabIndex = 45;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FloralWhite;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(32, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(769, 220);
            dataGridView1.TabIndex = 46;
            // 
            // btAjouter
            // 
            btAjouter.BackColor = Color.Tan;
            btAjouter.FlatStyle = FlatStyle.Flat;
            btAjouter.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btAjouter.Location = new Point(837, 163);
            btAjouter.Name = "btAjouter";
            btAjouter.Size = new Size(36, 33);
            btAjouter.TabIndex = 47;
            btAjouter.Text = "+";
            btAjouter.UseVisualStyleBackColor = false;
            // 
            // btEnlever
            // 
            btEnlever.BackColor = Color.Tan;
            btEnlever.FlatStyle = FlatStyle.Flat;
            btEnlever.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btEnlever.Location = new Point(837, 213);
            btEnlever.Name = "btEnlever";
            btEnlever.Size = new Size(36, 33);
            btEnlever.TabIndex = 48;
            btEnlever.Text = "-";
            btEnlever.UseVisualStyleBackColor = false;
            // 
            // CRCommande
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(899, 450);
            Controls.Add(btEnlever);
            Controls.Add(btAjouter);
            Controls.Add(dataGridView1);
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
        private DataGridView dataGridView1;
        private Button btAjouter;
        private Button btEnlever;
    }
}