namespace Projet.NET.View
{
    partial class VoirReponse
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
            this.Dgv_Repondre = new System.Windows.Forms.DataGridView();
            this.Dgv_Repondre_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_RepondreReponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LblIdMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Repondre)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Repondre
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Repondre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Repondre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Repondre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Repondre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_Repondre_id,
            this.Dgv_RepondreReponse});
            this.Dgv_Repondre.Location = new System.Drawing.Point(18, 317);
            this.Dgv_Repondre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_Repondre.Name = "Dgv_Repondre";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Repondre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.RowTemplate.Height = 24;
            this.Dgv_Repondre.Size = new System.Drawing.Size(1276, 428);
            this.Dgv_Repondre.TabIndex = 9;
            // 
            // Dgv_Repondre_id
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Repondre_id.HeaderText = "id";
            this.Dgv_Repondre_id.Name = "Dgv_Repondre_id";
            this.Dgv_Repondre_id.Visible = false;
            // 
            // Dgv_RepondreReponse
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RepondreReponse.DefaultCellStyle = dataGridViewCellStyle3;
            this.Dgv_RepondreReponse.HeaderText = "Réponse sur la question";
            this.Dgv_RepondreReponse.Name = "Dgv_RepondreReponse";
            this.Dgv_RepondreReponse.Width = 1350;
            // 
            // LblIdMessage
            // 
            this.LblIdMessage.AutoSize = true;
            this.LblIdMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblIdMessage.Location = new System.Drawing.Point(681, 33);
            this.LblIdMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdMessage.Name = "LblIdMessage";
            this.LblIdMessage.Size = new System.Drawing.Size(0, 25);
            this.LblIdMessage.TabIndex = 17;
            this.LblIdMessage.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "La question";
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuestion.Location = new System.Drawing.Point(18, 66);
            this.TxtQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtQuestion.Multiline = true;
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(1274, 190);
            this.TxtQuestion.TabIndex = 15;
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Location = new System.Drawing.Point(0, 755);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(1312, 61);
            this.BtnAnnuler.TabIndex = 13;
            this.BtnAnnuler.Text = "Retour";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 262);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 32);
            this.label2.TabIndex = 12;
            this.label2.Text = "Toute les réponses à la question";
            // 
            // VoirReponse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1312, 816);
            this.Controls.Add(this.Dgv_Repondre);
            this.Controls.Add(this.LblIdMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtQuestion);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "VoirReponse";
            this.Text = "VoirReponse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Repondre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Repondre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Repondre_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_RepondreReponse;
        private System.Windows.Forms.Label LblIdMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label label2;
    }
}