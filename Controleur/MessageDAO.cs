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
    public class MessageDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Message> ChargerUser()
        {
            List<Message> lesMessages = new List<Message>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idMessage," +
                    "objetMessage," +
                    "texteMessage," +
                    "dateEnvoieMessage," +
                    "idUser from Messages");
                while (reader.Read())
                {
                    Message m = new Message(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDateTime(3),
                        reader.GetInt32(4));
                    lesMessages.Add(m);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesMessages;
        }
        public static Boolean CreerMessage(Message message)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Messages" +
                    "(objetMessage, texteMessage, dateEnvoieMessage, idUser) " +
                    "VALUES ('"
                    + message.objetMessage + "', '"
                    + message.texteMessage + "', '"
                    + message.dateEnvoieMessage + "', '"
                    + message.idUser + "');");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean ModifierMessage(Message message)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE Messages SET " +
                    " objetMessage = '" + message.objetMessage + "'," +
                    " texteMessage = '" + message.texteMessage + "', " +
                    " dateEnvoieMessage = '" + message.dateEnvoieMessage + "', " +
                    " idUser = '" + message.idUser + "' " +
                    "  WHERE idMessage = '" + message.idMessage + "' ;");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        public static Boolean SupprimerMessage(Message message)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM Messages WHERE idMessage = "
                    + message.idMessage + " ;");
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
