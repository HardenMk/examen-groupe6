using GestionDeLaConnexion;
using GestionPersonneUtilitiesLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClasseLib
{
    public class Adresse:IAdresse
    {
        public Adresse()
        {
        }

        private int _id;
        private String _quartier;
        private String _commune;
        private string _ville;
        private string _pays;

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {
                _id = value;
            }
        }

        public string quartier
        {
            get
            {
                return _quartier;
            }

            set
            {
                _quartier = value;
            }
        }

        public string commune
        {
            get
            {
                return _commune;
            }

            set
            {
                _commune = value;
            }
        }

        public string ville
        {
            get
            {
                return _ville;
            }

            set
            {

                _ville = value;
            }
        }

        public string pays
        {
            get
            {
                return _pays;
            }

            set
            {

                _pays = value;
            }
        }



        public int Nouveau()
        {
            int id = 0;

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "select max(id) as lastId from adresse";

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    if (rd["lastId"] == DBNull.Value)
                        id = 1;
                    else
                        id = Convert.ToInt32(rd["lastId"].ToString()) + 1;
                }

                rd.Dispose();
            }

            return id;
        }

        public void Enregistrer(IAdresse adresse)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_insert_adresse";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@quartier", 50, DbType.String, _quartier));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@commune", 50, DbType.String, _commune));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@ville", 50, DbType.String, _ville));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@pays", 50, DbType.String, _pays));

                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_delete_adresse";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        private IAdresse GetAdresse(IDataReader rd)
        {
            IAdresse adresse = new Adresse();

            adresse.Id = int.Parse(rd["id"].ToString());
            adresse.quartier = rd["quartier"].ToString();
            adresse.commune = rd["commune"].ToString();
            adresse.ville = rd["ville"].ToString();
            adresse.pays = rd["pays"].ToString();

            return adresse;
        }

        public List<IAdresse> Adresses()
        {
            List<IAdresse> lst = new List<IAdresse>();

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_select_adresses";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetAdresse(rd));
                }

                rd.Dispose();
            }

            return lst;
        }

        public IAdresse OneAdresse(int id)
        {
            IAdresse adresse = new Adresse();


            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_select_adresse";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    adresse = GetAdresse(rd);
                }

                rd.Dispose();
            }

            return adresse;
        }

      
    }
}
