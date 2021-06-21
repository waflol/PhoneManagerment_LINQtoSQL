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
    public partial class Form_Edit_Phone : Form
    {
        BLPhones Phone = new BLPhones();
        DataSet Phone_search_dataset = new DataSet();

        public Form_Edit_Phone(string namephone)
        {
          //  Phone_search_dataset = Phone.search_ModelName(namephone);
            InitializeComponent();
            txt_ModelName.Text = namephone;
        }

        private void Form_Edit_Phone_Load(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = Phone.search_ModelName(txt_ModelName.Text);

                if (dataGridView1.Rows.Count > 0)
                {
                    cbb_Ram.Text = dataGridView1.Rows[0].Cells[1].Value.ToString(); 
                    cbb_InternalStorage.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    cbb_Display.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    cbb_SimType.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    cbb_RearCamera.Text = dataGridView1.Rows[0].Cells[10].Value.ToString(); 
                    txt_Price.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    cbb_FingerprintSensor.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                    cbb_FrontCamera.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
                    cbb_NetworkType.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                }
                else
                    throw new Exception();
            }
            catch
            {
             
            }
        }
        string x = " ";
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Phone.updatePhones(int.Parse(Phone_search_dataset.Tables[0].Rows[0][11].ToString()), txt_ModelName.Text, cbb_Ram.Text, cbb_FrontCamera.Text, cbb_SimType.Text, cbb_NetworkType.Text, txt_Price.Text, cbb_FingerprintSensor.Text, cbb_InternalStorage.Text, cbb_InternalStorage.Text, cbb_RearCamera.Text, cbb_Display.Text, ref x);
            this.Close();
        }
    }
}
