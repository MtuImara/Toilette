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
    public partial class Site : Form
    {
        public Site(string Datas)
        {
            InitializeComponent();

            textBoxUser.Text = Datas; //passation des donnees de l'utilisateur

            //appel foction
            afficherSite("");
        }




        //***********************************************************************
        //***********************************************************************
        //fonctio et bouton de nettoyage
        public void netoyage()
        {
            textBoxNomSite.Text = "";
            textBoxComSite.Text = "";
            textBoxQSite.Text = "";
            textBoxNom.Text = "";
            textBoxCom.Text = "";
            textBoxQ.Text = "";
            textBoxID.Text = "";
            textBoxRechercheSite.Text = "";
        }

        //bouton de nettoyage
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            netoyage(); //appel fonctio de nettoyage forms
        }

        //***********************************************************************
        //***********************************************************************
        //fonction d'affichage
        public void afficherSite(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM site WHERE CONCAT(nom,localisation,quartier) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewSite.AllowUserToAddRows = false;
                dataGridViewSite.DataSource = dt;
                dataGridViewSite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //fonction event TEXTCHANGED pour faire la recherche d'une donnee
        private void eventRechercheDonnee(object sender, EventArgs e)
        {
            afficherSite(textBoxRechercheSite.Text);
        }

        //fonction event CLICK pour remplir le form a partir de DatagridView
        private void eventRemplissageFormsDatagrid(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewSite.CurrentRow.Cells[0].Value.ToString();
            textBoxNom.Text = dataGridViewSite.CurrentRow.Cells[1].Value.ToString();
            textBoxCom.Text = dataGridViewSite.CurrentRow.Cells[2].Value.ToString();
            textBoxQ.Text = dataGridViewSite.CurrentRow.Cells[3].Value.ToString();
        }


        //***********************************************************************
        //***********************************************************************
        //fonction et bouton d'Ajout
        public void ajoutSite()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO site(nom,localisation,quartier,user) VALUES('" + this.textBoxNomSite.Text + "','" + this.textBoxComSite.Text + "','" + this.textBoxQSite.Text + "','"+this.textBoxUser.Text+"')";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("Nouveau Site bien enregistré");

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

        //bouton ajout
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (textBoxNomSite.Text != "" && textBoxComSite.Text != "" && textBoxQSite.Text != "")
            {
                ajoutSite();


                netoyage(); //nettoyagedu formulaire
                afficherSite(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //***********************************************************************
        //***********************************************************************
        //fonction et bouton de modification
        public void modifierSite()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE site SET nom  ='" + textBoxNom.Text + "' , localisation ='" + textBoxCom.Text + "' , quartier  ='" + textBoxQ.Text + "' WHERE id_site ='" + textBoxID.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Site a été bien Modifié");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxID.Text != "" && textBoxCom.Text != "" && textBoxQ.Text != "")
            {
                modifierSite();


                netoyage(); //nettoyagedu formulaire
                afficherSite(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //***********************************************************************
        //***********************************************************************
        //fonction et bouton de Supprimer
        public void supprimerSite()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
            try
            {
                connection.Open();
                string requete = "DELETE FROM site WHERE id_site   ='" + textBoxID.Text + "' ";
                MySqlCommand supprimer = new MySqlCommand(requete, connection);

                supprimer.Connection = connection;
                supprimer.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Site a été bien Supprimé");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxID.Text != "" && textBoxCom.Text != "" && textBoxQ.Text != "")
            {
                supprimerSite();


                netoyage(); //nettoyagedu formulaire
                afficherSite(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
