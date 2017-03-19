﻿namespace TechSupport.View
{
    partial class OpenIncidentsReport
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.incidentReportDataSet = new TechSupport.IncidentReportDataSet();
            this.incidentReportDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OpenIncidentsForTechnicians";
            reportDataSource1.Value = this.incidentReportDataSetBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "TechSupport.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(739, 445);
            this.reportViewer1.TabIndex = 0;
            // 
            // incidentReportDataSet
            // 
            this.incidentReportDataSet.DataSetName = "IncidentReportDataSet";
            this.incidentReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // incidentReportDataSetBindingSource
            // 
            this.incidentReportDataSetBindingSource.DataSource = this.incidentReportDataSet;
            this.incidentReportDataSetBindingSource.Position = 0;
            // 
            // OpenIncidentsReport
            // 
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.reportViewer1);
            this.Name = "OpenIncidentsReport";
            this.Text = "Open Incidents Report";
            this.Load += new System.EventHandler(this.OpenIncidentsReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidentReportDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource incidentReportDataSetBindingSource;
        private IncidentReportDataSet incidentReportDataSet;
    }
}