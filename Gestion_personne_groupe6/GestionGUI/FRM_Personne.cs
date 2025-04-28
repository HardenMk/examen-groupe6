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

namespace GestionGUI
{
    public partial class FRM_Personne : Form
    {
        private BindingSource bdsrc1 = new BindingSource();
        Form frm;
        public FRM_Personne(Form frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        public void ChargerData(IPersonne personne)
        {
            List<IPersonne> lst = new List<IPersonne>();
            lst = personne.Personnes();
            bdsrc1.DataSource = lst;
            dgvPersonne.DataSource = bdsrc1;

        }



        private string verifierchamp()
        {


            if (txtnom.Text == string.Empty)
            {
                return "Saisis le nom";
            }

            if (txtpostnom.Text == string.Empty)
            {
                return "Saisis le postnom";
            }
            if (txtprenom.Text == string.Empty)
            {
                return "Saisis le prenom";
            }

            if (cbxsexe.SelectedIndex == -1)
            {
                return "choisis le sexe";
            }

            return null;
        }
        private void viderchamp()
        {
            txtnom.Clear();
            txtpostnom.Clear();
            txtprenom.Clear();
            cbxsexe.SelectedIndex = -1;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Personne_Load(object sender, EventArgs e)
        {
           
            try
            {
                ChargerData(new Personne());
                chargercomboSexe();
                initialiserId();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error when loading datas, " + ex.Message, "Loading datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                if (ImplementerConnexion.con != null)
                {
                    if (ImplementerConnexion.con.State == System.Data.ConnectionState.Open)
                        ImplementerConnexion.con.Close();
                }
            }
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {

        }


        private void dgvPersonne_DoubleClick(object sender, EventArgs e)
        {


        }

        private void btnmod_Click(object sender, EventArgs e)
        {

        }

        private void modifierpersonne()
        {
            int i;
            i = dgvPersonne.CurrentRow.Index;
            txtcode.Text = dgvPersonne["id", i].Value.ToString();
            txtnom.Text = dgvPersonne["Nom", i].Value.ToString();
            txtpostnom.Text = dgvPersonne["Postnom", i].Value.ToString();
            txtprenom.Text = dgvPersonne["Prenom", i].Value.ToString();
            Text = dgvPersonne["sex", i].Value.ToString();

        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AjoutModifierPersonne();
        }

        private void AjoutModifierPersonne()
        {
            try
            {
                if (verifierchamp() != null)
                {
                    MessageBox.Show(verifierchamp(), "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IPersonne personne = new Personne();
                    personne.Id = Convert.ToInt32(txtcode.Text);
                    personne.Nom = txtnom.Text;
                    personne.Postnom = txtpostnom.Text;
                    personne.Prenom = txtprenom.Text;
                    personne.Sex = cbxsexe.Text.Equals(sexe.Masculin.ToString()) ? sexe.Masculin : sexe.Féminin;
                    personne.Enregistrer(personne);
                    ChargerData(personne);


                    MessageBox.Show("Personne enregistrer avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiserId();
                    viderchamp();
                    if (frm is FRM_AjouterTelephone)
                    {
                        (frm as FRM_AjouterTelephone).chargercomboPersonne(new Personne());
                    }
                    else
                    {
                        (frm as FRM_AjouterDomicile).chargercomboPersonne(new Personne());
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

        private void chargercomboSexe()
        {
            cbxsexe.DataSource = Enum.GetNames(typeof(sexe));
            cbxsexe.SelectedIndex = 0;
        }

        private void initialiserId()
        {
            IPersonne personne = new Personne();
            txtcode.Text = personne.Nouveau().ToString();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
