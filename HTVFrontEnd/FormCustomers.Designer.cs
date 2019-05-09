namespace HTVFrontEnd
{
    partial class FormCustomers
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
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_custID = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.text_custName = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.text_custAddress = new System.Windows.Forms.TextBox();
            this.lbl_phonePrimary = new System.Windows.Forms.Label();
            this.lbl_phoneSecondary = new System.Windows.Forms.Label();
            this.text_phonePrimary = new System.Windows.Forms.TextBox();
            this.text_phoneSecondary = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_history = new System.Windows.Forms.Label();
            this.col_saleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_vehicle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_staff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(12, 415);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(612, 415);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(612, 12);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(12, 9);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(68, 13);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Text = "Customer ID:";
            // 
            // lbl_custID
            // 
            this.lbl_custID.AllowDrop = true;
            this.lbl_custID.AutoSize = true;
            this.lbl_custID.Location = new System.Drawing.Point(83, 9);
            this.lbl_custID.Name = "lbl_custID";
            this.lbl_custID.Size = new System.Drawing.Size(84, 13);
            this.lbl_custID.TabIndex = 4;
            this.lbl_custID.Text = "ID CONTAINER";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(12, 44);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name:";
            // 
            // text_custName
            // 
            this.text_custName.Location = new System.Drawing.Point(53, 41);
            this.text_custName.Name = "text_custName";
            this.text_custName.Size = new System.Drawing.Size(254, 20);
            this.text_custName.TabIndex = 6;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Location = new System.Drawing.Point(341, 44);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(48, 13);
            this.lbl_address.TabIndex = 7;
            this.lbl_address.Text = "Address:";
            // 
            // text_custAddress
            // 
            this.text_custAddress.Location = new System.Drawing.Point(395, 41);
            this.text_custAddress.Name = "text_custAddress";
            this.text_custAddress.Size = new System.Drawing.Size(292, 20);
            this.text_custAddress.TabIndex = 8;
            // 
            // lbl_phonePrimary
            // 
            this.lbl_phonePrimary.AutoSize = true;
            this.lbl_phonePrimary.Location = new System.Drawing.Point(12, 90);
            this.lbl_phonePrimary.Name = "lbl_phonePrimary";
            this.lbl_phonePrimary.Size = new System.Drawing.Size(41, 13);
            this.lbl_phonePrimary.TabIndex = 9;
            this.lbl_phonePrimary.Text = "Phone:";
            // 
            // lbl_phoneSecondary
            // 
            this.lbl_phoneSecondary.AutoSize = true;
            this.lbl_phoneSecondary.Location = new System.Drawing.Point(341, 90);
            this.lbl_phoneSecondary.Name = "lbl_phoneSecondary";
            this.lbl_phoneSecondary.Size = new System.Drawing.Size(92, 13);
            this.lbl_phoneSecondary.TabIndex = 10;
            this.lbl_phoneSecondary.Text = "Secondary Phone";
            // 
            // text_phonePrimary
            // 
            this.text_phonePrimary.Location = new System.Drawing.Point(59, 87);
            this.text_phonePrimary.Name = "text_phonePrimary";
            this.text_phonePrimary.Size = new System.Drawing.Size(248, 20);
            this.text_phonePrimary.TabIndex = 11;
            // 
            // text_phoneSecondary
            // 
            this.text_phoneSecondary.Location = new System.Drawing.Point(439, 87);
            this.text_phoneSecondary.Name = "text_phoneSecondary";
            this.text_phoneSecondary.Size = new System.Drawing.Size(248, 20);
            this.text_phoneSecondary.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_saleID,
            this.col_date,
            this.col_vehicle,
            this.col_price,
            this.col_staff});
            this.dataGridView1.Location = new System.Drawing.Point(12, 146);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(675, 263);
            this.dataGridView1.TabIndex = 13;
            // 
            // lbl_history
            // 
            this.lbl_history.AutoSize = true;
            this.lbl_history.Location = new System.Drawing.Point(12, 130);
            this.lbl_history.Name = "lbl_history";
            this.lbl_history.Size = new System.Drawing.Size(88, 13);
            this.lbl_history.TabIndex = 14;
            this.lbl_history.Text = "Purchace History";
            // 
            // col_saleID
            // 
            this.col_saleID.HeaderText = "Invoice #";
            this.col_saleID.Name = "col_saleID";
            this.col_saleID.ReadOnly = true;
            // 
            // col_date
            // 
            this.col_date.HeaderText = "Date";
            this.col_date.Name = "col_date";
            this.col_date.ReadOnly = true;
            // 
            // col_vehicle
            // 
            this.col_vehicle.HeaderText = "Purchaced Vehicle";
            this.col_vehicle.Name = "col_vehicle";
            this.col_vehicle.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.HeaderText = "SalePrice";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_staff
            // 
            this.col_staff.HeaderText = "Sales Staff";
            this.col_staff.Name = "col_staff";
            this.col_staff.ReadOnly = true;
            // 
            // FormCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.lbl_history);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.text_phoneSecondary);
            this.Controls.Add(this.text_phonePrimary);
            this.Controls.Add(this.lbl_phoneSecondary);
            this.Controls.Add(this.lbl_phonePrimary);
            this.Controls.Add(this.text_custAddress);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.text_custName);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_custID);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Name = "FormCustomers";
            this.Text = "FormCustomers";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_custID;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox text_custName;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox text_custAddress;
        private System.Windows.Forms.Label lbl_phonePrimary;
        private System.Windows.Forms.Label lbl_phoneSecondary;
        private System.Windows.Forms.TextBox text_phonePrimary;
        private System.Windows.Forms.TextBox text_phoneSecondary;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_history;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_saleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_vehicle;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_staff;
    }
}