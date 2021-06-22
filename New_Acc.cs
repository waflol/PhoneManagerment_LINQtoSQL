using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneManagerment_LINQtoSQL.BS_Layer;

namespace PhoneManagerment_LINQtoSQL
{
    public partial class New_Acc : Form {
        public New_Acc() {
            InitializeComponent();
        }

        private void Yes_Button_Click(object sender, EventArgs e) {
            BLAccount bLAccount = new BLAccount();
            bLAccount.addAccount(User_Textbox.Text, Pass_Textbox.Text);
            this.Close();
        }

        private void Reset_Button_Click(object sender, EventArgs e) {
            User_Textbox.Text = "";
            Pass_Textbox.Text = "";
        }
    }
}
