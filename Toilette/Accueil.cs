using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

namespace Toilette
{
    public partial class Accueil : Form
    {
        public Accueil(string Datas)
        {
            InitializeComponent();

            richTextBoxLoginUser.Text = Datas;//appel du login de l'utilisateur a partir du form d'authentification

            fonctionRapportGraphCaisse(); //appel f(x) graph caisse
        }


        //minimisation du menu par le btn
        private void minimisationForm(object sender, EventArgs e)
        {
            if (panelMenuVertical.Width == 213)
            {
                panelMenuVertical.Width = 60;
            }
            else
            {
                panelMenuVertical.Width = 213;
            }
        }


        //***************************************************************************
        //fonction d'appel du form en system MVC
        private void appelForm(object Formhijo)
        {
            if (this.panelTableauDeBord.Controls.Count > 0)
                this.panelTableauDeBord.Controls.RemoveAt(0);

            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelTableauDeBord.Controls.Add(fh);
            this.panelTableauDeBord.Tag = fh;
            fh.Show();

        }



        //***************************************************************************

        //***************************************************************************
        //boutons pour l'appel des forms

        private void buttonToilette_Click(object sender, EventArgs e)
        {
            appelForm(new toilette(richTextBoxLoginUser.Text));
        }

        private void buttonCaisse_Click(object sender, EventArgs e)
        {
            appelForm(new Caisse(richTextBoxLoginUser.Text));
        }

        private void buttonSite_Click(object sender, EventArgs e)
        {
            appelForm(new Site(richTextBoxLoginUser.Text));
        }

        private void buttonDepense_Click(object sender, EventArgs e)
        {
            appelForm(new Depense(richTextBoxLoginUser.Text));
        }

        private void buttonUtilisateur_Click(object sender, EventArgs e)
        {
            appelForm(new Personnel(richTextBoxLoginUser.Text));
        }

        private void buttonInventProduit_Click(object sender, EventArgs e)
        {
            appelForm(new FormReportToilette());
        }

        private void Accueil_Load(object sender, EventArgs e)
        {

        }

        private void buttonInventVente_Click(object sender, EventArgs e)
        {
            appelForm(new FormReportCaisse());
            //appelForm(new FormRapportCaisseEtDepense());
        }
        private void buttonAccueil_Click(object sender, EventArgs e)
        {
            // appelForm(new panelTableauDeBord);
            appelForm(new Dashboard());
        }
        private void BoutonDepense_Click(object sender, EventArgs e)
        {
            appelForm(new FormReportDepense());
        }

        //fonction Graphique caisse
        public void fonctionRapportGraphCaisse()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "SELECT numero, montant, date_heure, sorte, montant_sortie FROM caisse,depense   ";

                
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetCaisse dsV = new DataSetCaisse();

                md.Fill(dsV, "DataTableCaiss");

                ReportDataSource source = new ReportDataSource("DataSetGraphMeilleureToilette", dsV.Tables[0]);

                this.reportViewerCaisse.LocalReport.DataSources.Clear();
                this.reportViewerCaisse.LocalReport.DataSources.Add(source);
                this.reportViewerCaisse.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // fermeture de la session
        private void buttonFermetureApp_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login ac = new Login();
            ac.Show();
        }

        private void panelTableauDeBord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonInventaire_Click(object sender, EventArgs e)
        {
            panelSousMenu.Visible = true;
        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            panelSousMenu.Visible = false;
        }
    }
}
