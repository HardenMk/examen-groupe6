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
    public partial class FRM_AjouterDomicile: Form
    {
        public FRM_AjouterDomicile()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FRM_Adresse frm = new FRM_Adresse();
            frm.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FRM_Personne frm = new FRM_Personne();
            frm.ShowDialog();
        }
    }
}
