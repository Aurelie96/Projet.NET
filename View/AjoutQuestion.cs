﻿using Projet.NET.Controleur;
using Projet.NET.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet.NET.View
{
    public partial class AjoutQuestion : Form
    {
        public AjoutQuestion(String users, String Matiere)
        {
            InitializeComponent();
            LblMatiere.Text = Matiere;
            Lbl_Login.Text = users;
        }

        private void BtnAjouter_Click(object sender, EventArgs e)
        {
            Users use = new Users(Lbl_Login.Text);
            int user = UsersDAO.ChargerIdUser(use);
            int niveau = UsersDAO.ChargerIdNiveauxParUser(use);
            int matiere = MatiereDAO.RecuperationIdMatiere(LblMatiere.Text);
            DateTime thisDay = DateTime.Today;
            thisDay.ToString("yyyy-MM-d HH:mm:ss");

            Envoyer LeMesssage = new Envoyer(TxtObjet.Text, txtQuestion.Text, thisDay, user, matiere, niveau);
            bool i = EnvoyerDAO.CreerMessage(LeMesssage);
            if(i == true)
            {
                
                MessageBox.Show("Le message a bien été envoyé !");
                ActiveForm.Close();
                Forum forum = new Forum(use, LblMatiere.Text);
                forum.ShowDialog();
            }
            else
            {
                MessageBox.Show("Le message n'a pas été envoyé");
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Users user = new Users(Lbl_Login.Text);
            ActiveForm.Close();
            Forum forum = new Forum(user, LblMatiere.Text);
            forum.Hide();
            forum.Show();
        }
    }
}