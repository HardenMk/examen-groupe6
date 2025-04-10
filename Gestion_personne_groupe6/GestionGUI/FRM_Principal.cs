using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGUI
{
    public partial class FRM_Principal: Form
    {
        public FRM_Principal()
        {
            InitializeComponent();
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
            Application.Exit();
        }

        private void cacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
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
    }
}
