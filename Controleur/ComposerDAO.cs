﻿using MySql.Data.MySqlClient;
using Projet.NET.Data;
using Projet.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Controleur
{
    class ComposerDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Composer> ChargerComposer()
        {
            List<Composer> lesComposers = new List<Composer>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idMatiere," +
                    "idNiveau from Composer");
                while (reader.Read())
                {
                    Composer m = new Composer(
                        reader.GetInt32(0),
                        reader.GetInt32(4),
                        reader.GetInt32(5));
                    lesComposers.Add(m);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesComposers;
        }
        public static Boolean CreerComposer(Composer composer)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Composer" +
                    "(idMatiere, idNiveaux) " +
                    "VALUES ('"
                    + composer.idMatiere + "', '"
                    + composer.idNiveaux + "');");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
    }
}
