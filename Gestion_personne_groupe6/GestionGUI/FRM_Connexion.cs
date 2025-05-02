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
using System.Windows.Forms.Design;
using GestionClasseLib;
using GestionDeLaConnexion;

namespace GestionGUI
{
    public partial class FRM_Connexion : Form
    {
        public FRM_Connexion()
        {
            InitializeComponent();
        }
        public void initialiserConnections()
        {
            connexion connection = new connexion();
            connection.Serveur =Properties.Settings.Default.serveurbd;
            connection.Database = Properties.Settings.Default.nombasedesdon;
            connection.User =Properties.Settings.Default.userbd;
            connection.Password = Properties.Settings.Default.motdepassebd;
            ImplementerConnexion.getinstance().connections(connection);
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtnom.Text == "sa" )
                {
                    if (txtmtp.Text == "sa12345")
                    {
                        FRM_Principal frm = new FRM_Principal();
                        frm.btnoutils.Visible = false;
                        frm.panelbutton.Enabled = false;
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("mot de passe incorrect!!");
                        txtmtp.Text = "";
                    }
                }
                else
                {
                    if (string.IsNullOrEmpty(Properties.Settings.Default.serveurbd))
                    {
                        MessageBox.Show("Vous n'etes pas connectés");
                    }
                    else
                    {
                        if (txtnom.Text == string.Empty || txtmtp.Text == string.Empty)
                        {
                            MessageBox.Show("Saisissez le mot de passe et le nom d'utilisateur", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            initialiserConnections();
                            bool test = false;
                            IUtilisateur user = new Utilisateur();
                            test = user.VerifierUtilisateur(txtnom.Text, txtmtp.Text);
                            if (test)
                            {
                                FRM_Principal frm = new FRM_Principal();
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                //throw new Exception(Message);                                
                                txtmtp.Text = "";

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Connexion",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtmtp.Text = "";

            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtmtp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.guna2Button1_Click(sender, e);
            }
        }
    }
}
