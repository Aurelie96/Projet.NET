using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Envoyer
    {
        #region Propriétés
        public int idMessage { get; set; }
        public string objetMessage { get; set; }
        public string texteMessage { get; set; }
        public DateTime dateEnvoieMessage { get; set; }
        public int idUser { get; set; }
        public int idMatiere { get; set; }
        public int idNiveaux { get; set; }
        #endregion

        #region Constructeur
        public Envoyer (int id, string objet, string text, DateTime date, int idUs, int idMat, int idNiv)
        {
            this.idMessage = id;
            this.objetMessage = objet;
            this.texteMessage = text;
            this.dateEnvoieMessage = date;
            this.idUser = idUs;
            this.idMatiere = idMat;
            this.idNiveaux = idNiv;
        }
        public Envoyer(string objet, string text, DateTime date, int idUs, int idMat, int idNiv)
        {
            this.objetMessage = objet;
            this.texteMessage = text;
            this.dateEnvoieMessage = date;
            this.idUser = idUs;
            this.idMatiere = idMat;
            this.idNiveaux = idNiv;
        }
        public Envoyer()
        {
        }
        public Envoyer(int id)
        {
            this.idMessage = id;
        }
        #endregion
    }
}
