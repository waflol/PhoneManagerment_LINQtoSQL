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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddTransaction form_addTrans = new Form_AddTransaction();
            form_addTrans.ShowDialog();
        }

        private void transactionDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_TransactionDetails form_TransactionDetails = new Form_TransactionDetails();
            form_TransactionDetails.ShowDialog();
        }

        private void addNewPhoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_AddNewPhone form_addnewphone = new Form_AddNewPhone();
            form_addnewphone.ShowDialog();
        }

        private void phoneDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Phone_Details formphonedetail = new Form_Phone_Details();
            formphonedetail.ShowDialog();
        }

        private void benefitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Report report = new Form_Report();
            report.ShowDialog();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e) {
            Application.Exit();
        }

        private void infomationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hùng Anh\nHữu Giàu\nThế Hiển\n","Producer",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void menu_Home_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void changePassWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Pass change = new Change_Pass();
            change.ShowDialog();
        }

        private void addNewAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormLogin.currentAccount == "Admin")
            {
                New_Acc new_Acc = new New_Acc();
                new_Acc.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not the Administrator");
            }
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormLogin.currentAccount == "Admin")
            {
                Mange_Acc acc = new Mange_Acc();
                acc.ShowDialog();
            }
            else
            {
                MessageBox.Show("You are not the Administrator");
            }
        }

        private void customerDetailsToolStripMenuItem_Click(object sender, EventArgs e) {
            Customer_ID_Detail customer_ID_Detail = new Customer_ID_Detail();
            customer_ID_Detail.ShowDialog();
        }
    }
}
