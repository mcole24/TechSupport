﻿namespace TechSupport
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayOpenIncidentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateIncidentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewIncidentsByTechniciansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openIncidentsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.incidentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(778, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // incidentsToolStripMenuItem
            // 
            this.incidentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayOpenIncidentsToolStripMenuItem,
            this.createIncidentToolStripMenuItem,
            this.updateIncidentToolStripMenuItem,
            this.viewIncidentsByTechniciansToolStripMenuItem,
            this.openIncidentsReportToolStripMenuItem});
            this.incidentsToolStripMenuItem.Name = "incidentsToolStripMenuItem";
            this.incidentsToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.incidentsToolStripMenuItem.Text = "Incidents";
            // 
            // displayOpenIncidentsToolStripMenuItem
            // 
            this.displayOpenIncidentsToolStripMenuItem.Name = "displayOpenIncidentsToolStripMenuItem";
            this.displayOpenIncidentsToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.displayOpenIncidentsToolStripMenuItem.Text = "Display Open Incidents";
            this.displayOpenIncidentsToolStripMenuItem.Click += new System.EventHandler(this.displayOpenIncidentsToolStripMenuItem_Click);
            // 
            // createIncidentToolStripMenuItem
            // 
            this.createIncidentToolStripMenuItem.Name = "createIncidentToolStripMenuItem";
            this.createIncidentToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.createIncidentToolStripMenuItem.Text = "Create Incident";
            this.createIncidentToolStripMenuItem.Click += new System.EventHandler(this.createIncidentToolStripMenuItem_Click);
            // 
            // updateIncidentToolStripMenuItem
            // 
            this.updateIncidentToolStripMenuItem.Name = "updateIncidentToolStripMenuItem";
            this.updateIncidentToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.updateIncidentToolStripMenuItem.Text = "Update Incident";
            this.updateIncidentToolStripMenuItem.Click += new System.EventHandler(this.updateIncidentToolStripMenuItem_Click);
            // 
            // viewIncidentsByTechniciansToolStripMenuItem
            // 
            this.viewIncidentsByTechniciansToolStripMenuItem.Name = "viewIncidentsByTechniciansToolStripMenuItem";
            this.viewIncidentsByTechniciansToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.viewIncidentsByTechniciansToolStripMenuItem.Text = "View Incidents By Technicians";
            this.viewIncidentsByTechniciansToolStripMenuItem.Click += new System.EventHandler(this.viewIncidentsByTechniciansToolStripMenuItem_Click);
            // 
            // openIncidentsReportToolStripMenuItem
            // 
            this.openIncidentsReportToolStripMenuItem.Name = "openIncidentsReportToolStripMenuItem";
            this.openIncidentsReportToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.openIncidentsReportToolStripMenuItem.Text = "Open Incidents Report";
            this.openIncidentsReportToolStripMenuItem.Click += new System.EventHandler(this.openIncidentsReportToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 380);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Tech Support";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayOpenIncidentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateIncidentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewIncidentsByTechniciansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openIncidentsReportToolStripMenuItem;
    }
}

