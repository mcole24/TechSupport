namespace TechSupport.View
{
    partial class CreateIncidentForm
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
        5
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.customerNameBox = new System.Windows.Forms.ComboBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.productNameBox = new System.Windows.Forms.ComboBox();
            this.productLabel = new System.Windows.Forms.Label();
            this.titleBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.descriptionBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.createIncidentButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameBox
            // 
            this.customerNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerNameBox.FormattingEnabled = true;
            this.customerNameBox.Location = new System.Drawing.Point(126, 28);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(275, 21);
            this.customerNameBox.TabIndex = 0;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLabel.Location = new System.Drawing.Point(63, 28);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(57, 13);
            this.customerLabel.TabIndex = 1;
            this.customerLabel.Text = "Customer: ";
            // 
            // productNameBox
            // 
            this.productNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameBox.FormattingEnabled = true;
            this.productNameBox.Location = new System.Drawing.Point(126, 55);
            this.productNameBox.Name = "productNameBox";
            this.productNameBox.Size = new System.Drawing.Size(275, 21);
            this.productNameBox.TabIndex = 2;
            // 
            // productLabel
            // 
            this.productLabel.AutoSize = true;
            this.productLabel.Location = new System.Drawing.Point(70, 58);
            this.productLabel.Name = "productLabel";
            this.productLabel.Size = new System.Drawing.Size(50, 13);
            this.productLabel.TabIndex = 3;
            this.productLabel.Text = "Product: ";
            // 
            // titleBox
            // 
            this.titleBox.Location = new System.Drawing.Point(126, 82);
            this.titleBox.Name = "titleBox";
            this.titleBox.Size = new System.Drawing.Size(275, 20);
            this.titleBox.TabIndex = 4;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(87, 82);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(33, 13);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Title: ";
            // 
            // descriptionBox
            // 
            this.descriptionBox.Location = new System.Drawing.Point(126, 108);
            this.descriptionBox.Multiline = true;
            this.descriptionBox.Name = "descriptionBox";
            this.descriptionBox.Size = new System.Drawing.Size(275, 140);
            this.descriptionBox.TabIndex = 6;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(54, 111);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(66, 13);
            this.descriptionLabel.TabIndex = 7;
            this.descriptionLabel.Text = "Description: ";
            // 
            // createIncidentButton
            // 
            this.createIncidentButton.Location = new System.Drawing.Point(126, 289);
            this.createIncidentButton.Name = "createIncidentButton";
            this.createIncidentButton.Size = new System.Drawing.Size(103, 23);
            this.createIncidentButton.TabIndex = 8;
            this.createIncidentButton.Text = "Create Incident";
            this.createIncidentButton.UseVisualStyleBackColor = true;
            this.createIncidentButton.Click += new System.EventHandler(this.createIncidentButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(325, 289);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CreateIncidentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 347);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createIncidentButton);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.descriptionBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.productLabel);
            this.Controls.Add(this.productNameBox);
            this.Controls.Add(this.customerLabel);
            this.Controls.Add(this.customerNameBox);
            this.Name = "CreateIncidentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateIncidentForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CreateIncidentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerNameBox;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox productNameBox;
        private System.Windows.Forms.Label productLabel;
        private System.Windows.Forms.TextBox titleBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox descriptionBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button createIncidentButton;
        private System.Windows.Forms.Button cancelButton;
    }
}