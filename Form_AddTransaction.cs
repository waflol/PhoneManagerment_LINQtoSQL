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
    public partial class Form_AddTransaction : Form {
        public Form_AddTransaction() {
            InitializeComponent();
            dataGridView1.Visible = false;
            label10.Visible = false;
        }
        BLTransaction_Details transaction_Detail = new BLTransaction_Details();
        BLTransactions transaction = new BLTransactions();
        BLCustomer customer = new BLCustomer();
        // tạo đối tượng thực thi tầng nghiệp vụ
        BLPhones Phone = new BLPhones();
        // biến để lưu dữ liệu truy vẫn
        DataSet Phone_search_dataset = new DataSet();
        // biến tổng tiền
        private int Total_cost = 0;
        // biến giá tiền điện thoại bị xoá
        private int Phone_remove_cost = 0;
        // biến trỏ giá trị trong datagridvieww
        private int index;
        // biến trỏ giá trị để xoá trong datagridview
        private int index_remove;
        // tạo mảng lưu tên điện thoại đã chọn
        private List<string> Phones_name_buying = new List<string>();
        // tạo biến điện thoại sẽ bị xoá
        string Phone_remove;
        // tạo biến phoneID để lấy phoneID report
        private List<string> phoneID = new List<string>();
        // phone id tạm để gán
        private string temp_phoneID;
        private string temp_phoneID_remove;
        private bool isAlready(string PhoneName) {
            for (int i = 0; i < GridView_Cart.Rows.Count; i++) {
                if (GridView_Cart.Rows[i].Cells[0].Value != null) {
                    if (GridView_Cart.Rows[i].Cells[0].Value.Equals(PhoneName)) {
                        index = i;
                        return true;
                    }
                }
            }
            return false;
        }

        private void Add_Phone_Button_Click(object sender, EventArgs e) {
            if ((int)numeric_Quantity.Value > 0 && Phone_Name_Textbox.Text != "") {
                // kiểm tra điện thoại đã đươcc thêm hay chưa
                if (!isAlready(Phone_Name_Textbox.Text)) {
                    GridView_Cart.Rows.Add(Phone_Name_Textbox.Text, txt_Price.Text, numeric_Quantity.Value);
                    Phones_name_buying.Add(Phone_Name_Textbox.Text);
                    phoneID.Add(temp_phoneID);
                } else {
                    // cập nhật lại cột số lượng trong hoá đơn
                    GridView_Cart[2, index].Value = int.Parse(GridView_Cart[2, index].Value.ToString()) + (int)numeric_Quantity.Value;
                    //phoneID.Add(temp_phoneID);
                }
                Total_cost += int.Parse(txt_Price.Text) * (int)numeric_Quantity.Value;
                Total_Cost_Textbox.Text = Total_cost.ToString();
                ////Debug
                //label10.Text = phoneID.Count.ToString();

                // reset lại panel điện thoại
                foreach (var c in Phone_Info_Panel.Controls) {
                    if (c is TextBox) {
                        (c as TextBox).Text = "";
                    }
                    numeric_Quantity.Value = 1;
                }
            } else {
                MessageBox.Show("An image Phone ?");
            }
        }

        private void Reset_Button_Click(object sender, EventArgs e) {
            clearall_form();
        }

        private void GridView_Cart_CellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                index_remove = GridView_Cart.CurrentCell.RowIndex;
                if (GridView_Cart.Rows[index_remove].Cells[0].Value != null) {
                    // gán phone trong datagridview đã chọn
                    Phone_remove = GridView_Cart.Rows[index_remove].Cells[0].Value.ToString();
                    temp_phoneID_remove = GridView_Cart.Rows[index_remove].Cells[11].Value.ToString();
                }
            } catch { }
        }

        private void Remove_Button_Click(object sender, EventArgs e) {
            try {
                // xoá tên điện thoại ra khỏi mảnng
                Phones_name_buying.RemoveAt(index_remove);
                phoneID.RemoveAt(index_remove);
                Total_cost -= int.Parse(GridView_Cart.Rows[index_remove].Cells[1].Value.ToString()) * int.Parse(GridView_Cart.Rows[index_remove].Cells[2].Value.ToString());
                // xoá row trên datagridview
                GridView_Cart.Rows.RemoveAt(index_remove);
                Total_Cost_Textbox.Text = Total_cost.ToString();
            } catch { }
        }

        private void Export_Button_Click(object sender, EventArgs e) {
            dataGridView2.DataSource = customer.FindCustomer(Name_Textbox.Text,Phone_Number_Textbox.Text,Address_Textbox.Text);
            // kiem tra neu khach hang da ton tai
            if (dataGridView2.Rows[0].Cells[3].Value != null) {
                transaction.addTransaction(transaction.returnMaxID() + 1, Total_cost, dtpk_BuyDate.Value.ToString(), int.Parse(dataGridView2.Rows[0].Cells[3].Value.ToString()), FormLogin.currentAccount);
            } else {
                 customer.addCustomer(Name_Textbox.Text, Phone_Number_Textbox.Text, Address_Textbox.Text, customer.returnMaxID() + 1);
            transaction.addTransaction(transaction.returnMaxID() + 1, Total_cost, dtpk_BuyDate.Value.ToString(), customer.returnMaxID(), FormLogin.currentAccount);
            }
            for (int i = 0; i < phoneID.Count; i++) {
                transaction_Detail.addTransaction_details((GridView_Cart[2, i].Value.ToString()), transaction.returnMaxID().ToString(), phoneID[i]);

            }
            Deal_Result deal_Result = new Deal_Result(transaction.returnMaxID());
            deal_Result.ShowDialog();
            clearall_form();
        }
        void clearall_form() {
            foreach (var c in Customer_Panel.Controls) {
                if (c is TextBox) {
                    (c as TextBox).Text = "";
                }
            }
            foreach (var c in Phone_Info_Panel.Controls) {
                if (c is TextBox) {
                    (c as TextBox).Text = "";
                }
                numeric_Quantity.Value = 1;
            }
            GridView_Cart.Rows.Clear();
            GridView_Cart.Refresh();
        }

        private void Phone_Search_Textbox_TextChanged(object sender, EventArgs e) {
            try {
                dataGridView1.DataSource = Phone.search_ModelName(Phone_Search_Textbox.Text);
                if (dataGridView1.Rows.Count > 0 && Phone_Search_Textbox.Text != "" && dataGridView1.Rows[0].Cells[0].Value != null) {
                    Phone_Name_Textbox.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    txt_Ram.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                    txt_istorage.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                    txt_Display.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
                    txt_sim.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                    txt_camera.Text = dataGridView1.Rows[0].Cells[10].Value.ToString();
                    txt_Price.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
                    temp_phoneID = dataGridView1.Rows[0].Cells[11].Value.ToString();
                } else {
                    throw new Exception();
                }
            } catch {
                Phone_Name_Textbox.Text = "";
                txt_Ram.Text = "";
                txt_istorage.Text = "";
                txt_Display.Text = "";
                txt_sim.Text = "";
                txt_camera.Text = "";
                txt_Price.Text = "";
            }
        }
    }
}
