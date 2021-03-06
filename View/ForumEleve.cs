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
    public partial class ForumEleve : Form
    {
        public ForumEleve(Users user, string nomMatiere)
        {
            InitializeComponent();
            int niveau = UsersController.ChargerIdNiveaux(user);
            int matiere = MatiereController.RecuperationIdMatiere(nomMatiere);
            List<Envoyer> lesMessages = EnvoyerController.ChargerMessageParMatiere(niveau, matiere);
            for (int i = 0; i < lesMessages.Count(); i++)
            {
                Console.Write(i);
                Dgv_Forum.Rows.Add(lesMessages[i].objetMessage, lesMessages[i].texteMessage);
            }
            LblMatiere.Text = nomMatiere;
            LblUser.Text = user.loginUser;
            label1.Text = "Bienvenue sur le forum de  " + nomMatiere;
            Dgv_Forum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Forum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        /*btn_Question_Click
         Permet d'aller sur la view AjoutQuestion*/
        private void btn_Question_Click(object sender, EventArgs e)
        {
            string nomMatiere = LblMatiere.Text;
            AjoutQuestion ajoutQuestion = new AjoutQuestion(LblUser.Text, LblMatiere.Text);
            ActiveForm.Close();
            ajoutQuestion.Hide();
            ajoutQuestion.Show();
        }

        private void Dgv_Forum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow lineSelected = Dgv_Forum.Rows[Dgv_Forum.SelectedCells[0].RowIndex];
            string objetMessage = Convert.ToString(lineSelected.Cells[0].Value);
            string texteMessage = Convert.ToString(lineSelected.Cells[1].Value);
            Envoyer envoyer = EnvoyerController.ChargerMessage(objetMessage, texteMessage);
            
            VoirReponse repondreQuestion = new VoirReponse(envoyer);
            ActiveForm.Close();
            repondreQuestion.Hide();
            repondreQuestion.Show();
        }
        /*BtnRafraichir_Click
         Permet de rafraîchir le DataGridView*/
        private void BtnRafraichir_Click(object sender, EventArgs e)
        {
            Dgv_Forum.Rows.Clear();
            Users user = new Users(LblUser.Text);
            int niveau = UsersController.ChargerIdNiveaux(user);
            int matiere = MatiereController.RecuperationIdMatiere(LblMatiere.Text);
            List<Envoyer> lesMessages = EnvoyerController.ChargerMessageParMatiere(niveau, matiere);
            for (int i = 0; i < lesMessages.Count(); i++)
            {
                Console.Write(i);
                Dgv_Forum.Rows.Add(lesMessages[i].objetMessage, lesMessages[i].texteMessage);
            }
            Dgv_Forum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Forum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        /*BtnRetour_Click
         Permet de retourner sur la view Accueil*/
        private void BtnRetour_Click_1(object sender, EventArgs e)
        {
            Users users = new Users(LblUser.Text);
            AccueilEleve accueil = new AccueilEleve(users);
            ActiveForm.Close();
            accueil.Hide();
            accueil.Show();
        }
    }
}
