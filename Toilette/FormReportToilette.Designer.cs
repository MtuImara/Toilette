namespace Toilette
{
    partial class FormReportToilette
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
            this.reportViewerToilette = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAfficheToutesToilettes = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewerToilette
            // 
            this.reportViewerToilette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportViewerToilette.LocalReport.ReportEmbeddedResource = "Toilette.RapportToilette.rdlc";
            this.reportViewerToilette.Location = new System.Drawing.Point(17, 25);
            this.reportViewerToilette.Name = "reportViewerToilette";
            this.reportViewerToilette.ServerReport.BearerToken = null;
            this.reportViewerToilette.Size = new System.Drawing.Size(703, 561);
            this.reportViewerToilette.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.comboBoxType);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.buttonAfficheToutesToilettes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(759, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 309);
            this.panel1.TabIndex = 35;
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
            this.buttonAfficheToutesToilettes.Location = new System.Drawing.Point(63, 198);
            this.buttonAfficheToutesToilettes.Name = "buttonAfficheToutesToilettes";
            this.buttonAfficheToutesToilettes.Size = new System.Drawing.Size(178, 36);
            this.buttonAfficheToutesToilettes.TabIndex = 34;
            this.buttonAfficheToutesToilettes.Text = "Rapport";
            this.buttonAfficheToutesToilettes.UseVisualStyleBackColor = false;
            this.buttonAfficheToutesToilettes.Click += new System.EventHandler(this.buttonAfficheToutesToilettes_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(47, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(209, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Voir toutes les Toilettes";
            // 
            // comboBoxType
            // 
            this.comboBoxType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Femme",
            "Homme"});
            this.comboBoxType.Location = new System.Drawing.Point(108, 100);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(161, 23);
            this.comboBoxType.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 11F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(26, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 19);
            this.label9.TabIndex = 35;
            this.label9.Text = "Type:";
            // 
            // FormReportToilette
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reportViewerToilette);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormReportToilette";
            this.Text = "FormReportToilette";
            this.Load += new System.EventHandler(this.FormReportToilette_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewerToilette;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonAfficheToutesToilettes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label9;
    }
}