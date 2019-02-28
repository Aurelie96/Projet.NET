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
    public class NiveauxController
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        /*La méthode ChargerNiveaux permet de récupérer tout les niveaux
         et de les mettre dans une List<Niveau>*/
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

        public static int TrouverIdNiveaux(string nomNiveaux)
        {
            int i = 0;
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idNiveau," +
                    "nomNiveau from Niveaux" +
                    $" WHERE nomNiveau = '{nomNiveaux}'");
                while (reader.Read())
                {
                    i = reader.GetInt32(0);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return i;
        }
        /*La méthode CreerNiveaux permet de créer un champ
         dans la table Niveaux et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
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
        /*La méthode ModifierNiveaux reçoit un type Niveaux
         Elle vas faire une mise à jour d'une niveaux 
         et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
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
        /*La méthode SupprimerNiveaux reçoit un type Niveaux
         Elle vas supprimer une niveaux
         et retourne un Boolean pour dire si la ligne a bien été inséré*/
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
