namespace Projet.NET
{
    partial class Connexion
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.retenirMdp = new System.Windows.Forms.CheckBox();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.linkInscription = new System.Windows.Forms.LinkLabel();
            this.linkMdpOublie = new System.Windows.Forms.LinkLabel();
            this.btnAnnule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.Location = new System.Drawing.Point(38, 41);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(86, 32);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Login";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelMotDePasse
            // 
            this.labelMotDePasse.AutoSize = true;
            this.labelMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMotDePasse.Location = new System.Drawing.Point(38, 107);
            this.labelMotDePasse.Name = "labelMotDePasse";
            this.labelMotDePasse.Size = new System.Drawing.Size(184, 32);
            this.labelMotDePasse.TabIndex = 1;
            this.labelMotDePasse.Text = "Mot de passe";
            this.labelMotDePasse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(233, 41);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(230, 22);
            this.txtLogin.TabIndex = 2;
            // 
            // txtMotDePasse
            // 
            this.txtMotDePasse.Location = new System.Drawing.Point(234, 117);
            this.txtMotDePasse.Name = "txtMotDePasse";
            this.txtMotDePasse.Size = new System.Drawing.Size(229, 22);
            this.txtMotDePasse.TabIndex = 3;
            // 
            // retenirMdp
            // 
            this.retenirMdp.AutoSize = true;
            this.retenirMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retenirMdp.Location = new System.Drawing.Point(44, 206);
            this.retenirMdp.Name = "retenirMdp";
            this.retenirMdp.Size = new System.Drawing.Size(367, 36);
            this.retenirMdp.TabIndex = 4;
            this.retenirMdp.Text = "Retenir mon mot de passe";
            this.retenirMdp.UseVisualStyleBackColor = true;
            // 
            // btnConnexion
            // 
            this.btnConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnexion.Location = new System.Drawing.Point(50, 293);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(172, 57);
            this.btnConnexion.TabIndex = 5;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // linkInscription
            // 
            this.linkInscription.AutoSize = true;
            this.linkInscription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkInscription.Location = new System.Drawing.Point(39, 369);
            this.linkInscription.Name = "linkInscription";
            this.linkInscription.Size = new System.Drawing.Size(123, 29);
            this.linkInscription.TabIndex = 6;
            this.linkInscription.TabStop = true;
            this.linkInscription.Text = "Inscription";
            this.linkInscription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkInscription_LinkClicked);
            // 
            // linkMdpOublie
            // 
            this.linkMdpOublie.AutoSize = true;
            this.linkMdpOublie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkMdpOublie.Location = new System.Drawing.Point(39, 434);
            this.linkMdpOublie.Name = "linkMdpOublie";
            this.linkMdpOublie.Size = new System.Drawing.Size(231, 29);
            this.linkMdpOublie.TabIndex = 7;
            this.linkMdpOublie.TabStop = true;
            this.linkMdpOublie.Text = "Mot de passe oublié";
            // 
            // btnAnnule
            // 
            this.btnAnnule.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnule.Location = new System.Drawing.Point(335, 293);
            this.btnAnnule.Name = "btnAnnule";
            this.btnAnnule.Size = new System.Drawing.Size(174, 57);
            this.btnAnnule.TabIndex = 8;
            this.btnAnnule.Text = "Annuler";
            this.btnAnnule.UseVisualStyleBackColor = true;
            this.btnAnnule.Click += new System.EventHandler(this.btnAnnule_Click);
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 507);
            this.Controls.Add(this.btnAnnule);
            this.Controls.Add(this.linkMdpOublie);
            this.Controls.Add(this.linkInscription);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.retenirMdp);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.labelLogin);
            this.Name = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.CheckBox retenirMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.LinkLabel linkInscription;
        private System.Windows.Forms.LinkLabel linkMdpOublie;
        private System.Windows.Forms.Button btnAnnule;
    }
}

