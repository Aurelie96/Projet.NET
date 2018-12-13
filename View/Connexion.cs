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

namespace Projet.NET
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnule_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            bool test = false;
            test = UsersDAO.Connexion(txtLogin.Text, txtMotDePasse.Text);
            if(test == true)
            {
                Accueil accueil = new Accueil();
                accueil.Hide();
                accueil.Show();
            }
            else
            {
                MessageBox.Show("Votre mot de passe ou login est incorrect");
            }
        }
    }
}
