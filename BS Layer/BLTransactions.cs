using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLTransactions
    {
        
        public Table<Transaction> GetTransactions()
        {
            DataSet ds = new DataSet();
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.Transactions;
        }

        public int returnMaxID()
        {
            
        }

        // them phone
        public bool addTransaction(int idtrans, int totalprice, string date, int idcus, string username)
        {
            
        }
        //xoa phone
        public bool deleteTransaction(ref string err, string IDtrans)
        {
            
        }
        // cap nhat phone
        public bool updateTransaction(int idtrans, int totalprice, DateTime date, int idcus, string username, ref string err)
        {
            
        }
    }
}
