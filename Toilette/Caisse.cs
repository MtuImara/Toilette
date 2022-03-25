using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Toilette
{
    public partial class Caisse : Form
    {
        public Caisse(string Datas)
        {
            InitializeComponent();

            textBoxUser.Text = Datas; //passation des donnees de l'utilisateur

            afficherToilette(""); //appel fonction affichage des toilette
            afficherCaisse(""); //appel fonction affichage de la caisse
        }






        //***********************************************************************
        //***********************************************************************
        //fonctio et bouton de nettoyage
        public void nettoyage()
        {
            textBoxRecherche.Text = "";
            textBoxNumeroToilette.Text = "";
            comboBoxNomSite.Text = "";
            textBoxPrix.Text = "";
            comboBoxSituation.Text = "";
            textBoxNumToiletteR.Text = "";
            textBoxCaisseR.Text = "";
            textBoxMontantR.Text = "";
            textBoxIDToilette.Text = "";
            textBoxIDCaisse.Text = "";
            comboBoxSorte.Text = "";
            textBoxType.Text = "";

        }
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyage();
        }


        //***********************************************************************
        //***********************************************************************
        //fonction d'affichage
        public void afficherToilette(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM toilette WHERE CONCAT(numero,site,etat) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewToilette.AllowUserToAddRows = false;
                dataGridViewToilette.DataSource = dt;
                dataGridViewToilette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //fonction event CLICK pour remplir le form a partir de DatagridView Toilette
        private void eventRemplissageFormsDatagrid(object sender, EventArgs e)
        {
            textBoxIDToilette.Text = dataGridViewToilette.CurrentRow.Cells[0].Value.ToString();
            textBoxNumeroToilette.Text = dataGridViewToilette.CurrentRow.Cells[1].Value.ToString();
            comboBoxNomSite.Text = dataGridViewToilette.CurrentRow.Cells[2].Value.ToString();
            comboBoxSituation.Text = dataGridViewToilette.CurrentRow.Cells[3].Value.ToString();
            textBoxPrix.Text = dataGridViewToilette.CurrentRow.Cells[4].Value.ToString();
            textBoxType.Text = dataGridViewToilette.CurrentRow.Cells[5].Value.ToString();
            comboBoxSorte.Text = dataGridViewToilette.CurrentRow.Cells[7].Value.ToString();
        }


        //***********************************************************************
        //***********************************************************************
        //fonction d'affichage caisse
        public void afficherCaisse(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM caisse WHERE CONCAT(numero) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewCaisse.AllowUserToAddRows = false;
                dataGridViewCaisse.DataSource = dt;
                dataGridViewCaisse.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //fonction event CLICK pour remplir le form a partir de DatagridView Caisse
        private void eventRemplissageFormsDatagridCaisse(object sender, EventArgs e)
        {
            textBoxIDCaisse.Text = dataGridViewCaisse.CurrentRow.Cells[0].Value.ToString();
            textBoxNumToiletteR.Text = dataGridViewCaisse.CurrentRow.Cells[1].Value.ToString();
            textBoxMontantR.Text = dataGridViewCaisse.CurrentRow.Cells[2].Value.ToString();
            dateEnregistrement.Text = dataGridViewCaisse.CurrentRow.Cells[3].Value.ToString();
            textBoxCaisseR.Text = dataGridViewCaisse.CurrentRow.Cells[4].Value.ToString();
            textBoxSommeR.Text = dataGridViewCaisse.CurrentRow.Cells[5].Value.ToString();
            textBoxUser.Text = dataGridViewCaisse.CurrentRow.Cells[6].Value.ToString();


        }



        private void rechercheDonnee(object sender, EventArgs e)
        {
            afficherToilette(textBoxRecherche.Text); //appel fonction affichage des toilette
            afficherCaisse(textBoxRecherche.Text); //appel fonction affichage de la caisse
        }




        //***********************************************************************
        //***********************************************************************
        //fonction d'Ajout a la caisse, fonction modification de la situation de la toilette et bouton d'Ajout a la caisse

        public void ajoutCaisse()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO caisse(numero,montant,montantRetourne,user,sorte) VALUES('" + this.textBoxNumeroToilette.Text + "','" + this.textBoxPrix.Text + "',0,'"+this.textBoxUser.Text+ "','" + this.comboBoxSorte.Text + "')";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("montant bien enregistrée");

                while (lire.Read())
                {
                    connection.Close();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Votre Base de donnée n'est pas connée à l'application", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }


        //***************************************************************************************
        //fonction et bouton de modification Toilette
        public void fonctionModificationToilette()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE toilette SET etat='Occupee' WHERE id_toilette ='" + textBoxIDToilette.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //bouton ajout caisse
        private void buttonAjoutCaisse_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroToilette.Text != "" && comboBoxNomSite.Text != "" && textBoxPrix.Text != "" && comboBoxSituation.Text != "" && textBoxIDToilette.Text != "" && comboBoxSorte.Text != "")
            {
                if(comboBoxSituation.Text!="Occupee")
                {
                    ajoutCaisse();
                    fonctionModificationToilette();


                    fonctionImprimer();//appel fonction d'impression

                    nettoyage();//appel fonction de nettoyage forms
                    afficherToilette(""); //appel fonction affichage des toilette
                    afficherCaisse(""); //appel fonction affichage de la caisse
                }
                else
                {
                    MessageBox.Show("Cette Toilette est encore Occupée, veillez vérifier sinon libérez la en cliquant sur le bouton Libérer", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                MessageBox.Show("Veillez bien remplir tous les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }





        //***********************************************************************
        //***********************************************************************
        //fonction et bouton de liération d'une toilette

        public void libererToilette()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE toilette SET etat='Libre' WHERE id_toilette ='" + textBoxIDToilette.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Vous avez Libérez cette Toilette");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //bouton liberation de la toilette
        private void buttonLibererToilette_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroToilette.Text != "" && comboBoxNomSite.Text != "" && textBoxPrix.Text != "" && comboBoxSituation.Text != "" && textBoxIDToilette.Text != "")
            {
                if (comboBoxSituation.Text != "Libre")
                {

                    libererToilette();


                    nettoyage();//appel fonction de nettoyage forms
                    afficherToilette(""); //appel fonction affichage des toilette
                    afficherCaisse(""); //appel fonction affichage de la caisse
                }
                else
                {
                    MessageBox.Show("Cette Toilette est déjà Libre", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Veillez bien remplir tous les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        //***********************************************************************
        //***********************************************************************
        //fonction et bouton de retour en cas d'echec d'ajout a la caisse

        public void fonctionEchec()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE caisse SET montant = 0, montantRetourne ='" + textBoxMontantR.Text + "',user='"+textBoxUser.Text+"' WHERE id_caisse ='" + textBoxIDCaisse.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Opération réussie");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //***********************************************************************
        //fonction de libération d'une toilette

        public void libererToiletteApresEchec()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE toilette SET etat='Libre' WHERE numero ='" + textBoxNumToiletteR.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        //bouton retour
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            if (textBoxNumToiletteR.Text != "" && textBoxMontantR.Text != "" && textBoxIDCaisse.Text != "")
            {
                if(textBoxSommeR.Text != "0")
                {
                    MessageBox.Show("Ce Retour a été Effectué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    fonctionEchec();
                    libererToiletteApresEchec();


                    nettoyage();//appel fonction de nettoyage forms
                    afficherToilette(""); //appel fonction affichage des toilette
                    afficherCaisse(""); //appel fonction affichage de la caisse

                }



            }
            else
            {
                MessageBox.Show("Veillez bien remplir tous les champs ou bien ce Retour a été Effectué", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }








        //**************************************************************************************************
        //**************************************************************************************************
        //**************************************************************************************************
        //fonction event Print_Page de print_Document
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("ETS KATHOS", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            e.Graphics.DrawString(" "+ dateEnregistrement.Text, new Font("Times New Roman", 11, FontStyle.Regular), Brushes.Black, new Point(150, 10));
            e.Graphics.DrawString(" " + dateTimeE.Text, new Font("Times New Roman", 11, FontStyle.Regular), Brushes.Black, new Point(250, 10));
            e.Graphics.DrawString("CD/LUSHI/RCCM/18-A-00429", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(10, 30));
            e.Graphics.DrawString("Caissier(ère) : " + textBoxUser.Text , new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(10, 50));


            e.Graphics.DrawString("------------------------------------------------------------------", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(0, 70));
            e.Graphics.DrawString("FACTURE", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(120, 90));

            e.Graphics.DrawString("Sorte                    : " + comboBoxSorte.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, 120));
            e.Graphics.DrawString("Toilette Numéro : " + textBoxNumeroToilette.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, 140));
            e.Graphics.DrawString("Type de Toilette : " + textBoxType.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, 160));

            e.Graphics.DrawString("Localisation         : " + comboBoxNomSite.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, 180));
            //e.Graphics.DrawString("Price: " + textBoxPrixProduitVendu.Text, new Font("Century Schoolbook", 12, FontStyle.Bold), Brushes.Black, new Point(70, 200));
            //e.Graphics.DrawString("Le: " + dateRemise.Text, new Font("Century Schoolbook", 10, FontStyle.Bold), Brushes.Black, new Point(70, 250));

            e.Graphics.DrawString("Somme Payée    : " + textBoxPrix.Text, new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(10, 200));
            e.Graphics.DrawString(" Fc ", new Font("Times New Roman", 12, FontStyle.Regular), Brushes.Black, new Point(190, 200));
            e.Graphics.DrawString(" Gardons nos Toilettes Propres ", new Font("Times New Roman", 12, FontStyle.Bold), Brushes.Black, new Point(50, 250));

        }

        //**************************************************************************************************
        //fonction d'appercu avant impression
        public void fonctionImprimer()
        {
            printPreviewDialog1.Document = printDocument1;

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 350, 400); //format du papier

            printPreviewDialog1.ShowDialog();
        }

    }
}
