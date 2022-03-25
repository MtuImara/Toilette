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
    public partial class FormReportCaisse : Form
    {
        public FormReportCaisse()
        {
            InitializeComponent();

            fonctionAMultipleRapport();//appel fonction affiche report

            afficherAgenceComboBoxNumToilette();//appel fonction affiche comboBox Nom du site
            afficherAgenceComboBoxUser();//appel fonction affiche comboBox Nom du User
        }

        private void FormReportCaisse_Load(object sender, EventArgs e)
        {

            this.reportViewerCaisse.RefreshReport();
        }


        

        //fonction affiche User comboBox
        public void afficherAgenceComboBoxUser()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM utilisateur";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    comboBoxUser.Items.Add(lire.GetString("login"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //fonction affiche numero toilette comboBox
        public void afficherAgenceComboBoxNumToilette()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM toilette";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    comboBoxNomToilette.Items.Add(lire.GetString("numero"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        public void fonctionAMultipleRapport()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "SELECT numero, montant, date_heure, user, sorte FROM caisse WHERE date_heure BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "'  ";
                
                //multiple requette
                if (comboBoxUser.Text != "")
                {
                    requete += " AND user='" + comboBoxUser.Text + "'";
                }

                if (comboBoxNomToilette.Text != "")
                {
                    requete += "AND numero='" + comboBoxNomToilette.Text + "'";
                }

                if (comboBoxNomToilette.Text != "")
                {
                    requete += " AND user='" + comboBoxUser.Text + "' AND numero='" + comboBoxNomToilette.Text + "'";
                }



                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetCaisse dsV = new DataSetCaisse();

                md.Fill(dsV, "DataTableCaiss");

                ReportDataSource source = new ReportDataSource("DataSetCaisse", dsV.Tables[0]);

                this.reportViewerCaisse.LocalReport.DataSources.Clear();
                this.reportViewerCaisse.LocalReport.DataSources.Add(source);
                this.reportViewerCaisse.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // bouton report
        private void buttonAfficheToutesToilettes_Click(object sender, EventArgs e)
        {
            fonctionAMultipleRapport();//appel fonction A multiple rapport
        }
    }
}
