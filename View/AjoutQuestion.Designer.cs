﻿namespace Projet.NET.View
{
    partial class AjoutQuestion
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
            this.TxtObjet = new System.Windows.Forms.TextBox();
            this.BtnAjouter = new System.Windows.Forms.Button();
            this.BtnAnnuler = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Login = new System.Windows.Forms.Label();
            this.LblMatiere = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblNiveau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtObjet
            // 
            this.TxtObjet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtObjet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObjet.Location = new System.Drawing.Point(178, 98);
            this.TxtObjet.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtObjet.Multiline = true;
            this.TxtObjet.Name = "TxtObjet";
            this.TxtObjet.Size = new System.Drawing.Size(1616, 48);
            this.TxtObjet.TabIndex = 1;
            // 
            // BtnAjouter
            // 
            this.BtnAjouter.AutoSize = true;
            this.BtnAjouter.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAjouter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAjouter.Location = new System.Drawing.Point(0, 888);
            this.BtnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAjouter.Name = "BtnAjouter";
            this.BtnAjouter.Size = new System.Drawing.Size(1797, 84);
            this.BtnAjouter.TabIndex = 2;
            this.BtnAjouter.Text = "Envoyer";
            this.BtnAjouter.UseVisualStyleBackColor = false;
            this.BtnAjouter.Click += new System.EventHandler(this.BtnAjouter_Click);
            // 
            // BtnAnnuler
            // 
            this.BtnAnnuler.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BtnAnnuler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnuler.Location = new System.Drawing.Point(0, 972);
            this.BtnAnnuler.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAnnuler.Name = "BtnAnnuler";
            this.BtnAnnuler.Size = new System.Drawing.Size(1797, 83);
            this.BtnAnnuler.TabIndex = 3;
            this.BtnAnnuler.Text = "Annuler";
            this.BtnAnnuler.UseVisualStyleBackColor = false;
            this.BtnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuestion.Location = new System.Drawing.Point(181, 209);
            this.txtQuestion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuestion.Multiline = true;
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(1603, 669);
            this.txtQuestion.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Posez votre question";
            // 
            // Lbl_Login
            // 
            this.Lbl_Login.AutoSize = true;
            this.Lbl_Login.Location = new System.Drawing.Point(596, 14);
            this.Lbl_Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_Login.Name = "Lbl_Login";
            this.Lbl_Login.Size = new System.Drawing.Size(0, 25);
            this.Lbl_Login.TabIndex = 6;
            this.Lbl_Login.Visible = false;
            // 
            // LblMatiere
            // 
            this.LblMatiere.AutoSize = true;
            this.LblMatiere.Location = new System.Drawing.Point(796, 12);
            this.LblMatiere.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblMatiere.Name = "LblMatiere";
            this.LblMatiere.Size = new System.Drawing.Size(0, 25);
            this.LblMatiere.TabIndex = 7;
            this.LblMatiere.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 32);
            this.label2.TabIndex = 8;
            this.label2.Text = "Objet :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Question :";
            // 
            // LblNiveau
            // 
            this.LblNiveau.AutoSize = true;
            this.LblNiveau.Location = new System.Drawing.Point(932, 38);
            this.LblNiveau.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LblNiveau.Name = "LblNiveau";
            this.LblNiveau.Size = new System.Drawing.Size(0, 25);
            this.LblNiveau.TabIndex = 10;
            this.LblNiveau.Visible = false;
            // 
            // AjoutQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1797, 1055);
            this.Controls.Add(this.LblNiveau);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtObjet);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.LblMatiere);
            this.Controls.Add(this.Lbl_Login);
            this.Controls.Add(this.BtnAjouter);
            this.Controls.Add(this.BtnAnnuler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AjoutQuestion";
            this.Text = "AjoutQuestion";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtObjet;
        private System.Windows.Forms.Button BtnAjouter;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Login;
        private System.Windows.Forms.Label LblMatiere;
        private System.Windows.Forms.Button BtnAnnuler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblNiveau;
    }
}