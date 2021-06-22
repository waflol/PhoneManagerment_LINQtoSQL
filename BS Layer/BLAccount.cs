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

        public Table<Account> GetAccount()
        {

            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
         
            return qlBH.Accounts;
        }
        public IQueryable findAccount(string name)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = (from item in qlBH.Accounts
                         where item.username.StartsWith(name)
                         select item);

            return Query;
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
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext(); 
            Account acc = new Account();
            acc.username = user;
            acc.password = pass;

            qlBH.Accounts.InsertOnSubmit(acc);
            qlBH.Accounts.Context.SubmitChanges();
            return true;


        }
        //xoa phone
        public bool deleteAccount(ref string err, string user)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = from item in qlBH.Accounts
                        where item.username.Equals(user)
                        select item;

            qlBH.Accounts.DeleteAllOnSubmit(Query);
            qlBH.SubmitChanges();
            return true;
        }
        // cap nhat phone
        public bool updateAccount(string user, string pass, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Accounts
                         where item.username.Equals(user)
                         select item).SingleOrDefault();//Biến Query là biến tham chiếu lưu phone của 1 phone trong danh sách qlBH.Phones

            if (Query != null)
            {
                Query.username = user;
                Query.password = pass;

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
