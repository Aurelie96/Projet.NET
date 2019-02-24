using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Projet.NET.Controleur;
using Projet.NET.View;
using Projet.NET.Model;
using System.Net.Mail;

namespace Projet.NET
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }
        /*BtnConnexion_Click_1
         Permet de ce connecter et d'ouvrir la view Accueil*/
        private void BtnConnexion_Click_1(object sender, EventArgs e)
        {
            bool test = false;
            test = UsersViewModel.Connexion(txtLogin.Text, txtMotDePasse.Text);
            Users user = new Users(txtLogin.Text, txtMotDePasse.Text);
            if (test == true)
            {
                //ActiveForm.Visible = false;
                Accueil accueil = new Accueil(user);
                accueil.Hide();
                accueil.Show();
            }
            else
            {
                MessageBox.Show("Votre mot de passe ou login est incorrect");
            }
        }
        /*BtnAnnule_Click_1
         Permet de fermer l'application*/
        private void BtnAnnule_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /*LinkInscription_LinkClicked_1
         Permet d'aler sur la view Inscription*/
        private void LinkInscription_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Inscription inscrire = new Inscription();
            inscrire.Hide();
            inscrire.Show();
        }
        /*LinkMdpOublie_LinkClicked
         Permet d'envoyer un mail pour donner son mot de passe*/
        private void LinkMdpOublie_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string user = UsersViewModel.RecuperationMail(txtLogin.Text);
            string motdepass = UsersViewModel.RecuperationMdp(txtLogin.Text);
            MailMessage email = new MailMessage();
            email.From = new System.Net.Mail.MailAddress("soutienscolaireril2017@gmail.com");
            email.To.Add(new MailAddress(user));
            email.IsBodyHtml = true;
            email.Subject = "soutien_2018";
            email.Body = " Ce message vous est envoyé car vous avez perdu ou oublié votre mot de passe. Si ne n'est pas le cas, veuillez ne pas tenir compte de ce message. <br /> <b>Votre mot de passe: " + motdepass + "</b>";
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Credentials = new System.Net.NetworkCredential("soutienscolaireril2017", "soutien_2018");
            smtp.EnableSsl = true;
            try
            {
                smtp.Send(email);
                MessageBox.Show("email est envoyé");
            }
            catch (SmtpException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
