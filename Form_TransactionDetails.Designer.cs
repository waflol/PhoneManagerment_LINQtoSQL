
namespace PhoneManagerment_LINQtoSQL
{
    partial class Form_TransactionDetails
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_IDTrans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GridView_Details_Trans = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Details_Trans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_remove.Location = new System.Drawing.Point(503, 81);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(2);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(61, 27);
            this.btn_remove.TabIndex = 11;
            this.btn_remove.Text = "Remove";
            this.btn_remove.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_IDTrans
            // 
            this.txt_IDTrans.Location = new System.Drawing.Point(320, 82);
            this.txt_IDTrans.Margin = new System.Windows.Forms.Padding(2);
            this.txt_IDTrans.Name = "txt_IDTrans";
            this.txt_IDTrans.Size = new System.Drawing.Size(162, 20);
            this.txt_IDTrans.TabIndex = 10;
            this.txt_IDTrans.TextChanged += new System.EventHandler(this.txt_IDTrans_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Find Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Details";
            // 
            // GridView_Details_Trans
            // 
            this.GridView_Details_Trans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Details_Trans.Location = new System.Drawing.Point(11, 142);
            this.GridView_Details_Trans.Margin = new System.Windows.Forms.Padding(2);
            this.GridView_Details_Trans.Name = "GridView_Details_Trans";
            this.GridView_Details_Trans.RowHeadersWidth = 51;
            this.GridView_Details_Trans.RowTemplate.Height = 24;
            this.GridView_Details_Trans.Size = new System.Drawing.Size(790, 297);
            this.GridView_Details_Trans.TabIndex = 7;
            this.GridView_Details_Trans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView_Details_Trans_CellClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PhoneManagerment_LINQtoSQL.Properties.Resources._84f355b7203c4435a8bcdaad90553032;
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PhoneManagerment_LINQtoSQL.Properties.Resources.coin;
            this.pictureBox1.Location = new System.Drawing.Point(641, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form_TransactionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.txt_IDTrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridView_Details_Trans);
            this.Name = "Form_TransactionDetails";
            this.Text = "Form_TransactionDetails";
            this.Load += new System.EventHandler(this.Form_TransactionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Details_Trans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txt_IDTrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridView_Details_Trans;
    }
}