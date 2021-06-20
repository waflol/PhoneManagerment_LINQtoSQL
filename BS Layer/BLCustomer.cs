using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLCustomer
    {
        DBMain db = null;
        string err;
        public BLCustomers()
        {
            db = new DBMain();
        }
        public DataSet GetCustomers()
        {
            return db.ExcuteQueryDataSet("select * from Customer", CommandType.Text);
        }

        public int returnMaxID()
        {
            string sqlString = "select max(ID_customer) as max_id from Customer";
            DataSet ds = db.ExcuteQueryDataSet(sqlString, CommandType.Text);
            try
            {
                if (ds == null || ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0)
                    return 0;
                else
                    return int.Parse(ds.Tables[0].Rows[0]["max_id"].ToString());
            }
            catch (Exception error)
            {
                return 0;
            }

        }

        // them phone
        public bool addCustomer(string cusname, string phonenumber, string address, int ID_customer)
        {
            string sqlString = "Insert Into Customer Values('" + cusname + "','" + phonenumber + "','" + address + "'," + ID_customer.ToString() + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //xoa phone
        public bool deleteCustomer(ref string err, int ID_customer)
        {
            string sqlString = "Delete From Customer where ID_customer = " + ID_customer.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateCustomer(string cusname, string phonenumber, string address, string idcus, ref string err)
        {
            string sqlString = "Update Customer Set Customer_Name = '" + cusname + "',PhoneNumber = '" + phonenumber + "',Address = '" + address + "' where ID_customer = " + idcus.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
