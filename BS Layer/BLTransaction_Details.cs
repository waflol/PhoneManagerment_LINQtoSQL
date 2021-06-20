using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneManagerment_LINQtoSQL.BS_Layer
{
    class BLTransaction_Details
    {
        DBMain db = null;
        string err;
        public BLTransaction_details()
        {
            db = new DBMain();
        }

        public DataSet getTransaction_details()
        {
            string sqlString = "select * from Customer, Phone, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_phone = Phone.ID_phone";
            return db.ExcuteQueryDataSet(sqlString, CommandType.Text);
        }

        public bool addTransaction_details(string quantity, string idtransaction, string idphone)
        {
            string sqlString = "Insert Into Transaction_Details Values(" + quantity + "," + idtransaction + "," + idphone + ")";
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public bool deleteTransaction_details(string idtransaction)
        {
            string sqlString = "Delete From Transaction_Details where ID_transaction = " + idtransaction;
            return db.MyExecuteNonQuery(sqlString, CommandType.Text, ref err);
        }

        public DataSet search_byCusname(string cusname)
        {
            string sqltring = "select * from Customer, Phone, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_phone = Phone.ID_phone and Customer.Customer_Name like '" + cusname + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
        public DataSet search_byPhonename(string phonename)
        {
            string sqltring = "select * from Customer, Phone, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_phone = Phone.ID_phone and Phone.Model_Name like '" + phonename + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }

        public DataSet search_byDate(string date)
        {
            string sqltring = "select * from Customer, Phone, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_phone = Phone.ID_phone and Transactions.Date = '" + date + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }

        public DataSet search_byPhonenum(string phonenum)
        {
            string sqltring = "select * from Customer, Phone, Transaction_Details, Transactions where Customer.ID_customer = Transactions.ID_customer and Transactions.ID_transaction = Transaction_Details.ID_transaction and Transaction_Details.ID_phone = Phone.ID_phone and Customer.PhoneNumber like '" + phonenum + "%'";
            return db.ExcuteQueryDataSet(sqltring, CommandType.Text);
        }
    }
}
