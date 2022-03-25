namespace Toilette
{
    partial class Dashboard
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
            this.panelTableauDeBord = new System.Windows.Forms.Panel();
            this.reportViewerCaisse = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelTableauDeBord.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTableauDeBord
            // 
            this.panelTableauDeBord.BackColor = System.Drawing.Color.White;
            this.panelTableauDeBord.Controls.Add(this.reportViewerCaisse);
            this.panelTableauDeBord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTableauDeBord.Location = new System.Drawing.Point(0, 0);
            this.panelTableauDeBord.Name = "panelTableauDeBord";
            this.panelTableauDeBord.Size = new System.Drawing.Size(1071, 588);
            this.panelTableauDeBord.TabIndex = 7;
            this.panelTableauDeBord.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTableauDeBord_Paint);
            // 
            // reportViewerCaisse
            // 
            this.reportViewerCaisse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportViewerCaisse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reportViewerCaisse.LocalReport.ReportEmbeddedResource = "Toilette.ReportGraphAccueil.rdlc";
            this.reportViewerCaisse.Location = new System.Drawing.Point(53, 35);
            this.reportViewerCaisse.Name = "reportViewerCaisse";
            this.reportViewerCaisse.ServerReport.BearerToken = null;
            this.reportViewerCaisse.ShowBackButton = false;
            this.reportViewerCaisse.ShowContextMenu = false;
            this.reportViewerCaisse.ShowCredentialPrompts = false;
            this.reportViewerCaisse.ShowDocumentMapButton = false;
            this.reportViewerCaisse.ShowExportButton = false;
            this.reportViewerCaisse.ShowFindControls = false;
            this.reportViewerCaisse.ShowPageNavigationControls = false;
            this.reportViewerCaisse.ShowParameterPrompts = false;
            this.reportViewerCaisse.ShowPrintButton = false;
            this.reportViewerCaisse.ShowProgress = false;
            this.reportViewerCaisse.ShowRefreshButton = false;
            this.reportViewerCaisse.ShowStopButton = false;
            this.reportViewerCaisse.ShowToolBar = false;
            this.reportViewerCaisse.Size = new System.Drawing.Size(980, 531);
            this.reportViewerCaisse.TabIndex = 1;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1071, 588);
            this.Controls.Add(this.panelTableauDeBord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panelTableauDeBord.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTableauDeBord;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerCaisse;
    }
}