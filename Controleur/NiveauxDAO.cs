using MySql.Data.MySqlClient;
using Projet.NET.Data;
using Projet.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Controleur
{
    public class NiveauxDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Niveaux> ChargerNiveaux()
        {
            List<Niveaux> lesNiveaux = new List<Niveaux>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idNiveau," +
                    "nomNiveau from Niveaux");
                while (reader.Read())
                {
                    Niveaux n = new Niveaux(
                        reader.GetInt32(0),
                        reader.GetString(1));
                    lesNiveaux.Add(n);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesNiveaux;
        }
        public static Boolean CreerNiveaux(Niveaux niveaux)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Niveaux" +
                    "(idNiveau, nomNiveau) " +
                    "VALUES ('"
                    + niveaux.idNiveaux + "', '"
                    + niveaux.nomNiveaux + "');");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierNiveaux(Niveaux niveaux)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Niveaux SET " +
                    " nomNiveau = '" + niveaux.nomNiveaux + "' " +
                    "  WHERE idNiveau = '" + niveaux.idNiveaux + "' ;");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerNiveaux(Niveaux niveaux)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Niveaux WHERE idNiveau = "
                    + niveaux.idNiveaux + " ;");
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
