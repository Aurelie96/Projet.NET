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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connexion));
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelMotDePasse = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtMotDePasse = new System.Windows.Forms.TextBox();
            this.BtnConnexion = new System.Windows.Forms.Button();
            this.LinkInscription = new System.Windows.Forms.LinkLabel();
            this.LinkMdpOublie = new System.Windows.Forms.LinkLabel();
            this.BtnAnnule = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            resources.ApplyResources(this.labelLogin, "labelLogin");
            this.labelLogin.Name = "labelLogin";
            // 
            // labelMotDePasse
            // 
            resources.ApplyResources(this.labelMotDePasse, "labelMotDePasse");
            this.labelMotDePasse.Name = "labelMotDePasse";
            // 
            // txtLogin
            // 
            resources.ApplyResources(this.txtLogin, "txtLogin");
            this.txtLogin.Name = "txtLogin";
            // 
            // txtMotDePasse
            // 
            resources.ApplyResources(this.txtMotDePasse, "txtMotDePasse");
            this.txtMotDePasse.Name = "txtMotDePasse";
            // 
            // BtnConnexion
            // 
            this.BtnConnexion.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.BtnConnexion, "BtnConnexion");
            this.BtnConnexion.Name = "BtnConnexion";
            this.BtnConnexion.UseVisualStyleBackColor = false;
            this.BtnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click_1);
            // 
            // LinkInscription
            // 
            resources.ApplyResources(this.LinkInscription, "LinkInscription");
            this.LinkInscription.Name = "LinkInscription";
            this.LinkInscription.TabStop = true;
            this.LinkInscription.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkInscription_LinkClicked_1);
            // 
            // LinkMdpOublie
            // 
            resources.ApplyResources(this.LinkMdpOublie, "LinkMdpOublie");
            this.LinkMdpOublie.Name = "LinkMdpOublie";
            this.LinkMdpOublie.TabStop = true;
            this.LinkMdpOublie.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkMdpOublie_LinkClicked);
            // 
            // BtnAnnule
            // 
            this.BtnAnnule.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.BtnAnnule, "BtnAnnule");
            this.BtnAnnule.Name = "BtnAnnule";
            this.BtnAnnule.UseVisualStyleBackColor = false;
            this.BtnAnnule.Click += new System.EventHandler(this.BtnAnnule_Click_1);
            // 
            // Connexion
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.BtnAnnule);
            this.Controls.Add(this.LinkMdpOublie);
            this.Controls.Add(this.LinkInscription);
            this.Controls.Add(this.BtnConnexion);
            this.Controls.Add(this.txtMotDePasse);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.labelMotDePasse);
            this.Controls.Add(this.labelLogin);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Name = "Connexion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelMotDePasse;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtMotDePasse;
        private System.Windows.Forms.Button BtnConnexion;
        private System.Windows.Forms.LinkLabel LinkInscription;
        private System.Windows.Forms.LinkLabel LinkMdpOublie;
        private System.Windows.Forms.Button BtnAnnule;
    }
}

