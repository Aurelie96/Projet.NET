namespace Projet.NET.View
{
    partial class RepondreQuestionTuteur
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RepondreQuestionTuteur));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Dgv_Repondre = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.LblIdMessage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtQuestion = new System.Windows.Forms.TextBox();
            this.BtnEnvoyer = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtReponse = new System.Windows.Forms.TextBox();
            this.Dgv_Repondre_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dgv_RepondreReponse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Repondre)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_Repondre
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.Dgv_Repondre, "Dgv_Repondre");
            this.Dgv_Repondre.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Repondre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Dgv_Repondre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_Repondre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dgv_Repondre_id,
            this.Dgv_RepondreReponse});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_Repondre.DefaultCellStyle = dataGridViewCellStyle5;
            this.Dgv_Repondre.Name = "Dgv_Repondre";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_Repondre.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.Dgv_Repondre.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre.RowTemplate.Height = 24;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // LblIdMessage
            // 
            resources.ApplyResources(this.LblIdMessage, "LblIdMessage");
            this.LblIdMessage.Name = "LblIdMessage";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // TxtQuestion
            // 
            resources.ApplyResources(this.TxtQuestion, "TxtQuestion");
            this.TxtQuestion.Name = "TxtQuestion";
            // 
            // BtnEnvoyer
            // 
            resources.ApplyResources(this.BtnEnvoyer, "BtnEnvoyer");
            this.BtnEnvoyer.Name = "BtnEnvoyer";
            this.BtnEnvoyer.UseVisualStyleBackColor = true;
            this.BtnEnvoyer.Click += new System.EventHandler(this.BtnEnvoyer_Click);
            // 
            // BtnAnnuler
            // 
            resources.ApplyResources(this.BtnAnnuler, "BtnAnnuler");
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.UseVisualStyleBackColor = true;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // TxtReponse
            // 
            resources.ApplyResources(this.TxtReponse, "TxtReponse");
            this.TxtReponse.Name = "TxtReponse";
            // 
            // Dgv_Repondre_id
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dgv_Repondre_id.DefaultCellStyle = dataGridViewCellStyle3;
            resources.ApplyResources(this.Dgv_Repondre_id, "Dgv_Repondre_id");
            this.Dgv_Repondre_id.Name = "Dgv_Repondre_id";
            // 
            // Dgv_RepondreReponse
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Dgv_RepondreReponse.DefaultCellStyle = dataGridViewCellStyle4;
            resources.ApplyResources(this.Dgv_RepondreReponse, "Dgv_RepondreReponse");
            this.Dgv_RepondreReponse.Name = "Dgv_RepondreReponse";
            // 
            // RepondreQuestionTuteur
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.Dgv_Repondre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblIdMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtQuestion);
            this.Controls.Add(this.BtnEnvoyer);
            this.Controls.Add(this.BtnAnnuler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtReponse);
            this.Name = "RepondreQuestionTuteur";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_Repondre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_Repondre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblIdMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtQuestion;
        private System.Windows.Forms.Button BtnEnvoyer;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReponse;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_Repondre_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dgv_RepondreReponse;
    }
}