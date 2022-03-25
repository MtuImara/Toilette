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
    public partial class toilette : Form
    {
        public toilette(string Datas)
        {
            InitializeComponent();

            textBoxUser.Text = Datas; //passation des donnees de l'utilisateur

            afficherToilette(""); //appel fonction affichage

            afficherAgenceComboBoxEtudiant(); //appel fonction affichage comboBox
        }


        //***************************************************************************************
        //masquez un champ avec un checkBox
        
        public void fonctionMasquerChampAjoutNouveau()
        {
            if (checkBoxNouveau.Checked)
            {
                buttonAjout.Visible = true;
            }
            else
            {
                buttonAjout.Visible = false;
            }
        }

        public void masquerBoutonModifier()
        {

            if (checkBoxModifier.Checked)
            {
                buttonModifier.Visible = true;
            }
            else
            {
                buttonModifier.Visible = false;
            }
        }


        public void masquerBoutonSupprimer()
        {

            if (checkBoxSuppression.Checked)
            {
                buttonSupprimer.Visible = true;
            }
            else
            {
                buttonSupprimer.Visible = false;
            }
        }


        public void masquerTousBoutons()
        {
            if (checkBoxVoirTousBouton.Checked)
            {
                buttonAjout.Visible = true;
                buttonModifier.Visible = true;                
                buttonSupprimer.Visible = true;
            }
            else
            {
                buttonAjout.Visible = false;
                buttonModifier.Visible = false;
                buttonSupprimer.Visible = false;
            }
        }

        //appel des fonctions des masquage

        private void checkBoxNouveau_CheckedChanged(object sender, EventArgs e)
        {
            fonctionMasquerChampAjoutNouveau();
        }
        
        private void checkBoxModifier_CheckedChanged(object sender, EventArgs e)
        {
            masquerBoutonModifier();
        }

        private void checkBoxSuppression_CheckedChanged(object sender, EventArgs e)
        {
            masquerBoutonSupprimer();
        }

        private void checkBoxVoirTousBouton_CheckedChanged(object sender, EventArgs e)
        {
            masquerTousBoutons();
        }





        //***************************************************************************************

        //***************************************************************************************
        //fonction et bouton de nettoyage 
        public void nettoyerForm()
        {

            textBoxNumeroToilette.Text = "";
            comboBoxNomSite.Text = "";
            textBoxNumToilMod.Text = "";
            comboBoxSiteMod.Text = "";
            comboBoxSituationMod.Text = "";
            textBoxID.Text = "";
            textBoxPrix.Text = "";
            textBoxPrixMod.Text = "";
            comboBoxType.Text = "";
            comboBoxTypeMod.Text = "";
            comboBoxSorte.Text = "";
            comboBoxSorteMod.Text = "";
        }

        //***************************************************************************************


        //***************************************************************************************
        //fonction et bouton d'ajout de la nouvelle Toilette
        public void fonctionAjoutNouvelleToilette()
        {

            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string requete = "INSERT INTO toilette(numero,site,etat,prix,type,user,sorte) VALUES('" + this.textBoxNumeroToilette.Text + "','" + this.comboBoxNomSite.Text + "','Libre','" + this.textBoxPrix.Text + "','"+this.comboBoxType.Text+"','"+this.textBoxUser.Text+ "','" + this.comboBoxSorte.Text + "')";
                MySqlCommand inserer = new MySqlCommand(requete, connection);
                MySqlDataReader lire;

                connection.Open();
                lire = inserer.ExecuteReader();

                MessageBox.Show("Nouvelle Toilette bien enregistrée");

                while (lire.Read())
                {
                    connection.Close();
                }

                //nettoyerForm(); //nettoyagedu formulaire


            }
            catch (Exception ex)
            {
                MessageBox.Show("Votre Base de donnée n'est pas connée à l'application ou bien le Numéro de la Toilette Existe déjà", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                MessageBox.Show(ex.Message);
            }
        }



        //bouton d'ajout de la nouvelle Toilette
        private void buttonAjout_Click(object sender, EventArgs e)
        {
            if (textBoxNumeroToilette.Text != "" && comboBoxNomSite.Text != "" && textBoxPrix.Text!="" && comboBoxType.Text!="" && comboBoxSorte.Text != "")
            {
                fonctionAjoutNouvelleToilette();


                nettoyerForm(); //nettoyagedu formulaire
                afficherToilette(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //***************************************************************************************

        //***************************************************************************************
        //fonction d'affichage
        public void afficherToilette(string rechercheValeur)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
                string requete = "SELECT * FROM toilette WHERE CONCAT(numero,site,etat,type) LIKE '%" + rechercheValeur + "%'";
                MySqlCommand afficher = new MySqlCommand(requete, connection);
                MySqlDataAdapter md = new MySqlDataAdapter(afficher);
                DataTable dt = new DataTable();
                md.Fill(dt);

                dataGridViewToilette.AllowUserToAddRows = false;
                dataGridViewToilette.DataSource = dt;
                dataGridViewToilette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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


        //Evenement Click de selection du dataGrideView
        private void eventSelectionDataGridClick(object sender, EventArgs e)
        {
            textBoxID.Text = dataGridViewToilette.CurrentRow.Cells[0].Value.ToString();
            textBoxNumToilMod.Text = dataGridViewToilette.CurrentRow.Cells[1].Value.ToString();
            comboBoxSiteMod.Text = dataGridViewToilette.CurrentRow.Cells[2].Value.ToString();
            comboBoxSituationMod.Text = dataGridViewToilette.CurrentRow.Cells[3].Value.ToString();
            textBoxPrixMod.Text = dataGridViewToilette.CurrentRow.Cells[4].Value.ToString();
            comboBoxTypeMod.Text = dataGridViewToilette.CurrentRow.Cells[5].Value.ToString();
            comboBoxSorteMod.Text = dataGridViewToilette.CurrentRow.Cells[7].Value.ToString();
        }



        //***************************************************************************************

        //***************************************************************************************
        //fonction d'evenement provenant du textChange pour effectuer la recherche
        private void eventRechercheDonnee(object sender, EventArgs e)
        {
            afficherToilette(textBoxRechercheProd.Text);
        }


        //***************************************************************************************

        //***************************************************************************************
        //fonction et bouton de modification
        public void fonctionModification()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

            try
            {

                connection.Open();
                string requete = "UPDATE toilette SET numero ='" + textBoxNumToilMod.Text + "' , site='" + comboBoxSiteMod.Text + "' , etat='" + comboBoxSituationMod.Text + "',prix='" + textBoxPrixMod.Text + "',type='"+comboBoxTypeMod.Text+ "',sorte='" + comboBoxSorteMod.Text + "' WHERE id_toilette ='" + textBoxID.Text + "'";
                MySqlCommand modifier = new MySqlCommand(requete, connection);

                modifier.Connection = connection;
                modifier.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Toilette a été bien Modifiée");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (textBoxNumToilMod.Text != "" && comboBoxSiteMod.Text != "" && comboBoxSituationMod.Text != "" && textBoxPrixMod.Text != "" && comboBoxTypeMod.Text!="" && comboBoxSorteMod.Text != "")
            {
                fonctionModification();


                nettoyerForm(); //nettoyagedu formulaire
                afficherToilette(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //***************************************************************************************

        //***************************************************************************************
        //fonction et bouton de suppression
        public void fonctionSuppression()
        {
            MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");
            try
            {
                connection.Open();
                string requete = "DELETE FROM toilette WHERE id_toilette ='" + textBoxID.Text + "' ";
                MySqlCommand supprimer = new MySqlCommand(requete, connection);

                supprimer.Connection = connection;
                supprimer.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Toilette a été bien Supprimée");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if (textBoxNumToilMod.Text != "" && comboBoxSiteMod.Text != "" && comboBoxSituationMod.Text != "" && textBoxPrixMod.Text!="" && comboBoxTypeMod.Text!="" && comboBoxSorteMod.Text != "")
            {
                fonctionSuppression();


                nettoyerForm(); //nettoyagedu formulaire
                afficherToilette(""); //fonction d'affichage
            }
            else
            {
                MessageBox.Show("Veillez bien remplir toud les champs", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        //***************************************************************************
        //bouton de nettoyage
        private void buttonNettoyage_Click(object sender, EventArgs e)
        {
            nettoyerForm();
        }



        //fonction affiche Site comboBox
        public void afficherAgenceComboBoxEtudiant()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("database=BD_Toilette; server=localhost; user id=root; pwd=");

                string personnel = "SELECT * FROM site";

                connection.Open();
                MySqlCommand perso = new MySqlCommand(personnel, connection);
                MySqlDataReader lire = perso.ExecuteReader();

                while (lire.Read())
                {
                    comboBoxNomSite.Items.Add(lire.GetString("nom"));

                    comboBoxSiteMod.Items.Add(lire.GetString("nom"));
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
        private void eventKeypressChiffreSeulementPrix(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxPrix.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
            }

            if (!Char.IsDigit(qte) && qte != 8 && qte != 46)
            {
                e.Handled = true;
            }
        }

        private void eventKeypressChiffreSeulementPrixMod(object sender, KeyPressEventArgs e)
        {
            char qte = e.KeyChar;

            if (qte == 46 && textBoxPrixMod.Text.IndexOf('.') != -1)
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
