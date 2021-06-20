
namespace PhoneManagerment_LINQtoSQL
{
    partial class Form_Phone_Details
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
            this.phoneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridView_PhoneRecord = new System.Windows.Forms.DataGridView();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.txt_PhoneID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PhoneRecord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // phoneBindingSource
            // 
            this.phoneBindingSource.DataMember = "Phone";
            // 
            // phonesBindingSource
            // 
            this.phonesBindingSource.DataMember = "Phones";
            // 
            // GridView_PhoneRecord
            // 
            this.GridView_PhoneRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_PhoneRecord.GridColor = System.Drawing.SystemColors.Control;
            this.GridView_PhoneRecord.Location = new System.Drawing.Point(10, 203);
            this.GridView_PhoneRecord.Name = "GridView_PhoneRecord";
            this.GridView_PhoneRecord.RowHeadersVisible = false;
            this.GridView_PhoneRecord.Size = new System.Drawing.Size(1007, 236);
            this.GridView_PhoneRecord.TabIndex = 56;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "Phone";
            // 
            // bindingSource2
            // 
            this.bindingSource2.DataMember = "Phones";
            // 
            // txt_PhoneID
            // 
            this.txt_PhoneID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PhoneID.Location = new System.Drawing.Point(494, 93);
            this.txt_PhoneID.Name = "txt_PhoneID";
            this.txt_PhoneID.Size = new System.Drawing.Size(203, 26);
            this.txt_PhoneID.TabIndex = 54;
            this.txt_PhoneID.TextChanged += new System.EventHandler(this.txt_PhoneID_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(396, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Phone Id";
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.Firebrick;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(481, 165);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(78, 32);
            this.btn_Delete.TabIndex = 55;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "label3";
            // 
            // btn_Edit
            // 
            this.btn_Edit.BackColor = System.Drawing.Color.DarkGreen;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Edit.Location = new System.Drawing.Point(591, 165);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(78, 32);
            this.btn_Edit.TabIndex = 58;
            this.btn_Edit.Text = "Edit";
            this.btn_Edit.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(458, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 31);
            this.label4.TabIndex = 59;
            this.label4.Text = "Phone Available";
            // 
            // Form_Phone_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.GridView_PhoneRecord);
            this.Controls.Add(this.txt_PhoneID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.label3);
            this.Name = "Form_Phone_Details";
            this.Text = "Form_Phone_Details";
            this.Load += new System.EventHandler(this.Form_Phone_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.phoneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_PhoneRecord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource phoneBindingSource;
        private System.Windows.Forms.BindingSource phonesBindingSource;
        private System.Windows.Forms.DataGridView GridView_PhoneRecord;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.TextBox txt_PhoneID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Label label4;
    }
}