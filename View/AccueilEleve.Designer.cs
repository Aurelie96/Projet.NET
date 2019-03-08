namespace Projet.NET.View
{
    partial class AccueilEleve
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_Groupe = new System.Windows.Forms.DataGridView();
            this.dgv_GroupeNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_login = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Groupe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 38);
            this.label1.TabIndex = 2;
            // 
            // Dgv_Groupe
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Groupe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_Groupe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Groupe.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Groupe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Groupe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_GroupeNom});
            this.Dgv_Groupe.Location = new System.Drawing.Point(18, 81);
            this.Dgv_Groupe.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_Groupe.Name = "Dgv_Groupe";
            this.Dgv_Groupe.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Groupe.RowTemplate.Height = 24;
            this.Dgv_Groupe.Size = new System.Drawing.Size(1330, 689);
            this.Dgv_Groupe.TabIndex = 4;
            this.Dgv_Groupe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_Groupe_CellContentClick);
            // 
            // dgv_GroupeNom
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_GroupeNom.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_GroupeNom.HeaderText = "Nom des groupes du forum";
            this.dgv_GroupeNom.Name = "dgv_GroupeNom";
            this.dgv_GroupeNom.ReadOnly = true;
            this.dgv_GroupeNom.Width = 1450;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(172, 9);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(0, 38);
            this.lbl_login.TabIndex = 5;
            this.lbl_login.Visible = false;
            // 
            // AccueilEleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1366, 789);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.Dgv_Groupe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccueilEleve";
            this.Text = "AccueilEleve";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Groupe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_Groupe;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_GroupeNom;
        private System.Windows.Forms.Label lbl_login;
    }
}