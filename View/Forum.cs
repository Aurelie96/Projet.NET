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
    public partial class Forum : Form
    {
        public Forum(Users user, string nomMatiere)
        {
            InitializeComponent();
            int users = UsersDAO.ChargerIdUser(user);
            int matiere = MatiereDAO.RecuperationIdMatiere(nomMatiere);
            List<Envoyer> lesMessages = EnvoyerDAO.ChargerMessageParMatiere(users, matiere);
            for (int i = 0; i < lesMessages.Count(); i++)
            {
                Console.Write(i);
                Dgv_Forum.Rows.Add(lesMessages[i].objetMessage, lesMessages[i].texteMessage);
            }
            LblMatiere.Text = nomMatiere;
            LblUser.Text = user.loginUser;
            Dgv_Forum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Forum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

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
            Envoyer envoyer = EnvoyerDAO.ChargerMessage(objetMessage, texteMessage);

            ActiveForm.Close();
            RepondreQuestion repondreQuestion = new RepondreQuestion(envoyer);
            repondreQuestion.Hide();
            repondreQuestion.Show();
        }

        private void BtnRafraichir_Click(object sender, EventArgs e)
        {
            Dgv_Forum.Rows.Clear();
            Users user = new Users(LblUser.Text);
            int users = UsersDAO.ChargerIdUser(user);
            int matiere = MatiereDAO.RecuperationIdMatiere(LblMatiere.Text);
            List<Envoyer> lesMessages = EnvoyerDAO.ChargerMessageParMatiere(users, matiere);
            for(int i = 0; i <lesMessages.Count(); i++)
            {
                Console.Write(i);
                Dgv_Forum.Rows.Add(lesMessages[i].objetMessage, lesMessages[i].texteMessage);
            }
            Dgv_Forum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Forum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void BtnRetour_Click(object sender, EventArgs e)
        {
            Users users = new Users(LblUser.Text);
            ActiveForm.Close();
            Accueil accueil = new Accueil(users);
            accueil.Hide();
            accueil.Show();
        }
    }
}
