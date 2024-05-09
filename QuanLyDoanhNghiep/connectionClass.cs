using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep
{
    // lop "ket noi"
    public class connectionClass
    {
        public static string sqlConnection = "";
        public static bool successConnect = false;
        //public string userName;
        public SqlConnection con;
        public SqlCommand cmd;

        public string getConectedString()
        {
            string fn = @"\conection.txt";
            string fn2 = System.IO.Directory.GetCurrentDirectory();

            fn = fn2 + fn;
            StreamReader sr = new StreamReader(fn);
            sqlConnection = sr.ReadLine();
            sr.Close();
            return sqlConnection;
        }
        public void ShowForm(Form A, Form Cha)
        {
            A.MdiParent = Cha;
            A.Show();
        }

        public void writeConnectionString(string KN)
        {
            string FN = @"\conection.txt";
            string FN2 = System.IO.Directory.GetCurrentDirectory();
            FN = FN2 + FN;

            StreamWriter A = new StreamWriter(FN);
            A.WriteLine(KN);
            A.Close();
        }

        public string getConnectionString_fromTop(string sql)
        {
            sqlConnection = sql;
            return sqlConnection;
        }
        
        public SqlConnection _con
        {
            get { return con; }
            set { con = value;}
        }
        public SqlCommand _cmd
        {
            get { return cmd; }
            set { cmd = value; }
        }
        
        public bool getConnection()
        {
            try
            {
                con = new SqlConnection(sqlConnection);
                cmd = con.CreateCommand();
                //cmd = con.CreateCommand();
                con.Open();
                cmd.Connection = con;
                successConnect = true;
            }
            catch { successConnect = false; }
            return successConnect;
        }
        public void closeConnection()
        {
            con.Close();
        }
        public DataTable getTable(string sqlQuery)
        {
            getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            closeConnection();
            return dt;
        }
        public DataSet createTable(string sqlQuery)
        {
            getConnection();
            SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds);
            closeConnection();
            return ds;
        }

        
    }
}
