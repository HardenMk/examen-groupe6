using GestionDeLaConnexion;
using GestionPersonneUtilitiesLib;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GestionClasseLib
{
    public class Utilisateur : IUtilisateur
    {
        public Utilisateur()
        {
        }

        private int _id;
        private string _nom_user;
        private string _mot_de_passe;


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

        public string Nom_user
        {
            get
            {
                return _nom_user;
            }

            set
            {
                _nom_user = value;
            }
        }
        public string Mot_de_passe
        {
            get
            {
                return _mot_de_passe;
            }

            set
            {
                _mot_de_passe = value;
            }
        }
        public int Nouveau()
        {
            int id = 0;
            ImplementerConnexion.connectioncreer();
            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "select max(id) as lastId from utilisateur";

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

        private String crypterMotDePasse()
        {
            return GetMD5(_mot_de_passe);
        }

        public void Enregistrer(IUtilisateur utilisateur)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_insert_utilisateur";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@nom_user", 50, DbType.String, _nom_user));
                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@mot_de_passe", 50, DbType.String, crypterMotDePasse()));
                cmd.ExecuteNonQuery();
            }
        }

        public void Supprimer(int id)
        {
            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_delete_utilisateur";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, _id));

                int record = cmd.ExecuteNonQuery();

                if (record == 0)
                    throw new InvalidOperationException("That id does not exist !!!");
            }
        }

        public List<IUtilisateur> Utilisateurs()
        {
            List<IUtilisateur> lst = new List<IUtilisateur>();

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_select_utilisateurs";
                cmd.CommandType = CommandType.StoredProcedure;
                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetUtilisateur(rd));
                }

                rd.Dispose();
            }

            return lst;
        }

        private IUtilisateur GetUtilisateur(IDataReader rd)
        {
            IUtilisateur utilisateur = new Utilisateur();

            utilisateur.Id = Convert.ToInt32(rd["id"].ToString());
            utilisateur.Nom_user = rd["nom_user"].ToString();
            utilisateur.Mot_de_passe = rd["mot_de_passe"].ToString();

            return utilisateur;
        }

        public IUtilisateur OneUtilisateur(int id)
        {
            IUtilisateur utilisateur = new Utilisateur();

            ImplementerConnexion.connectioncreer();

            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = "sp_select_utilisateur";
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(Parametres.getInstance.AjouterParametre(cmd, "@id", 4, DbType.Int32, id));

                IDataReader rd = cmd.ExecuteReader();

                if (rd.Read())
                {
                    utilisateur = GetUtilisateur(rd);
                }

                rd.Dispose();
            }

            return utilisateur;
        }


        public List<IUtilisateur> RechercherUtilisateur(String txtrech)
        {
            List<IUtilisateur> lst = new List<IUtilisateur>();
            string req = "select * from utilisateur where nom_user like '%" + txtrech + "%' order by id asc";

            ImplementerConnexion.connectioncreer();
            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = req;
                cmd.CommandType = CommandType.Text;
                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetUtilisateur(rd));
                }

                rd.Dispose();
            }

            return lst;
        }
        public static String GetMD5(String Texte)
        {
            String md5Hash = "";
            MD5CryptoServiceProvider x = new MD5CryptoServiceProvider();
            byte[] data = Encoding.ASCII.GetBytes(Texte);
            data = x.ComputeHash(data);
            md5Hash = Encoding.ASCII.GetString(data);
            return md5Hash;
        }

        public bool VerifierUtilisateur(string nom, string mtp)
        {
            try
            {
                string nomuser = nom;bool test=false;
                string psw = GetMD5(mtp);
                string password; string nomutilisateur="";
                ImplementerConnexion.connectioncreer();
                using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
                {
                    cmd.CommandText = "select nom_user,mot_de_passe from utilisateur where nom_user='" + nomuser + "'";
                    SqlDataReader dr = null;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        nomutilisateur = dr.GetString(0);
                        password = dr.GetString(1);
                        if (nomuser == nomutilisateur && psw == password)
                        {
                            dr.Dispose();
                            test=true;
                        }
                        else
                        {
                            dr.Dispose();
                            throw new Exception("Mot de passe incorrect!!!");                           
                        }
                    }
                    else
                    {
                        dr.Dispose();
                        throw new Exception("utilisateur non reconnu");
                    }

                }
                return test;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
