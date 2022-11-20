using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Challange
{
    internal class Datahandler
    {
        static string connectionstring = @"Data Source=(local);Initial Catalog=Transactions;Integrated Security=True";
        SqlConnection conn = new SqlConnection(connectionstring);
        SqlCommand cmd;
        SqlDataReader reader;

        public List<Client> allclient()
        {
            string allclient = $"Select * from Client";
            List<Client> list = new List<Client>();
            try
            {
                conn.Open();
                cmd = new SqlCommand(allclient, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Client(int.Parse(reader[0].ToString()), reader[1].ToString(), reader[2].ToString(), decimal.Parse(reader[3].ToString())));
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
        public List<Tranaction> ClientTranaction(int ID)
        {
            string allTranaction = $" select TransactionId, C.ClientID,Amount,TransactionTypeName,Comment " +
                                   $"from Client c inner join[Transaction] T on c.ClientID = T.ClientID  inner join TransactionType TT on " +
                                   $"T.TransactionTypeID = TT.TransactionTypeID where C.ClientID = {ID}";
           List<Tranaction> list = new List<Tranaction>();
            try
            {
                conn.Open();
                cmd = new SqlCommand(allTranaction, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    list.Add(new Tranaction(int.Parse(reader[0].ToString()), int.Parse(reader[1].ToString()), decimal.Parse(reader[2].ToString()), reader[3].ToString(), reader[4].ToString()));
                }
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return list;
        }
        public void Update(int ID,string comment)
        {
            string update = $"update [Transaction] set Comment ='{comment}' where TransactionId ={ID};";
            try
            {
                conn.Open();
                cmd = new SqlCommand(update, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void insertTranaction(int transactionId, int clientID, decimal amount, string transactionTypeName, string comment)
        {

            string insert = $"insert into [Transaction](TransactionId,ClientID,Amount,TransactionTypeID,Comment) Values({transactionId}, {clientID}, {amount},{transactionTypeName} , '{comment}'); ";
            string updateamount = $"update Client set clientBalance = clientBalance+({amount}) where ClientID ={clientID}";
            try
            {
                conn.Open();
                cmd = new SqlCommand(insert, conn);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(updateamount, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tranaction added");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public int Tranactionid()
        {
            string last = $"select top 1 TransactionId from [Transaction] order by TransactionId desc";
            int tranactionid = 0; ;
            try
            {
                conn.Open();
                cmd = new SqlCommand(last, conn);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    tranactionid = int.Parse(reader[0].ToString())+1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return tranactionid;
        }
    }
}
