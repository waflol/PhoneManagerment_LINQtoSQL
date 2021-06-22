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
    class BLTransactions
    {
        
        public Table<Transaction> GetTransactions()
        {

            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();



            return qlBH.Transactions;
        }

        public int returnMaxID()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var query = (from item in qlBH.Transactions
                         select item.ID_transaction).Max();
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
        public bool addTransaction(int idtrans, int totalprice, string date, int idcus, string username)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            Transaction trans = new Transaction();
            trans.ID_transaction = idtrans;
            trans.ID_customer = idcus;
            trans.Total_price = totalprice;
            trans.username = username;
            trans.Date = DateTime.Parse(date);
            
            try
            {
                qlBH.Transactions.InsertOnSubmit(trans);
                qlBH.Transactions.Context.SubmitChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }

        }
        //xoa phone
        public bool deleteTransaction(ref string err, string IDtrans)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = from item in qlBH.Transactions
                        where item.ID_transaction == int.Parse(IDtrans)
                        select item;

            
            try
            {
                qlBH.Transactions.DeleteAllOnSubmit(Query);
                qlBH.SubmitChanges();
                return true;
            }
            catch (Exception error)
            {
                return false;
            }
        }
        // cap nhat phone
        public bool updateTransaction(int idtrans, int totalprice, string date, int idcus, string username, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Transactions
                         where item.ID_transaction == idtrans
                         select item).SingleOrDefault();//Biến Query là biến tham chiếu lưu phone của 1 phone trong danh sách qlBH.Phones

            if (Query != null)
            {
                Query.ID_transaction = idtrans;
                Query.Total_price = totalprice;
                Query.Date = DateTime.Parse(date);
                Query.ID_customer = idcus;
                Query.username = username;
                
                try
                {
                    qlBH.SubmitChanges();
                }
                catch (Exception error)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
