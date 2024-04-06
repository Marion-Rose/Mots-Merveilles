namespace Mots_Merveilles.Forms
{
    partial class CRLivre
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
            lbAuteur = new Label();
            lbTitre = new Label();
            txtTitre = new TextBox();
            comboBoxAuteur = new ComboBox();
            comboBoxEditeur = new ComboBox();
            lbEditeur = new Label();
            lbISBN = new Label();
            txtIsbn = new TextBox();
            comboBoxType = new ComboBox();
            lbType = new Label();
            lbPrix = new Label();
            txtPrix = new TextBox();
            lbQuantite = new Label();
            txtQuantite = new TextBox();
            btModifier = new Button();
            btCreer = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbAuteur
            // 
            lbAuteur.AutoSize = true;
            lbAuteur.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbAuteur.Location = new Point(446, 34);
            lbAuteur.Name = "lbAuteur";
            lbAuteur.Size = new Size(87, 21);
            lbAuteur.TabIndex = 14;
            lbAuteur.Text = "Auteur";
            // 
            // lbTitre
            // 
            lbTitre.AutoSize = true;
            lbTitre.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitre.Location = new Point(46, 32);
            lbTitre.Name = "lbTitre";
            lbTitre.Size = new Size(64, 21);
            lbTitre.TabIndex = 12;
            lbTitre.Text = "Titre";
            // 
            // txtTitre
            // 
            txtTitre.BackColor = Color.White;
            txtTitre.BorderStyle = BorderStyle.FixedSingle;
            txtTitre.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtTitre.Location = new Point(124, 31);
            txtTitre.Name = "txtTitre";
            txtTitre.Size = new Size(271, 27);
            txtTitre.TabIndex = 11;
            // 
            // comboBoxAuteur
            // 
            comboBoxAuteur.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxAuteur.FormattingEnabled = true;
            comboBoxAuteur.Location = new Point(547, 32);
            comboBoxAuteur.Name = "comboBoxAuteur";
            comboBoxAuteur.Size = new Size(271, 28);
            comboBoxAuteur.TabIndex = 15;
            // 
            // comboBoxEditeur
            // 
            comboBoxEditeur.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxEditeur.FormattingEnabled = true;
            comboBoxEditeur.Location = new Point(124, 89);
            comboBoxEditeur.Name = "comboBoxEditeur";
            comboBoxEditeur.Size = new Size(271, 28);
            comboBoxEditeur.TabIndex = 17;
            // 
            // lbEditeur
            // 
            lbEditeur.AutoSize = true;
            lbEditeur.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbEditeur.Location = new Point(18, 91);
            lbEditeur.Name = "lbEditeur";
            lbEditeur.Size = new Size(92, 21);
            lbEditeur.TabIndex = 16;
            lbEditeur.Text = "Editeur";
            // 
            // lbISBN
            // 
            lbISBN.AutoSize = true;
            lbISBN.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbISBN.Location = new Point(469, 92);
            lbISBN.Name = "lbISBN";
            lbISBN.Size = new Size(64, 21);
            lbISBN.TabIndex = 19;
            lbISBN.Text = "ISBN";
            // 
            // txtIsbn
            // 
            txtIsbn.BackColor = Color.White;
            txtIsbn.BorderStyle = BorderStyle.FixedSingle;
            txtIsbn.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtIsbn.Location = new Point(547, 91);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(271, 27);
            txtIsbn.TabIndex = 18;
            // 
            // comboBoxType
            // 
            comboBoxType.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxType.FormattingEnabled = true;
            comboBoxType.Location = new Point(123, 153);
            comboBoxType.Name = "comboBoxType";
            comboBoxType.Size = new Size(271, 28);
            comboBoxType.TabIndex = 21;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbType.Location = new Point(51, 155);
            lbType.Name = "lbType";
            lbType.Size = new Size(58, 21);
            lbType.TabIndex = 20;
            lbType.Text = "Type";
            // 
            // lbPrix
            // 
            lbPrix.AutoSize = true;
            lbPrix.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrix.Location = new Point(433, 152);
            lbPrix.Name = "lbPrix";
            lbPrix.Size = new Size(53, 21);
            lbPrix.TabIndex = 23;
            lbPrix.Text = "Prix";
            // 
            // txtPrix
            // 
            txtPrix.BackColor = Color.White;
            txtPrix.BorderStyle = BorderStyle.FixedSingle;
            txtPrix.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrix.Location = new Point(492, 151);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(109, 27);
            txtPrix.TabIndex = 22;
            txtPrix.TextChanged += txtBox_TextChanged;
            // 
            // lbQuantite
            // 
            lbQuantite.AutoSize = true;
            lbQuantite.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbQuantite.Location = new Point(626, 156);
            lbQuantite.Name = "lbQuantite";
            lbQuantite.Size = new Size(106, 21);
            lbQuantite.TabIndex = 25;
            lbQuantite.Text = "Quantité";
            // 
            // txtQuantite
            // 
            txtQuantite.BackColor = Color.White;
            txtQuantite.BorderStyle = BorderStyle.FixedSingle;
            txtQuantite.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtQuantite.Location = new Point(738, 154);
            txtQuantite.Name = "txtQuantite";
            txtQuantite.Size = new Size(109, 27);
            txtQuantite.TabIndex = 24;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btModifier.Location = new Point(344, 209);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(181, 49);
            btModifier.TabIndex = 27;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Font = new Font("Copperplate Gothic Light", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btCreer.Location = new Point(344, 209);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(181, 49);
            btCreer.TabIndex = 26;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Copperplate Gothic Light", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(547, 121);
            label1.Name = "label1";
            label1.Size = new Size(162, 14);
            label1.TabIndex = 28;
            label1.Text = "*13 chiffres attendus";
            // 
            // CRLivre
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(870, 291);
            Controls.Add(label1);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbQuantite);
            Controls.Add(txtQuantite);
            Controls.Add(lbPrix);
            Controls.Add(txtPrix);
            Controls.Add(comboBoxType);
            Controls.Add(lbType);
            Controls.Add(lbISBN);
            Controls.Add(txtIsbn);
            Controls.Add(comboBoxEditeur);
            Controls.Add(lbEditeur);
            Controls.Add(comboBoxAuteur);
            Controls.Add(lbAuteur);
            Controls.Add(lbTitre);
            Controls.Add(txtTitre);
            Name = "CRLivre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mots & Merveilles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbAuteur;
        private Label lbTitre;
        private TextBox txtTitre;
        private ComboBox comboBoxAuteur;
        private ComboBox comboBoxEditeur;
        private Label lbEditeur;
        private Label lbISBN;
        private TextBox txtIsbn;
        private ComboBox comboBoxType;
        private Label lbType;
        private Label lbPrix;
        private TextBox txtPrix;
        private Label lbQuantite;
        private TextBox txtQuantite;
        private Button btModifier;
        private Button btCreer;
        private Label label1;
    }
}