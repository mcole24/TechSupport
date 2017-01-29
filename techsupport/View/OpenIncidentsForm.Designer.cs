namespace TechSupport.View
{
    partial class OpenIncidentsForm
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
            this.openIncidentsListView = new System.Windows.Forms.ListView();
            this.ProductCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOpened = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Technician = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // openIncidentsListView
            // 
            this.openIncidentsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductCode,
            this.DateOpened,
            this.Customer,
            this.Technician,
            this.Title});
            this.openIncidentsListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.openIncidentsListView.Location = new System.Drawing.Point(0, 0);
            this.openIncidentsListView.Name = "openIncidentsListView";
            this.openIncidentsListView.Size = new System.Drawing.Size(557, 341);
            this.openIncidentsListView.TabIndex = 0;
            this.openIncidentsListView.UseCompatibleStateImageBehavior = false;
            this.openIncidentsListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ProductCode
            // 
            this.ProductCode.Text = "Product Code";
            // 
            // DateOpened
            // 
            this.DateOpened.Text = "Date Opened";
            this.DateOpened.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Customer
            // 
            this.Customer.Text = "Customer";
            this.Customer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Technician
            // 
            this.Technician.Text = "Technician";
            this.Technician.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OpenIncidentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 341);
            this.Controls.Add(this.openIncidentsListView);
            this.Name = "OpenIncidentsForm";
            this.Text = "Open Incidents";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OpenIncidentsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView openIncidentsListView;
        private System.Windows.Forms.ColumnHeader ProductCode;
        private System.Windows.Forms.ColumnHeader DateOpened;
        private System.Windows.Forms.ColumnHeader Customer;
        private System.Windows.Forms.ColumnHeader Technician;
        private System.Windows.Forms.ColumnHeader Title;
    }
}