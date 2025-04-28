using GestionClasseLib;
using GestionDeLaConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGUI
{
    public partial class FRM_Principal : Form
    {
        private static DataTable dt;
        private static SqlDataAdapter sda;
        public FRM_Principal()
        {
            InitializeComponent();
            this.panelbutton.Size = new System.Drawing.Size(204, 543);

        }

        private void btnconnexion_Click(object sender, EventArgs e)
        {
            FRM_ConnexionBd frm = new FRM_ConnexionBd();
            frm.ShowDialog();
        }

        private void chargerUserInstance(UserControl user)
        {
            pnlafficher.Controls.Clear();
            pnlafficher.Controls.Add(user);
            user.Dock = DockStyle.Fill;
            //UserPersonne.instance.chargerdatavieuw();
            user.BringToFront();
        }
        private void btnagenda_Click(object sender, EventArgs e)
        {
            pnltop.Top = btnpersonne.Top;
            chargerUserInstance(UserPersonne.instance);
            //pnlafficher.Controls.Clear();
            //pnlafficher.Controls.Add(UserPersonne.instance);
            //UserPersonne.instance.Dock = DockStyle.Fill;
            ////UserPersonne.instance.chargerdatavieuw();
            //UserPersonne.instance.BringToFront();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Voulez-vous quitter l'application", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnphone_Click(object sender, EventArgs e)
        {
            pnltop.Top = btnphone.Top;
            chargerUserInstance(UserTelephone.instance);
        }

        private void btnacceuil_Click(object sender, EventArgs e)
        {
            pnltop.Top = btnacceuil.Top;
            pnlafficher.Controls.Clear();

        }

        private void btncaisse_Click(object sender, EventArgs e)
        {
            pnltop.Top = btnDomicile.Top;
            chargerUserInstance(UserDomicile.instance);
        }

        private void btnpanel_Click(object sender, EventArgs e)
        {
            if (btnpanel.Location == new System.Drawing.Point(175, 0))//la location du bouton
            {
                this.panelbutton.Size = new System.Drawing.Size(60, 543);
            }
            else
            {
                this.panelbutton.Size = new System.Drawing.Size(204, 543);
            }
        }

        private void listeDePersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        public static void ChargerRapportViewer(String cmdtext, String typeRapport)
        {
            DataTable dt1 = new DataTable();
            dt1 = recuperdata(cmdtext);         
            FRM_Imprimer frm = new FRM_Imprimer();

            try
            {
                frm.reportViewer1.LocalReport.DataSources.Clear();
                frm.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt1));
                frm.reportViewer1.LocalReport.ReportEmbeddedResource = "GestionGUI.Rapport." + typeRapport;
                frm.reportViewer1.RefreshReport();

                frm.ShowDialog();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when Selecting data, " + ex.Message, "Selecting data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementerConnexion.fermerconnection();

              

            }
        }
        public static DataTable recuperdata(string req)
        {
            ImplementerConnexion.connectioncreer();
            using (IDbCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = req;
                cmd.CommandType = CommandType.StoredProcedure;
                sda = new SqlDataAdapter((SqlCommand)cmd);
                dt = new DataTable();
                sda.Fill(dt);
            }
            return dt;
        }
        private void listeDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void listeDesPersonnesAvecLeursAdressesToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void adressesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adressesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Adresse frm = new FRM_Adresse(new FRM_AjouterDomicile(UserDomicile.instance));
            frm.ShowDialog();
        }

        private void listeDesPersonnesEtLeursDomicilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargerRapportViewer("sp_liste_personneDomicile", "Rpt_liste_personneAdresses.rdlc");

        }

        private void listeDesPersonnesEtLeursNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargerRapportViewer("sp_liste_personnes", "Rpt_liste_personneTelephone.rdlc");

        }

        private void listeDesPersonnesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChargerRapportViewer("sp_select_personnes", "Rpt_liste_personnes.rdlc");

        }

        private void gererLesUtilisateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRM_Utilisateur frm = new FRM_Utilisateur();
            frm.ShowDialog();
        }

        private void seConnecterÀLaBaseDesDonnéesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void seDeconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult q = MessageBox.Show("Voulez-vous vous deconnectez", "Deconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (q == DialogResult.Yes)
            {
                Application.Restart();
            }
        }
    }
}

