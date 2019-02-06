﻿using MySql.Data.MySqlClient;
using Projet.NET.Data;
using Projet.NET.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.NET.Controleur
{
    public class EnvoyerDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
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
        public static List<Envoyer> ChargerMessageParMatiere(int user, int matiere)
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
                    $"WHERE idUser = '{user}' " +
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
