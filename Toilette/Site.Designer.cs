namespace Toilette
{
    partial class Site
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
            this.buttonNettoyage = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSite = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCom = new System.Windows.Forms.TextBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRechercheSite = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQSite = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxComSite = new System.Windows.Forms.TextBox();
            this.textBoxNomSite = new System.Windows.Forms.TextBox();
            this.buttonAjout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxToilette.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSite)).BeginInit();
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
            this.groupBoxToilette.Controls.Add(this.buttonNettoyage);
            this.groupBoxToilette.Controls.Add(this.groupBox7);
            this.groupBoxToilette.Controls.Add(this.groupBox4);
            this.groupBoxToilette.Controls.Add(this.groupBox1);
            this.groupBoxToilette.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.groupBoxToilette.Location = new System.Drawing.Point(8, 8);
            this.groupBoxToilette.Name = "groupBoxToilette";
            this.groupBoxToilette.Size = new System.Drawing.Size(1054, 572);
            this.groupBoxToilette.TabIndex = 2;
            this.groupBoxToilette.TabStop = false;
            this.groupBoxToilette.Text = "Site";
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
            this.buttonNettoyage.Location = new System.Drawing.Point(532, 214);
            this.buttonNettoyage.Name = "buttonNettoyage";
            this.buttonNettoyage.Size = new System.Drawing.Size(129, 33);
            this.buttonNettoyage.TabIndex = 41;
            this.buttonNettoyage.Text = "Nettoyer";
            this.buttonNettoyage.UseVisualStyleBackColor = false;
            this.buttonNettoyage.Click += new System.EventHandler(this.buttonNettoyage_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.dataGridViewSite);
            this.groupBox7.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox7.Location = new System.Drawing.Point(13, 289);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(653, 269);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Affichage des Sites";
            // 
            // dataGridViewSite
            // 
            this.dataGridViewSite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSite.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewSite.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewSite.Location = new System.Drawing.Point(6, 16);
            this.dataGridViewSite.Name = "dataGridViewSite";
            this.dataGridViewSite.Size = new System.Drawing.Size(642, 242);
            this.dataGridViewSite.TabIndex = 11;
            this.dataGridViewSite.Click += new System.EventHandler(this.eventRemplissageFormsDatagrid);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox4.Controls.Add(this.textBoxUser);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxQ);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxCom);
            this.groupBox4.Controls.Add(this.textBoxNom);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.textBoxRechercheSite);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.textBoxID);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox4.Location = new System.Drawing.Point(690, 17);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(352, 512);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxUser.Location = new System.Drawing.Point(224, 260);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(105, 23);
            this.textBoxUser.TabIndex = 53;
            this.textBoxUser.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 52;
            this.label3.Text = "Quartier:";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQ.Location = new System.Drawing.Point(168, 193);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(161, 23);
            this.textBoxQ.TabIndex = 51;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(24, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 50;
            this.label4.Text = "Commune:";
            // 
            // textBoxCom
            // 
            this.textBoxCom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxCom.Location = new System.Drawing.Point(168, 124);
            this.textBoxCom.Name = "textBoxCom";
            this.textBoxCom.Size = new System.Drawing.Size(161, 23);
            this.textBoxCom.TabIndex = 49;
            // 
            // textBoxNom
            // 
            this.textBoxNom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNom.Location = new System.Drawing.Point(168, 55);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(161, 23);
            this.textBoxNom.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(24, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Nom du Site:";
            // 
            // textBoxRechercheSite
            // 
            this.textBoxRechercheSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxRechercheSite.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Bold);
            this.textBoxRechercheSite.Location = new System.Drawing.Point(168, 435);
            this.textBoxRechercheSite.Name = "textBoxRechercheSite";
            this.textBoxRechercheSite.Size = new System.Drawing.Size(173, 24);
            this.textBoxRechercheSite.TabIndex = 46;
            this.textBoxRechercheSite.TextChanged += new System.EventHandler(this.eventRechercheDonnee);
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
            this.textBoxID.Location = new System.Drawing.Point(157, 260);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(61, 23);
            this.textBoxID.TabIndex = 38;
            this.textBoxID.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.buttonSupprimer);
            this.groupBox6.Controls.Add(this.buttonModifier);
            this.groupBox6.Location = new System.Drawing.Point(6, 284);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(340, 89);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimer.FlatAppearance.BorderSize = 0;
            this.buttonSupprimer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonSupprimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimer.ForeColor = System.Drawing.Color.White;
            this.buttonSupprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSupprimer.Location = new System.Drawing.Point(175, 27);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(160, 40);
            this.buttonSupprimer.TabIndex = 25;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifier.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonModifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifier.FlatAppearance.BorderSize = 0;
            this.buttonModifier.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifier.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonModifier.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifier.ForeColor = System.Drawing.Color.White;
            this.buttonModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifier.Location = new System.Drawing.Point(5, 27);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(164, 40);
            this.buttonModifier.TabIndex = 23;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxQSite);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxComSite);
            this.groupBox1.Controls.Add(this.textBoxNomSite);
            this.groupBox1.Controls.Add(this.buttonAjout);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(71, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 247);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nouveau Site";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Quartier:";
            // 
            // textBoxQSite
            // 
            this.textBoxQSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxQSite.Location = new System.Drawing.Point(190, 129);
            this.textBoxQSite.Name = "textBoxQSite";
            this.textBoxQSite.Size = new System.Drawing.Size(214, 23);
            this.textBoxQSite.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(26, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 26;
            this.label7.Text = "Commune:";
            // 
            // textBoxComSite
            // 
            this.textBoxComSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxComSite.Location = new System.Drawing.Point(190, 85);
            this.textBoxComSite.Name = "textBoxComSite";
            this.textBoxComSite.Size = new System.Drawing.Size(214, 23);
            this.textBoxComSite.TabIndex = 25;
            // 
            // textBoxNomSite
            // 
            this.textBoxNomSite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxNomSite.Location = new System.Drawing.Point(190, 42);
            this.textBoxNomSite.Name = "textBoxNomSite";
            this.textBoxNomSite.Size = new System.Drawing.Size(214, 23);
            this.textBoxNomSite.TabIndex = 23;
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
            this.buttonAjout.Location = new System.Drawing.Point(126, 182);
            this.buttonAjout.Name = "buttonAjout";
            this.buttonAjout.Size = new System.Drawing.Size(177, 40);
            this.buttonAjout.TabIndex = 22;
            this.buttonAjout.Text = "Nouveau";
            this.buttonAjout.UseVisualStyleBackColor = false;
            this.buttonAjout.Click += new System.EventHandler(this.buttonAjout_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(26, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nom du Site:";
            // 
            // Site
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.groupBoxToilette);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Site";
            this.ShowIcon = false;
            this.Text = "Site";
            this.groupBoxToilette.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSite)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridViewSite;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxRechercheSite;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxComSite;
        private System.Windows.Forms.TextBox textBoxNomSite;
        private System.Windows.Forms.Button buttonAjout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNettoyage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCom;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQSite;
        private System.Windows.Forms.TextBox textBoxUser;
    }
}