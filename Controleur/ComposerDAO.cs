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
    public class ComposerDAO
    {
        private static ConnexionBDD connexion = new ConnexionBDD();
        public static List<Composer> ChargerComposer()
        {
            List<Composer> lesComposer = new List<Composer>();
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
                        reader.GetInt32(1));
                    lesComposer.Add(m);
                }
                reader.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }
            return lesComposer;
        }
    }
}
