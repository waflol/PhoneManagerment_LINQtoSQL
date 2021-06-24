
namespace PhoneManagerment_LINQtoSQL {
    partial class Customer_ID_Detail {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SDT_Textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reload_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(508, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // SDT_Textbox
            // 
            this.SDT_Textbox.Location = new System.Drawing.Point(213, 21);
            this.SDT_Textbox.Name = "SDT_Textbox";
            this.SDT_Textbox.Size = new System.Drawing.Size(263, 20);
            this.SDT_Textbox.TabIndex = 1;
            this.SDT_Textbox.TextChanged += new System.EventHandler(this.KH_Textbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tìm Khách Hàng";
            // 
            // Reload_Button
            // 
            this.Reload_Button.Location = new System.Drawing.Point(401, 52);
            this.Reload_Button.Name = "Reload_Button";
            this.Reload_Button.Size = new System.Drawing.Size(75, 23);
            this.Reload_Button.TabIndex = 3;
            this.Reload_Button.Text = "Reload";
            this.Reload_Button.UseVisualStyleBackColor = true;
            this.Reload_Button.Click += new System.EventHandler(this.Reload_Button_Click);
            // 
            // Customer_ID_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(531, 401);
            this.Controls.Add(this.Reload_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SDT_Textbox);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Customer_ID_Detail";
            this.Text = "Customer_ID_Detail";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SDT_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Reload_Button;
    }
}