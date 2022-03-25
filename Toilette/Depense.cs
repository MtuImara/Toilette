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
    public partial class Depense : Form
    {
        public Depense(string Datas)
        {
            InitializeComponent();
            textBoxUser.Text = Datas; //passation des donnees de l'utilisateur

            afficherPersonnelComboBox(); //appel fonction affiche comboBox Personnel
            //appel fonction affiche
            afficherDepense("");
        }



        //***********************************************************************
        //***********************************************************************
        //fonctio et bouton de nettoyage
        public void netoyage()
        {
            textBoxMontantSortie.Text = "";
            comboBoxNomPerso.Text = "";
            richTextBoxMotif.Text = "";
            textBoxmontant.Text = "";
            comboBoxNomPersoMod.Text = "";
            richTextBoxMot.Text = "";
            textBoxID.Text = "";
            textBoxRechercheDep.Text = "";
        }

        //bouton de nettoyage
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            netoyage();
        }


        //***********************************************************************
        //***********************************************************************
        //fonction d'affichage
        public void afficherDepense(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM depense WHERE CONCAT(nom_utilisateur) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewDepense.AllowUserToAddRows = false;
                dataGridViewDepense.DataSource = dt;
                dataGridViewDepense.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        //fonction event TEXTCHANGED pour faire la recherche d'une donnee
        private void eventRechercheDonnee(object sender, EventArgs e)
        {
            afficherDepense(textBoxRechercheDep.Text);
        }


        //fonction event CLICK pour remplir le form a partir de DatagridView
        private void eventRemplissageFormsDatagrid(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewDepense.CurrentRow.Cells[0].Value.ToString();
            textBoxmontant.Text = dataGridViewDepense.CurrentRow.Cells[1].Value.ToString();
            comboBoxNomPersoMod.Text = dataGridViewDepense.CurrentRow.Cells[2].Value.ToString();
            richTextBoxMot.Text = dataGridViewDepense.CurrentRow.Cells[3].Value.ToString();
        }



        //***********************************************************************
        //***********************************************************************
        //fonction et bouton d'Ajout

        public void ajoutDepense()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO depense(montant_sortie,nom_utilisateur,motif,user) VALUES('" + this.textBoxMontantSortie.Text + "','" + this.comboBoxNomPerso.Text + "','" + this.richTextBoxMotif.Text + "','"+this.textBoxUser.Text+"')";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("Nouvelle Dépense bien enregistrée");

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
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (textBoxMontantSortie.Text != "" && comboBoxNomPerso.Text != "" && richTextBoxMotif.Text != "")
            {
                ajoutDepense();


                netoyage(); //nettoyagedu formulaire
                afficherDepense(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir tous les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //***********************************************************************
        //***********************************************************************
        //fonction et bouton de retour ou echec
        public void retourDepense()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE depense SET echec   ='Echec' WHERE id_depense ='" + textBoxID.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Echec de Dépense bien enregistré");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void buttonRetour_Click(object sender, EventArgs e)
        {
            if (textBoxmontant.Text != "" && comboBoxNomPersoMod.Text != "" && richTextBoxMot.Text != "" && textBoxID.Text != "")
            {
                retourDepense();


                netoyage(); //nettoyagedu formulaire
                afficherDepense(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir tous les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //fonction affiche Personnel comboBox
        public void afficherPersonnelComboBox()
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
                    comboBoxNomPerso.Items.Add(lire.GetString("login"));

                    comboBoxNomPersoMod.Items.Add(lire.GetString("login"));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        //**********************************************************************************************
        //**********************************************************************************************
        //fonctins keyPress de verification des champs
        private void eventKeypressChiffreSeulementMontantSortie(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxMontantSortie.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

       
    }
}
