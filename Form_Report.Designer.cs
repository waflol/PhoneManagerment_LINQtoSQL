
namespace PhoneManagerment_LINQtoSQL
{
    partial class Form_Report
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PhoneDB = new PhoneManagerment_LINQtoSQL.PhoneDB();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Show_Button = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TransactionsTableAdapter = new PhoneManagerment_LINQtoSQL.PhoneDBTableAdapters.TransactionsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDB)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionsBindingSource
            // 
            this.TransactionsBindingSource.DataMember = "Transactions";
            this.TransactionsBindingSource.DataSource = this.PhoneDB;
            // 
            // PhoneDB
            // 
            this.PhoneDB.DataSetName = "PhoneDB";
            this.PhoneDB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Chọn ngày";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(16, 32);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // Show_Button
            // 
            this.Show_Button.Location = new System.Drawing.Point(247, 29);
            this.Show_Button.Name = "Show_Button";
            this.Show_Button.Size = new System.Drawing.Size(75, 23);
            this.Show_Button.TabIndex = 5;
            this.Show_Button.Text = "Show";
            this.Show_Button.UseVisualStyleBackColor = true;
            this.Show_Button.Click += new System.EventHandler(this.Show_Button_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "PhoneDB";
            reportDataSource1.Value = this.TransactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PhoneManagerment_LINQtoSQL.Report_TongTienBanDt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 82);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(381, 246);
            this.reportViewer1.TabIndex = 8;
            // 
            // TransactionsTableAdapter
            // 
            this.TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 337);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Show_Button);
            this.Name = "Form_Report";
            this.Text = "Form_Report";
            this.Load += new System.EventHandler(this.Form_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PhoneDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Show_Button;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TransactionsBindingSource;
        private PhoneDB PhoneDB;
        private PhoneDBTableAdapters.TransactionsTableAdapter TransactionsTableAdapter;
    }
}