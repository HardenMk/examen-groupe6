using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionClasseLib;
using GestionDeLaConnexion;
using System.Data.SqlClient;


namespace GestionGUI
{
    public partial class UserPersonne : UserControl
    {
        private static UserPersonne userA;
        private BindingSource bdsrc1 = new BindingSource();

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
        public void ChargerData(IPersonne personne)
        {
            List<IPersonne> lst = new List<IPersonne>();
            lst = personne.Personnes();

            bdsrc1.DataSource = lst;
            dgvPersonne.DataSource = bdsrc1;
            toollabelnbrgridvieuw.Text = dgvPersonne.Rows.Count.ToString();

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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnlrecette_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnajout_Click(object sender, EventArgs e)
        {
            FRM_AjouterPersonne frm = new FRM_AjouterPersonne(this);
            frm.ShowDialog();
        }

        private void UserPersonne_Load(object sender, EventArgs e)
        {
           
            desactiverbtn();
            toollabelnbrgridvieuw.Text = dgvPersonne.Rows.Count.ToString();
            toollabelnumero.Text = chargertoolnumero();
            try
            {
                ChargerData(new Personne());
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

        private string chargertoolnumero()
        {
            if (dgvPersonne.Rows.Count > 0)
            {
                int i = dgvPersonne.CurrentRow.Index + 1;
                return i.ToString();
            }
            return "0";
        }
        private void btnsupp_Click(object sender, EventArgs e)
        {
            SupprimerPersonne();
        }

        private void SupprimerPersonne()
        {
            int i; int id;
            i = dgvPersonne.CurrentRow.Index;
            id = (int)dgvPersonne["id", i].Value;
            if (id == 0)
            {
                MessageBox.Show("Doubler Cliquez sur la ligne à supprimer");
            }
            else
            {
                try
                {
                    DialogResult q = MessageBox.Show("Voulez vous vraiment supprimer la personne", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (q == DialogResult.Yes)
                    {
                        IPersonne personne = new Personne();

                        personne.Id = id;

                        personne.Supprimer(personne.Id);

                        ChargerData(personne);

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

        private void dgvPersonne_DoubleClick(object sender, EventArgs e)
        {
            activerbtn();
        }

        private void dgvPersonne_Click(object sender, EventArgs e)
        {
            toollabelnumero.Text = chargertoolnumero();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            modifierpersonne();
        }

        private void modifierpersonne()
        {
            FRM_AjouterPersonne frm = new FRM_AjouterPersonne(this);
            frm.txttitre.Text = "Modifier Personne";
            int i;
            i = dgvPersonne.CurrentRow.Index;
            frm.txtcode.Text = dgvPersonne["id", i].Value.ToString();
            frm.txtnom.Text = dgvPersonne["Nom", i].Value.ToString();
            frm.txtpostnom.Text = dgvPersonne["Postnom", i].Value.ToString();
            frm.txtprenom.Text = dgvPersonne["Prenom", i].Value.ToString();
            frm.cbxSexe.Text = dgvPersonne["sex", i].Value.ToString();
            frm.ShowDialog();
        }

        private void couperToolStripButton_Click(object sender, EventArgs e)
        {
            SupprimerPersonne();
        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            btnajout_Click(sender, e);
        }

        private void copierToolStripButton_Click(object sender, EventArgs e)
        {
            modifierpersonne();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtrech.Text != string.Empty)
            {
                IPersonne pers = new Personne();
                dgvPersonne.DataSource = pers.RechercherPersonne(txtrech.Text);
                toollabelnbrgridvieuw.Text = dgvPersonne.Rows.Count.ToString();
            }
            else
            {
                ChargerData(new Personne());
            }
        }

        private void imprimerToolStripButton_Click(object sender, EventArgs e)
        {
          FRM_Principal.ChargerRapportViewer("sp_select_personnes", "Rpt_liste_personnes.rdlc");
        }
    }
}
