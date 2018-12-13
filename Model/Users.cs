using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Users
    {
        public int idUser { get; set; }
        public string nomUser { get; set; }
        public string prenomUser { get; set; }
        public string loginUser { get; set; }
        public string passwordUser { get; set; }
        public string emailUser { get; set; }
        public bool tuteurUser { get; set; }
        public bool eleveUser { get; set; }

        public Users(int id, string nom, string prenom, string login,
            string password, string email, bool tuteur, bool eleve)
        {
            this.idUser = id;
            this.nomUser = nom;
            this.prenomUser = prenom;
            this.loginUser = login;
            this.passwordUser = password;
            this.emailUser = email;
            this.tuteurUser = tuteur;
            this.eleveUser = eleve;
        }
    }
}
