﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Model
{
    public class Niveaux
    {
        public int idNiveaux { get; set; }
        public string nomNiveaux { get; set; }

        public Niveaux(int id, string nom)
        {
            this.idNiveaux = id;
            this.nomNiveaux = nom;
        }
    }
}