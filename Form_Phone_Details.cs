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

        string x = " ";
        string Phone_Id;
        string Phone_name;
        int index;
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

        private void btn_Edit_Click(object sender, EventArgs e) {
            Form_Edit_Phone form_Edit_Phone = new Form_Edit_Phone(Phone_name);
            form_Edit_Phone.ShowDialog();
            LoadPhone();
            txt_PhoneID.Text = "";
        }

        private void GridView_PhoneRecord_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                index = GridView_PhoneRecord.CurrentCell.RowIndex;
                if (GridView_PhoneRecord.Rows[index].Cells[11].Value != null) {
                    Phone_Id = GridView_PhoneRecord.Rows[index].Cells[11].Value.ToString();
                    Phone_name= GridView_PhoneRecord.Rows[index].Cells[0].Value.ToString();
                    txt_PhoneID.Text = GridView_PhoneRecord.Rows[index].Cells[0].Value.ToString();
                }
            } catch {

            }
        }

        private void btn_Delete_Click(object sender, EventArgs e) {
           phones.deletePhones(ref x,Phone_Id);
            LoadPhone();
            txt_PhoneID.Text = "";
        }
    }
}
