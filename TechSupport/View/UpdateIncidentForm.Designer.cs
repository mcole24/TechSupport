namespace TechSupport.View
{
    partial class UpdateIncidentForm
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
            this.incidentIDLabel = new System.Windows.Forms.Label();
            this.incidentIDBox = new System.Windows.Forms.TextBox();
            this.getIncidentButton = new System.Windows.Forms.Button();
            this.customerLabel = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.productBox = new System.Windows.Forms.TextBox();
            this.technicianLabel = new System.Windows.Forms.Label();
            this.technicianComboBox = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.dateOpenedLabel = new System.Windows.Forms.Label();
            this.dateOpenedBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.textToAddLabel = new System.Windows.Forms.Label();
            this.textToAddBox = new System.Windows.Forms.TextBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // incidentIDLabel
            // 
            this.incidentIDLabel.AutoSize = true;
            this.incidentIDLabel.Location = new System.Drawing.Point(23, 38);
            this.incidentIDLabel.Name = "incidentIDLabel";
            this.incidentIDLabel.Size = new System.Drawing.Size(65, 13);
            this.incidentIDLabel.TabIndex = 0;
            this.incidentIDLabel.Text = "Incident ID: ";
            // 
            // incidentIDBox
            // 
            this.incidentIDBox.Location = new System.Drawing.Point(123, 30);
            this.incidentIDBox.Name = "incidentIDBox";
            this.incidentIDBox.Size = new System.Drawing.Size(109, 20);
            this.incidentIDBox.TabIndex = 1;
            // 
            // getIncidentButton
            // 
            this.getIncidentButton.Location = new System.Drawing.Point(259, 27);
            this.getIncidentButton.Name = "getIncidentButton";
            this.getIncidentButton.Size = new System.Drawing.Size(103, 23);
            this.getIncidentButton.TabIndex = 2;
            this.getIncidentButton.Text = "Get";
            this.getIncidentButton.UseVisualStyleBackColor = true;
            this.getIncidentButton.Click += new System.EventHandler(this.getIncidentButton_Click);
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(23, 57);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(57, 13);
            this.customerLabel.TabIndex = 3;
            this.customerLabel.Text = "Customer: ";
            // 
            // customerBox
            // 
            this.customerBox.Enabled = false;
            this.customerBox.Location = new System.Drawing.Point(123, 57);
            this.customerBox.Name = "customerBox";
            this.customerBox.ReadOnly = true;
            this.customerBox.Size = new System.Drawing.Size(239, 20);
            this.customerBox.TabIndex = 4;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(23, 83);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(50, 13);
            this.productLabel.TabIndex = 5;
            this.productLabel.Text = "Product: ";
            // 
            // productBox
            // 
            this.productBox.Enabled = false;
            this.productBox.Location = new System.Drawing.Point(123, 83);
            this.productBox.Name = "productBox";
            this.productBox.ReadOnly = true;
            this.productBox.Size = new System.Drawing.Size(239, 20);
            this.productBox.TabIndex = 6;
            // 
            // technicianLabel
            // 
            this.technicianLabel.AutoSize = true;
            this.technicianLabel.Location = new System.Drawing.Point(22, 109);
            this.technicianLabel.Name = "technicianLabel";
            this.technicianLabel.Size = new System.Drawing.Size(66, 13);
            this.technicianLabel.TabIndex = 7;
            this.technicianLabel.Text = "Technician: ";
            // 
            // technicianComboBox
            // 
            this.technicianComboBox.Enabled = false;
            this.technicianComboBox.FormattingEnabled = true;
            this.technicianComboBox.Location = new System.Drawing.Point(123, 109);
            this.technicianComboBox.Name = "technicianComboBox";
            this.technicianComboBox.Size = new System.Drawing.Size(239, 21);
            this.technicianComboBox.TabIndex = 8;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(23, 136);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 13);
            this.titleLabel.TabIndex = 9;
            this.titleLabel.Text = "Title: ";
            // 
            // titleBox
            // 
            this.titleBox.Enabled = false;
            this.titleBox.Location = new System.Drawing.Point(123, 136);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(239, 20);
            this.titleBox.TabIndex = 10;
            // 
            // dateOpenedLabel
            // 
            this.dateOpenedLabel.AutoSize = true;
            this.dateOpenedLabel.Location = new System.Drawing.Point(23, 162);
            this.dateOpenedLabel.Name = "dateOpenedLabel";
            this.dateOpenedLabel.Size = new System.Drawing.Size(77, 13);
            this.dateOpenedLabel.TabIndex = 11;
            this.dateOpenedLabel.Text = "Date Opened: ";
            // 
            // dateOpenedBox
            // 
            this.dateOpenedBox.Enabled = false;
            this.dateOpenedBox.Location = new System.Drawing.Point(123, 162);
            this.dateOpenedBox.Name = "dateOpenedBox";
            this.dateOpenedBox.ReadOnly = true;
            this.dateOpenedBox.Size = new System.Drawing.Size(100, 20);
            this.dateOpenedBox.TabIndex = 12;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(23, 188);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionLabel.TabIndex = 13;
            this.descriptionLabel.Text = "Description: ";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Enabled = false;
            this.descriptionBox.Location = new System.Drawing.Point(123, 188);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.ReadOnly = true;
            this.descriptionBox.Size = new System.Drawing.Size(239, 95);
            this.descriptionBox.TabIndex = 14;
            // 
            // textToAddLabel
            // 
            this.textToAddLabel.AutoSize = true;
            this.textToAddLabel.Location = new System.Drawing.Point(23, 289);
            this.textToAddLabel.Name = "textToAddLabel";
            this.textToAddLabel.Size = new System.Drawing.Size(67, 13);
            this.textToAddLabel.TabIndex = 15;
            this.textToAddLabel.Text = "Text to add: ";
            // 
            // textToAddBox
            // 
            this.textToAddBox.Enabled = false;
            this.textToAddBox.Location = new System.Drawing.Point(123, 289);
            this.textToAddBox.Multiline = true;
            this.textToAddBox.Name = "textToAddBox";
            this.textToAddBox.ReadOnly = true;
            this.textToAddBox.Size = new System.Drawing.Size(239, 100);
            this.textToAddBox.TabIndex = 16;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(123, 418);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 17;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(205, 418);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 18;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(287, 418);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 19;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // UpdateIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 483);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.textToAddBox);
            this.Controls.Add(this.textToAddLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.dateOpenedBox);
            this.Controls.Add(this.dateOpenedLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.technicianComboBox);
            this.Controls.Add(this.technicianLabel);
            this.Controls.Add(this.productBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.getIncidentButton);
            this.Controls.Add(this.incidentIDBox);
            this.Controls.Add(this.incidentIDLabel);
            this.Name = "UpdateIncidentForm";
            this.Text = "Update Incident";
            this.Load += new System.EventHandler(this.UpdateIncidentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label incidentIDLabel;
        private System.Windows.Forms.TextBox incidentIDBox;
        private System.Windows.Forms.Button getIncidentButton;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox productBox;
        private System.Windows.Forms.Label technicianLabel;
        private System.Windows.Forms.ComboBox technicianComboBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label dateOpenedLabel;
        private System.Windows.Forms.TextBox dateOpenedBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label textToAddLabel;
        private System.Windows.Forms.TextBox textToAddBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button cancelButton;
    }
}