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
    public partial class Form_Phone_Details : Form
    {
        BLPhones phones = new BLPhones();
        bool Them;
        string err;

        public Form_Phone_Details()
        {
            InitializeComponent();
        }

        void LoadPhone()
        {
            try
            {
                GridView_PhoneRecord.DataSource = phones.GetPhones();

            }
            catch(Exception error)
            {
                MessageBox.Show("K load dc!");
            }

        }
        private void Form_Phone_Details_Load(object sender, EventArgs e)
        {
            LoadPhone();
        }

        private void txt_PhoneID_TextChanged(object sender, EventArgs e)
        {
            GridView_PhoneRecord.DataSource = phones.search_ModelName(txt_PhoneID.Text);
        }
    }
}
