using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Matiere
    {
        public int idMatiere { get; set; }
        public string nomMatiere { get; set; }

        public Matiere(int id, string nom)
        {
            this.idMatiere = id;
            this.nomMatiere = nom;
        }
        public Matiere(string nom)
        {
            this.nomMatiere = nom;
        }
        public Matiere(int id)
        {
            this.idMatiere = id;
        }
    }
}
