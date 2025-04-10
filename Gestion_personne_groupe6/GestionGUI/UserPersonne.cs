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
    public partial class UserPersonne: UserControl
    {
        private static UserPersonne userA; 
       
        private int idmod; 
        public static UserPersonne instance
        {
            get
            {
                if (userA == null)
                {
                    userA = new UserPersonne();

                }
                return userA;
            }
        }
        public UserPersonne()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnlrecette_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            FRM_AjouterPersonne frm = new FRM_AjouterPersonne();
            frm.ShowDialog();
        }
    }
}
