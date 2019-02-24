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
    public partial class Accueil : Form
    {
        public Accueil(Users user)
        {
            InitializeComponent();
            Connexion connexion = new Connexion();
            connexion.Close();
            lbl_login.Text = user.loginUser;
            List<Matiere> LesMatieres = MatiereViewModel.ChargerNomMatiereParUser(user);
            for(int i = 0; i < LesMatieres.Count(); i++)
            {
                Console.Write(i);
                Dgv_Groupe.Rows.Add(LesMatieres[i].nomMatiere);
            }
        }
        /*Dgv_Groupe_CellContentClick
         Permet de cliquer sur une cellule du dataGridView
         Ouvre la view Forum*/
        private void Dgv_Groupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Users user = new Users(lbl_login.Text);
            DataGridViewRow lineSelected = Dgv_Groupe.Rows[Dgv_Groupe.SelectedCells[0].RowIndex];
            string nomMatiere = Convert.ToString(lineSelected.Cells[0].Value);
            Matiere matiere = new Matiere(Dgv_Groupe.SelectedRows.ToString());
            ActiveForm.Close();
            Forum forum = new Forum(user, nomMatiere);
            forum.Hide();
            forum.Show();
        }
    }
}
