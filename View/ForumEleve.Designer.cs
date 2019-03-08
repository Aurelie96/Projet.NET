namespace Projet.NET.View
{
    partial class ForumEleve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Forum = new System.Windows.Forms.DataGridView();
            this.dgv_Objet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Question = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.BtnRetour = new System.Windows.Forms.Button();
            this.BtnRafraichir = new System.Windows.Forms.Button();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblMatiere = new System.Windows.Forms.Label();
            this.btn_Question = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Forum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_Forum
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Forum.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Forum.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Forum.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Forum.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Objet,
            this.dgv_Question});
            this.Dgv_Forum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dgv_Forum.Location = new System.Drawing.Point(0, 0);
            this.Dgv_Forum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_Forum.Name = "Dgv_Forum";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Forum.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Forum.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Forum.RowTemplate.Height = 24;
            this.Dgv_Forum.Size = new System.Drawing.Size(1924, 765);
            this.Dgv_Forum.TabIndex = 0;
            this.Dgv_Forum.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Forum_CellContentClick);
            // 
            // dgv_Objet
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Objet.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Objet.HeaderText = "Objet de la question";
            this.dgv_Objet.Name = "dgv_Objet";
            this.dgv_Objet.ReadOnly = true;
            this.dgv_Objet.Width = 350;
            // 
            // dgv_Question
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Question.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Question.HeaderText = "Toute les questions";
            this.dgv_Question.Name = "dgv_Question";
            this.dgv_Question.Width = 1100;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.BtnRetour);
            this.splitContainer1.Panel1.Controls.Add(this.BtnRafraichir);
            this.splitContainer1.Panel1.Controls.Add(this.LblUser);
            this.splitContainer1.Panel1.Controls.Add(this.LblMatiere);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Question);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Dgv_Forum);
            this.splitContainer1.Size = new System.Drawing.Size(1924, 875);
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 2;
            // 
            // BtnRetour
            // 
            this.BtnRetour.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRetour.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetour.Location = new System.Drawing.Point(1364, 19);
            this.BtnRetour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRetour.Name = "BtnRetour";
            this.BtnRetour.Size = new System.Drawing.Size(162, 58);
            this.BtnRetour.TabIndex = 5;
            this.BtnRetour.Text = "Retour";
            this.BtnRetour.UseVisualStyleBackColor = true;
            this.BtnRetour.Click += new System.EventHandler(this.BtnRetour_Click_1);
            // 
            // BtnRafraichir
            // 
            this.BtnRafraichir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRafraichir.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRafraichir.Location = new System.Drawing.Point(1534, 19);
            this.BtnRafraichir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnRafraichir.Name = "BtnRafraichir";
            this.BtnRafraichir.Size = new System.Drawing.Size(180, 58);
            this.BtnRafraichir.TabIndex = 4;
            this.BtnRafraichir.Text = "Rafraichir";
            this.BtnRafraichir.UseVisualStyleBackColor = true;
            this.BtnRafraichir.Click += new System.EventHandler(this.BtnRafraichir_Click);
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(840, 64);
            this.LblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(0, 25);
            this.LblUser.TabIndex = 3;
            this.LblUser.Visible = false;
            // 
            // LblMatiere
            // 
            this.LblMatiere.AutoSize = true;
            this.LblMatiere.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMatiere.Location = new System.Drawing.Point(432, 28);
            this.LblMatiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMatiere.Name = "LblMatiere";
            this.LblMatiere.Size = new System.Drawing.Size(0, 38);
            this.LblMatiere.TabIndex = 2;
            this.LblMatiere.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LblMatiere.Visible = false;
            // 
            // btn_Question
            // 
            this.btn_Question.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Question.Location = new System.Drawing.Point(1722, 19);
            this.btn_Question.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Question.Name = "btn_Question";
            this.btn_Question.Size = new System.Drawing.Size(185, 58);
            this.btn_Question.TabIndex = 1;
            this.btn_Question.Text = "Question";
            this.btn_Question.UseVisualStyleBackColor = true;
            this.btn_Question.Click += new System.EventHandler(this.btn_Question_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 0;
            // 
            // ForumEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 875);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ForumEleve";
            this.Text = "ForumEleve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Forum)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Forum;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Objet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Question;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button BtnRetour;
        private System.Windows.Forms.Button BtnRafraichir;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblMatiere;
        private System.Windows.Forms.Button btn_Question;
        private System.Windows.Forms.Label label1;
    }
}