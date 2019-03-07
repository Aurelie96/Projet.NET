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
    public partial class ListMatiereTuteur : Form
    {
        public ListMatiereTuteur(Users user, string nomNiveaux)
        {
            InitializeComponent();
            Connexion connexion = new Connexion();
            connexion.Close();
            lbl_login.Text = user.loginUser;
            lbl_niveau.Text = nomNiveaux;
            int idNiveaux = NiveauxController.TrouverIdNiveaux(nomNiveaux);
            List<Matiere> LesMatieres = ComposerController.ChargerComposerNomMatiere(idNiveaux);
            for (int i = 0; i < LesMatieres.Count(); i++)
            {
                Console.Write(i);
                Dgv_Groupe.Rows.Add(LesMatieres[i].nomMatiere);
            }
        }
        private void Dgv_Groupe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Users user = new Users(lbl_login.Text);
            string nomNiveaux = lbl_niveau.Text;
            DataGridViewRow lineSelected = Dgv_Groupe.Rows[Dgv_Groupe.SelectedCells[0].RowIndex];
            string nomMatiere = Convert.ToString(lineSelected.Cells[0].Value);
            Matiere matiere = new Matiere(Dgv_Groupe.SelectedRows.ToString());
            Forum forum = new Forum(user, nomMatiere, nomNiveaux);
            ActiveForm.Close();
            forum.Hide();
            forum.Show();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            Users users = new Users(lbl_login.Text);
            Accueil accueil = new Accueil(users);
            ActiveForm.Close();
            accueil.Hide();
            accueil.Show();
        }
    }
}
