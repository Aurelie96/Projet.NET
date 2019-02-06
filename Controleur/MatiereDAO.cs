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

        /*La méthode ChargerMatiere permet de récupérer
         toutes les données de la table Matiere et de le mettre
         dans une List<Matiere>*/
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
        /*La méthode ChargerMatiereParIdMatiere recoit un idMatiere,
         * récupère le nom de la matière
         et renvoie un type Matiere*/
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
        /*La méthode ChargerNomMatiereParUser reçoit un User,
         récupère le nom des matière de l'utilisateur,
         renvoie une List<Matiere>*/
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
        /*La méthode CreerMatiere permet de créer un champ
         dans la table Matiere et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
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
        /*La méthode ModifierMatiere reçoit un type Matiere
         Elle vas faire une mise à jour d'une matière 
         et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
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
        /*La méthode SupprimerMatiere reçoit un type Matiere
         Elle vas supprimer une matiere
         et retourne un Boolean pour dire si la ligne a bien été inséré*/
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
        /*La méthode RecuperationIdMatiere reçoit un string matière
         Elle recupère les Id des Matière par rapport a un nom de matiere
         retourne un int*/
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
