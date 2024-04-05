using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QLThuVien
{
    internal class Ham
    {
        public void ketnoi(SqlConnection conn)
        {
            string chuoiketnoi = " SERVER = LAPTOP-0C74PSLK; database = QuanLyThuVien; integrated Security = True ";
            conn.ConnectionString = chuoiketnoi;
            conn.Open();

        }



        public void HienThiDg(DataGridView dg, string sql, SqlConnection conn)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataSet dataset = new DataSet();
                adapter.Fill(dataset, "new data");
            dg.DataSource = dataset;
            dg.DataMember = "new data";
        }

        public void HienThicbox(ComboBox comb, string sql, SqlConnection conn, string hienthi, string giau)
        {
            SqlCommand comd = new SqlCommand(sql, conn);
            SqlDataReader reader = comd.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(reader);
            comb.DataSource = table;
            comb.DisplayMember = hienthi;
            comb.ValueMember = giau;
            reader.Close();
        }
        public void CapNhat(string sql, SqlConnection conn)
        {
            SqlCommand comd = new SqlCommand(sql, conn);
            try
            {
                comd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("Your  query is: " + sql + " With the error is: " + e.Message);
            }

        }

        public bool login(SqlConnection conn, String userName, String password)
        {
            if (userName.Equals("") || password.Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                string sql = "SELECT hoTen FROM DOCGIA WHERE UserName = @UserName AND Password = @Password";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@UserName", userName);
                cmd.Parameters.AddWithValue("@Password", password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string hoTen = reader["HoTen"].ToString();
                    FormMuon_TraSach formBorrowBook = new FormMuon_TraSach(hoTen);
                    formBorrowBook.Show();
                    return true;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại.");
                    return false;

                }
            }
            return false;
        }
        public bool register(SqlConnection conn, String fullName, DateTimePicker DOB, String address, String userName, String password)
        {
            if (fullName.Equals("") ||
              DOB.Value.ToString().Equals("") ||
              userName.Equals("") ||
              password.Equals("") ||
              address.Equals("")
          )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else
            {
                string sql = "Insert into DOCGIA values(@MaDG, @HoTen, @NgaySinh,@DiaChi, @UserName, @Password)";
                SqlCommand comd = new SqlCommand(sql, conn);
                String maDG = generateNewId(conn);
                comd.Parameters.AddWithValue("@MaDG", maDG);
                comd.Parameters.AddWithValue("@HoTen", fullName);
                comd.Parameters.AddWithValue("@NgaySinh", DOB.Value.ToString("yyyy/MM/dd"));
                comd.Parameters.AddWithValue("@DiaChi", address);
                comd.Parameters.AddWithValue("@UserName", userName);
                comd.Parameters.AddWithValue("@Password", password);
                comd.ExecuteNonQuery();
                MessageBox.Show("Đăng ký thành công");
                return true;
            }
            return false;
        }
        private string generateNewId(SqlConnection conn)
        {
            string sql = "Select MAX(MaDG) from DOCGIA";
            SqlCommand comd = new SqlCommand(sql, conn);
            Object result = comd.ExecuteScalar();
            string dg = "DG";
            int number;
            if (result != DBNull.Value)
            {
                string maxIdDocGia = result.ToString();
                string numberString = maxIdDocGia.Substring(2);
                number = Convert.ToInt16(numberString);
                number++;
                if (number < 10)
                {
                    dg += "00";
                }
                else if (number < 100)
                {
                    dg += "0";
                }
                return dg + number;
            }
            return "DG001";
        }
    }
}
