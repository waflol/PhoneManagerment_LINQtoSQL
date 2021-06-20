using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLTransactions
    {
        DBMain db = null;
        string err;
        public BLTransaction()
        {
            db = new DBMain();
        }
        public DataSet GetPhones()
        {
            return db.ExcuteQueryDataSet("select * from Transactions", CommandType.Text);
        }

        public int returnMaxID()
        {
            string sqlString = "select max(ID_transaction) as max_id from Transactions";
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
        public bool addTransaction(int idtrans, int totalprice, string date, int idcus, string username)
        {
            //string sqlString = "Insert Into Transactions Values("+idtrans.ToString()+","+totalprice.ToString()+",'"+date+"',"+idcus.ToString()+",'"+username+"')";
            string sqlString = "Insert into Transactions Values(" + idtrans.ToString() + "," + totalprice.ToString() + ",CONVERT(datetime,'" + date + "',103)," + idcus.ToString() + ",'" + username + "')";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        //xoa phone
        public bool deleteTransaction(ref string err, string IDtrans)
        {
            string sqlString = "Delete From Transactions where ID_transaction = " + IDtrans.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
        // cap nhat phone
        public bool updateTransaction(int idtrans, int totalprice, DateTime date, int idcus, string username, ref string err)
        {
            string sqlString = "Update Transactions Set Total_price = " + totalprice.ToString() + ", Date = " + date.ToString() + ",ID_customer = " + idcus.ToString() + ",username = '" + username + "' where ID_transaction = " + idtrans.ToString();
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }
    }
}
