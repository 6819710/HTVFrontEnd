namespace HTVFrontEnd
{
    partial class FormMain
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
            this.btn_customer = new System.Windows.Forms.Button();
            this.btn_sales = new System.Windows.Forms.Button();
            this.btn_vehicles = new System.Windows.Forms.Button();
            this.btn_dealerInstalledOptions = new System.Windows.Forms.Button();
            this.btn_taxInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_customer
            // 
            this.btn_customer.Location = new System.Drawing.Point(12, 12);
            this.btn_customer.Name = "btn_customer";
            this.btn_customer.Size = new System.Drawing.Size(166, 70);
            this.btn_customer.TabIndex = 0;
            this.btn_customer.Text = "Customers";
            this.btn_customer.UseVisualStyleBackColor = true;
            this.btn_customer.Click += new System.EventHandler(this.btn_customer_Click);
            // 
            // btn_sales
            // 
            this.btn_sales.Location = new System.Drawing.Point(184, 12);
            this.btn_sales.Name = "btn_sales";
            this.btn_sales.Size = new System.Drawing.Size(166, 70);
            this.btn_sales.TabIndex = 1;
            this.btn_sales.Text = "Sales";
            this.btn_sales.UseVisualStyleBackColor = true;
            this.btn_sales.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // btn_vehicles
            // 
            this.btn_vehicles.Location = new System.Drawing.Point(356, 12);
            this.btn_vehicles.Name = "btn_vehicles";
            this.btn_vehicles.Size = new System.Drawing.Size(166, 70);
            this.btn_vehicles.TabIndex = 2;
            this.btn_vehicles.Text = "Vehicles";
            this.btn_vehicles.UseVisualStyleBackColor = true;
            this.btn_vehicles.Click += new System.EventHandler(this.btn_vehicles_Click);
            // 
            // btn_dealerInstalledOptions
            // 
            this.btn_dealerInstalledOptions.Location = new System.Drawing.Point(528, 12);
            this.btn_dealerInstalledOptions.Name = "btn_dealerInstalledOptions";
            this.btn_dealerInstalledOptions.Size = new System.Drawing.Size(166, 70);
            this.btn_dealerInstalledOptions.TabIndex = 3;
            this.btn_dealerInstalledOptions.Text = "Dealer Installed Options";
            this.btn_dealerInstalledOptions.UseVisualStyleBackColor = true;
            this.btn_dealerInstalledOptions.Click += new System.EventHandler(this.btn_dealerInstalledOptions_Click);
            // 
            // btn_taxInvoice
            // 
            this.btn_taxInvoice.Location = new System.Drawing.Point(700, 12);
            this.btn_taxInvoice.Name = "btn_taxInvoice";
            this.btn_taxInvoice.Size = new System.Drawing.Size(166, 70);
            this.btn_taxInvoice.TabIndex = 4;
            this.btn_taxInvoice.Text = "Tax Invoices";
            this.btn_taxInvoice.UseVisualStyleBackColor = true;
            this.btn_taxInvoice.Click += new System.EventHandler(this.btn_taxInvoice_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 98);
            this.Controls.Add(this.btn_taxInvoice);
            this.Controls.Add(this.btn_dealerInstalledOptions);
            this.Controls.Add(this.btn_vehicles);
            this.Controls.Add(this.btn_sales);
            this.Controls.Add(this.btn_customer);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_customer;
        private System.Windows.Forms.Button btn_sales;
        private System.Windows.Forms.Button btn_vehicles;
        private System.Windows.Forms.Button btn_dealerInstalledOptions;
        private System.Windows.Forms.Button btn_taxInvoice;
    }
}