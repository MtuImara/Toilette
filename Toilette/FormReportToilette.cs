using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing.Imaging;
using Microsoft.Reporting.WinForms;

namespace Toilette
{
    public partial class FormReportToilette : Form
    {
        public FormReportToilette()
        {
            InitializeComponent();


            reportToutesToilettes(); //appel fonction
        }

        private void FormReportToilette_Load(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// /fonction et bouton d'inventaire de toutes les toilettes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        public void reportToutesToilettes()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "SELECT numero, site, etat, prix, type FROM toilette  ";

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetToilet dsV = new DataSetToilet();

                md.Fill(dsV, "DataTableT");

                ReportDataSource source = new ReportDataSource("DataSetToi", dsV.Tables[0]);

                this.reportViewerToilette.LocalReport.DataSources.Clear();
                this.reportViewerToilette.LocalReport.DataSources.Add(source);
                this.reportViewerToilette.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAfficheToutesToilettes_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "SELECT numero, site, etat, prix, type FROM toilette  ";

                //string requete = "SELECT * FROM  retour WHERE dateRetour BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "' ";

                //multiple requette
                if (comboBoxType.Text != "")
                {
                    requete += " WHERE type='" + comboBoxType.Text + "'";
                }
                    


                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetToilet dsV = new DataSetToilet();

                md.Fill(dsV, "DataTableT");

                ReportDataSource source = new ReportDataSource("DataSetToi", dsV.Tables[0]);

                this.reportViewerToilette.LocalReport.DataSources.Clear();
                this.reportViewerToilette.LocalReport.DataSources.Add(source);
                this.reportViewerToilette.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
