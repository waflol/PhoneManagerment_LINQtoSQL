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
              //  Phone_search_dataset = Phone.search_ModelName(txt_ModelName.Text);

                if (Phone_search_dataset.Tables.Count > 0)
                {
                    cbb_Ram.Text = Phone_search_dataset.Tables[0].Rows[0][1].ToString();
                    cbb_InternalStorage.Text = Phone_search_dataset.Tables[0].Rows[0][8].ToString();
                    cbb_Display.Text = Phone_search_dataset.Tables[0].Rows[0][3].ToString();
                    cbb_SimType.Text = Phone_search_dataset.Tables[0].Rows[0][4].ToString();
                    cbb_RearCamera.Text = Phone_search_dataset.Tables[0].Rows[0][10].ToString();
                    txt_Price.Text = Phone_search_dataset.Tables[0].Rows[0][6].ToString();
                    cbb_FingerprintSensor.Text = Phone_search_dataset.Tables[0].Rows[0][7].ToString();
                    cbb_FrontCamera.Text = Phone_search_dataset.Tables[0].Rows[0][2].ToString();
                    cbb_NetworkType.Text = Phone_search_dataset.Tables[0].Rows[0][5].ToString();
                    //label10.Text = temp_phoneID;Phone_search_dataset.Tables[0].Rows[0][6].ToString();
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
