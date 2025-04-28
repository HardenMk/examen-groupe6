using GestionDeLaConnexion;
using System;
using System.Data;

namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                connexion connection = new connexion();

                connection.Serveur = @"INGENIEUR";
                connection.Database = "gestion_personne";
                connection.User = "sa";
                connection.Password = "mk101214";
                ImplementerConnexion.getinstance().connections(connection);

                Console.WriteLine("Connection Successfuly !!!");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            //catch (System.Data.SqlClient ex)
            //{
            //    Console.WriteLine("Connection error, " + ex.Message);
            //}
            catch (Exception ex)
            {
                Console.WriteLine("Connection error, " + ex.Message);
            }
            finally
            {
                ImplementerConnexion.fermerconnection();
               
            }

            Console.ReadLine();
        }
    }
}
