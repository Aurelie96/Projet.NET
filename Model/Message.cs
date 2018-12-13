using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Message
    {
        public int idMessage { get; set; }
        public string objetMessage { get; set; }
        public string texteMessage { get; set; }
        public DateTime dateEnvoieMessage { get; set; }
        public int idUser { get; set; }

        public Message (int id, string objet, string text, DateTime date, int idUs)
        {
            this.idMessage = id;
            this.objetMessage = objet;
            this.texteMessage = text;
            this.dateEnvoieMessage = date;
            this.idUser = idUs;
        }
    }
}
