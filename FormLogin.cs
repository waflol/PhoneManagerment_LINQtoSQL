using PhoneManagerment_LINQtoSQL.BS_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagerment_LINQtoSQL
{
    public partial class FormLogin : Form
    {
        public static string currentAccount = "";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string user = txt_Username.Text;
            string pass = txt_Password.Text;
            BLAccount acc = new BLAccount();

            if (acc.checkAccount(user, pass))
            {

                currentAccount = user;
                this.Visible = false;
                Home obj2 = new Home();
                obj2.ShowDialog();
            }
            else
            {

                MessageBox.Show("Invalid username and Password.");

            }
        }

        private void txt_Password_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string user = txt_Username.Text;
                string pass = txt_Password.Text;
                BLAccount acc = new BLAccount();

                if (acc.checkAccount(user, pass))
                {

                    currentAccount = user;
                    this.Visible = false;
                    Home obj2 = new Home();
                    obj2.ShowDialog();
                }
                else
                {

                    MessageBox.Show("Invalid username and Password.");

                }
            }
        }
    }
}
