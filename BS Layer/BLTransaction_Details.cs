using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLTransaction_Details
    {
       

        public IQueryable getTransaction_details()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query =  from cus in qlBH.Customers
                         join trans in qlBH.Transactions on cus.ID_customer equals trans.ID_customer
                         join trans_detail in qlBH.Transaction_Details on trans.ID_transaction equals trans_detail.ID_transaction
                         join phone in qlBH.Phones on trans_detail.ID_phone equals phone.ID_phone into tt
                         select new
                         


            return Query;
        }

        public bool addTransaction_details(string quantity, string idtransaction, string idphone)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            Transaction_Detail trans_detail = new Transaction_Detail();
            trans_detail.ID_transaction = int.Parse(idtransaction);
            trans_detail.ID_phone = int.Parse(idphone);
            trans_detail.quantity = int.Parse(quantity);
            qlBH.Transaction_Details.InsertOnSubmit(trans_detail);
            qlBH.Transaction_Details.Context.SubmitChanges();
            return true;
        }

        public bool deleteTransaction_details(string idtransaction)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = from item in qlBH.Transaction_Details
                        where item.ID_transaction == int.Parse(idtransaction)
                        select item;

            qlBH.Transaction_Details.DeleteAllOnSubmit(Query);
            qlBH.SubmitChanges();
            return true;
        }

        public IQueryable search_byCusname(string cusname)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Transaction_Details
                         where item.ID_transaction.ToString().StartsWith(cusname)
                         select item);
            return Query;
        }
        public IQueryable search_byPhonename(string phonename)
        {
            
        }

        public IQueryable search_byDate(string date)
        {
            
        }

        public IQueryable search_byPhonenum(string phonenum)
        {
            
        }
       
    }
}
