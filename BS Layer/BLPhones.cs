using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLPhones
    {
        public Table<Phone> GetPhones()
        {
            DataSet ds = new DataSet();
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            return qlBH.Phones;
        }

        public int ReturnMaxID()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            Phone 
        }

    }
}
