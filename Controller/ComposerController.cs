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
    public class ComposerController
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
        public static List<Matiere> ChargerComposerNomMatiere(int idNiveau)
        {
            List<Matiere> lesMatieres = new List<Matiere>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "m.idMatiere," +
                    "m.nomMatiere " +
                    "from Composer c, Matiere m " +
                    "where c.idMatiere = m.idMatiere " +
                    $"and c.idNiveau = '{idNiveau}';");
                while (reader.Read())
                {
                    Matiere m = new Matiere(
                        reader.GetInt32(0),
                        reader.GetString(1));
                    lesMatieres.Add(m);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesMatieres;
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
