using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeLaConnexion
{
    public class connexion
    {

        string _serveur = "serveur";
        string _user = "user";
        string _password = "password";
        string _database = "database";


        public string Serveur
        {
            get
            {
                return _serveur;
            }

            set
            {
                _serveur = value;
            }
        }
        public string Database
        {
            get
            {
                return _database;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new InvalidOperationException("Please specify a valid Database !!!");
                else
                    _database = value;
            }
        }


        public string User
        {
            get
            {
                return _user;
            }

            set
            {
                _user = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }

            set
            {
                _password = value;
            }
        }


    }
}
