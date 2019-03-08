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
    public partial class AccueilTuteur : Form
    {
        public AccueilTuteur(Users user)
        {
            InitializeComponent();
            Connexion connexion = new Connexion();
            connexion.Close();
            lbl_login.Text = user.loginUser;
            label1.Text = "Bonjour " + user.loginUser;
            List<Niveaux> LesNiveaux = NiveauxController.ChargerNiveaux();
            for (int i = 0; i < LesNiveaux.Count(); i++)
            {
                Console.Write(i);
                Dgv_Niveaux.Rows.Add(LesNiveaux[i].nomNiveaux);
            }
        }

        private void Dgv_Niveaux_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Users user = new Users(lbl_login.Text);
            DataGridViewRow lineSelected = Dgv_Niveaux.Rows[Dgv_Niveaux.SelectedCells[0].RowIndex];
            string nomNiveau = Convert.ToString(lineSelected.Cells[0].Value);
            Niveaux niveau = new Niveaux(Dgv_Niveaux.SelectedRows.ToString());
            ListMatiere forum = new ListMatiere(user, nomNiveau);
            ActiveForm.Close();
            forum.Hide();
            forum.Show();
        }
    }
}
