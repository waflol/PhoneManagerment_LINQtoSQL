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
    class BLTransaction_Details
    {
       
        
        public IQueryable getTransaction_details()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = from trans in qlBH.Transactions
                        join cus in qlBH.Customers on trans.ID_customer equals cus.ID_customer
                        join trans_detail in qlBH.Transaction_Details on trans.ID_transaction equals trans_detail.ID_transaction
                        join phone in qlBH.Phones on trans_detail.ID_phone equals phone.ID_phone
                        select new {cus.Customer_Name,cus.PhoneNumber,cus.Address,cus.ID_customer,phone.Model_Name,phone.Price,trans_detail.quantity,trans.Date, trans.username,trans.ID_transaction};
           
            

            return Query;
        }

        public bool addTransaction_details(string quantity, string idtransaction, string idphone)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            Transaction_Detail trans_detail = new Transaction_Detail();
            trans_detail.ID_transaction = int.Parse(idtransaction);
            trans_detail.ID_phone = int.Parse(idphone);
            trans_detail.quantity = int.Parse(quantity);
            try
            {
                qlBH.Transaction_Details.InsertOnSubmit(trans_detail);
                qlBH.Transaction_Details.Context.SubmitChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public bool deleteTransaction_details(string idtransaction)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = from item in qlBH.Transaction_Details
                        where item.ID_transaction == int.Parse(idtransaction)
                        select item;

            
            try
            {
                qlBH.Transaction_Details.DeleteAllOnSubmit(Query);
                qlBH.SubmitChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }

        public IQueryable search_bycusname(string cusname)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = from trans in qlBH.Transactions
                        join cus in qlBH.Customers on trans.ID_customer equals cus.ID_customer
                        join trans_detail in qlBH.Transaction_Details on trans.ID_transaction equals trans_detail.ID_transaction
                        join phone in qlBH.Phones on trans_detail.ID_phone equals phone.ID_phone
                        where cus.Customer_Name.StartsWith(cusname)
                        select new { cus.Customer_Name, cus.PhoneNumber, cus.Address, cus.ID_customer, phone.Model_Name, phone.Price, trans_detail.quantity, trans.Date, trans.username };
            return Query;
        }

        public IQueryable search_byPhonename(string phonename)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = from trans in qlBH.Transactions
                        join cus in qlBH.Customers on trans.ID_customer equals cus.ID_customer
                        join trans_detail in qlBH.Transaction_Details on trans.ID_transaction equals trans_detail.ID_transaction
                        join phone in qlBH.Phones on trans_detail.ID_phone equals phone.ID_phone
                        where cus.PhoneNumber.StartsWith(phonename)
                        select new { cus.Customer_Name, cus.PhoneNumber, cus.Address, cus.ID_customer, phone.Model_Name, phone.Price, trans_detail.quantity, trans.Date, trans.username };
            return Query;
        }

        public IQueryable search_byDate(string date)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = from trans in qlBH.Transactions
                        join cus in qlBH.Customers on trans.ID_customer equals cus.ID_customer
                        join trans_detail in qlBH.Transaction_Details on trans.ID_transaction equals trans_detail.ID_transaction
                        join phone in qlBH.Phones on trans_detail.ID_phone equals phone.ID_phone
                        where trans.Date.Equals(DateTime.Parse(date))
                        select new { cus.Customer_Name, cus.PhoneNumber, cus.Address, cus.ID_customer, phone.Model_Name, phone.Price, trans_detail.quantity, trans.Date, trans.username };
            return Query;
        }

        public IQueryable search_byPhonenum(string phonenum)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = from trans in qlBH.Transactions
                        join cus in qlBH.Customers on trans.ID_customer equals cus.ID_customer
                        join trans_detail in qlBH.Transaction_Details on trans.ID_transaction equals trans_detail.ID_transaction
                        join phone in qlBH.Phones on trans_detail.ID_phone equals phone.ID_phone
                        where cus.PhoneNumber.StartsWith(phonenum)
                        select new { cus.Customer_Name, cus.PhoneNumber, cus.Address, cus.ID_customer, phone.Model_Name, phone.Price, trans_detail.quantity, trans.Date, trans.username };
            return Query;
        }

        public IQueryable search_by_Trans_ID(int ID) {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = from trans in qlBH.Transactions
                        join cus in qlBH.Customers on trans.ID_customer equals cus.ID_customer
                        join trans_detail in qlBH.Transaction_Details on trans.ID_transaction equals trans_detail.ID_transaction
                        join phone in qlBH.Phones on trans_detail.ID_phone equals phone.ID_phone
                        where trans_detail.ID_transaction==ID
                        select new { cus.Customer_Name, cus.Loyal_customer, phone.Model_Name, phone.Price, trans_detail.quantity,trans.Total_price, trans.Date, trans.username };
            return Query;
        }

    }
}
