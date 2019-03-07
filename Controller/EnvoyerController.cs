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
    public class EnvoyerController
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        /*La méthode ChargerMessage recoit deux string 
         et retourne le message qui contient l'objet et le texte*/
        public static Envoyer ChargerMessage(string objet, string texte)
        {
            Envoyer lesMessages = new Envoyer();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idMessage, " +
                    "objetMessage, " +
                    "texteMessage, " +
                    "dateEnvoieMessage, " +
                    "idUser, " +
                    "idMatiere, " +
                    "idNiveau from message " +
                    $"WHERE objetMessage = '{objet}' " +
                    $"AND texteMessage = '{texte}' ;");
                if (reader.Read())
                {
                    lesMessages = new Envoyer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDateTime(3),
                        reader.GetInt32(4),
                        reader.GetInt32(5),
                        reader.GetInt32(6));
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesMessages;
        }
        /*La méthode ChargerMessageParMatiere recoit deux int  
         et retourne le message de l'utilisateur par rapport a une matière*/
        public static List<Envoyer> ChargerMessageParMatiere(int niveau, int matiere)
        {
            List<Envoyer> lesMessages = new List<Envoyer>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idMessage, " +
                    "objetMessage, " +
                    "texteMessage, " +
                    "dateEnvoieMessage, " +
                    "idUser, " +
                    "idMatiere, " +
                    "idNiveau from message " +
                    $"WHERE idNiveau = '{niveau}' " +
                    $"AND idMatiere = '{matiere}' ");
                while (reader.Read())
                {
                    Envoyer m = new Envoyer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDateTime(3),
                        reader.GetInt32(4),
                        reader.GetInt32(5),
                        reader.GetInt32(6));
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
        /*La méthode ChargerMessageParIdMessage recoit un paramètre de type Envoyer 
         et retourne le message par rapport a l'id du message qui se trouve dans Envoyer*/
        public static Envoyer ChargerMessageParIdMessage(Envoyer envoyer)
        {
            Envoyer lesMessages = new Envoyer();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idMessage, " +
                    "objetMessage, " +
                    "texteMessage, " +
                    "dateEnvoieMessage, " +
                    "idUser, " +
                    "idMatiere, " +
                    "idNiveau from message " +
                    $"WHERE idMessage = '{envoyer.idMessage}' ");
                if (reader.Read())
                {
                    lesMessages = new Envoyer(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetDateTime(3),
                        reader.GetInt32(4),
                        reader.GetInt32(5),
                        reader.GetInt32(6));
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesMessages;
        }
        /*La méthode CreerMessage permet de créer un champ
         dans la table Envoyer et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
        public static Boolean CreerMessage(Envoyer message)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO message" +
                    "(objetMessage, texteMessage, dateEnvoieMessage, idUser, idMatiere, idNiveau) " +
                    "VALUES ('"
                    + message.objetMessage + "', '"
                    + message.texteMessage + "', '"
                    + message.dateEnvoieMessage.ToString("yyyy-MM-d HH:mm:ss") + "', '"
                    + message.idUser + "', '"
                    + message.idMatiere + "', '"
                    + message.idNiveaux + "');");
                test = true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
                test = false;
            }
            return test;
        }
        /*La méthode ModifierMessage reçoit un type Envoyer
         Elle vas faire une mise à jour d'un message 
         et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
        public static Boolean ModifierMessage(Envoyer message)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("UPDATE message SET " +
                    " objetMessage = '" + message.objetMessage + "'," +
                    " texteMessage = '" + message.texteMessage + "', " +
                    " dateEnvoieMessage = '" + message.dateEnvoieMessage + "', " +
                    " idUser = '" + message.idUser + "', " +
                    " idMatiere = '" + message.idMatiere + "', " +
                    " idNiveau = '" + message.idNiveaux + "' " +
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
        /*La méthode SupprimerMessage reçoit un type Envoyer
         Elle vas supprimer un message
         et retourne un Boolean pour dire si la ligne a bien été supprimé*/
        public static Boolean SupprimerMessage(Envoyer message)
        {
            bool test = false;
            try
            {
                connexion.execWrite("DELETE FROM message WHERE idMessage = "
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
