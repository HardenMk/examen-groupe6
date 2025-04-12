using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeLaConnexion
{
    public class ImplementerConnexion:IConnexion
    {

        public static SqlConnection con = new SqlConnection();
        public static SqlCommand cmd = new SqlCommand();
        private SqlDataAdapter sda = new SqlDataAdapter();
        //private DataTable dt = new DataTable();
        public string constr;
        private static ImplementerConnexion instance;


        public ImplementerConnexion()
        {
            //constr = connectivite();
            //con = new SqlConnection(constr);
            //cmd = new SqlCommand();
           // cmd.Connection = con;
        }
        private string connectivite(connexion conex)
        {
            string nomserveur = conex.Serveur;
            string nombd = conex.Database;
            string nomuser = conex.User;
            string mtp = conex.Password;
            constr = string.Format("Data Source={0};Initial Catalog={1};User ID={2};PassWord={3};MultipleActiveResultSets=true", nomserveur, nombd, nomuser, mtp);
            return constr;
        }
        public static ImplementerConnexion getinstance()
        {
            if (instance == null) instance = new ImplementerConnexion();
            return instance;
        }
        public void connections(connexion conex)
        {
            constr = connectivite(conex);
            con = new SqlConnection(constr);
            if (con.State == ConnectionState.Closed)

                con.Open();
        }
        public static bool connectioncreer()
        {
            if (con.State == ConnectionState.Closed)

                con.Open();
            return true;
        }

        public static bool fermerconnection()
        {
            if (con.State == ConnectionState.Open)

                con.Close();
            return true;
        }
    }
}
