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
using System.Xml.Linq;
using GestionClasseLib;

namespace GestionGUI
{
    public partial class FRM_AjouterPersonne : Form
    {
        private UserControl user;
        public FRM_AjouterPersonne(UserControl user)
        {
            InitializeComponent();
            this.user = user;
            initialiserId();
            // Charger les Sexes
            chargercomboSexe();
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

            if (cbxSexe.SelectedIndex == -1)
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
            cbxSexe.SelectedIndex = -1;
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            (user as UserPersonne).desactiverbtn();
            this.Close();
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
                    IPersonne personne = new Personne();
                    personne.Id = Convert.ToInt32(txtcode.Text);
                    personne.Nom = txtnom.Text;
                    personne.Postnom = txtpostnom.Text;
                    personne.Prenom = txtprenom.Text;
                    personne.Sex = cbxSexe.Text.Equals(sexe.Masculin.ToString()) ? sexe.Masculin : sexe.Féminin;
                    personne.Enregistrer(personne);
                    (user as UserPersonne).ChargerData(personne);
                    
                    if (txttitre.Text != "Modifier Personne")
                    {
                        MessageBox.Show("Personne enregistrer avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        initialiserId();
                        viderchamp();
                    }
                    else
                    {
                        MessageBox.Show("Information modifiée avec succes !!!", "Enregistrement personne", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        (user as UserPersonne).desactiverbtn();
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

        private void FRM_AjouterPersonne_Load(object sender, EventArgs e)
        {

            
        }

        private void chargercomboSexe()
        {
            cbxSexe.DataSource = Enum.GetNames(typeof(sexe));
            cbxSexe.SelectedIndex = 0;
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
