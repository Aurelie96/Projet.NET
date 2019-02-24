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
    public class UsersViewModel
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        /*La méthode ChargerUser permet de récupérer tout les user
         et de les mettre dans une List<Users>*/
        public static List<Users> ChargerUser()
        {
            List<Users> lesUsers = new List<Users>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idUser," +
                    "nomUser," +
                    "prenomUser," +
                    "loginUser," +
                    "mdpUser," +
                    "emailUser," +
                    "tuteurUser," +
                    "eleveUser, " +
                    "idNiveau from Users");
                while (reader.Read())
                {
                    Users u = new Users(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                        reader.GetInt32(6),
                        reader.GetInt32(7),
                        reader.GetInt32(8));
                    lesUsers.Add(u);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesUsers;
        }
        /*La méthode ChargerIdUser permet de récupérer le user
         * par rapport a un login
         et de les mettre dans un int*/
        public static int ChargerIdUser(Users user)
        {
            int i = 0;
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idUser from Users" +
                    $" WHERE loginUser = '{user.loginUser}'");
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
        /*La méthode ChargerLoginUser permet de récupérer le user
         * par rapport a un idUser
         et de les mettre dans un Users*/
        public static Users ChargerLoginUser(int idUser)
        {
            Users i = new Users(idUser);
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "loginUser from Users" +
                    $" WHERE idUser = '{idUser}'");
                while (reader.Read())
                {
                    i = new Users(reader.GetString(0));
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return i;
        }
        /*La méthode ChargerIdNiveauxParUser permet de récupérer 
         l'idNiveau du user
         par rapport a un login
         et de les mettre dans un int*/
        public static int ChargerIdNiveauxParUser(Users user)
        {
            int i = 0;
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idNiveau from Users" +
                    $" WHERE loginUser = '{user.loginUser}'");
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
        /*La méthode CreerUser permet de créer un champ
         dans la table Users et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
        public static Boolean CreerUser(Users user)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Users" +
                    "(nomUser, prenomUser, loginUser, mdpUser" +
                    ", emailUser, tuteurUser, eleveUser, idNiveau) " +
                    "VALUES ('"
                    + user.nomUser + "', '"
                    + user.prenomUser + "', '"
                    + user.loginUser + "', '"
                    + user.passwordUser + "', '"
                    + user.emailUser + "', '"
                    + user.tuteurUser + "', '"
                    + user.eleveUser + "', '"
                    + user.idNiveaux + "');");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        /*La méthode ModifierUser reçoit un type Users
         Elle vas faire une mise à jour d'un user 
         et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
        public static Boolean ModifierUser(Users user)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Users SET " +
                    " nomUser = '" + user.nomUser + "'," +
                    " prenomUser = '" + user.prenomUser + "', " +
                    " loginUser = '" + user.loginUser + "', " +
                    " mdpUser = '" + user.passwordUser + "', " +
                    " emailUser = '" + user.emailUser + "', " +
                    " tuteurUser = '" + user.tuteurUser + "', " +
                    " eleveUser = '" + user.eleveUser + "', " +
                    " idNiveau = '" + user.idNiveaux + "'" +
                    " WHERE idUser = '" + user.idUser + "' ;");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        /*La méthode SupprimerUser reçoit un type Users
         Elle vas supprimer un user
         et retourne un Boolean pour dire si la ligne a bien été inséré*/
        public static Boolean SupprimerUser(Users user)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Users WHERE idUser = "
                    + user.idUser + " ;");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        /*La méthode Connexion reçoit deux string
         Elle vas permettre de vérifier que le login et mdp 
         correspond a un user*/
        public static bool Connexion(string login, string password)
        {
            bool test = false;
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead($"SELECT * FROM Users WHERE loginuser = '{login}' AND mdpUser = '{password}';");
                if (reader.Read())
                {
                    test = true;
                }
            }
            catch(MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        /*La méthode RecuperationMail reçoit un string de login 
         et retourn l'adresse mail de l'utilisateur*/
        public static string RecuperationMail(string login)
        {
            string resultat = "";
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead($"SELECT emailUser from Users WHERE loginUser = '{login}'");
                if (reader.Read())
                {
                    resultat = reader.GetString(0);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return resultat;
        }
        /*La méthode RecuperationMdp reçoit un string 
         et retourn le mot de passe de l'utilisateur*/
        public static string RecuperationMdp(string login)
        {
            string mdp = "";
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead($"SELECT mdpUser from Users WHERE loginUser = '{login}'");
                if (reader.Read())
                {
                    mdp = reader.GetString(0);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return mdp;
        }
    }
}
