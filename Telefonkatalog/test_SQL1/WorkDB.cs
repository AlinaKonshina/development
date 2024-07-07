using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace test_SQL1
{
    internal class WorkDB
    {
        OdbcConnection conn = new OdbcConnection();

        public WorkDB()
        {
            conn.ConnectionString = "Dsn=tel";
        }

        public DataTable Execute(string SQLCommand)
        {
            DataTable dt = null;
         
            try
            {
                conn.Open();
                dt = new DataTable();
                OdbcCommand ocmd = conn.CreateCommand();
                ocmd.CommandText = SQLCommand;
                dt.Load(ocmd.ExecuteReader());
            }

            catch (Exception e) {
                MessageBox.Show(e.Message,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }

            return dt;

        }
        public DataTable GetAll(string tablename)
        {
            return Execute("SELECT * FROM" + tablename);
        }
    }



}
