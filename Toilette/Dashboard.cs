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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            fonctionRapportGraphCaisse(); //appel f(x) graph caisse
        }

        private void panelTableauDeBord_Paint(object sender, PaintEventArgs e)
        {

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
    }
}
