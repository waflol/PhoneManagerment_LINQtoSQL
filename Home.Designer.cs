
namespace PhoneManagerment_LINQtoSQL
{
    partial class Home
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
            this.menu_Home = new System.Windows.Forms.MenuStrip();
            this.addTransactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPhoneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infomationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.benefitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu_Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_Home
            // 
            this.menu_Home.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_Home.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addTransactionToolStripMenuItem,
            this.transactionDetailToolStripMenuItem,
            this.addNewPhoneToolStripMenuItem,
            this.phoneDetailsToolStripMenuItem,
            this.infomationToolStripMenuItem,
            this.benefitToolStripMenuItem});
            this.menu_Home.Location = new System.Drawing.Point(0, 0);
            this.menu_Home.Name = "menu_Home";
            this.menu_Home.Size = new System.Drawing.Size(979, 33);
            this.menu_Home.TabIndex = 1;
            this.menu_Home.Text = "menuStrip1";
            // 
            // addTransactionToolStripMenuItem
            // 
            this.addTransactionToolStripMenuItem.Name = "addTransactionToolStripMenuItem";
            this.addTransactionToolStripMenuItem.Size = new System.Drawing.Size(166, 29);
            this.addTransactionToolStripMenuItem.Text = "Add transaction";
            this.addTransactionToolStripMenuItem.Click += new System.EventHandler(this.addTransactionToolStripMenuItem_Click);
            // 
            // transactionDetailToolStripMenuItem
            // 
            this.transactionDetailToolStripMenuItem.Name = "transactionDetailToolStripMenuItem";
            this.transactionDetailToolStripMenuItem.Size = new System.Drawing.Size(189, 29);
            this.transactionDetailToolStripMenuItem.Text = "Transaction details";
            this.transactionDetailToolStripMenuItem.Click += new System.EventHandler(this.transactionDetailToolStripMenuItem_Click);
            // 
            // addNewPhoneToolStripMenuItem
            // 
            this.addNewPhoneToolStripMenuItem.Name = "addNewPhoneToolStripMenuItem";
            this.addNewPhoneToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.addNewPhoneToolStripMenuItem.Text = "Add new phone";
            this.addNewPhoneToolStripMenuItem.Click += new System.EventHandler(this.addNewPhoneToolStripMenuItem_Click);
            // 
            // phoneDetailsToolStripMenuItem
            // 
            this.phoneDetailsToolStripMenuItem.Name = "phoneDetailsToolStripMenuItem";
            this.phoneDetailsToolStripMenuItem.Size = new System.Drawing.Size(143, 29);
            this.phoneDetailsToolStripMenuItem.Text = "Phone details";
            this.phoneDetailsToolStripMenuItem.Click += new System.EventHandler(this.phoneDetailsToolStripMenuItem_Click);
            // 
            // infomationToolStripMenuItem
            // 
            this.infomationToolStripMenuItem.Name = "infomationToolStripMenuItem";
            this.infomationToolStripMenuItem.Size = new System.Drawing.Size(124, 29);
            this.infomationToolStripMenuItem.Text = "Infomation";
            this.infomationToolStripMenuItem.Click += new System.EventHandler(this.infomationToolStripMenuItem_Click);
            // 
            // benefitToolStripMenuItem
            // 
            this.benefitToolStripMenuItem.Name = "benefitToolStripMenuItem";
            this.benefitToolStripMenuItem.Size = new System.Drawing.Size(87, 29);
            this.benefitToolStripMenuItem.Text = "Benefit";
            this.benefitToolStripMenuItem.Click += new System.EventHandler(this.benefitToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneManagerment_LINQtoSQL.Properties.Resources.city;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(955, 466);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 514);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menu_Home);
            this.Name = "Home";
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.menu_Home.ResumeLayout(false);
            this.menu_Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_Home;
        private System.Windows.Forms.ToolStripMenuItem addTransactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPhoneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infomationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem benefitToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}