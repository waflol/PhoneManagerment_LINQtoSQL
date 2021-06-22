
namespace PhoneManagerment_LINQtoSQL
{
    partial class Change_Pass {
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
            this.cc = new System.Windows.Forms.Label();
            this.cc2 = new System.Windows.Forms.Label();
            this.Yes_Butoon = new System.Windows.Forms.Button();
            this.Change = new System.Windows.Forms.Label();
            this.Old_pass_textbox = new System.Windows.Forms.TextBox();
            this.New_pass_textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cc
            // 
            this.cc.AutoSize = true;
            this.cc.Location = new System.Drawing.Point(68, 51);
            this.cc.Name = "cc";
            this.cc.Size = new System.Drawing.Size(75, 13);
            this.cc.TabIndex = 0;
            this.cc.Text = "Old PassWord";
            // 
            // cc2
            // 
            this.cc2.AutoSize = true;
            this.cc2.Location = new System.Drawing.Point(68, 94);
            this.cc2.Name = "cc2";
            this.cc2.Size = new System.Drawing.Size(81, 13);
            this.cc2.TabIndex = 1;
            this.cc2.Text = "New PassWord";
            // 
            // Yes_Butoon
            // 
            this.Yes_Butoon.Location = new System.Drawing.Point(154, 140);
            this.Yes_Butoon.Name = "Yes_Butoon";
            this.Yes_Butoon.Size = new System.Drawing.Size(75, 23);
            this.Yes_Butoon.TabIndex = 2;
            this.Yes_Butoon.Text = "Yes";
            this.Yes_Butoon.UseVisualStyleBackColor = true;
            this.Yes_Butoon.Click += new System.EventHandler(this.Yes_Butoon_Click);
            // 
            // Change
            // 
            this.Change.AutoSize = true;
            this.Change.Location = new System.Drawing.Point(130, 22);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(99, 13);
            this.Change.TabIndex = 4;
            this.Change.Text = "Change Pass Word";
            // 
            // Old_pass_textbox
            // 
            this.Old_pass_textbox.Location = new System.Drawing.Point(153, 48);
            this.Old_pass_textbox.Name = "Old_pass_textbox";
            this.Old_pass_textbox.Size = new System.Drawing.Size(161, 20);
            this.Old_pass_textbox.TabIndex = 5;
            // 
            // New_pass_textbox
            // 
            this.New_pass_textbox.Location = new System.Drawing.Point(153, 91);
            this.New_pass_textbox.Name = "New_pass_textbox";
            this.New_pass_textbox.Size = new System.Drawing.Size(161, 20);
            this.New_pass_textbox.TabIndex = 6;
            // 
            // Change_Pass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 196);
            this.Controls.Add(this.New_pass_textbox);
            this.Controls.Add(this.Old_pass_textbox);
            this.Controls.Add(this.Change);
            this.Controls.Add(this.Yes_Butoon);
            this.Controls.Add(this.cc2);
            this.Controls.Add(this.cc);
            this.Name = "Change_Pass";
            this.Text = "Change_Pass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cc;
        private System.Windows.Forms.Label cc2;
        private System.Windows.Forms.Button Yes_Butoon;
        private System.Windows.Forms.Label Change;
        private System.Windows.Forms.TextBox Old_pass_textbox;
        private System.Windows.Forms.TextBox New_pass_textbox;
    }
}