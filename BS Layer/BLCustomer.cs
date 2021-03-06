using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLCustomer
    {
       
        public Table<Customer> GetCustomers()
        {

            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();


            return qlBH.Customers;
        }

        public IQueryable FindCustomer(string name, string phone, string address) {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Customers
                         where item.Customer_Name == name & item.PhoneNumber == phone & item.Address == address
                         select item) ;
            return Query;
        }

        public IQueryable FindCustomer_SDT(string phone) {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Customers
                         where item.PhoneNumber.StartsWith(phone)
                         select item);
            return Query;
        }

        public int returnMaxID()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var query = (from item in qlBH.Customers
                         select item.ID_customer).Max();
            try
            {
                return query;
            }
            catch
            {
                return -1;
            }

        }

        // them phone
        public bool addCustomer(string cusname, string phonenumber, string address, int ID_customer)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext()
;           Customer cus = new Customer();
            cus.ID_customer = ID_customer;
            cus.Customer_Name = cusname;
            cus.PhoneNumber = phonenumber;
            cus.Address = address;
            cus.Loyal_customer = "No";
            qlBH.Customers.InsertOnSubmit(cus);
            qlBH.Customers.Context.SubmitChanges();
            return true;



        }
        //xoa phone
        public bool deleteCustomer(ref string err, int ID_customer)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = from item in qlBH.Customers
                        where item.ID_customer == ID_customer
                        select item;

            qlBH.Customers.DeleteAllOnSubmit(Query);
            qlBH.SubmitChanges();
            return true;
        }
        // cap nhat phone
        public bool updateCustomer(string cusname, string phonenumber, string address, string idcus, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Customers
                         where item.ID_customer == int.Parse(idcus)
                         select item).SingleOrDefault();//Biến Query là biến tham chiếu lưu phone của 1 phone trong danh sách qlBH.Phones

            if (Query != null)
            {
                Query.ID_customer = int.Parse(idcus);
                Query.Customer_Name = cusname;
                Query.PhoneNumber = phonenumber;
                Query.Address = address;
                try
                {
                    qlBH.SubmitChanges();
                }
                catch
                {
                    return false;
                }
                
            }

            return true;
        }
    }
}
