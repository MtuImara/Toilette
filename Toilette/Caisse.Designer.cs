namespace Toilette
{
    partial class Caisse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caisse));
            this.groupBoxCaisse = new System.Windows.Forms.GroupBox();
            this.groupBoxV = new System.Windows.Forms.GroupBox();
            this.dataGridViewCaisse = new System.Windows.Forms.DataGridView();
            this.groupBoxBack = new System.Windows.Forms.GroupBox();
            this.textBoxSommeR = new System.Windows.Forms.TextBox();
            this.dateEnregistrement = new System.Windows.Forms.DateTimePicker();
            this.textBoxIDCaisse = new System.Windows.Forms.TextBox();
            this.textBoxMontantR = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxCaisseR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNumToiletteR = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRetour = new System.Windows.Forms.Button();
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxSorte = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.buttonLibererToilette = new System.Windows.Forms.Button();
            this.textBoxIDToilette = new System.Windows.Forms.TextBox();
            this.comboBoxSituation = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxPrix = new System.Windows.Forms.TextBox();
            this.comboBoxNomSite = new System.Windows.Forms.ComboBox();
            this.textBoxNumeroToilette = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAjoutCaisse = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewToilette = new System.Windows.Forms.DataGridView();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.dateTimeE = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCaisse.SuspendLayout();
            this.groupBoxV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaisse)).BeginInit();
            this.groupBoxBack.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToilette)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxCaisse
            // 
            this.groupBoxCaisse.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCaisse.BackColor = System.Drawing.Color.White;
            this.groupBoxCaisse.Controls.Add(this.dateTimeE);
            this.groupBoxCaisse.Controls.Add(this.dateEnregistrement);
            this.groupBoxCaisse.Controls.Add(this.groupBoxV);
            this.groupBoxCaisse.Controls.Add(this.groupBoxBack);
            this.groupBoxCaisse.Controls.Add(this.buttonNettoyage);
            this.groupBoxCaisse.Controls.Add(this.label6);
            this.groupBoxCaisse.Controls.Add(this.textBoxRecherche);
            this.groupBoxCaisse.Controls.Add(this.groupBox2);
            this.groupBoxCaisse.Controls.Add(this.groupBox7);
            this.groupBoxCaisse.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxCaisse.Location = new System.Drawing.Point(4, -3);
            this.groupBoxCaisse.Name = "groupBoxCaisse";
            this.groupBoxCaisse.Size = new System.Drawing.Size(1063, 603);
            this.groupBoxCaisse.TabIndex = 2;
            this.groupBoxCaisse.TabStop = false;
            this.groupBoxCaisse.Text = "CAISSE";
            // 
            // groupBoxV
            // 
            this.groupBoxV.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBoxV.Controls.Add(this.dataGridViewCaisse);
            this.groupBoxV.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxV.Location = new System.Drawing.Point(15, 318);
            this.groupBoxV.Name = "groupBoxV";
            this.groupBoxV.Size = new System.Drawing.Size(703, 269);
            this.groupBoxV.TabIndex = 43;
            this.groupBoxV.TabStop = false;
            this.groupBoxV.Text = "Situation de la Caisse";
            // 
            // dataGridViewCaisse
            // 
            this.dataGridViewCaisse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewCaisse.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCaisse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCaisse.Location = new System.Drawing.Point(6, 22);
            this.dataGridViewCaisse.Name = "dataGridViewCaisse";
            this.dataGridViewCaisse.Size = new System.Drawing.Size(691, 238);
            this.dataGridViewCaisse.TabIndex = 3;
            this.dataGridViewCaisse.Click += new System.EventHandler(this.eventRemplissageFormsDatagridCaisse);
            // 
            // groupBoxBack
            // 
            this.groupBoxBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBoxBack.Controls.Add(this.textBoxSommeR);
            this.groupBoxBack.Controls.Add(this.textBoxIDCaisse);
            this.groupBoxBack.Controls.Add(this.textBoxMontantR);
            this.groupBoxBack.Controls.Add(this.label8);
            this.groupBoxBack.Controls.Add(this.textBoxCaisseR);
            this.groupBoxBack.Controls.Add(this.label5);
            this.groupBoxBack.Controls.Add(this.textBoxNumToiletteR);
            this.groupBoxBack.Controls.Add(this.label3);
            this.groupBoxBack.Controls.Add(this.buttonRetour);
            this.groupBoxBack.Location = new System.Drawing.Point(739, 537);
            this.groupBoxBack.Name = "groupBoxBack";
            this.groupBoxBack.Size = new System.Drawing.Size(318, 48);
            this.groupBoxBack.TabIndex = 42;
            this.groupBoxBack.TabStop = false;
            this.groupBoxBack.Visible = false;
            // 
            // textBoxSommeR
            // 
            this.textBoxSommeR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxSommeR.Location = new System.Drawing.Point(247, 76);
            this.textBoxSommeR.Name = "textBoxSommeR";
            this.textBoxSommeR.ReadOnly = true;
            this.textBoxSommeR.Size = new System.Drawing.Size(63, 26);
            this.textBoxSommeR.TabIndex = 49;
            this.textBoxSommeR.Visible = false;
            // 
            // dateEnregistrement
            // 
            this.dateEnregistrement.CustomFormat = "";
            this.dateEnregistrement.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEnregistrement.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnregistrement.Location = new System.Drawing.Point(816, 469);
            this.dateEnregistrement.Name = "dateEnregistrement";
            this.dateEnregistrement.Size = new System.Drawing.Size(58, 26);
            this.dateEnregistrement.TabIndex = 48;
            // 
            // textBoxIDCaisse
            // 
            this.textBoxIDCaisse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDCaisse.Location = new System.Drawing.Point(16, 69);
            this.textBoxIDCaisse.Name = "textBoxIDCaisse";
            this.textBoxIDCaisse.ReadOnly = true;
            this.textBoxIDCaisse.Size = new System.Drawing.Size(42, 26);
            this.textBoxIDCaisse.TabIndex = 36;
            this.textBoxIDCaisse.Visible = false;
            // 
            // textBoxMontantR
            // 
            this.textBoxMontantR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxMontantR.Location = new System.Drawing.Point(8, 30);
            this.textBoxMontantR.Name = "textBoxMontantR";
            this.textBoxMontantR.ReadOnly = true;
            this.textBoxMontantR.Size = new System.Drawing.Size(153, 26);
            this.textBoxMontantR.TabIndex = 47;
            this.textBoxMontantR.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(25, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Montant Payé";
            this.label8.Visible = false;
            // 
            // textBoxCaisseR
            // 
            this.textBoxCaisseR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCaisseR.Location = new System.Drawing.Point(170, -29);
            this.textBoxCaisseR.Name = "textBoxCaisseR";
            this.textBoxCaisseR.ReadOnly = true;
            this.textBoxCaisseR.Size = new System.Drawing.Size(141, 26);
            this.textBoxCaisseR.TabIndex = 45;
            this.textBoxCaisseR.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(205, -53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 19);
            this.label5.TabIndex = 44;
            this.label5.Text = "Caisse";
            this.label5.Visible = false;
            // 
            // textBoxNumToiletteR
            // 
            this.textBoxNumToiletteR.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumToiletteR.Location = new System.Drawing.Point(6, -29);
            this.textBoxNumToiletteR.Name = "textBoxNumToiletteR";
            this.textBoxNumToiletteR.ReadOnly = true;
            this.textBoxNumToiletteR.Size = new System.Drawing.Size(153, 26);
            this.textBoxNumToiletteR.TabIndex = 43;
            this.textBoxNumToiletteR.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, -52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 19);
            this.label3.TabIndex = 42;
            this.label3.Text = "Numéro Toilette";
            this.label3.Visible = false;
            // 
            // buttonRetour
            // 
            this.buttonRetour.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonRetour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRetour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRetour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonRetour.FlatAppearance.BorderSize = 0;
            this.buttonRetour.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.buttonRetour.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetour.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRetour.ForeColor = System.Drawing.Color.White;
            this.buttonRetour.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetour.Location = new System.Drawing.Point(81, 76);
            this.buttonRetour.Name = "buttonRetour";
            this.buttonRetour.Size = new System.Drawing.Size(160, 40);
            this.buttonRetour.TabIndex = 41;
            this.buttonRetour.Text = "Retour";
            this.buttonRetour.UseVisualStyleBackColor = false;
            this.buttonRetour.Visible = false;
            this.buttonRetour.Click += new System.EventHandler(this.buttonRetour_Click);
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
            this.buttonNettoyage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonNettoyage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNettoyage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNettoyage.ForeColor = System.Drawing.Color.White;
            this.buttonNettoyage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonNettoyage.Location = new System.Drawing.Point(522, 20);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(113, 27);
            this.buttonNettoyage.TabIndex = 41;
            this.buttonNettoyage.Text = "Nettoyer";
            this.buttonNettoyage.UseVisualStyleBackColor = false;
            this.buttonNettoyage.Click += new System.EventHandler(this.buttonNettoyage_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(135, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Recherche Toilette:";
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRecherche.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxRecherche.Location = new System.Drawing.Point(268, 21);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(144, 24);
            this.textBoxRecherche.TabIndex = 18;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.rechercheDonnee);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.textBoxType);
            this.groupBox2.Controls.Add(this.comboBoxSorte);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.textBoxUser);
            this.groupBox2.Controls.Add(this.buttonLibererToilette);
            this.groupBox2.Controls.Add(this.textBoxIDToilette);
            this.groupBox2.Controls.Add(this.comboBoxSituation);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.textBoxPrix);
            this.groupBox2.Controls.Add(this.comboBoxNomSite);
            this.groupBox2.Controls.Add(this.textBoxNumeroToilette);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buttonAjoutCaisse);
            this.groupBox2.Location = new System.Drawing.Point(739, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 406);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // comboBoxSorte
            // 
            this.comboBoxSorte.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSorte.FormattingEnabled = true;
            this.comboBoxSorte.Items.AddRange(new object[] {
            "Toilette",
            "Urinoire"});
            this.comboBoxSorte.Location = new System.Drawing.Point(146, 20);
            this.comboBoxSorte.Name = "comboBoxSorte";
            this.comboBoxSorte.Size = new System.Drawing.Size(154, 27);
            this.comboBoxSorte.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(6, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 19);
            this.label11.TabIndex = 38;
            this.label11.Text = "Sorte:";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUser.Location = new System.Drawing.Point(112, 307);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.ReadOnly = true;
            this.textBoxUser.Size = new System.Drawing.Size(153, 26);
            this.textBoxUser.TabIndex = 37;
            this.textBoxUser.Visible = false;
            // 
            // buttonLibererToilette
            // 
            this.buttonLibererToilette.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonLibererToilette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLibererToilette.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonLibererToilette.FlatAppearance.BorderSize = 0;
            this.buttonLibererToilette.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonLibererToilette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonLibererToilette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonLibererToilette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLibererToilette.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLibererToilette.ForeColor = System.Drawing.Color.White;
            this.buttonLibererToilette.Image = global::Toilette.Properties.Resources.stock1;
            this.buttonLibererToilette.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLibererToilette.Location = new System.Drawing.Point(52, 345);
            this.buttonLibererToilette.Name = "buttonLibererToilette";
            this.buttonLibererToilette.Size = new System.Drawing.Size(213, 40);
            this.buttonLibererToilette.TabIndex = 36;
            this.buttonLibererToilette.Text = "Libérer Toilette";
            this.buttonLibererToilette.UseVisualStyleBackColor = false;
            this.buttonLibererToilette.Click += new System.EventHandler(this.buttonLibererToilette_Click);
            // 
            // textBoxIDToilette
            // 
            this.textBoxIDToilette.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxIDToilette.Location = new System.Drawing.Point(6, 307);
            this.textBoxIDToilette.Name = "textBoxIDToilette";
            this.textBoxIDToilette.ReadOnly = true;
            this.textBoxIDToilette.Size = new System.Drawing.Size(42, 26);
            this.textBoxIDToilette.TabIndex = 35;
            this.textBoxIDToilette.Visible = false;
            // 
            // comboBoxSituation
            // 
            this.comboBoxSituation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxSituation.FormattingEnabled = true;
            this.comboBoxSituation.Location = new System.Drawing.Point(146, 190);
            this.comboBoxSituation.Name = "comboBoxSituation";
            this.comboBoxSituation.Size = new System.Drawing.Size(153, 27);
            this.comboBoxSituation.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(8, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Situation:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(9, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 19);
            this.label7.TabIndex = 32;
            this.label7.Text = "Prix:";
            // 
            // textBoxPrix
            // 
            this.textBoxPrix.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPrix.Location = new System.Drawing.Point(147, 145);
            this.textBoxPrix.Name = "textBoxPrix";
            this.textBoxPrix.ReadOnly = true;
            this.textBoxPrix.Size = new System.Drawing.Size(153, 26);
            this.textBoxPrix.TabIndex = 31;
            // 
            // comboBoxNomSite
            // 
            this.comboBoxNomSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNomSite.FormattingEnabled = true;
            this.comboBoxNomSite.Location = new System.Drawing.Point(147, 102);
            this.comboBoxNomSite.Name = "comboBoxNomSite";
            this.comboBoxNomSite.Size = new System.Drawing.Size(153, 27);
            this.comboBoxNomSite.TabIndex = 30;
            // 
            // textBoxNumeroToilette
            // 
            this.textBoxNumeroToilette.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNumeroToilette.Location = new System.Drawing.Point(147, 60);
            this.textBoxNumeroToilette.Name = "textBoxNumeroToilette";
            this.textBoxNumeroToilette.ReadOnly = true;
            this.textBoxNumeroToilette.Size = new System.Drawing.Size(153, 26);
            this.textBoxNumeroToilette.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "Numéro Toilette:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(9, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Site:";
            // 
            // buttonAjoutCaisse
            // 
            this.buttonAjoutCaisse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutCaisse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAjoutCaisse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutCaisse.FlatAppearance.BorderSize = 0;
            this.buttonAjoutCaisse.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutCaisse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAjoutCaisse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAjoutCaisse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutCaisse.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjoutCaisse.ForeColor = System.Drawing.Color.White;
            this.buttonAjoutCaisse.Image = global::Toilette.Properties.Resources.panierNew;
            this.buttonAjoutCaisse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjoutCaisse.Location = new System.Drawing.Point(52, 252);
            this.buttonAjoutCaisse.Name = "buttonAjoutCaisse";
            this.buttonAjoutCaisse.Size = new System.Drawing.Size(213, 40);
            this.buttonAjoutCaisse.TabIndex = 26;
            this.buttonAjoutCaisse.Text = "Ajouter Caisse";
            this.buttonAjoutCaisse.UseVisualStyleBackColor = false;
            this.buttonAjoutCaisse.Click += new System.EventHandler(this.buttonAjoutCaisse_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox7.Controls.Add(this.dataGridViewToilette);
            this.groupBox7.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(15, 55);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(703, 257);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Toilette";
            // 
            // dataGridViewToilette
            // 
            this.dataGridViewToilette.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dataGridViewToilette.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewToilette.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewToilette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewToilette.Location = new System.Drawing.Point(6, 18);
            this.dataGridViewToilette.Name = "dataGridViewToilette";
            this.dataGridViewToilette.Size = new System.Drawing.Size(691, 230);
            this.dataGridViewToilette.TabIndex = 11;
            this.dataGridViewToilette.Click += new System.EventHandler(this.eventRemplissageFormsDatagrid);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // textBoxType
            // 
            this.textBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxType.Location = new System.Drawing.Point(54, 307);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.ReadOnly = true;
            this.textBoxType.Size = new System.Drawing.Size(42, 26);
            this.textBoxType.TabIndex = 40;
            this.textBoxType.Visible = false;
            // 
            // dateTimeE
            // 
            this.dateTimeE.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimeE.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimeE.Location = new System.Drawing.Point(886, 468);
            this.dateTimeE.Name = "dateTimeE";
            this.dateTimeE.Size = new System.Drawing.Size(68, 26);
            this.dateTimeE.TabIndex = 41;
            // 
            // Caisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.groupBoxCaisse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Caisse";
            this.ShowIcon = false;
            this.Text = "Caisse";
            this.groupBoxCaisse.ResumeLayout(false);
            this.groupBoxCaisse.PerformLayout();
            this.groupBoxV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCaisse)).EndInit();
            this.groupBoxBack.ResumeLayout(false);
            this.groupBoxBack.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewToilette)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCaisse;
        private System.Windows.Forms.GroupBox groupBoxV;
        private System.Windows.Forms.DataGridView dataGridViewCaisse;
        private System.Windows.Forms.GroupBox groupBoxBack;
        private System.Windows.Forms.Button buttonRetour;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonAjoutCaisse;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView dataGridViewToilette;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxPrix;
        private System.Windows.Forms.ComboBox comboBoxNomSite;
        private System.Windows.Forms.TextBox textBoxNumeroToilette;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIDToilette;
        private System.Windows.Forms.ComboBox comboBoxSituation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMontantR;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxCaisseR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNumToiletteR;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIDCaisse;
        private System.Windows.Forms.Button buttonLibererToilette;
        private System.Windows.Forms.DateTimePicker dateEnregistrement;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox textBoxSommeR;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.ComboBox comboBoxSorte;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxType;
        private System.Windows.Forms.DateTimePicker dateTimeE;
    }
}