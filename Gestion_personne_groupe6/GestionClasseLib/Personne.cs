using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeLaConnexion;
using GestionPersonneUtilitiesLib;
using GestionUtiliteeLib;

namespace GestionClasseLib
{
    public class Personne:IPersonne
    {
        public Personne()
        {
        }

        private int _id;
        private string _nom;
        private string _postnom;
        private string _prenom;
        private sexe _sex;
        private List<ITelephone> _telephonePersonnes;

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

        public string Nom
        {
            get
            {
                return _nom;
            }

            set
            {
                _nom = value;
            }
        }

        

        public string Postnom
        {
            get
            {
                return _postnom;
            }

            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    value = value.ToLower();
                    _postnom = value[0].ToString().ToUpper() + new string(value.ToCharArray(), 1, value.Length - 1);
                }
                else
                    _postnom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return _prenom;
            }

            set
            {
               _prenom = value;
            }
        }

        public sexe Sex
        {
            get
            {
                return _sex;
            }

            set
            {
                _sex = value;
            }
        }

        public List<ITelephone> TelephonePersonnes
        {
            get
            {
                //List<ITelephone> telephones = new List<ITelephone>();

                ITelephone phone = new Telephone();

                if (_telephonePersonnes == null)
                    _telephonePersonnes = new List<ITelephone>();

                _telephonePersonnes.Clear();
                _telephonePersonnes = phone.TelephonesPersonnes(_id);

                return _telephonePersonnes;
            }
        }

        public string NomComplet
        {
            get
            {
                return (_nom + " " + (string.IsNullOrEmpty(_postnom) ? "" : _postnom + " ") + _prenom).Trim();
            }
        }

        public int Nouveau()
        {
            int id = 0;
            ImplementerConnexion.connectioncreer();
            using (SqlCommand cmd =ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "select max(id) as lastId from personne";

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

        public void Enregistrer(IPersonne personne)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_insert_personne";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@nom", 50, DbType.String, _nom));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@postnom", 50, DbType.String, _postnom));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@prenom", 50, DbType.String, _prenom));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@sexe", 1, DbType.String, _sex == sexe.Féminin ? "F" : "M"));

                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_delete_personne";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        public List<IPersonne> Personnes()
        {
            List<IPersonne> lst = new List<IPersonne>();

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_select_personnes";
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetPersonne(rd));
                }

                rd.Dispose();
            }

            return lst;
        }

        private IPersonne GetPersonne(IDataReader rd)
        {
            IPersonne personne = new Personne();

            personne.Id = Convert.ToInt32(rd["id"].ToString());
            personne.Nom = rd["nom"].ToString();
            personne.Postnom = rd["postnom"].ToString();
            personne.Prenom = rd["prenom"].ToString();
            personne.Sex = rd["sexe"].ToString().Equals("M") ? sexe.Masculin : sexe.Féminin;

            return personne;
        }

        public IPersonne OnePersonne(int id)
        {
            IPersonne personne = new Personne();

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_select_personne";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    personne = GetPersonne(rd);
                }

                rd.Dispose();
            }

            return personne;
        }

        public override string ToString()
        {
            return (_nom + " " + (string.IsNullOrEmpty(_postnom) ? "" : _postnom + " ") + _prenom).Trim();
        }
    }
}

