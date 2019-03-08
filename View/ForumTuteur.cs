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
    public partial class ForumTuteur : Form
    {
        public ForumTuteur(Users user, string nomMatiere, string nomNiveaux)
        {
            InitializeComponent();
            int idNiveaux = NiveauxController.TrouverIdNiveaux(nomNiveaux);
            int matiere = MatiereController.RecuperationIdMatiere(nomMatiere);
            List<Envoyer> lesMessages = EnvoyerController.ChargerMessageParMatiere(idNiveaux, matiere);
            for (int i = 0; i < lesMessages.Count(); i++)
            {
                Console.Write(i);
                Dgv_Forum.Rows.Add(lesMessages[i].objetMessage, lesMessages[i].texteMessage);
            }
            LblNiveau.Text = nomNiveaux;
            LblMatiere.Text = nomMatiere;
            LblUser.Text = user.loginUser;
            label1.Text = "Bienvenue sur le forum de  " + nomMatiere;
            Dgv_Forum.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Forum.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
        private void BtnRetour_Click(object sender, EventArgs e)
        {
            Users users = new Users(LblUser.Text);
            ListMatiere accueil = new ListMatiere(users, LblNiveau.Text);
            ActiveForm.Close();
            accueil.Hide();
            accueil.Show();
        }

        private void Dgv_Forum_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow lineSelected = Dgv_Forum.Rows[Dgv_Forum.SelectedCells[0].RowIndex];
            string objetMessage = Convert.ToString(lineSelected.Cells[0].Value);
            string texteMessage = Convert.ToString(lineSelected.Cells[1].Value);
            Envoyer envoyer = EnvoyerController.ChargerMessage(objetMessage, texteMessage);
            
            RepondreQuestionTuteur repondreQuestion = new RepondreQuestionTuteur(envoyer, LblNiveau.Text);
            ActiveForm.Close();
            repondreQuestion.Hide();
            repondreQuestion.Show();
        }
    }
}
