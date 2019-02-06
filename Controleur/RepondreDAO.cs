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
    public class RepondreDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        /*La méthode ChargerRepondre reçoit un type Envoyer
         Il vas récupérer tout les réponse par rapport a une question*/
        public static List<Repondre> ChargerRepondre(Envoyer envoyer)
        {
            List<Repondre> lesReponses = new List<Repondre>();
            try
            {
                MySqlDataReader reader;
                reader = connexion.execRead("SELECT " +
                    "idReponse," +
                    "texteReponse," +
                    "idMessage from Reponse " +
                    $"WHERE idMessage = '{envoyer.idMessage}'");
                while (reader.Read())
                {
                    Repondre r = new Repondre(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2));
                    lesReponses.Add(r);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesReponses;
        }
        /*La méthode CreerReponse recoit un type Repondre
         Il permet de créer un champ
         dans la table Reponse et de retourner un Boolean 
         pour dire si la ligne a bien été inséré*/
        public static Boolean CreerReponse(Repondre repondre)
        {
            Boolean test = false;
            try
            {
                connexion.execWrite("INSERT INTO Reponse" +
                    "(texteReponse, idMessage) " +
                    "VALUES ('"
                    + repondre.texteReponse + "', '"
                    + repondre.idMessage + "');");
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
