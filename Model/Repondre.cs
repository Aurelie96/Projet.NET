using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Repondre
    {
        public int idReponse { get; set; }
        public string texteReponse { get; set; }
        public int idMessage { get; set; }

        public Repondre(int id, string texte, int idMess)
        {
            this.idReponse = id;
            this.texteReponse = texte;
            this.idMessage = idMess;
        }

        public Repondre(string texte, int idMess)
        {
            this.texteReponse = texte;
            this.idMessage = idMess;
        }
    }
}
