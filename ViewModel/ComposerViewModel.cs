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
    public class ComposerViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();

        /*La méthode ChargerComposer permet de récupérer
         toutes les données de la table Composer et de le mettre
         dans une List<Composer>*/
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
        /*La méthode CréerComposer permet de créer un champ
         dans la table Composer et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
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
