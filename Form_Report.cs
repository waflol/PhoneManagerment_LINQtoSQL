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
    public partial class Form_Report : Form
    {
        public Form_Report()
        {
            InitializeComponent();
        }

        private void Form_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PhoneDB.Transactions' table. You can move, or remove it, as needed.
          
        }

        private void Show_Button_Click(object sender, EventArgs e)
        {
            this.TransactionsTableAdapter.Fill(this.PhoneDB.Transactions,dateTimePicker1.Value.ToString());

            this.reportViewer1.RefreshReport();
        }
    }
}
