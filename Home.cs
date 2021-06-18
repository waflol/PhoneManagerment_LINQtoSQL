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
    }
}
