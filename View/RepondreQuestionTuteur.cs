using Projet.NET.Controleur;
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
    public partial class RepondreQuestionTuteur : Form
    {
        public RepondreQuestionTuteur(Envoyer envoyer, string niveau)
        {
            InitializeComponent();
            label4.Text = niveau;
            //Récupération de toute les réponses et remplir le dataGridView
            List<Repondre> LesReponses = RepondreController.ChargerRepondre(envoyer);
            for (int i = 0; i < LesReponses.Count(); i++)
            {
                Console.Write(i);
                Dgv_Repondre.Rows.Add(LesReponses[i].idReponse, LesReponses[i].texteReponse);
            }

            Dgv_Repondre.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Repondre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TxtQuestion.Text = envoyer.texteMessage;
            LblIdMessage.Text = envoyer.idMessage.ToString();
        }
        /*BtnEnvoyer_Click
         Permet d'envoyer une réponse pour les questions*/
        private void BtnEnvoyer_Click(object sender, EventArgs e)
        {
            Repondre repondre = new Repondre(TxtReponse.Text, int.Parse(LblIdMessage.Text));
            bool i = RepondreController.CreerReponse(repondre);
            if (i == true)
            {
                Envoyer envoyer = new Envoyer(int.Parse(LblIdMessage.Text));
                envoyer = EnvoyerController.ChargerMessageParIdMessage(envoyer);
                Users users = UsersController.ChargerLoginUser(envoyer.idUser);
                Matiere matiere = MatiereController.ChargerMatiereParIdMatiere(envoyer.idMatiere);
                MessageBox.Show("Le message a bien été envoyé !");
                ForumTuteur forum = new ForumTuteur(users, matiere.nomMatiere, label4.Text);
                ActiveForm.Close();
                forum.Hide();
                forum.Show();
            }
            else
            {
                MessageBox.Show("Le message n'a pas été envoyé");
            }
        }
        /*BtnAnnuler_Click
         Permet de fermer l'application et de retourner sur la view Forum*/
        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Envoyer envoyer = new Envoyer(int.Parse(LblIdMessage.Text));
            envoyer = EnvoyerController.ChargerMessageParIdMessage(envoyer);
            Users users = UsersController.ChargerLoginUser(envoyer.idUser);
            Matiere matiere = MatiereController.ChargerMatiereParIdMatiere(envoyer.idMatiere);
            ForumTuteur forum = new ForumTuteur(users, matiere.nomMatiere, label4.Text);
            ActiveForm.Close();
            forum.Hide();
            forum.Show();
        }
    }
}
