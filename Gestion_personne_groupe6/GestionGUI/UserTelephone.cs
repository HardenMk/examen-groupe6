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
    public partial class UserTelephone: UserControl
    {
        private static UserTelephone userA;

        private int idmod;
        public static UserTelephone instance
        {
            get
            {
                if (userA == null)
                {
                    userA = new UserTelephone();

                }
                return userA;
            }
        }
        public UserTelephone()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            FRM_AjouterTelephone frm = new FRM_AjouterTelephone();
            frm.ShowDialog();
        }
    }
}
