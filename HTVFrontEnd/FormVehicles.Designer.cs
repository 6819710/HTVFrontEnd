namespace HTVFrontEnd
{
    partial class FormVehicles
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
            this.btn_updateInsert = new System.Windows.Forms.Button();
            this.lbl_serialNumber = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_year = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_baseCost = new System.Windows.Forms.Label();
            this.btn_new = new System.Windows.Forms.Button();
            this.text_serialNumber = new System.Windows.Forms.TextBox();
            this.text_name = new System.Windows.Forms.TextBox();
            this.text_baseCost = new System.Windows.Forms.TextBox();
            this.text_year = new System.Windows.Forms.TextBox();
            this.text_model = new System.Windows.Forms.TextBox();
            this.text_make = new System.Windows.Forms.TextBox();
            this.lbl_sold = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(12, 144);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 0;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            this.btn_prev.Click += new System.EventHandler(this.btn_prev_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(463, 144);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 1;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_updateInsert
            // 
            this.btn_updateInsert.Location = new System.Drawing.Point(463, 12);
            this.btn_updateInsert.Name = "btn_updateInsert";
            this.btn_updateInsert.Size = new System.Drawing.Size(75, 23);
            this.btn_updateInsert.TabIndex = 5;
            this.btn_updateInsert.Text = "Update";
            this.btn_updateInsert.UseVisualStyleBackColor = true;
            this.btn_updateInsert.Click += new System.EventHandler(this.btn_updateInsert_Click);
            // 
            // lbl_serialNumber
            // 
            this.lbl_serialNumber.AutoSize = true;
            this.lbl_serialNumber.Location = new System.Drawing.Point(12, 43);
            this.lbl_serialNumber.Name = "lbl_serialNumber";
            this.lbl_serialNumber.Size = new System.Drawing.Size(73, 13);
            this.lbl_serialNumber.TabIndex = 6;
            this.lbl_serialNumber.Text = "Serial Number";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(435, 43);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(35, 13);
            this.lbl_name.TabIndex = 7;
            this.lbl_name.Text = "Name";
            // 
            // lbl_year
            // 
            this.lbl_year.AutoSize = true;
            this.lbl_year.Location = new System.Drawing.Point(435, 90);
            this.lbl_year.Name = "lbl_year";
            this.lbl_year.Size = new System.Drawing.Size(29, 13);
            this.lbl_year.TabIndex = 8;
            this.lbl_year.Text = "Year";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Location = new System.Drawing.Point(12, 90);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(108, 13);
            this.lbl_make.TabIndex = 9;
            this.lbl_make.Text = "Make / Manufactorer";
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Location = new System.Drawing.Point(236, 90);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(36, 13);
            this.lbl_model.TabIndex = 10;
            this.lbl_model.Text = "Model";
            // 
            // lbl_baseCost
            // 
            this.lbl_baseCost.AutoSize = true;
            this.lbl_baseCost.Location = new System.Drawing.Point(236, 43);
            this.lbl_baseCost.Name = "lbl_baseCost";
            this.lbl_baseCost.Size = new System.Drawing.Size(55, 13);
            this.lbl_baseCost.TabIndex = 11;
            this.lbl_baseCost.Text = "Base Cost";
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 12;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // text_serialNumber
            // 
            this.text_serialNumber.Location = new System.Drawing.Point(12, 59);
            this.text_serialNumber.Name = "text_serialNumber";
            this.text_serialNumber.Size = new System.Drawing.Size(221, 20);
            this.text_serialNumber.TabIndex = 13;
            // 
            // text_name
            // 
            this.text_name.Location = new System.Drawing.Point(438, 59);
            this.text_name.Name = "text_name";
            this.text_name.Size = new System.Drawing.Size(100, 20);
            this.text_name.TabIndex = 14;
            // 
            // text_baseCost
            // 
            this.text_baseCost.Location = new System.Drawing.Point(239, 59);
            this.text_baseCost.Name = "text_baseCost";
            this.text_baseCost.Size = new System.Drawing.Size(193, 20);
            this.text_baseCost.TabIndex = 15;
            // 
            // text_year
            // 
            this.text_year.Location = new System.Drawing.Point(438, 106);
            this.text_year.Name = "text_year";
            this.text_year.Size = new System.Drawing.Size(100, 20);
            this.text_year.TabIndex = 16;
            // 
            // text_model
            // 
            this.text_model.Location = new System.Drawing.Point(239, 106);
            this.text_model.Name = "text_model";
            this.text_model.Size = new System.Drawing.Size(193, 20);
            this.text_model.TabIndex = 17;
            // 
            // text_make
            // 
            this.text_make.Location = new System.Drawing.Point(12, 106);
            this.text_make.Name = "text_make";
            this.text_make.Size = new System.Drawing.Size(221, 20);
            this.text_make.TabIndex = 18;
            // 
            // lbl_sold
            // 
            this.lbl_sold.AutoSize = true;
            this.lbl_sold.Location = new System.Drawing.Point(110, 17);
            this.lbl_sold.Name = "lbl_sold";
            this.lbl_sold.Size = new System.Drawing.Size(97, 13);
            this.lbl_sold.TabIndex = 19;
            this.lbl_sold.Text = "SOLD / AVALIBLE";
            // 
            // FormVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 179);
            this.Controls.Add(this.lbl_sold);
            this.Controls.Add(this.text_make);
            this.Controls.Add(this.text_model);
            this.Controls.Add(this.text_year);
            this.Controls.Add(this.text_baseCost);
            this.Controls.Add(this.text_name);
            this.Controls.Add(this.text_serialNumber);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.lbl_baseCost);
            this.Controls.Add(this.lbl_model);
            this.Controls.Add(this.lbl_make);
            this.Controls.Add(this.lbl_year);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_serialNumber);
            this.Controls.Add(this.btn_updateInsert);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_prev);
            this.Name = "FormVehicles";
            this.Text = "FormVehicles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_updateInsert;
        private System.Windows.Forms.Label lbl_serialNumber;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_year;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_baseCost;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox text_serialNumber;
        private System.Windows.Forms.TextBox text_name;
        private System.Windows.Forms.TextBox text_baseCost;
        private System.Windows.Forms.TextBox text_year;
        private System.Windows.Forms.TextBox text_model;
        private System.Windows.Forms.TextBox text_make;
        private System.Windows.Forms.Label lbl_sold;
    }
}