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
            var query = (from phone in qlBH.Phones
                         select phone.ID_phone).Max();
            return query;
        }
        public bool addPhones(int ID_phone, string modelName, string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera, string Display)
        {

           

        }
        //xoa phone
        public bool deletePhones(ref string err, string IDphone)
        {
           
        }
        // cap nhat phone
        public bool updatePhones(int ID_phone, string modelName, string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera, ref string err)
        {
           
        }

        public DataSet search_ModelName(string namephone)
        {
           
        }

    }
}
