namespace Projet.NET.View
{
    partial class RepondreQuestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.BtnEnvoyer = new System.Windows.Forms.Button();
            this.TxtReponse = new System.Windows.Forms.TextBox();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LblIdMessage = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Repondre)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Repondre
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_Repondre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dgv_Repondre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dgv_Repondre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Repondre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_Repondre_id,
            this.Dgv_RepondreReponse});
            this.Dgv_Repondre.Location = new System.Drawing.Point(0, 217);
            this.Dgv_Repondre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dgv_Repondre.Name = "Dgv_Repondre";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Dgv_Repondre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.RowTemplate.Height = 24;
            this.Dgv_Repondre.Size = new System.Drawing.Size(846, 230);
            this.Dgv_Repondre.TabIndex = 0;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 452);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mettez votre réponse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(457, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Toute les réponses à la question";
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAnnuler.Location = new System.Drawing.Point(0, 655);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(846, 34);
            this.BtnAnnuler.TabIndex = 4;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // BtnEnvoyer
            // 
            this.BtnEnvoyer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnEnvoyer.Location = new System.Drawing.Point(0, 619);
            this.BtnEnvoyer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEnvoyer.Name = "BtnEnvoyer";
            this.BtnEnvoyer.Size = new System.Drawing.Size(846, 36);
            this.BtnEnvoyer.TabIndex = 5;
            this.BtnEnvoyer.Text = "Envoyer";
            this.BtnEnvoyer.UseVisualStyleBackColor = true;
            this.BtnEnvoyer.Click += new System.EventHandler(this.BtnEnvoyer_Click);
            // 
            // TxtReponse
            // 
            this.TxtReponse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtReponse.Location = new System.Drawing.Point(0, 489);
            this.TxtReponse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtReponse.Multiline = true;
            this.TxtReponse.Name = "TxtReponse";
            this.TxtReponse.Size = new System.Drawing.Size(844, 120);
            this.TxtReponse.TabIndex = 1;
            // 
            // TxtQuestion
            // 
            this.TxtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuestion.Location = new System.Drawing.Point(13, 51);
            this.TxtQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtQuestion.Multiline = true;
            this.TxtQuestion.Name = "TxtQuestion";
            this.TxtQuestion.Size = new System.Drawing.Size(820, 124);
            this.TxtQuestion.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "La question";
            // 
            // LblIdMessage
            // 
            this.LblIdMessage.AutoSize = true;
            this.LblIdMessage.Location = new System.Drawing.Point(663, 36);
            this.LblIdMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblIdMessage.Name = "LblIdMessage";
            this.LblIdMessage.Size = new System.Drawing.Size(0, 25);
            this.LblIdMessage.TabIndex = 8;
            this.LblIdMessage.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(834, 625);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 9;
            this.label4.Visible = false;
            // 
            // RepondreQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(846, 689);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblIdMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtQuestion);
            this.Controls.Add(this.BtnEnvoyer);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtReponse);
            this.Controls.Add(this.Dgv_Repondre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RepondreQuestion";
            this.Text = "RepondreQuestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Repondre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Repondre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Button BtnEnvoyer;
        private System.Windows.Forms.TextBox TxtReponse;
        private System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Repondre_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_RepondreReponse;
        private System.Windows.Forms.Label LblIdMessage;
        private System.Windows.Forms.Label label4;
    }
}