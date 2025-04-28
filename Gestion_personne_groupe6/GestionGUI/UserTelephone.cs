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
    public partial class UserTelephone: UserControl
    {
        private static UserTelephone userA;
        private BindingSource bdsrc1 = new BindingSource();

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
        public void ChargerData(ITelephone telephone)
        {
            List<ITelephone> lst = new List<ITelephone>();
            IPersonne persphone = new Personne();
            lst = telephone.Telephones();

            dvgphone.Rows.Clear();
            foreach (ITelephone t in lst)
            {
                persphone = persphone.OnePersonne(t.Id_proprietaire);
                dvgphone.Rows.Add(t.Id,persphone.Nom,persphone.Postnom,persphone.Prenom,t.NumeroComplet,persphone.NomComplet,t.Initial,t.Numero);
              
            }
            toollabelnbrgridvieuw.Text = dvgphone.Rows.Count.ToString();

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

        private void btnajout_Click(object sender, EventArgs e)
        {
            FRM_AjouterTelephone frm = new FRM_AjouterTelephone(this);
            frm.ShowDialog();
        }

        private void pnlrecette_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserTelephone_Load(object sender, EventArgs e)
        {
           
            try
            {
                desactiverbtn();
                ChargerData(new Telephone());
                toollabelnbrgridvieuw.Text = dvgphone.Rows.Count.ToString();
                toollabelnumero.Text = chargertoolnumero();
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
            if (dvgphone.Rows.Count > 0)
            {
                int i = dvgphone.CurrentRow.Index + 1;
                return i.ToString();
            }
            return "0";
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            supprimerTelephone();

        }
        private void supprimerTelephone()
        {
            int i; int id;
            i = dvgphone.CurrentRow.Index;
            id = (int)dvgphone["id", i].Value;
            if (id == 0)
            {
                MessageBox.Show("Doubler Cliquez sur la ligne à supprimer");
            }
            else
            {
                try
                {
                    DialogResult q = MessageBox.Show("Voulez vous vraiment supprimer le numero", "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (q == DialogResult.Yes)
                    {
                        ITelephone phone = new Telephone();

                        phone.Id = id;

                        phone.Supprimer(phone.Id);

                        ChargerData(phone);

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

        private void dvgphone_DoubleClick(object sender, EventArgs e)
        {
            activerbtn();
        }

        private void dvgphone_Click(object sender, EventArgs e)
        {
            toollabelnumero.Text = chargertoolnumero();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            modifiertelephone();
        }
        private void modifiertelephone()
        {
            
            FRM_AjouterTelephone frm = new FRM_AjouterTelephone(this);
            frm.txttitre.Text = "Modifier Numero";
            int i;
            i = dvgphone.CurrentRow.Index;
            frm.txtId.Text = dvgphone["id", i].Value.ToString();
            frm.cbxpersonne.Text= dvgphone["nomComplet", i].Value.ToString();
            frm.txtinitial.Text = dvgphone["initial", i].Value.ToString();
            frm.txtnumero.Text = dvgphone["numero", i].Value.ToString();
            frm.ShowDialog();
        }

        private void couperToolStripButton_Click(object sender, EventArgs e)
        {
            supprimerTelephone();

        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            btnajout_Click(sender, e);
        }

        private void copierToolStripButton_Click(object sender, EventArgs e)
        {
            modifiertelephone();
        }

        private void txtrech_TextChanged(object sender, EventArgs e)
        {
            if (txtrech.Text != string.Empty)
            {
                rechercherTelephone(new Telephone(),txtrech.Text);
            }
            else
            {
                ChargerData(new Telephone());
            }
        }

        private void rechercherTelephone(ITelephone telephone,string txtrech)
        {
            List<ITelephone> lst = new List<ITelephone>();
            lst = telephone.RechercherTelephone(txtrech);
            dvgphone.Rows.Clear();
            foreach (ITelephone t in lst)
            {
                IPersonne persphone = new Personne();
                persphone = persphone.OnePersonne(t.Id_proprietaire);
                dvgphone.Rows.Add(t.Id, persphone.Nom, persphone.Postnom, persphone.Prenom, t.NumeroComplet, persphone.NomComplet, t.Initial, t.Numero);

            }
            toollabelnbrgridvieuw.Text = dvgphone.Rows.Count.ToString();
            // RechercherTelephone(txtrech.Text);
            toollabelnbrgridvieuw.Text = dvgphone.Rows.Count.ToString();
        }

        private void imprimerToolStripButton_Click(object sender, EventArgs e)
        {
           FRM_Principal.ChargerRapportViewer("sp_liste_personnes", "Rpt_liste_personneTelephone.rdlc");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
