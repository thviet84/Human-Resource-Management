using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyDoanhNghiep
{
    //lop "chuoi xu ly"
    public class executeStringClass
    {
        //connectionClass connectionClass = new connectionClass();
        connectionClass conn = new connectionClass();
        public string username;
        public bool checkConnection()
        {
            conn.getConectedString();
            if (conn.getConnection())
            {
                return true;
            } else return false;
        }
        public bool checkConnection_fromTop(string KN)
        {
            conn.getConnectionString_fromTop(KN);
            if (conn.getConnection())
            {
                conn.getConectedString();
                return true;
            }
            else return false;
        }
        public DataTable showData(string sqlQuery)
        {
            return conn.getTable(sqlQuery);
        }
        public void HienThiCBB(string SQL, ComboBox CB, string LayCot1, string LayCot2)
        {
            DataTable DT = showData(SQL);
            
            CB.DataSource = DT;
            
            CB.DisplayMember = LayCot2;
            CB.ValueMember = LayCot1;
            //  CB.DisplayMember = LayCot2;
            // CB.ValueMember = LayCot2;
        }
        public string KiemTra_Ten(string SQL_Query, Label ma)
        {
            // ma.Text = Business.KiemTraChuoi(SQL_Query);

            ma.Text = KiemTraChuoi(SQL_Query);
            return ma.Text;
        }
        public string KiemTraChuoi(string str)
        {
            try
            {
                string s;
                s = conn.getTable(str).Rows[0][0].ToString();
                return s.ToString();
            }
            catch (Exception ex)
            {
                return "";
            }
        }
        public string cutString(string chuoi)
        {
            Char[] mang = chuoi.ToCharArray();
            string daCat = "";
            for(int i=0; i<chuoi.Length; i++)
            {
                if (mang[i] >= 65 & mang[i]<=90 )
                {
                    daCat = daCat + chuoi[i];
                }
            }
            return daCat;
        }
        public string hashDateTime(string dateTime)
        {
            string[] date = dateTime.Split(' ');
            return date[0];
        }

        public string getIDLogin(string un, string pwd)
        {
            string id = null;
            string query = "select *from taiKhoan where username = '"+un +"' and passwd = '"+pwd+"'";
            try
            {
                conn.getConnection();
                SqlCommand cmd = new SqlCommand(query,conn.con);
                SqlDataAdapter adt = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adt.Fill(dt); 
                if (dt != null)
                {
                    foreach(DataRow dr in dt.Rows)
                    {
                        id  = dr["username"].ToString();

                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.closeConnection();

            }
            return id;
        }

        public string getUName(string uid)
        {
            string un = "select taiKhoan.username from taiKhoan inner join nhanVien" +
                        " on nhanVien.maNV=taiKhoan.maNV " +
                        "where nhanVien.maNV = '" + uid + "';";
            return  KiemTraChuoi(un);
            
        }
        public int getLevel (string maNV)
        {
            string queryGetLevel = "select distinct chucNang.levelFunc from chucNang " +
                "inner join  quyenTruyCap on quyenTruyCap.quyen = chucNang.quyen " +
                "inner join phanQuyen on phanQuyen.quyen = quyenTruyCap.quyen " +
                "where phanQuyen.username = '"+maNV+"'; ";
            
            return int.Parse(KiemTraChuoi(queryGetLevel));
        }
        public string getQuyen(string maNV, int level)
        {
            string id = null;
            
            //string ketqua = "";
            string query = "select distinct phanQuyen.username, quyenTruyCap.quyen, chucNang.tenCN, " +
                            "chucNang.trangThai, chucNang.levelFunc " +
                            "from chucNang inner join quyenTruyCap on quyenTruyCap.quyen = chucNang.quyen " +
                            "inner join phanQuyen on phanQuyen.quyen = quyenTruyCap.quyen " +
                            "where phanQuyen.username = '"+maNV+"' or chucNang.levelFunc <= "+level+"; ";
            //select chucNang.tenCN, quyenTruyCap.quyen, chucNang.trangThai from chucNang inner join quyenTruyCap on quyenTruyCap.quyen = chucNang.quyen inner join phanQuyen on phanQuyen.quyen = quyenTruyCap.quyen where phanQuyen.username = '" + maNV + "';
            conn.getConnection();
            try
            {
                DataTable dt = conn.getTable(query);
                if (dt != null)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["trangThai"].ToString() == "True")
                        {
                            id =  dr["tenCN"].ToString() + "/" + id  ;
                            //MessageBox.Show(dr["tenCN"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error \n" + ex);
            }
            finally
            {
                conn.closeConnection();
            }
            return id;
        }

        /*public bool KT_quyen(string username, string quyen,DataGridView dgv)
        {
            string access = "";
            access = printQuyen(username, dgv);
            if (access == quyen )
            {return true;}
            else{return false;}
        }*/
        

        public string returnFormName(string tenForm)
        {
            string[] test = (tenForm + "").Split(':');
            string result = test[1].Trim();
            
            return result;
            /*for (int i=0; i <= mang.Length; i++)
            {
                if (i <= mang.Length) { continue; }
                else { mang[i] = test[1]; }
            }*/
        }
        /*public bool IsOpen(string tenMangMoi, string[] mang)
        {
            bool check = false;
            foreach (string form in mang)
            {
                if (mang.Contains(tenMangMoi))
                {
                    return true;
                }
                else return false;
            }
            /*foreach (Form f in Application.OpenForms)
            {if (f.Text == name)
                {   IsOpen = true;
                    f.Focus();
                    break;}}

            return check;
        }*/
        public string rtFormValue(string tenForm)
        {
            string query = "select openned from isOpenForm where formName ='" + tenForm + "';";
            string rs = KiemTraChuoi(query);
            return rs;
        }
        public bool checkFormOpen(string tenForm)
        {
            bool check = false;
            if (rtFormValue(tenForm) == "False")
            {
                check = false;
            }
            else if (rtFormValue(tenForm) == "True")
            {
                check = true;
            }
            return check;
        }
        public void changeFormValue(string tenForm)
        {
            string queryFalse = "update isOpenForm " +
                                "set openned = 1 " +
                                "where formName = '" + tenForm + "';";
            string queryTrue = "update isOpenForm " +
                                "set openned = 0 " +
                                "where formName = '" + tenForm + "';";
            if (checkFormOpen(tenForm) == false)
            {
                try
                {
                    conn.getConnection();
                    SqlCommand cmd = new SqlCommand(queryFalse, conn.con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                { MessageBox.Show("Error\n" + e, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                finally { conn.closeConnection(); }
            }
            else if (checkFormOpen(tenForm) == true)
            {
                try
                {
                    conn.getConnection();
                    SqlCommand cmd = new SqlCommand(queryTrue, conn.con);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                { MessageBox.Show("Error\n" + e, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                finally { conn.closeConnection(); }
            }
        }
    }

}
