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
    public partial class AccueilEleve : Form
    {
        public AccueilEleve(Users user)
        {
            InitializeComponent();
            Connexion connexion = new Connexion();
            connexion.Close();
            lbl_login.Text = user.loginUser;
            label1.Text = "Bonjour " + user.loginUser;
            List<Matiere> LesMatieres = MatiereController.ChargerNomMatiereParUser(user);
            for (int i = 0; i < LesMatieres.Count(); i++)
            {
                Console.Write(i);
                Dgv_Groupe.Rows.Add(LesMatieres[i].nomMatiere);
            }
        }
        private void Dgv_Groupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Users user = new Users(lbl_login.Text);
            DataGridViewRow lineSelected = Dgv_Groupe.Rows[Dgv_Groupe.SelectedCells[0].RowIndex];
            string nomMatiere = Convert.ToString(lineSelected.Cells[0].Value);
            Matiere matiere = new Matiere(Dgv_Groupe.SelectedRows.ToString());
            ForumEleve forum = new ForumEleve(user, nomMatiere);
            ActiveForm.Close();
            forum.Hide();
            forum.Show();
        }
    }
}
