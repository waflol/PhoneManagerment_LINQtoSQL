using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLCustomer
    {
       
        public Table<Customer> GetCustomers()
        {
            DataSet ds = new DataSet();
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.Customers;
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
            
        }
        //xoa phone
        public bool deleteCustomer(ref string err, int ID_customer)
        {
           
        }
        // cap nhat phone
        public bool updateCustomer(string cusname, string phonenumber, string address, string idcus, ref string err)
        {
            
        }
    }
}
