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
    public partial class FormReportDepense : Form
    {
        public FormReportDepense()
        {
            InitializeComponent();

            fonctionAMultipleRapport(); // appel de la fonction report
        }

        private void FormReportDepense_Load(object sender, EventArgs e)
        {

        }


        public void fonctionAMultipleRapport()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "SELECT montant_sortie , nom_utilisateur , motif , date_sortie , user FROM depense WHERE date_sortie BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "'  ";

                //multiple requette
                if (comboBoxUser.Text != "")
                {
                    requete += " AND user='" + comboBoxUser.Text + "'";
                }

                if (comboBoxNomSite.Text != "")
                {
                    //requete += "AND numero='" + comboBoxNomSite.Text + "'";
                }

                if (comboBoxNomSite.Text != "")
                {
                   // requete += " AND user='" + comboBoxUser.Text + "' AND numero='" + comboBoxNomSite.Text + "'";
                }



                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetDepense dsV = new DataSetDepense();

                md.Fill(dsV, "DataTableDepense");

                ReportDataSource source = new ReportDataSource("DataSetDepense", dsV.Tables[0]);

                this.reportViewerDepense.LocalReport.DataSources.Clear();
                this.reportViewerDepense.LocalReport.DataSources.Add(source);
                this.reportViewerDepense.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAfficheToutesToilettes_Click(object sender, EventArgs e)
        {
            fonctionAMultipleRapport();
        }
    }
}
