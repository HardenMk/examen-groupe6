using GestionClasseLib;
using GestionDeLaConnexion;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
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
        UserControl user;
        public FRM_AjouterDomicile(UserControl user)
        {
            InitializeComponent();
            // Charger 
            initialiserId();
            // Charger les personnes
            chargercomboPersonne(new Personne());
            // Charger les personnes
            chargercomboAdresse(new Adresse());
            this.user = user;
        }
        private string verifierchamp()
        {
            if (cbxPersonne.SelectedIndex == -1)
            {
                return "choisis la personne";
            }
            if (cbxAdresse.SelectedIndex == -1)
            {
                return "choisis l'adresse";
            }
            if (txtId.Text == string.Empty)
            {
                return "Saisis le nom";
            }
            if (txtavenue.Text == string.Empty)
            {
                return "Saisis l'avenue";
            }
            if (txtnumeroavenue.Text == string.Empty)
            {
                return "Saisis le numero de la parcelle";
            }            

            return null;
        }
        private void viderchamp()
        {
            txtnumeroavenue.Clear();
            txtavenue.Clear();
            //cbxPersonne.SelectedIndex = -1;
            chargercomboAdresse(new Adresse());
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            (user as UserDomicile).desactiverbtn();
            this.Close();

        }
        public void chargercomboPersonne(IPersonne personne)
        {
            List<IPersonne> lstpers = new List<IPersonne>();
            lstpers = personne.Personnes();
            cbxPersonne.DataSource = lstpers;
            cbxPersonne.DisplayMember = "NomComplet";
            cbxPersonne.ValueMember = "Id";
            cbxPersonne.SelectedIndex = -1;
            cbxPersonne.Text = "Proprietaire";

            //cbxSexe.SelectedIndex = 0;
        }

        public void chargercomboAdresse(IAdresse adresse)
        {
            List<IAdresse> lstadr = new List<IAdresse>();
            lstadr = adresse.Adresses();
            cbxAdresse.DataSource = lstadr;
            cbxAdresse.DisplayMember = "AdresseComplet";
            cbxAdresse.ValueMember = "Id";
            cbxAdresse.SelectedIndex = -1;
            cbxAdresse.Text = "Adresse";

            //cbxSexe.SelectedIndex = 0;
        }

        private void initialiserId()
        {
            IDomicile dom = new domicile();
            txtId.Text = dom.Nouveau().ToString();
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            FRM_Adresse frm = new FRM_Adresse(this);
            frm.btnmod.Visible = false;
            frm.btnsupp.Visible = false;
            frm.ShowDialog();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            FRM_Personne frm = new FRM_Personne(this);
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
                    IDomicile dom = new domicile();
                    dom.Id = Convert.ToInt32(txtId.Text);
                    dom.id_personne = (int)Convert.ToUInt32(cbxPersonne.SelectedValue);
                    dom.id_adresse = (int)Convert.ToUInt32(cbxAdresse.SelectedValue);
                    dom.avenue = txtavenue.Text;
                    dom.numero_domicile = Convert.ToInt32(txtnumeroavenue.Text);
                    dom.Enregistrer(dom);
                    (user as UserDomicile).ChargerData(dom);

                    if (txttitre.Text != "Modifier Domicile")
                    {
                        MessageBox.Show("Numero enregistrer avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiserId();
                        viderchamp();
                    }
                    else
                    {
                        MessageBox.Show("Information modifiée avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        (user as UserDomicile).desactiverbtn();
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

        private void txtnumeroavenue_KeyPress(object sender, KeyPressEventArgs e)
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
