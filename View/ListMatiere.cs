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
    public partial class ListMatiere : Form
    {
        public ListMatiere(Users user, string nomNiveaux)
        {
            InitializeComponent();
            Connexion connexion = new Connexion();
            connexion.Close();
            lbl_login.Text = user.loginUser;
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
            DataGridViewRow lineSelected = Dgv_Groupe.Rows[Dgv_Groupe.SelectedCells[0].RowIndex];
            string nomMatiere = Convert.ToString(lineSelected.Cells[0].Value);
            Matiere matiere = new Matiere(Dgv_Groupe.SelectedRows.ToString());
            ActiveForm.Close();
            ForumTuteur forum = new ForumTuteur(user, nomMatiere);
            forum.Hide();
            forum.Show();
        }
    }
}
