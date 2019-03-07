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
    public partial class VoirReponse : Form
    {
        public VoirReponse(Envoyer envoyer)
        {
            InitializeComponent();
            List<Repondre> LesReponses = RepondreController.ChargerRepondre(envoyer);
            for (int i = 0; i < LesReponses.Count(); i++)
            {
                Console.Write(i);
                Dgv_Repondre.Rows.Add(LesReponses[i].idReponse, LesReponses[i].texteReponse);
            }
            Dgv_Repondre.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            Dgv_Repondre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TxtQuestion.Text = envoyer.texteMessage;
            LblIdMessage.Text = envoyer.idMessage.ToString();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            Envoyer envoyer = new Envoyer(int.Parse(LblIdMessage.Text));
            envoyer = EnvoyerController.ChargerMessageParIdMessage(envoyer);
            Users users = UsersController.ChargerLoginUser(envoyer.idUser);
            Matiere matiere = MatiereController.ChargerMatiereParIdMatiere(envoyer.idMatiere);
            ForumEleve forum = new ForumEleve(users, matiere.nomMatiere);
            ActiveForm.Close();
            forum.ShowDialog();
        }
    }
}
