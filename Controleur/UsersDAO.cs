using MySql.Data.MySqlClient;
using Projet.NET.Data;
using Projet.NET.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Controleur
{
    public class UsersDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
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
                    + user.idNiveaux+"');");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
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
<<<<<<< HEAD

=======
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
>>>>>>> master
    }


}
