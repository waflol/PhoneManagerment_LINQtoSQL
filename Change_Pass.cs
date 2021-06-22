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
    public partial class Change_Pass : Form {
        public Change_Pass() {
            InitializeComponent();
            //Change.Text = FormLogin.currentPass;
        }

        string x = "";
        private void Yes_Butoon_Click(object sender, EventArgs e) {
            BLAccount bLAccount = new BLAccount();
            Change.Text = Old_pass_textbox.Text;
            if (FormLogin.currentPass == Old_pass_textbox.Text) {
                bLAccount.updateAccount(FormLogin.currentAccount, New_pass_textbox.Text, ref x);
                MessageBox.Show("Doi Thanh Cong");
                this.Close();
            } else {
                Change.Text = FormLogin.currentPass;
                MessageBox.Show("Wrong Old Password");
            }
        }
    }
}
