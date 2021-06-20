using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLAccount
    {

        public DataSet GetAccount()
        {
            DataSet ds = new DataSet();
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            DataTable dt = new DataTable();
            dt.Rows.Add(qlBH.Accounts);
            ds.Tables.Add(dt);
            return ds;
        }

        public bool checkAccount(string user, string pass)
        {

            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Accounts
                         where item.username.Equals(user)
                                && item.password.Equals(pass)
                         select item).ToList();
            if (Query.Count != 0)
                return true;
            else
                return false;
        }

        public bool ExistAccount(string user)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Accounts
                         where item.username.Equals(user)
                         select item).ToList();
            if (Query.Count != 0)
                return true;
            else
                return false;


        }
        // them phone
        public bool addAccount(string user, string pass)
        {
            return false;
        }
        //xoa phone
        public bool deleteAccount(ref string err, string user)
        {
            return false;
        }
        // cap nhat phone
        public bool updateAccount(string user, string pass, ref string err)
        {
            return false;
        }
    }
}
