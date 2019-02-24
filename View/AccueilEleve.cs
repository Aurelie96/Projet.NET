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
    public partial class AccueilEleve : Form
    {
        public AccueilEleve(Users user)
        {
            InitializeComponent();
            Connexion connexion = new Connexion();
            connexion.Close();
            lbl_login.Text = user.nomUser;
            List<Matiere> LesMatieres = MatiereViewModel.ChargerNomMatiereParUser(user);
            for (int i = 0; i < LesMatieres.Count(); i++)
            {
                Console.Write(i);
                Dgv_Groupe.Rows.Add(LesMatieres[i].nomMatiere);
            }
        }
    }
}
