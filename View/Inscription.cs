using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet.NET.View;
using Projet.NET.Controleur;
using System.Data.SqlClient;
using Projet.NET.Model;

namespace Projet.NET.View
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void linkToConnexion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Connexion c = new Connexion();
            c.ShowDialog();
        }

        private void btnInscrire_Click(object sender, EventArgs e)
        {
            //int i = Convert.ToInt32(checkBox1.Checked);
            if (
               txtNom.Text.Trim() != ""
               && txtPrenom.Text.Trim() != ""
               && txtPseudo.Text.Trim() != ""
               && txtPwd.Text.Trim() != ""
               && txtEmail.Text.Trim() != ""
               && (checkBox1.Checked || checkBox2.Checked)
                )
            {
                Users u = new Users(txtNom.Text, txtPrenom.Text, txtPseudo.Text, txtPwd.Text, txtEmail.Text, Convert.ToInt32(checkBox1.Checked), Convert.ToInt32(checkBox2.Checked), cbxLevels.SelectedIndex + 1);
                UsersDAO.CreerUser(u);
                Accueil a = new Accueil();
                a.ShowDialog();
            }
            else
            {
                MessageBox.Show("Veuillez renseigner tous les champs", "Erreur formulaire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            List<Niveaux> lstNiveaux = NiveauxDAO.ChargerNiveaux();
            foreach (Niveaux niveau in lstNiveaux)
            {
                cbxLevels.Items.Add(niveau.nomNiveaux);
            }
        }
    }
}
