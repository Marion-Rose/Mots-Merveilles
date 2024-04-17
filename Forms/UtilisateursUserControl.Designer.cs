namespace Mots_Merveilles.Forms
{
    partial class UtilisateursUserControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lbMDP = new Label();
            txtMDP = new TextBox();
            lbIdentifiant = new Label();
            txtIdentifiant = new TextBox();
            comboBoxGroupe = new ComboBox();
            lbGroupe = new Label();
            lbPrenom = new Label();
            txtPrenom = new TextBox();
            btSupprimer = new Button();
            btModifier = new Button();
            btCreer = new Button();
            lbNom = new Label();
            txtNom = new TextBox();
            checkBoxActif = new CheckBox();
            comboBoxSalarie = new ComboBox();
            lbSalarie = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbMDP
            // 
            lbMDP.AutoSize = true;
            lbMDP.Location = new Point(740, 94);
            lbMDP.Margin = new Padding(2, 0, 2, 0);
            lbMDP.Name = "lbMDP";
            lbMDP.Size = new Size(98, 20);
            lbMDP.TabIndex = 80;
            lbMDP.Text = "Mot de passe";
            // 
            // txtMDP
            // 
            txtMDP.BackColor = Color.White;
            txtMDP.BorderStyle = BorderStyle.FixedSingle;
            txtMDP.Location = new Point(890, 89);
            txtMDP.Margin = new Padding(2, 3, 2, 3);
            txtMDP.Name = "txtMDP";
            txtMDP.PasswordChar = '*';
            txtMDP.Size = new Size(187, 27);
            txtMDP.TabIndex = 6;
            // 
            // lbIdentifiant
            // 
            lbIdentifiant.AutoSize = true;
            lbIdentifiant.Location = new Point(372, 92);
            lbIdentifiant.Margin = new Padding(2, 0, 2, 0);
            lbIdentifiant.Name = "lbIdentifiant";
            lbIdentifiant.Size = new Size(77, 20);
            lbIdentifiant.TabIndex = 78;
            lbIdentifiant.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            txtIdentifiant.BackColor = Color.White;
            txtIdentifiant.BorderStyle = BorderStyle.FixedSingle;
            txtIdentifiant.Location = new Point(503, 90);
            txtIdentifiant.Margin = new Padding(2, 3, 2, 3);
            txtIdentifiant.Name = "txtIdentifiant";
            txtIdentifiant.Size = new Size(188, 27);
            txtIdentifiant.TabIndex = 5;
            // 
            // comboBoxGroupe
            // 
            comboBoxGroupe.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxGroupe.FormattingEnabled = true;
            comboBoxGroupe.Location = new Point(132, 96);
            comboBoxGroupe.Margin = new Padding(2, 3, 2, 3);
            comboBoxGroupe.Name = "comboBoxGroupe";
            comboBoxGroupe.Size = new Size(188, 28);
            comboBoxGroupe.TabIndex = 4;
            // 
            // lbGroupe
            // 
            lbGroupe.AutoSize = true;
            lbGroupe.Location = new Point(17, 98);
            lbGroupe.Margin = new Padding(2, 0, 2, 0);
            lbGroupe.Name = "lbGroupe";
            lbGroupe.Size = new Size(58, 20);
            lbGroupe.TabIndex = 75;
            lbGroupe.Text = "Groupe";
            // 
            // lbPrenom
            // 
            lbPrenom.AutoSize = true;
            lbPrenom.Location = new Point(839, 32);
            lbPrenom.Margin = new Padding(2, 0, 2, 0);
            lbPrenom.Name = "lbPrenom";
            lbPrenom.Size = new Size(60, 20);
            lbPrenom.TabIndex = 68;
            lbPrenom.Text = "Prénom";
            // 
            // txtPrenom
            // 
            txtPrenom.BackColor = Color.White;
            txtPrenom.BorderStyle = BorderStyle.FixedSingle;
            txtPrenom.Location = new Point(955, 30);
            txtPrenom.Margin = new Padding(2, 3, 2, 3);
            txtPrenom.Name = "txtPrenom";
            txtPrenom.Size = new Size(188, 27);
            txtPrenom.TabIndex = 3;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(721, 155);
            btSupprimer.Margin = new Padding(2, 3, 2, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(155, 32);
            btSupprimer.TabIndex = 10;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(536, 155);
            btModifier.Margin = new Padding(2, 3, 2, 3);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(155, 32);
            btModifier.TabIndex = 9;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(351, 155);
            btCreer.Margin = new Padding(2, 3, 2, 3);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(155, 32);
            btCreer.TabIndex = 8;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // lbNom
            // 
            lbNom.AutoSize = true;
            lbNom.Location = new Point(433, 32);
            lbNom.Margin = new Padding(2, 0, 2, 0);
            lbNom.Name = "lbNom";
            lbNom.Size = new Size(42, 20);
            lbNom.TabIndex = 57;
            lbNom.Text = "Nom";
            // 
            // txtNom
            // 
            txtNom.BackColor = Color.White;
            txtNom.BorderStyle = BorderStyle.FixedSingle;
            txtNom.CharacterCasing = CharacterCasing.Upper;
            txtNom.Location = new Point(532, 30);
            txtNom.Margin = new Padding(2, 3, 2, 3);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(188, 27);
            txtNom.TabIndex = 2;
            // 
            // checkBoxActif
            // 
            checkBoxActif.AutoSize = true;
            checkBoxActif.Font = new Font("Copperplate Gothic Light", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBoxActif.Location = new Point(1107, 92);
            checkBoxActif.Name = "checkBoxActif";
            checkBoxActif.Size = new Size(83, 24);
            checkBoxActif.TabIndex = 7;
            checkBoxActif.Text = "Actif";
            checkBoxActif.UseVisualStyleBackColor = true;
            // 
            // comboBoxSalarie
            // 
            comboBoxSalarie.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSalarie.FormattingEnabled = true;
            comboBoxSalarie.Location = new Point(155, 29);
            comboBoxSalarie.Margin = new Padding(2, 3, 2, 3);
            comboBoxSalarie.Name = "comboBoxSalarie";
            comboBoxSalarie.Size = new Size(188, 28);
            comboBoxSalarie.TabIndex = 1;
            comboBoxSalarie.SelectedIndexChanged += comboBoxSalarie_SelectedIndexChanged;
            // 
            // lbSalarie
            // 
            lbSalarie.AutoSize = true;
            lbSalarie.Location = new Point(39, 32);
            lbSalarie.Margin = new Padding(2, 0, 2, 0);
            lbSalarie.Name = "lbSalarie";
            lbSalarie.Size = new Size(54, 20);
            lbSalarie.TabIndex = 86;
            lbSalarie.Text = "Salarie";
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
            dataGridView1.Location = new Point(39, 221);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1139, 321);
            dataGridView1.TabIndex = 88;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // UtilisateursUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(dataGridView1);
            Controls.Add(comboBoxSalarie);
            Controls.Add(lbSalarie);
            Controls.Add(checkBoxActif);
            Controls.Add(lbMDP);
            Controls.Add(txtMDP);
            Controls.Add(lbIdentifiant);
            Controls.Add(txtIdentifiant);
            Controls.Add(comboBoxGroupe);
            Controls.Add(lbGroupe);
            Controls.Add(lbPrenom);
            Controls.Add(txtPrenom);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbNom);
            Controls.Add(txtNom);
            Name = "UtilisateursUserControl";
            Size = new Size(1204, 558);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbMDP;
        private TextBox txtMDP;
        private Label lbIdentifiant;
        private TextBox txtIdentifiant;
        private ComboBox comboBoxGroupe;
        private Label lbGroupe;
        private Label lbPrenom;
        private TextBox txtPrenom;
        private Button btSupprimer;
        private Button btModifier;
        private Button btCreer;
        private Label lbNom;
        private TextBox txtNom;
        private CheckBox checkBoxActif;
        private ComboBox comboBoxSalarie;
        private Label lbSalarie;
        private DataGridView dataGridView1;
    }
}
