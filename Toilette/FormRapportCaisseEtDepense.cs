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
    public partial class FormRapportCaisseEtDepense : Form
    {
        public FormRapportCaisseEtDepense()
        {
            InitializeComponent();


            fonctionRapportCaisse();//appel foction
            //fonctionRapportDepense();//appel foction
        }

        private void FormRapportCaisseEtDepense_Load(object sender, EventArgs e)
        {
            this.reportViewerCaisseDense.RefreshReport();
        }


        //fonction caisse
        public void fonctionRapportCaisse()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                //string requete = "SELECT numero, montant, date_heure, sorte, montant_sortie FROM caisse,depense WHERE date_heure BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "' AND date_sortie BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "'  ";
                //string requete = "SELECT numero, montant, date_heure, sorte, montant_sortie FROM caisse,depense   ";
                string requete = "SELECT SUM(montant) AS montant, SUM(montant_sortie) AS montant_sortie FROM caisse,depense ";
                //string requete = "SELECT numero, montant, date_heure, sorte, montant_sortie FROM caisse,depense ";

                /*    //multiple requette
                        if (comboBoxUser.Text != "")
                        {
                            requete += " AND user='" + comboBoxUser.Text + "'";
                        }

                        if (comboBoxNomSite.Text != "")
                        {
                            requete += "AND numero='" + comboBoxNomSite.Text + "'";
                        }

                        if (comboBoxNomSite.Text != "")
                        {
                            requete += " AND user='" + comboBoxUser.Text + "' AND numero='" + comboBoxNomSite.Text + "'";
                        }
                */


                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetCaisseEtDepense dsV = new DataSetCaisseEtDepense();

                md.Fill(dsV, "DataTableCaisseD");

                ReportDataSource source = new ReportDataSource("DataSetCaisseD", dsV.Tables[0]);

                this.reportViewerCaisseDense.LocalReport.DataSources.Clear();
                this.reportViewerCaisseDense.LocalReport.DataSources.Add(source);
                this.reportViewerCaisseDense.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //fonction depense
        public void fonctionRapportDepense()
        {
            
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                //string requete = "SELECT numero, montant, date_heure, montantRetourne, user FROM caisse WHERE date_heure BETWEEN '" + dateDebut.Text + "' AND '" + dateFin.Text + "'  ";
                string requete = "SELECT SUM(montant_sortie) AS montant_sortie FROM depense ";

            /*    //multiple requette
                if (comboBoxUser.Text != "")
                {
                    requete += " AND user='" + comboBoxUser.Text + "'";
                }

                if (comboBoxNomSite.Text != "")
                {
                    requete += "AND numero='" + comboBoxNomSite.Text + "'";
                }

                if (comboBoxNomSite.Text != "")
                {
                    requete += " AND user='" + comboBoxUser.Text + "' AND numero='" + comboBoxNomSite.Text + "'";
                }
        
             */

                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);


                DataSetCaisseEtDepense dsV = new DataSetCaisseEtDepense();

                md.Fill(dsV, "DataTableCaisseD");
                md.Fill(dsV, "DataTableDepenseC");

                ReportDataSource sourceD = new ReportDataSource("DataSetCaisseD", dsV.Tables[0]);
                //this.reportViewerCaisseDense.Reset();
                this.reportViewerCaisseDense.LocalReport.DataSources.Clear();
                this.reportViewerCaisseDense.LocalReport.DataSources.Add(sourceD);
                this.reportViewerCaisseDense.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void buttonAfficheToutesToilettes_Click(object sender, EventArgs e)
        {
            fonctionRapportCaisse();//appel foction
        }
    }
}
