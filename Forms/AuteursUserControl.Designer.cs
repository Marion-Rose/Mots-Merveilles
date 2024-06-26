﻿namespace Mots_Merveilles.Forms
{
    partial class AuteursUserControl
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
            txtNomAuteur = new TextBox();
            lbNomAuteur = new Label();
            lbPrenomAuteur = new Label();
            txtPrenomAuteur = new TextBox();
            btSupprimer = new Button();
            btModifier = new Button();
            btCreer = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // txtNomAuteur
            // 
            txtNomAuteur.BackColor = Color.White;
            txtNomAuteur.BorderStyle = BorderStyle.FixedSingle;
            txtNomAuteur.Location = new Point(383, 29);
            txtNomAuteur.Margin = new Padding(2, 3, 2, 3);
            txtNomAuteur.Name = "txtNomAuteur";
            txtNomAuteur.Size = new Size(186, 27);
            txtNomAuteur.TabIndex = 1;
            txtNomAuteur.TextChanged += txtBox_TextChanged;
            // 
            // lbNomAuteur
            // 
            lbNomAuteur.AutoSize = true;
            lbNomAuteur.Location = new Point(297, 31);
            lbNomAuteur.Margin = new Padding(2, 0, 2, 0);
            lbNomAuteur.Name = "lbNomAuteur";
            lbNomAuteur.Size = new Size(42, 20);
            lbNomAuteur.TabIndex = 8;
            lbNomAuteur.Text = "Nom";
            // 
            // lbPrenomAuteur
            // 
            lbPrenomAuteur.AutoSize = true;
            lbPrenomAuteur.Location = new Point(646, 31);
            lbPrenomAuteur.Margin = new Padding(2, 0, 2, 0);
            lbPrenomAuteur.Name = "lbPrenomAuteur";
            lbPrenomAuteur.Size = new Size(60, 20);
            lbPrenomAuteur.TabIndex = 10;
            lbPrenomAuteur.Text = "Prénom";
            // 
            // txtPrenomAuteur
            // 
            txtPrenomAuteur.BackColor = Color.White;
            txtPrenomAuteur.BorderStyle = BorderStyle.FixedSingle;
            txtPrenomAuteur.Location = new Point(757, 29);
            txtPrenomAuteur.Margin = new Padding(2, 3, 2, 3);
            txtPrenomAuteur.Name = "txtPrenomAuteur";
            txtPrenomAuteur.Size = new Size(181, 27);
            txtPrenomAuteur.TabIndex = 2;
            txtPrenomAuteur.TextChanged += txtBox_TextChanged;
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(708, 108);
            btSupprimer.Margin = new Padding(2, 3, 2, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(155, 32);
            btSupprimer.TabIndex = 5;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(534, 108);
            btModifier.Margin = new Padding(2, 3, 2, 3);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(155, 32);
            btModifier.TabIndex = 4;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(349, 108);
            btCreer.Margin = new Padding(2, 3, 2, 3);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(155, 32);
            btCreer.TabIndex = 3;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
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
            dataGridView1.Location = new Point(50, 185);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1098, 357);
            dataGridView1.TabIndex = 23;
            // 
            // AuteursUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(dataGridView1);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbPrenomAuteur);
            Controls.Add(txtPrenomAuteur);
            Controls.Add(lbNomAuteur);
            Controls.Add(txtNomAuteur);
            Margin = new Padding(2, 3, 2, 3);
            Name = "AuteursUserControl";
            Size = new Size(1204, 558);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomAuteur;
        private Label lbNomAuteur;
        private Label lbPrenomAuteur;
        private TextBox txtPrenomAuteur;
        private Button btSupprimer;
        private Button btModifier;
        private Button btCreer;
        private DataGridView dataGridView1;
    }
}