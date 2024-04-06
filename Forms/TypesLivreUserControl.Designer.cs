namespace Mots_Merveilles.Forms
{
    partial class TypesLivreUserControl
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
            btSupprimer = new Button();
            btModifier = new Button();
            btCreer = new Button();
            lbType = new Label();
            txtType = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btSupprimer
            // 
            btSupprimer.BackColor = Color.FromArgb(107, 59, 59);
            btSupprimer.FlatStyle = FlatStyle.Flat;
            btSupprimer.ForeColor = Color.FloralWhite;
            btSupprimer.Location = new Point(700, 102);
            btSupprimer.Margin = new Padding(2, 3, 2, 3);
            btSupprimer.Name = "btSupprimer";
            btSupprimer.Size = new Size(155, 32);
            btSupprimer.TabIndex = 21;
            btSupprimer.Text = "Supprimer";
            btSupprimer.UseVisualStyleBackColor = false;
            btSupprimer.Click += btSupprimer_Click;
            // 
            // btModifier
            // 
            btModifier.BackColor = Color.Tan;
            btModifier.FlatStyle = FlatStyle.Flat;
            btModifier.Location = new Point(526, 102);
            btModifier.Margin = new Padding(2, 3, 2, 3);
            btModifier.Name = "btModifier";
            btModifier.Size = new Size(155, 32);
            btModifier.TabIndex = 20;
            btModifier.Text = "Modifier";
            btModifier.UseVisualStyleBackColor = false;
            btModifier.Click += btModifier_Click;
            // 
            // btCreer
            // 
            btCreer.BackColor = Color.Tan;
            btCreer.FlatStyle = FlatStyle.Flat;
            btCreer.Location = new Point(341, 102);
            btCreer.Margin = new Padding(2, 3, 2, 3);
            btCreer.Name = "btCreer";
            btCreer.Size = new Size(155, 32);
            btCreer.TabIndex = 19;
            btCreer.Text = "Créer";
            btCreer.UseVisualStyleBackColor = false;
            btCreer.Click += btCreer_Click;
            // 
            // lbType
            // 
            lbType.AutoSize = true;
            lbType.Location = new Point(451, 37);
            lbType.Margin = new Padding(2, 0, 2, 0);
            lbType.Name = "lbType";
            lbType.Size = new Size(40, 20);
            lbType.TabIndex = 16;
            lbType.Text = "Type";
            // 
            // txtType
            // 
            txtType.BackColor = Color.White;
            txtType.BorderStyle = BorderStyle.FixedSingle;
            txtType.Location = new Point(525, 35);
            txtType.Margin = new Padding(2, 3, 2, 3);
            txtType.Name = "txtType";
            txtType.Size = new Size(156, 27);
            txtType.TabIndex = 15;
            txtType.TextChanged += txtBox_TextChanged;
            // 
            // dataGridView1
            // 
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
            dataGridView1.Location = new Point(50, 169);
            dataGridView1.Margin = new Padding(2, 3, 2, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1098, 322);
            dataGridView1.TabIndex = 24;
            // 
            // TypesLivreUserControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(dataGridView1);
            Controls.Add(btSupprimer);
            Controls.Add(btModifier);
            Controls.Add(btCreer);
            Controls.Add(lbType);
            Controls.Add(txtType);
            Margin = new Padding(2, 3, 2, 3);
            Name = "TypesLivreUserControl";
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
        private Label lbType;
        private TextBox txtType;
    }
}