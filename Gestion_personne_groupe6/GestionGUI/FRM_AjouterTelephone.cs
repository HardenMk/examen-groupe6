using GestionClasseLib;
using GestionDeLaConnexion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GestionGUI
{
    public partial class FRM_AjouterTelephone: Form
    {
        private UserControl user;

        public FRM_AjouterTelephone(UserControl user)
        {
            InitializeComponent();
            this.user = user;
            initialiserId();
            // Charger les personnes
            chargercomboPersonne(new Personne());
        }
        private string verifierchamp()
        {


            if (txtId.Text == string.Empty)
            {
                return "Saisis le nom";
            }

            if (txtinitial.Text == string.Empty)
            {
                return "Saisis l'initial du numero";
            }
            if (txtnumero.Text == string.Empty)
            {
                return "Saisis le numero";
            }

            if (cbxpersonne.SelectedIndex == -1)
            {
                return "choisis la personne";
            }

            return null;
        }
        private void viderchamp()
        {
            txtnumero.Clear();
            txtinitial.Clear();
            //cbxpersonne.SelectedIndex = -1;
        }
        private void txtadresse_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            (user as UserTelephone).desactiverbtn();
            this.Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FRM_Personne frm = new FRM_Personne(this);
            frm.ShowDialog();
        }
        public void chargercomboPersonne(IPersonne personne)
        {
            List<IPersonne> lstpers = new List<IPersonne>();
            lstpers = personne.Personnes();
            cbxpersonne.DataSource = lstpers;
            cbxpersonne.DisplayMember = "NomComplet";
            cbxpersonne.ValueMember = "Id";
            cbxpersonne.SelectedIndex = -1;
            cbxpersonne.Text = "Proprietaire";

            //cbxSexe.SelectedIndex = 0;
        }

        private void initialiserId()
        {
            ITelephone tel = new Telephone();
            txtId.Text = tel.Nouveau().ToString();
        }

    
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FRM_AjouterTelephone_Load(object sender, EventArgs e)
        {
           
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (verifierchamp() != null)
                {
                    MessageBox.Show(verifierchamp(), "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ITelephone tel = new Telephone();
                    tel.Id = Convert.ToInt32(txtId.Text);
                    tel.Id_proprietaire = (int)Convert.ToUInt32(cbxpersonne.SelectedValue);
                    tel.Initial = txtinitial.Text;
                    tel.Numero = txtnumero.Text;
                    tel.Enregistrer(tel);
                    (user as UserTelephone).ChargerData(tel);

                    if (txttitre.Text != "Modifier Numero")
                    {
                        MessageBox.Show("Numero enregistrer avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiserId();
                        viderchamp();
                    }
                    else
                    {
                        MessageBox.Show("Information modifiée avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        (user as UserTelephone).desactiverbtn();
                        this.Close();

                    }


                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when saving datas, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error when saving datas, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error when saving datas, " + ex.Message, "Saving datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                ImplementerConnexion.fermerconnection();
            }
        }

        private void cbxpersonne_Enter(object sender, EventArgs e)
        {
           // chargercomboPersonne(new Personne());
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }

        private void txtinitial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
            if (e.KeyChar == 8)
            {
                e.Handled = false;
            }
        }
    }
}
