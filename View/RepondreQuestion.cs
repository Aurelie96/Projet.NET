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
    public partial class RepondreQuestion : Form
    {
        public RepondreQuestion(Envoyer envoyer)
        {
            InitializeComponent();
            List<Repondre> LesReponses = RepondreDAO.ChargerRepondre(envoyer);
            for(int i = 0; i < LesReponses.Count(); i++)
            {
                Console.Write(i);
                Dgv_Repondre.Rows.Add(LesReponses[i].idReponse, LesReponses[i].texteReponse);
            }

            Dgv_Repondre.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Repondre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TxtQuestion.Text = envoyer.texteMessage;
            LblIdMessage.Text = envoyer.idMessage.ToString();
        }

        private void BtnEnvoyer_Click(object sender, EventArgs e)
        {
            Repondre repondre = new Repondre(TxtReponse.Text, int.Parse(LblIdMessage.Text));
            bool i = RepondreDAO.CreerReponse(repondre);
            if(i == true)
            {
                Envoyer envoyer = new Envoyer(int.Parse(LblIdMessage.Text));
                envoyer = EnvoyerDAO.ChargerMessageParIdMessage(envoyer);
                Users users = UsersDAO.ChargerLoginUser(envoyer.idUser);
                Matiere matiere = MatiereDAO.ChargerMatiereParIdMatiere(envoyer.idMatiere);
                MessageBox.Show("Le message a bien été envoyé !");
                Forum forum = new Forum(users, matiere.nomMatiere);
                ActiveForm.Close();
                forum.ShowDialog();
            }
            else
            {
                MessageBox.Show("Le message n'a pas été envoyé");
            }
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Envoyer envoyer = new Envoyer(int.Parse(LblIdMessage.Text));
            envoyer = EnvoyerDAO.ChargerMessageParIdMessage(envoyer);
            Users users = UsersDAO.ChargerLoginUser(envoyer.idUser);
            Matiere matiere = MatiereDAO.ChargerMatiereParIdMatiere(envoyer.idMatiere);
            Forum forum = new Forum(users, matiere.nomMatiere);
            ActiveForm.Close();
            forum.ShowDialog();
        }
    }
}
