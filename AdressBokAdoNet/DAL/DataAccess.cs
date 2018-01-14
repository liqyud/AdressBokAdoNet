using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AdressBokAdoNet.DAL
{
    class DataAccess
    {
        private SqlConnection con = null;
        private SqlCommand cmd = null;
        private DataSet dataSet = null;

        public DataAccess()
        {
            var connectionString = Properties.Settings.Default.AddressBookConnection;
            con = new SqlConnection(connectionString);
        }

        public DataSet RetrieveData(string query)
        {
            dataSet = new DataSet();
            DataTable table = new DataTable();

            cmd = con.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = query;
   
            try
            {
                con.Open();

                SqlDataAdapter da = null;
                using (da = new SqlDataAdapter(cmd))
                {
                    da.Fill(table);
                }

                dataSet.Tables.Add(table);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Message");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

            return dataSet;
        }

        public DataSet CreateUpdateDelete(string query)
        {
            dataSet = new DataSet();
            cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error Message");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return dataSet;
        }
    }
}
