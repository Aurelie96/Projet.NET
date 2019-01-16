using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Composer
    {
        public int idComposer { get; set; }
        public int idMatiere { get; set; }
        public int idNiveaux { get; set; }

        public Composer(int id,  int idMat, int idNiv)
        {
            this.idComposer = id;
            this.idMatiere = idMat;
            this.idNiveaux = idNiv;
        }
    }
}
