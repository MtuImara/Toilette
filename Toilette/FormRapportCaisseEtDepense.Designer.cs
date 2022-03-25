namespace Toilette
{
    partial class FormRapportCaisseEtDepense
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DataTableCaisseDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetCaisseEtDepense = new Toilette.DataSetCaisseEtDepense();
            this.DataTableDepenseCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAfficherRapport = new System.Windows.Forms.Button();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNomSite = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateFin = new System.Windows.Forms.DateTimePicker();
            this.dateDebut = new System.Windows.Forms.DateTimePicker();
            this.reportViewerCaisseDense = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableCaisseDBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCaisseEtDepense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableDepenseCBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataTableCaisseDBindingSource
            // 
            this.DataTableCaisseDBindingSource.DataMember = "DataTableCaisseD";
            this.DataTableCaisseDBindingSource.DataSource = this.DataSetCaisseEtDepense;
            // 
            // DataSetCaisseEtDepense
            // 
            this.DataSetCaisseEtDepense.DataSetName = "DataSetCaisseEtDepense";
            this.DataSetCaisseEtDepense.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTableDepenseCBindingSource
            // 
            this.DataTableDepenseCBindingSource.DataMember = "DataTableDepenseC";
            this.DataTableDepenseCBindingSource.DataSource = this.DataSetCaisseEtDepense;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.buttonAfficherRapport);
            this.groupBox1.Controls.Add(this.comboBoxUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxNomSite);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateFin);
            this.groupBox1.Controls.Add(this.dateDebut);
            this.groupBox1.Location = new System.Drawing.Point(709, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 309);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // buttonAfficherRapport
            // 
            this.buttonAfficherRapport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficherRapport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAfficherRapport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficherRapport.FlatAppearance.BorderSize = 0;
            this.buttonAfficherRapport.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.buttonAfficherRapport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonAfficherRapport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAfficherRapport.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.buttonAfficherRapport.ForeColor = System.Drawing.Color.White;
            this.buttonAfficherRapport.Location = new System.Drawing.Point(81, 235);
            this.buttonAfficherRapport.Name = "buttonAfficherRapport";
            this.buttonAfficherRapport.Size = new System.Drawing.Size(178, 36);
            this.buttonAfficherRapport.TabIndex = 52;
            this.buttonAfficherRapport.Text = "Rapport";
            this.buttonAfficherRapport.UseVisualStyleBackColor = false;
            this.buttonAfficherRapport.Click += new System.EventHandler(this.buttonAfficheToutesToilettes_Click);
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
            // 
            // comboBoxNomSite
            // 
            this.comboBoxNomSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxNomSite.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNomSite.FormattingEnabled = true;
            this.comboBoxNomSite.Location = new System.Drawing.Point(137, 103);
            this.comboBoxNomSite.Name = "comboBoxNomSite";
            this.comboBoxNomSite.Size = new System.Drawing.Size(184, 27);
            this.comboBoxNomSite.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(14, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Nom du Site:";
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
            // reportViewerCaisseDense
            // 
            reportDataSource1.Name = "DataSetCaisseD";
            reportDataSource1.Value = this.DataTableCaisseDBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTableDepenseCBindingSource;
            this.reportViewerCaisseDense.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerCaisseDense.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewerCaisseDense.LocalReport.ReportEmbeddedResource = "Toilette.ReportCaisseDepense.rdlc";
            this.reportViewerCaisseDense.Location = new System.Drawing.Point(21, 19);
            this.reportViewerCaisseDense.Name = "reportViewerCaisseDense";
            this.reportViewerCaisseDense.ServerReport.BearerToken = null;
            this.reportViewerCaisseDense.Size = new System.Drawing.Size(677, 550);
            this.reportViewerCaisseDense.TabIndex = 6;
            // 
            // FormRapportCaisseEtDepense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewerCaisseDense);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRapportCaisseEtDepense";
            this.Text = "FormRapportCaisseEtDepense";
            this.Load += new System.EventHandler(this.FormRapportCaisseEtDepense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataTableCaisseDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetCaisseEtDepense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTableDepenseCBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAfficherRapport;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNomSite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateFin;
        private System.Windows.Forms.DateTimePicker dateDebut;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCaisseDense;
        private System.Windows.Forms.BindingSource DataTableCaisseDBindingSource;
        private DataSetCaisseEtDepense DataSetCaisseEtDepense;
        private System.Windows.Forms.BindingSource DataTableDepenseCBindingSource;
    }
}