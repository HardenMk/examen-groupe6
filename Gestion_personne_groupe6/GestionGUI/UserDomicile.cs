using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionGUI
{
    public partial class UserDomicile: UserControl
    {
        private static UserDomicile userA;

        private int idmod;
        public static UserDomicile instance
        {
            get
            {
                if (userA == null)
                {
                    userA = new UserDomicile();

                }
                return userA;
            }
        }
        public UserDomicile()
        {
            InitializeComponent();
        }

        private void pnlrecette_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            FRM_AjouterDomicile frm = new FRM_AjouterDomicile();
            frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Adresse frm = new FRM_Adresse();
            frm.ShowDialog();
        }
    }
}
