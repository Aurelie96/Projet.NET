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
    public class MatiereDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Matiere> ChargerMatiere()
        {
            List<Matiere> lesMatieres = new List<Matiere>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idMatiere," +
                    "nomMatiere from Matieres");
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
        public static Boolean CreerMatiere(Matiere matiere)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Matieres" +
                    "(idMatiere, nomMatiere) " +
                    "VALUES ('"
                    + matiere.idMatiere + "', '"
                    + matiere.nomMatiere + "');");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierMatiere(Matiere matiere)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Matieres SET " +
                    " nomMatiere = '" + matiere.nomMatiere + "' " +
                    "  WHERE idMatiere = '" + matiere.idMatiere + "' ;");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerMatiere(Matiere matiere)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Matieres WHERE idMatiere = "
                    + matiere.idMatiere + " ;");
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
