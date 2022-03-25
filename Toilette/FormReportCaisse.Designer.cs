namespace Toilette
{
    partial class FormReportCaisse
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
            this.reportViewerCaisse = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAfficheToutesToilettes = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNomToilette = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerCaisse
            // 
            this.reportViewerCaisse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportViewerCaisse.LocalReport.ReportEmbeddedResource = "Toilette.ReportCaisse.rdlc";
            this.reportViewerCaisse.Location = new System.Drawing.Point(31, 26);
            this.reportViewerCaisse.Name = "reportViewerCaisse";
            this.reportViewerCaisse.ServerReport.BearerToken = null;
            this.reportViewerCaisse.Size = new System.Drawing.Size(677, 550);
            this.reportViewerCaisse.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonAfficheToutesToilettes);
            this.groupBox1.Controls.Add(this.comboBoxUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxNomToilette);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateFin);
            this.groupBox1.Controls.Add(this.dateDebut);
            this.groupBox1.Location = new System.Drawing.Point(719, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 309);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // buttonAfficheToutesToilettes
            // 
            this.buttonAfficheToutesToilettes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficheToutesToilettes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAfficheToutesToilettes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficheToutesToilettes.FlatAppearance.BorderSize = 0;
            this.buttonAfficheToutesToilettes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficheToutesToilettes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAfficheToutesToilettes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfficheToutesToilettes.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAfficheToutesToilettes.ForeColor = System.Drawing.Color.White;
            this.buttonAfficheToutesToilettes.Location = new System.Drawing.Point(81, 190);
            this.buttonAfficheToutesToilettes.Name = "buttonAfficheToutesToilettes";
            this.buttonAfficheToutesToilettes.Size = new System.Drawing.Size(178, 36);
            this.buttonAfficheToutesToilettes.TabIndex = 52;
            this.buttonAfficheToutesToilettes.Text = "Rapport";
            this.buttonAfficheToutesToilettes.UseVisualStyleBackColor = false;
            this.buttonAfficheToutesToilettes.Click += new System.EventHandler(this.buttonAfficheToutesToilettes_Click);
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(138, 153);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(184, 27);
            this.comboBoxUser.TabIndex = 51;
            this.comboBoxUser.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(15, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 15);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nom d\'Utilisateur:";
            this.label1.Visible = false;
            // 
            // comboBoxNomToilette
            // 
            this.comboBoxNomToilette.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNomToilette.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomToilette.FormattingEnabled = true;
            this.comboBoxNomToilette.Location = new System.Drawing.Point(137, 103);
            this.comboBoxNomToilette.Name = "comboBoxNomToilette";
            this.comboBoxNomToilette.Size = new System.Drawing.Size(184, 27);
            this.comboBoxNomToilette.TabIndex = 49;
            this.comboBoxNomToilette.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(10, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nom de la Toilette:";
            this.label8.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(155, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "A";
            // 
            // dateFin
            // 
            this.dateFin.CalendarFont = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold);
            this.dateFin.CustomFormat = "yyyy-MM-dd";
            this.dateFin.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.dateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateFin.Location = new System.Drawing.Point(191, 40);
            this.dateFin.Name = "dateFin";
            this.dateFin.Size = new System.Drawing.Size(127, 27);
            this.dateFin.TabIndex = 31;
            // 
            // dateDebut
            // 
            this.dateDebut.CalendarFont = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold);
            this.dateDebut.CustomFormat = "yyyy-MM-dd";
            this.dateDebut.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.dateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateDebut.Location = new System.Drawing.Point(18, 40);
            this.dateDebut.Name = "dateDebut";
            this.dateDebut.Size = new System.Drawing.Size(127, 27);
            this.dateDebut.TabIndex = 30;
            // 
            // FormReportCaisse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewerCaisse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportCaisse";
            this.Text = "FormReportCaisse";
            this.Load += new System.EventHandler(this.FormReportCaisse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCaisse;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNomToilette;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private System.Windows.Forms.Button buttonAfficheToutesToilettes;
    }
}