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
    public partial class UserDomicile : UserControl
    {
        private static UserDomicile userA;
        private BindingSource bdsrc1 = new BindingSource();
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
            FRM_AjouterDomicile frm = new FRM_AjouterDomicile(this);
            frm.ShowDialog();
        }
        public void ChargerData(IDomicile domicile)
        {
            List<IDomicile> lst = new List<IDomicile>();
            IPersonne persphone = new Personne();
            IAdresse adresse = new Adresse();
            lst = domicile.Domiciles();

            dvgdomicile.Rows.Clear();
            foreach (IDomicile d in lst)
            {
                persphone = persphone.OnePersonne(d.id_personne);
                adresse = adresse.OneAdresse(d.id_adresse);
                dvgdomicile.Rows.Add(d.Id, persphone.Nom, persphone.Postnom, persphone.Prenom, adresse.ville + " Q." + adresse.quartier + " Av." + d
                    .avenue + " N°" + d.numero_domicile, persphone.NomComplet, d.avenue, d.numero_domicile, adresse.AdresseComplet);

            }
            toollabelnbrgridvieuw.Text = dvgdomicile.Rows.Count.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            FRM_Adresse frm = new FRM_Adresse(new FRM_AjouterDomicile(this));
            frm.ShowDialog();
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

        private void UserDomicile_Load(object sender, EventArgs e)
        {
           
            try
            {
                desactiverbtn();
                ChargerData(new domicile());
                toollabelnbrgridvieuw.Text = dvgdomicile.Rows.Count.ToString();
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
            if (dvgdomicile.Rows.Count > 0)
            {
                int i = dvgdomicile.CurrentRow.Index + 1;
                return i.ToString();
            }
            return "0";
        }

        private void supprimerDomicile()
        {
            int i; int id;
            i = dvgdomicile.CurrentRow.Index;
            id = (int)dvgdomicile["id", i].Value;
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
                        IDomicile dom = new domicile();

                        dom.Id = id;

                        dom.Supprimer(dom.Id);

                        ChargerData(dom);

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

        private void dvgdomicile_DoubleClick(object sender, EventArgs e)
        {
            activerbtn();
        }

        private void dvgdomicile_Click(object sender, EventArgs e)
        {
            toollabelnumero.Text = chargertoolnumero();
        }

        private void modifierdomicile()
        {

            FRM_AjouterDomicile frm = new FRM_AjouterDomicile(this);
            frm.txttitre.Text = "Modifier Domicile";
            int i;
            i = dvgdomicile.CurrentRow.Index;
            frm.txtId.Text = dvgdomicile["Id", i].Value.ToString();
            frm.cbxPersonne.Text = dvgdomicile["nomComplet", i].Value.ToString();
            frm.cbxAdresse.Text = dvgdomicile["adressecomplet", i].Value.ToString();
            frm.txtavenue.Text = dvgdomicile["Avenue", i].Value.ToString();
            frm.txtnumeroavenue.Text = dvgdomicile["numeroavenue", i].Value.ToString();
            frm.ShowDialog();
        }

        public void RechercherTelephone(String txtrech)
        {
            List<ITelephone> lst = new List<ITelephone>();
            string req = "select t.id,t.id_proprietaire,t.initial,t.numero from telephone t inner join personne p on t.id_proprietaire=p.id where nom like '%" + txtrech + "%' or postnom like '%" + txtrech + "%' or prenom like '%" + txtrech + "%' order by id asc";

            ImplementerConnexion.connectioncreer();
            using (SqlCommand cmd = ImplementerConnexion.con.CreateCommand())
            {
                cmd.CommandText = req;
                cmd.CommandType = CommandType.Text;
                IDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    lst.Add(GetPhone(rd));
                }

                rd.Dispose();
            }

            dvgdomicile.Rows.Clear();
            foreach (ITelephone t in lst)
            {
                IPersonne persphone = new Personne();
                persphone = persphone.OnePersonne(t.Id_proprietaire);
                dvgdomicile.Rows.Add(t.Id, persphone.Nom, persphone.Postnom, persphone.Prenom, t.NumeroComplet, persphone.NomComplet, t.Initial, t.Numero);

            }
            toollabelnbrgridvieuw.Text = dvgdomicile.Rows.Count.ToString();

        }
        private ITelephone GetPhone(IDataReader rd)
        {
            ITelephone telephone = new Telephone();

            telephone.Id = int.Parse(rd["id"].ToString());
            telephone.Id_proprietaire = Convert.ToInt32(rd["id_proprietaire"].ToString());
            telephone.Initial = rd["initial"].ToString();
            telephone.Numero = rd["numero"].ToString();

            return telephone;
        }

        private void btnsupp_Click(object sender, EventArgs e)
        {
            supprimerDomicile();
        }

        private void couperToolStripButton_Click(object sender, EventArgs e)
        {
            supprimerDomicile();
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            modifierdomicile();
        }

        private void copierToolStripButton_Click(object sender, EventArgs e)
        {
            modifierdomicile();
        }

        private void enregistrerToolStripButton_Click(object sender, EventArgs e)
        {
            btnajout_Click(sender, e);
        }

        private void txtrech_TextChanged(object sender, EventArgs e)
        {
            if (txtrech.Text != string.Empty)
            {
                rechercherDomicile(new domicile(), txtrech.Text);
            }
            else
            {
                ChargerData(new domicile());
            }
        }
        private void rechercherDomicile(IDomicile domicile, string txtrech)
        {
            List<IDomicile> lst = new List<IDomicile>();
            IPersonne persphone = new Personne();
            IAdresse adresse = new Adresse();
            lst = domicile.RechercherDomicile(txtrech);

            dvgdomicile.Rows.Clear();
            foreach (IDomicile d in lst)
            {
                persphone = persphone.OnePersonne(d.id_personne);
                adresse = adresse.OneAdresse(d.id_adresse);
                dvgdomicile.Rows.Add(d.Id, persphone.Nom, persphone.Postnom, persphone.Prenom, adresse.ville + " Q." + adresse.quartier + " Av." + d
                    .avenue + " N°" + d.numero_domicile, persphone.NomComplet, d.avenue, d.numero_domicile, adresse.AdresseComplet);

            }
            toollabelnbrgridvieuw.Text = dvgdomicile.Rows.Count.ToString();
        }

        private void imprimerToolStripButton_Click(object sender, EventArgs e)
        {
            FRM_Principal.ChargerRapportViewer("sp_liste_personneDomicile", "Rpt_liste_personneAdresses.rdlc");

        }
    }
}
