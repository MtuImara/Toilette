namespace Toilette
{
    partial class Depense
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxToilette = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewDepense = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboBoxNomPersoMod = new System.Windows.Forms.ComboBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.richTextBoxMot = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxmontant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.textBoxRechercheDep = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxNomPerso = new System.Windows.Forms.ComboBox();
            this.richTextBoxMotif = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxMontantSortie = new System.Windows.Forms.TextBox();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxToilette.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepense)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxToilette
            // 
            this.groupBoxToilette.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxToilette.BackColor = System.Drawing.Color.White;
            this.groupBoxToilette.Controls.Add(this.groupBox7);
            this.groupBoxToilette.Controls.Add(this.groupBox4);
            this.groupBoxToilette.Controls.Add(this.groupBox1);
            this.groupBoxToilette.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxToilette.Location = new System.Drawing.Point(8, 8);
            this.groupBoxToilette.Name = "groupBoxToilette";
            this.groupBoxToilette.Size = new System.Drawing.Size(1054, 572);
            this.groupBoxToilette.TabIndex = 3;
            this.groupBoxToilette.TabStop = false;
            this.groupBoxToilette.Text = "Dépense";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.dataGridViewDepense);
            this.groupBox7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(13, 289);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(653, 269);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Affichage des dépenses:";
            // 
            // dataGridViewDepense
            // 
            this.dataGridViewDepense.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDepense.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDepense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDepense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewDepense.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewDepense.Name = "dataGridViewDepense";
            this.dataGridViewDepense.Size = new System.Drawing.Size(642, 242);
            this.dataGridViewDepense.TabIndex = 11;
            this.dataGridViewDepense.Click += new System.EventHandler(this.eventRemplissageFormsDatagrid);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.comboBoxNomPersoMod);
            this.groupBox4.Controls.Add(this.textBoxUser);
            this.groupBox4.Controls.Add(this.richTextBoxMot);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxmontant);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.buttonNettoyage);
            this.groupBox4.Controls.Add(this.textBoxRechercheDep);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxID);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(690, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 512);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Echec Dépense";
            // 
            // comboBoxNomPersoMod
            // 
            this.comboBoxNomPersoMod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNomPersoMod.FormattingEnabled = true;
            this.comboBoxNomPersoMod.Location = new System.Drawing.Point(153, 80);
            this.comboBoxNomPersoMod.Name = "comboBoxNomPersoMod";
            this.comboBoxNomPersoMod.Size = new System.Drawing.Size(158, 24);
            this.comboBoxNomPersoMod.TabIndex = 54;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUser.Location = new System.Drawing.Point(169, 255);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(127, 23);
            this.textBoxUser.TabIndex = 53;
            this.textBoxUser.Visible = false;
            // 
            // richTextBoxMot
            // 
            this.richTextBoxMot.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxMot.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxMot.Location = new System.Drawing.Point(36, 142);
            this.richTextBoxMot.Name = "richTextBoxMot";
            this.richTextBoxMot.ReadOnly = true;
            this.richTextBoxMot.Size = new System.Drawing.Size(278, 96);
            this.richTextBoxMot.TabIndex = 52;
            this.richTextBoxMot.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(147, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "Motif";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 50;
            this.label3.Text = "Personnel:";
            // 
            // textBoxmontant
            // 
            this.textBoxmontant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxmontant.Location = new System.Drawing.Point(154, 34);
            this.textBoxmontant.Name = "textBoxmontant";
            this.textBoxmontant.ReadOnly = true;
            this.textBoxmontant.Size = new System.Drawing.Size(157, 23);
            this.textBoxmontant.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(22, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 47;
            this.label4.Text = "Montant Sortie:";
            // 
            // buttonNettoyage
            // 
            this.buttonNettoyage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNettoyage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonNettoyage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.FlatAppearance.BorderSize = 0;
            this.buttonNettoyage.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonNettoyage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonNettoyage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNettoyage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNettoyage.ForeColor = System.Drawing.Color.White;
            this.buttonNettoyage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNettoyage.Location = new System.Drawing.Point(128, 379);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(129, 33);
            this.buttonNettoyage.TabIndex = 41;
            this.buttonNettoyage.Text = "Nettoyer";
            this.buttonNettoyage.UseVisualStyleBackColor = false;
            this.buttonNettoyage.Click += new System.EventHandler(this.buttonNettoyage_Click);
            // 
            // textBoxRechercheDep
            // 
            this.textBoxRechercheDep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRechercheDep.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxRechercheDep.Location = new System.Drawing.Point(168, 435);
            this.textBoxRechercheDep.Name = "textBoxRechercheDep";
            this.textBoxRechercheDep.Size = new System.Drawing.Size(173, 24);
            this.textBoxRechercheDep.TabIndex = 46;
            this.textBoxRechercheDep.TextChanged += new System.EventHandler(this.eventRechercheDonnee);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(7, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 19);
            this.label6.TabIndex = 45;
            this.label6.Text = "Recherche:";
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxID.Location = new System.Drawing.Point(102, 255);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(61, 23);
            this.textBoxID.TabIndex = 38;
            this.textBoxID.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonRetour);
            this.groupBox6.Location = new System.Drawing.Point(6, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 89);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetour.Location = new System.Drawing.Point(96, 27);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(164, 40);
            this.buttonRetour.TabIndex = 23;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.comboBoxNomPerso);
            this.groupBox1.Controls.Add(this.richTextBoxMotif);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxMontantSortie);
            this.groupBox1.Controls.Add(this.buttonAjout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouvelle Dépense";
            // 
            // comboBoxNomPerso
            // 
            this.comboBoxNomPerso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNomPerso.FormattingEnabled = true;
            this.comboBoxNomPerso.Location = new System.Drawing.Point(154, 135);
            this.comboBoxNomPerso.Name = "comboBoxNomPerso";
            this.comboBoxNomPerso.Size = new System.Drawing.Size(157, 24);
            this.comboBoxNomPerso.TabIndex = 29;
            // 
            // richTextBoxMotif
            // 
            this.richTextBoxMotif.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBoxMotif.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxMotif.Location = new System.Drawing.Point(330, 75);
            this.richTextBoxMotif.Name = "richTextBoxMotif";
            this.richTextBoxMotif.Size = new System.Drawing.Size(278, 96);
            this.richTextBoxMotif.TabIndex = 28;
            this.richTextBoxMotif.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(441, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Motif";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(22, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Personnel:";
            // 
            // textBoxMontantSortie
            // 
            this.textBoxMontantSortie.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMontantSortie.Location = new System.Drawing.Point(154, 89);
            this.textBoxMontantSortie.Name = "textBoxMontantSortie";
            this.textBoxMontantSortie.Size = new System.Drawing.Size(157, 23);
            this.textBoxMontantSortie.TabIndex = 23;
            this.textBoxMontantSortie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.eventKeypressChiffreSeulementMontantSortie);
            // 
            // buttonAjout
            // 
            this.buttonAjout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAjout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjout.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjout.FlatAppearance.BorderSize = 0;
            this.buttonAjout.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonAjout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjout.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjout.ForeColor = System.Drawing.Color.White;
            this.buttonAjout.Image = global::Toilette.Properties.Resources._;
            this.buttonAjout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjout.Location = new System.Drawing.Point(220, 187);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(177, 40);
            this.buttonAjout.TabIndex = 22;
            this.buttonAjout.Text = "Nouvelle";
            this.buttonAjout.UseVisualStyleBackColor = false;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(22, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Montant Sortie:";
            // 
            // Depense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.groupBoxToilette);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Depense";
            this.ShowIcon = false;
            this.Text = "Depense";
            this.groupBoxToilette.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDepense)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxToilette;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridViewDepense;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.TextBox textBoxRechercheDep;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxMotif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxMontantSortie;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBoxMot;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxmontant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.ComboBox comboBoxNomPersoMod;
        private System.Windows.Forms.ComboBox comboBoxNomPerso;
    }
}