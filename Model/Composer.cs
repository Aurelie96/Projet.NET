using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Composer
    {
        public int idMatiere { get; set; }
        public int idNiveau { get; set; }

        public Composer(int idM, int idN)
        {
            this.idMatiere = idM;
            this.idNiveau = idN;
        }
    }
}
