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
       

        public Table<Transaction_Detail> getTransaction_details()
        {
            DataSet ds = new DataSet();
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.Transaction_Details;
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
                         where item.Modol.StartsWith(namephone)
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
