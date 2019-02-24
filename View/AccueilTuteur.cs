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
            lbl_login.Text = user.nomUser;
            List<Niveaux> LesNiveaux = NiveauxViewModel.ChargerNiveaux();
            for (int i = 0; i < LesNiveaux.Count(); i++)
            {
                Console.Write(i);
                Dgv_Niveaux.Rows.Add(LesNiveaux[i].nomNiveaux);
            }
        }
    }
}
