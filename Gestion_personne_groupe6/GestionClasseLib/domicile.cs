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
    public class domicile : IDomicile
    {
        public domicile()
        {
        }

        private int _id;
        private int _id_personne;
        private int _id_adresse;
        private string _avenue;
        private int _numero_domicile;

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

        public int id_personne
        {
            get
            {
                return _id_personne;
            }

            set
            {
                _id_personne = value;
            }
        }

        public int id_adresse
        {
            get
            {
                return _id_adresse;
            }

            set
            {

                _id_adresse = value;
            }
        }

        public string avenue
        {
            get
            {
                return _avenue;
            }

            set
            {

                _avenue = value;
            }
        }

        public int numero_domicile
        {
            get
            {
                return _numero_domicile;
            }

            set
            {

                _numero_domicile = value;
            }
        }

        public int Nouveau()
        {
            int id = 0;

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "select max(id) as lastId from domicile";

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

        public void Enregistrer(IDomicile domicile)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_insert_domicile";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id_personne", 4, DbType.Int32, _id_personne));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id_adresse", 4, DbType.Int32, _id_adresse));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@avenue", 50, DbType.String, _avenue));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@numero_avenue", 4, DbType.Int32, _numero_domicile));

                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_delete_domicile";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        private IDomicile GetDomicile(IDataReader rd)
        {
            IDomicile domicile = new domicile();

            domicile.Id = int.Parse(rd["id"].ToString());
            domicile.id_personne = Convert.ToInt32(rd["id_personne"].ToString());
            domicile.id_adresse = Convert.ToInt32(rd["id_adresse"].ToString());
            domicile.numero_domicile = Convert.ToInt32(rd["numero_avenue"].ToString());
            domicile.avenue = rd["avenue"].ToString();

            return domicile;
        }

        public List<IDomicile> Domiciles()
        {
            List<IDomicile> lst = new List<IDomicile>();

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_select_domiciles";
                cmd.CommandType = CommandType.StoredProcedure;

                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDomicile(rd));
                }

                rd.Dispose();
            }

            return lst;
        }

        public List<IDomicile> RechercherDomicile(String txtrech)
        {
            List<IDomicile> lst = new List<IDomicile>();
            string req = "select d.id,d.id_adresse,d.id_personne,d.avenue,d.numero_avenue from domicile d inner join personne p on d.id_personne=p.id where nom like '%" + txtrech + "%' or postnom like '%" + txtrech + "%' or prenom like '%" + txtrech + "%' order by id asc";

            ImplementerConnexion.connectioncreer();
            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = req;
                cmd.CommandType = CommandType.Text;
                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetDomicile(rd));
                }

                rd.Dispose();
            }

            return lst;
        }
    }
}

