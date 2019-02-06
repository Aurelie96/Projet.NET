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
                    "nomMatiere from Matieres;");
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
        public static Matiere ChargerMatiereParIdMatiere(int idmatiere)
        {
            Matiere lesMatieres = new Matiere(idmatiere);
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idMatiere," +
                    "nomMatiere from matiere " +
                    $"WHERE idMatiere = '{idmatiere}';");
                if (reader.Read())
                {
                    lesMatieres = new Matiere(
                        reader.GetInt32(0),
                        reader.GetString(1));
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesMatieres;
        }

        public static List<Matiere> ChargerNomMatiereParUser(Users users)
        {
            List<Matiere> lesMatieresUser = new List<Matiere>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "M.nomMatiere " +
                    "FROM users U " +
                    "inner JOIN niveaux N ON N.idNiveau = U.idNiveau " +
                    "INNER JOIN composer C ON C.idNiveau = N.idNiveau " +
                    "INNER JOIN matiere M ON M.idMatiere = C.idMatiere " +
                    $"WHERE U.loginuser = '{users.loginUser}';");
                while (reader.Read())
                {
                    Matiere m = new Matiere(
                        reader.GetString(0));
                    lesMatieresUser.Add(m);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesMatieresUser;
        }
        public static Boolean CreerMatiere(Matiere matiere)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO matiere" +
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
                connexion.execWrite("UPDATE matiere SET " +
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
                connexion.execWrite("DELETE FROM matiere WHERE idMatiere = "
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

        public static int RecuperationIdMatiere(string matiere)
        {
            int i = 0;
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT idMatiere" +
                    $" FROM matiere WHERE nomMatiere = '{matiere}';");
                if (reader.Read())
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
    }
}
