using System.Collections.Generic;

namespace HTVFrontEnd
{
    partial class FormDealerInstalledOptions
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
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_prev = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.lbl_optId = new System.Windows.Forms.Label();
            this.lbl_optDes = new System.Windows.Forms.Label();
            this.lbl_optCost = new System.Windows.Forms.Label();
            this.text_optId = new System.Windows.Forms.TextBox();
            this.text_optDes = new System.Windows.Forms.TextBox();
            this.text_optCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(440, 357);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 0;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            // 
            // btn_prev
            // 
            this.btn_prev.Location = new System.Drawing.Point(12, 357);
            this.btn_prev.Name = "btn_prev";
            this.btn_prev.Size = new System.Drawing.Size(75, 23);
            this.btn_prev.TabIndex = 1;
            this.btn_prev.Text = "Previous";
            this.btn_prev.UseVisualStyleBackColor = true;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(12, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(75, 23);
            this.btn_new.TabIndex = 2;
            this.btn_new.Text = "New";
            this.btn_new.UseVisualStyleBackColor = true;
            // 
            // lbl_optId
            // 
            this.lbl_optId.AutoSize = true;
            this.lbl_optId.Location = new System.Drawing.Point(12, 38);
            this.lbl_optId.Name = "lbl_optId";
            this.lbl_optId.Size = new System.Drawing.Size(55, 13);
            this.lbl_optId.TabIndex = 3;
            this.lbl_optId.Text = "Option ID:";
            // 
            // lbl_optDes
            // 
            this.lbl_optDes.AutoSize = true;
            this.lbl_optDes.Location = new System.Drawing.Point(12, 99);
            this.lbl_optDes.Name = "lbl_optDes";
            this.lbl_optDes.Size = new System.Drawing.Size(97, 13);
            this.lbl_optDes.TabIndex = 4;
            this.lbl_optDes.Text = "Option Description:";
            // 
            // lbl_optCost
            // 
            this.lbl_optCost.AutoSize = true;
            this.lbl_optCost.Location = new System.Drawing.Point(12, 308);
            this.lbl_optCost.Name = "lbl_optCost";
            this.lbl_optCost.Size = new System.Drawing.Size(92, 13);
            this.lbl_optCost.TabIndex = 5;
            this.lbl_optCost.Text = "Option Base Cost:";
            // 
            // text_optId
            // 
            this.text_optId.Location = new System.Drawing.Point(12, 54);
            this.text_optId.Name = "text_optId";
            this.text_optId.Size = new System.Drawing.Size(503, 20);
            this.text_optId.TabIndex = 6;
            // 
            // text_optDes
            // 
            this.text_optDes.Location = new System.Drawing.Point(12, 115);
            this.text_optDes.Multiline = true;
            this.text_optDes.Name = "text_optDes";
            this.text_optDes.Size = new System.Drawing.Size(503, 166);
            this.text_optDes.TabIndex = 7;
            // 
            // text_optCost
            // 
            this.text_optCost.Location = new System.Drawing.Point(12, 324);
            this.text_optCost.Name = "text_optCost";
            this.text_optCost.Size = new System.Drawing.Size(503, 20);
            this.text_optCost.TabIndex = 8;
            // 
            // FormDealerInstalledOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 392);
            this.Controls.Add(this.text_optCost);
            this.Controls.Add(this.text_optDes);
            this.Controls.Add(this.text_optId);
            this.Controls.Add(this.lbl_optCost);
            this.Controls.Add(this.lbl_optDes);
            this.Controls.Add(this.lbl_optId);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_prev);
            this.Controls.Add(this.btn_next);
            this.Name = "FormDealerInstalledOptions";
            this.Text = "FormDealerInstalledOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_prev;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lbl_optId;
        private System.Windows.Forms.Label lbl_optDes;
        private System.Windows.Forms.Label lbl_optCost;
        private System.Windows.Forms.TextBox text_optId;
        private System.Windows.Forms.TextBox text_optDes;
        private System.Windows.Forms.TextBox text_optCost;
    }
}