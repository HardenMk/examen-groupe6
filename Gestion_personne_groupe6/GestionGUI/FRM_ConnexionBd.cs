using GestionDeLaConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGUI
{
    public partial class FRM_ConnexionBd: Form
    {
        private SqlConnection con;//declaration d'une variable con privee static du type sqlconnextio
        private SqlCommand cmd;
        public FRM_ConnexionBd()
        {
            InitializeComponent();
        }
        private string verifierchamp()
        {
            if (string.IsNullOrEmpty(txtLocal.Text)) { return "Saisissez le nom du serveur"; }
            if (string.IsNullOrEmpty(txtUser.Text)) { return "Saisissez le nom d'utilisateur du serveur"; }
            if (string.IsNullOrEmpty(txtMotdePasse.Text)) { return "Saisissez le mot de passe d'utilisateur du serveur"; }
            if (cbxbd.SelectedIndex == -1) { return "Choisissez la base des données"; }
            return null;
        }

        private void ChargerCombobd()
        {
            string Connexionstring = "";
            Connexionstring = @"Data Source=" + txtLocal.Text.Trim() + ";Initial Catalog=master ;Persist Security Info=false;User ID=" + txtUser.Text.Trim() + ";password=" + txtMotdePasse.Text.Trim() + ";MultipleActiveResultSets=true";

            con = new SqlConnection(Connexionstring);
            string rqt = "select name  from sys.databases";
            try
            {
                con.Open();
                cmd = new SqlCommand(rqt, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds, "sys.databases");
                cbxbd.DataSource = ds.Tables["sys.databases"];
                cbxbd.DisplayMember = "name";
                con.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        private void button6_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifierchamp() == null)
                {

                    Properties.Settings.Default.serveurbd = txtLocal.Text;
                    Properties.Settings.Default.userbd = txtUser.Text;
                    Properties.Settings.Default.nombasedesdon = cbxbd.Text.Trim();
                    Properties.Settings.Default.motdepassebd = txtMotdePasse.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("vous etes connecté");                    
                    initialiserConnections();
                    this.Close();
                }
                else
                {
                    MessageBox.Show(verifierchamp());
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);

            }
        }

        private void cbxbd_Enter(object sender, EventArgs e)
        {
            ChargerCombobd();

        }
        public void initialiserConnections()
        {
            connexion connection = new connexion();
            connection.Serveur = Properties.Settings.Default.serveurbd;
            connection.Database = Properties.Settings.Default.nombasedesdon;
            connection.User = Properties.Settings.Default.userbd;
            connection.Password = Properties.Settings.Default.motdepassebd;
            ImplementerConnexion.getinstance().connections(connection);
        }
    }
}
