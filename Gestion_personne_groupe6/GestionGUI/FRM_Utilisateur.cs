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
using static System.Net.Mime.MediaTypeNames;

namespace GestionGUI
{
    public partial class FRM_Utilisateur: Form
    {
        private BindingSource bdsrc1 = new BindingSource();
        public FRM_Utilisateur()
        {
            InitializeComponent();
        }
        public void ChargerData(IUtilisateur utilisateur)
        {
            List<IUtilisateur> lst = new List<IUtilisateur>();
            lst = utilisateur.Utilisateurs();
            bdsrc1.DataSource = lst;
            dvgutilisateur.DataSource = bdsrc1;

        }
        public void activerbtn()
        {
            // btnajout.Enabled = false;
            btnsupp.Enabled = true;
        }
        public void desactiverbtn()
        {
            // btnajout.Enabled = true;
            btnsupp.Enabled = false;
        }
        private string verifierchamp()
        {
            if (txtnom.Text == string.Empty)
            {
                return "Saisis le nom de l'utilisateur";
            }

            if (txtmtp.Text == string.Empty)
            {
                return "Saisis le mot de passe";
            }
            if (txtconfmtp.Text == string.Empty)
            {
                return "Confirmer le mot de passe";
            }
            //if (txtconfmtp.Text != txtconfmtp.Text)
            //{
            //    return "Confirmer le mot de passe";
            //}

            return null;
        }
        private void viderchamp()
        {
            txtnom.Clear();
            txtmtp.Clear();
            txtconfmtp.Clear();
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FRM_Utilisateur_Load(object sender, EventArgs e)
        {
           
            try
            {
                ChargerData(new Utilisateur());
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
        private void modifierutilisateur()
        {
            int i;
            i = dvgutilisateur.CurrentRow.Index;
            txtId.Text = dvgutilisateur["id", i].Value.ToString();
            txtnom.Text = dvgutilisateur["nom_user", i].Value.ToString();
            txtmtp.Text = dvgutilisateur["mot_de_passe", i].Value.ToString();
            txtconfmtp.Text = dvgutilisateur["mot_de_passe", i].Value.ToString();
            txtnom.Enabled = false;
            txtmtp.Enabled = false;
            txtconfmtp.Enabled = false;

        }

        private void dvgutilisateur_DoubleClick(object sender, EventArgs e)
        {
            modifierutilisateur();
            activerbtn();
        }

        private void AjoutModifierUtilisateur()
        {
            try
            {
                if (verifierchamp() != null)
                {
                    MessageBox.Show(verifierchamp(), "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtmtp.Text != txtconfmtp.Text)
                    {
                        MessageBox.Show("Mots de passe differents", "Enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtmtp.Text = "";
                        txtconfmtp.Text = "";
                    }
                    else
                    {
                        IUtilisateur utilisateur = new Utilisateur();
                        utilisateur.Id = Convert.ToInt32(txtId.Text);
                        utilisateur.Nom_user = txtnom.Text;
                        utilisateur.Mot_de_passe = txtmtp.Text;
                        utilisateur.Enregistrer(utilisateur);
                        ChargerData(utilisateur);
                        MessageBox.Show(" enregistrer avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiserId();
                        viderchamp();
                        txtnom.Enabled = true;
                        txtmtp.Enabled = true;
                        txtconfmtp.Enabled = true;
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
        private void initialiserId()
        {
            IUtilisateur utilisateur = new Utilisateur();
            txtId.Text = utilisateur.Nouveau().ToString();
        }

        private void SupprimerUtilisateur()
        {
            int i; int id;
            i = dvgutilisateur.CurrentRow.Index;
            id = (int)dvgutilisateur["id", i].Value;
            if (id == 0)
            {
                MessageBox.Show("Doubler Cliquez sur la ligne à supprimer");
            }
            else
            {
                try
                {
                    DialogResult q = MessageBox.Show("Voulez vous vraiment supprimer l'utilisateur", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (q == DialogResult.Yes)
                    {
                        IUtilisateur utilisateur = new Utilisateur();

                        utilisateur.Id = id;

                        utilisateur.Supprimer(utilisateur.Id);

                        ChargerData(utilisateur);

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

        private void txtrech_TextChanged(object sender, EventArgs e)
        {
            if (txtrech.Text != string.Empty)
            {
                IAdresse adr = new Adresse();
                dvgutilisateur.DataSource = adr.RechercherAdresse(txtrech.Text);
            }
            else
            {
                ChargerData(new Utilisateur());
            }
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            SupprimerUtilisateur();
        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            AjoutModifierUtilisateur();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            initialiserId();
            viderchamp();
            desactiverbtn();
            txtnom.Enabled = true;
            txtmtp.Enabled = true;
            txtconfmtp.Enabled = true;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
