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
    public partial class Personnel : Form
    {
        public Personnel(string Datas)
        {
            InitializeComponent();

            textBoxUser.Text = Datas; //passation des donnees de l'utilisateur

            //appel fonction affichage personnel
            afficherPersonnel("");
        }




        /// <summary>

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        // *********************************************************************
        // *********************************************************************
        //fonction et bouton de nettoyage

        public void nettoyage()
        {
            textBoxNom.Text = "";
            textBoxPrenom.Text = "";
            textBoxLogin.Text = "";
            textBoxPassword.Text = "";
            textBoxFonction.Text = "";
            textBoxID.Text = "";
            textBoxRecherchePerso.Text = "";
        }
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyage();
        }


        // *********************************************************************
        // *********************************************************************
        //fonction d'affichage du personnel
        public void afficherPersonnel(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM utilisateur WHERE CONCAT(nom,prenom,login,statut) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewPersonnel.AllowUserToAddRows = false;
                dataGridViewPersonnel.DataSource = dt;
                dataGridViewPersonnel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                /*
                                //les outils pour compter les bres des produits
                                int effectif = dataGridViewStock.RowCount;
                                double nombre = effectif;
                                textBoxEffectifProduit.Text = nombre.ToString();

                                // textBoxEffectifProduit.Text = Convert.ToString(nombre);
                */

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //event CLICK remplissage form a partir de DataGrid
        private void eventRemplissageFormDatagrid(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewPersonnel.CurrentRow.Cells[0].Value.ToString();
            textBoxNom.Text = dataGridViewPersonnel.CurrentRow.Cells[1].Value.ToString();
            textBoxPrenom.Text = dataGridViewPersonnel.CurrentRow.Cells[2].Value.ToString();
            textBoxLogin.Text = dataGridViewPersonnel.CurrentRow.Cells[3].Value.ToString();
            textBoxPassword.Text = dataGridViewPersonnel.CurrentRow.Cells[4].Value.ToString();
            textBoxFonction.Text = dataGridViewPersonnel.CurrentRow.Cells[5].Value.ToString();
        }


        //event TextChanged pour chercher une donnee dans le DataGrid
        private void eventRechercheDonne(object sender, EventArgs e)
        {
            afficherPersonnel(textBoxRecherchePerso.Text);
        }




        // *********************************************************************
        // *********************************************************************
        //fonction et bouton d'ajout utilisateur

        public void ajouterPersonnel()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO utilisateur(nom,prenom,login,password,statut,user) VALUES('" + this.textBoxNom.Text + "','" + this.textBoxPrenom.Text + "','" + this.textBoxLogin.Text + "','" + this.textBoxPassword.Text + "','" + this.textBoxFonction.Text + "','"+this.textBoxUser.Text+"')";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("Nouveau Personnel bien enregistré");

                while (lire.Read())
                {
                    connection.Close();
                }

                //nettoyerForm(); //nettoyagedu formulaire


            }
            catch (Exception ex)
            {
                MessageBox.Show("Votre Base de donnée n'est pas connée à l'application", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxPrenom.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxFonction.Text != "")
            {
                ajouterPersonnel();


                nettoyage(); //nettoyagedu formulaire
                afficherPersonnel(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // *********************************************************************
        // *********************************************************************
        //fonction et bouton de modification d'un utilisateur
        public void modifierPersonnel()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE utilisateur SET nom  ='" + textBoxNom.Text + "' , prenom ='" + textBoxPrenom.Text + "' , login ='" + textBoxLogin.Text + "', password ='" + textBoxPassword.Text + "' , statut  ='" + textBoxFonction.Text + "' WHERE id_utilisateur ='" + textBoxID.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Utilisateur a été bien Modifié");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //bouton modifié
        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxID.Text != "" && textBoxPrenom.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxFonction.Text != "")
            {
                modifierPersonnel();


                nettoyage(); //nettoyagedu formulaire
                afficherPersonnel(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir tous les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // *********************************************************************
        // *********************************************************************
        //fonction et bouton de suppression d'un utilisateur
        public void supprimerPersonnel()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
            try
            {
                connection.Open();
                string requete = "DELETE FROM utilisateur WHERE id_utilisateur  ='" + textBoxID.Text + "' ";
                MySqlCommand supprimer = new MySqlCommand(requete, connection);

                supprimer.Connection = connection;
                supprimer.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Utilisateur a été bien Supprimé");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNom.Text != "" && textBoxID.Text != "" && textBoxPrenom.Text != "" && textBoxLogin.Text != "" && textBoxPassword.Text != "" && textBoxFonction.Text != "")
            {
                supprimerPersonnel();


                nettoyage(); //nettoyagedu formulaire
                afficherPersonnel(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir tous les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
