using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionClasseLib;
using GestionDeLaConnexion;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace GestionGUI
{
    public partial class FRM_Adresse : Form
    {
        private BindingSource bdsrc1 = new BindingSource();
        Form frm;
        public FRM_Adresse(Form frm)
        {
            InitializeComponent();
            this.frm = frm;
        }
        public void ChargerData(IAdresse adresse)
        {
            List<IAdresse> lst = new List<IAdresse>();
            lst = adresse.Adresses();
            bdsrc1.DataSource = lst;
            dvgadresse.DataSource = bdsrc1;

        }
        public void activerbtn()
        {
            // btnajout.Enabled = false;
            btnmod.Enabled = true;
            btnsupp.Enabled = true;
        }
        public void desactiverbtn()
        {
            // btnajout.Enabled = true;
            btnmod.Enabled = false;
            btnsupp.Enabled = false;
        }
        private string verifierchamp()
        {
            if (txtpay.Text == string.Empty)
            {
                return "Saisis le pays";
            }

            if (txtvill.Text == string.Empty)
            {
                return "Saisis la ville";
            }
            if (txtcommune.Text == string.Empty)
            {
                return "Saisis la commune";
            }

            if (txtquartier.Text == string.Empty)
            {
                return "Saisis le quartier";
            }

            return null;
        }
        private void viderchamp()
        {
            txtpay.Clear();
            txtvill.Clear();
            txtcommune.Clear();
            txtquartier.Clear();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Adresse_Load(object sender, EventArgs e)
        {
            
            try
            {
                ChargerData(new Adresse());
                initialiserId();
                desactiverbtn();
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

        private void dvgadresse_DoubleClick(object sender, EventArgs e)
        {
            modifieradresse();
            activerbtn();
        }
        private void modifieradresse()
        {
            int i;
            i = dvgadresse.CurrentRow.Index;
            txtId.Text = dvgadresse["id", i].Value.ToString();
            txtpay.Text = dvgadresse["Pays", i].Value.ToString();
            txtvill.Text = dvgadresse["Ville", i].Value.ToString();
            txtcommune.Text = dvgadresse["Commune", i].Value.ToString();
            txtquartier.Text = dvgadresse["Quartier", i].Value.ToString();
        }

        private void AjoutModifierAdresse()
        {
            try
            {
                if (verifierchamp() != null)
                {
                    MessageBox.Show(verifierchamp(), "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    IAdresse adresse = new Adresse();
                    adresse.Id = Convert.ToInt32(txtId.Text);
                    adresse.pays = txtpay.Text;
                    adresse.ville = txtvill.Text;
                    adresse.commune = txtcommune.Text;
                    adresse.quartier = txtquartier.Text;
                    adresse.Enregistrer(adresse);
                    ChargerData(adresse);

                    MessageBox.Show(" enregistrer avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    initialiserId();
                    viderchamp();

                    (frm as FRM_AjouterDomicile).chargercomboAdresse(new Adresse());
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
        private void initialiserId()
        {
            IAdresse adresse = new Adresse();
            txtId.Text = adresse.Nouveau().ToString();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AjoutModifierAdresse();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            SupprimerAdresse();
        }
        private void SupprimerAdresse()
        {
            int i; int id;
            i = dvgadresse.CurrentRow.Index;
            id = (int)dvgadresse["id", i].Value;
            if (id == 0)
            {
                MessageBox.Show("Doubler Cliquez sur la ligne à supprimer");
            }
            else
            {
                try
                {
                    DialogResult q = MessageBox.Show("Voulez vous vraiment supprimer l'adresse", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (q == DialogResult.Yes)
                    {
                        IAdresse adresse = new Adresse();

                        adresse.Id = id;

                        adresse.Supprimer(adresse.Id);

                        ChargerData(adresse);

                        MessageBox.Show("suppression effectué avec succes", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        desactiverbtn();

                    }
                    else
                    {
                        MessageBox.Show("Suppression annulé ", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        desactiverbtn();
                    }
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show("Error when deleting datas, " + ex.Message, "Deleting datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Error when deleting datas, " + ex.Message, "Deleting datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error when deleting datas, " + ex.Message, "Deleting datas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                finally
                {
                    ImplementerConnexion.fermerconnection();
                }
            }
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            AjoutModifierAdresse();
        }

        private void txtrech_TextChanged(object sender, EventArgs e)
        {
            if (txtrech.Text != string.Empty)
            {
                IAdresse adr = new Adresse();
                dvgadresse.DataSource = adr.RechercherAdresse(txtrech.Text);
            }
            else
            {
                ChargerData(new Adresse());
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            initialiserId();
            viderchamp();
            desactiverbtn();
        }
    }
}
