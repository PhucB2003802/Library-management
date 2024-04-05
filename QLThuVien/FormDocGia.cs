using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class FormDocGia : Form
    {
        public SqlConnection conn = new SqlConnection();
        Ham chucnang = new Ham();

        public string tennhanvien;
        public FormDocGia(String userName)
        {
            InitializeComponent();
            labelTen.Text = "Xin chào : " + userName;
            tennhanvien = userName;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            FormCapNhatSach frmCapNhat = new FormCapNhatSach(tennhanvien);
            this.Hide();
            frmCapNhat.ShowDialog();
        }

        private void btThongKe_Click_1(object sender, EventArgs e)
        {
            FormThongKe fmThongke = new FormThongKe(tennhanvien);
            this.Hide();
            fmThongke.ShowDialog();
        }

        private void btMuon_Click_1(object sender, EventArgs e)
        {
            FormMuon_TraSach frmuon = new FormMuon_TraSach(tennhanvien);
            this.Hide();
            frmuon.ShowDialog();
        }

        private void FormDocGia_Load(object sender, EventArgs e)
        {
            chucnang.ketnoi(conn);
            chucnang.HienThiDg(dataGridView1, "Select MaDG,HoTen,NgaySinh,DiaChi from DocGia", conn);
            txtMaDG.Enabled = false;

            string sql_maxmaDG = "SELECT MAX(SUBSTRING(MaDG, 3, 3)) FROM DOCGIA";
            SqlCommand comd = new SqlCommand(sql_maxmaDG, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int masachdg = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (masachdg < 10)
                {
                    txtMaDG.Text = "DG00" + masachdg;
                }
                else
                {
                    txtMaDG.Text = "DG0" + masachdg;
                }
                txtMaDG.Enabled = false;
                reader.Close();
            }

        }

        private void btThemDG_Click(object sender, EventArgs e)
        {
            string sql_themdg = "INSERT INTO DOCGIA (MaDG,HoTen,NgaySinh,DiaChi) values ('" + txtMaDG.Text + "',N'" + txtHoTen.Text + "','" + dateTimePickerNgaysinh.Value.ToString("yyyy/MM/dd") + "',N'" + txtDiaChi.Text + "')";
            SqlCommand comd = new SqlCommand(sql_themdg, conn);
            try
            {
                comd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(sql_themdg + "Loi: " + ex.Message);
            }
            chucnang.HienThiDg(dataGridView1, "Select MaDG,HoTen,NgaySinh,DiaChi from DocGia", conn);

        }

        private void btSuaDG_Click(object sender, EventArgs e)
        {
            string sql_suaDG = "UPDATE DOCGIA SET MaDG ='" + txtMaDG.Text + "',HoTen = N'" + txtHoTen.Text + "',NgaySinh = '" + dateTimePickerNgaysinh.Value.ToString("yyyy/MM/dd") + "',DiaCHi = N'" + txtDiaChi.Text + "' Where MaDG = '"+txtMaDG.Text+"'";
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn sữa " + txtHoTen.Text + "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    chucnang.CapNhat(sql_suaDG, conn);
                    chucnang.HienThiDg(dataGridView1, "Select MaDG,HoTen,NgaySinh,DiaChi from DocGia", conn);
                    MessageBox.Show("Sửa Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sữa" + ex.Message, "Thông báo");

                }
            }
        }

        private void btnDatlai_Click(object sender, EventArgs e)
        {
            string sql_maxmaDG = "SELECT MAX(SUBSTRING(MaDG, 3, 3)) FROM DOCGIA";
            SqlCommand comd = new SqlCommand(sql_maxmaDG, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int masachdg = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (masachdg < 10)
                {
                    txtMaDG.Text = "DG00" + masachdg;
                }
                else
                {
                    txtMaDG.Text = "DG0" + masachdg;
                }
                txtMaDG.Enabled = false;
                reader.Close();
            }
            txtHoTen.Text = "";
            txtDiaChi.Text = "";
            btThemDG.Enabled = true;
            
        }

        private void btXoaDG_Click(object sender, EventArgs e)
        {
            string sql_xoaDG = "delete from DOCGIA where MaDG ='" + txtMaDG.Text + "'";
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn xóa " + txtHoTen.Text + "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    chucnang.CapNhat(sql_xoaDG, conn);
                    chucnang.HienThiDg(dataGridView1, "Select MaDG,HoTen,NgaySinh,DiaChi from DocGia", conn);
                    MessageBox.Show("Xóa Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể Xóa" + ex.Message, "Thông báo");

                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   
            txtMaDG.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtHoTen.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            dateTimePickerNgaysinh.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDiaChi.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();

            btThemDG.Enabled = false;
        }
    }
}
