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

namespace PhoneManagerment_LINQtoSQL {
    public partial class Customer_ID_Detail : Form {

        BLCustomer customers = new BLCustomer();
        public Customer_ID_Detail() {
            InitializeComponent();
            dataGridView1.DataSource = customers.GetCustomers();
        }

        //customers.GetCustomers();
        private void KH_Textbox_TextChanged(object sender, EventArgs e) {
            dataGridView1.DataSource = customers.FindCustomer_SDT(SDT_Textbox.Text);
        }

        private void Reload_Button_Click(object sender, EventArgs e) {
            dataGridView1.DataSource = customers.GetCustomers();
        }
    }
}
