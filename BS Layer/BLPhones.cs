using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data;
using System.Windows.Forms;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLPhones
    {
        public Table<Phone> GetPhones()
        {

            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            return qlBH.Phones;
            
        }

        public int ReturnMaxID()
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var query = (from phone in qlBH.Phones
                         select phone.ID_phone).Max();
            try
            {
               return query;
            }
            catch
            {
                return -1;
            }
            
        }

        public bool addPhones(int ID_phone, string modelName, string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera, string Display)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            Phone phone = new Phone();
            phone.ID_phone = ID_phone;
            phone.Model_Name = modelName;
            phone.ram = ram;
            phone.Front_Camera = frontCamera;
            phone.Sim_Type = simtype;
            phone.Network_Type = networktype;
            phone.Price = price;
            phone.Finger = finger;
            phone.istorage = estorage;
            phone.estorage = estorage;
            phone.Rear_Camera = rearcamera;
            phone.Display = Display;
            try
            {
                qlBH.Phones.InsertOnSubmit(phone);
                qlBH.Phones.Context.SubmitChanges();
                return true;
            }
            catch(Exception error)
            {
                return false;
            }
            



        }
        //xoa phone
        public bool deletePhones(ref string err, string IDphone)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = from item in qlBH.Phones
                          where item.ID_phone == int.Parse(IDphone)
                          select item;

            
            try
            {
                qlBH.Phones.DeleteAllOnSubmit(Query);
                qlBH.SubmitChanges();
                return true;
                
                
            }
            catch (Exception error)
            {
                return false;
            }

        }
        // cap nhat phone
        public bool updatePhones(int ID_phone, string modelName, string ram, string frontCamera, string simtype, string networktype, string price, string finger, string istorage, string estorage, string rearcamera, string Display, ref string err)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();
            var Query = (from item in qlBH.Phones
                          where item.ID_phone == ID_phone
                          select item).SingleOrDefault();//Biến Query là biến tham chiếu lưu phone của 1 phone trong danh sách qlBH.Phones

            if (Query != null)
            {
                Query.ID_phone = ID_phone;
                Query.Model_Name = modelName;
                Query.ram = ram;
                Query.Front_Camera = frontCamera;
                Query.Sim_Type = simtype;
                Query.Network_Type = networktype;
                Query.Price = price;
                Query.Finger = finger;
                Query.istorage = estorage;
                Query.estorage = estorage;
                Query.Rear_Camera = rearcamera;
                Query.Display = Display;
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

        public IQueryable search_ModelName(string namephone)
        {
            QuanLyBanHangDataContext qlBH = new QuanLyBanHangDataContext();

            var Query = (from item in qlBH.Phones
                        where item.Model_Name.StartsWith(namephone)
                        select item);

            return Query;
        }

    }
}
