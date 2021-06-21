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
    public partial class Form_AddNewPhone : Form {
        public Form_AddNewPhone() {
            InitializeComponent();
        }
        BLPhones phone = new BLPhones();

        private void btn_Save_Click(object sender, EventArgs e) {
            try {
                if (int.TryParse(txt_Price.Text, out int result)) {
                    phone.addPhones(phone.ReturnMaxID() + 1, txt_ModelName.Text, cbb_Ram.Text, cbb_FrontCamera.Text, cbb_SimType.Text, cbb_NetworkType.Text, txt_Price.Text, cbb_FingerprintSensor.Text, cbb_InternalStorage.Text, cbb_InternalStorage.Text, cbb_RearCamera.Text, cbb_Display.Text);
                    foreach (var c in this.Controls) {
                        if (c is TextBox) {
                            (c as TextBox).Clear();
                        }
                        if (c is ComboBox) {
                            (c as ComboBox).SelectedIndex = -1;
                            (c as ComboBox).Text = "--Select--";
                        }
                    }
                } else
                    MessageBox.Show("Nhập sai. Vui lòng nhập lại");
            } catch { }
        }

        private void btn_Reset_Click(object sender, EventArgs e) {
            foreach (var c in this.Controls) {
                if (c is TextBox) {
                    (c as TextBox).Clear();
                }
                if (c is ComboBox) {
                    (c as ComboBox).SelectedIndex = -1;
                    (c as ComboBox).Text = "--Select--";
                }
            }
        }
    }
}
