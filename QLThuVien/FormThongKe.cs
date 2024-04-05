using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class FormThongKe : Form
    {
        public SqlConnection conn = new SqlConnection();
        Ham chucnang = new Ham();
        public string tennhanvien;
        public FormThongKe(string userName)
        {
            InitializeComponent();
            labelTen.Text = "Xin chào : " + userName;
            tennhanvien = userName;
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            chucnang.ketnoi(conn);

        }




        private void btDangmuon_Click(object sender, EventArgs e)
        {
            chucnang.HienThiDg(dataGridView1, "Select a.MaDG,c.HoTen,a.MaSach,d.TenSach,a.NgayTra as NgayTraDuKien,a.Ghichu From MUONSACH a, DOCGIA c, SACH d where a.MaDG = c.MaDG and a.MaSach = d.MaSach and a.NgayTra >= CURRENT_TIMESTAMP;", conn);
            string sql_tongsosach = "Select COUNT(a.MaSach) Tongso From MUONSACH a, DOCGIA c, SACH d where a.MaDG = c.MaDG and a.MaSach = d.MaSach and a.NgayTra > CURRENT_TIMESTAMP";
            SqlCommand comd = new SqlCommand(sql_tongsosach, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int tongso = Convert.ToInt16(reader.GetValue(0).ToString());
                labelTongSo.Text = "Tổng : "+ tongso.ToString() + " Sách Đang Mượn";
                labelDanhsach.Text = "Danh Sách Các Sách Đang Mượn";
                reader.Close();
            }
            //Select COUNT(a.MaSach) Tongso From Sach a, MUONSACH b,DOCGIA c where a.MaSach = b.MaSach and c.MaDG = b.MaDG;
        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            FormCapNhatSach frmCapNhat = new FormCapNhatSach(tennhanvien);
            this.Hide();
            frmCapNhat.ShowDialog();
        }



        private void btMuon_Click(object sender, EventArgs e)
        {
            FormMuon_TraSach frmuon = new FormMuon_TraSach(tennhanvien);
            this.Hide();
            frmuon.ShowDialog();
        }

        private void btDocGia_Click_1(object sender, EventArgs e)
        {
            FormDocGia fmDocGia = new FormDocGia(tennhanvien);
            this.Hide();
            fmDocGia.ShowDialog();
        }

        private void btDaTra_Click(object sender, EventArgs e)
        {
            chucnang.HienThiDg(dataGridView1, "Select a.MaDG,b.HoTen,a.MaSach,c.TenSach,a.NgayTraDuKien,a.NgayTraThucTe FROM TRASACH a , DOCGIA b, SACH c Where a.MaDG = b.MaDG and a.MaSach = c.MaSach and a.NgayTraDuKien >= a.NgayTraThucTe", conn);
            string sql_tongsosach = "Select COUNT(a.MaSach) TongSo FROM TRASACH a , DOCGIA b, SACH c Where a.MaDG = b.MaDG and a.MaSach = c.MaSach and a.NgayTraDuKien >= a.NgayTraThucTe";
            SqlCommand comd = new SqlCommand(sql_tongsosach, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int tongso = Convert.ToInt16(reader.GetValue(0).ToString());
                labelTongSo.Text = "Tổng : " + tongso.ToString() + " Sách Đã Trả";
                labelDanhsach.Text = "Danh Sách Các Sách Đã Trả Đúng Hạn";
                reader.Close();
            }
            
            
        }

        private void btQuaHan_Click(object sender, EventArgs e)
        {
            chucnang.HienThiDg(dataGridView1, "Select a.MaDG,b.HoTen,a.MaSach,c.TenSach,a.NgayTraDuKien,a.NgayTraThucTe FROM TRASACH a , DOCGIA b, SACH c Where a.MaDG = b.MaDG and a.MaSach = c.MaSach and a.NgayTraDuKien < a.NgayTraThucTe", conn);
            string sql_tongsosach = "Select COUNT(a.MaSach) TongSo FROM TRASACH a , DOCGIA b, SACH c Where a.MaDG = b.MaDG and a.MaSach = c.MaSach and a.NgayTraDuKien < a.NgayTraThucTe";
            SqlCommand comd = new SqlCommand(sql_tongsosach, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int tongso = Convert.ToInt16(reader.GetValue(0).ToString());
                labelTongSo.Text = "Tổng : " + tongso.ToString() + " Sách Đã Quá Hạn";
                labelDanhsach.Text = "Danh Sách Các Sách Quá Hạn";
                reader.Close();
            }
        }

        private void btChuaTra_Click(object sender, EventArgs e)
        {
            chucnang.HienThiDg(dataGridView1, "Select a.MaDG,c.HoTen,a.MaSach,d.TenSach,a.NgayTra as NgayTraDuKien,a.Ghichu From MUONSACH a, DOCGIA c, SACH d where a.MaDG = c.MaDG and a.MaSach = d.MaSach and a.NgayTra < CURRENT_TIMESTAMP -1", conn);
            string sql_tongsosach = "Select COUNT(a.MaSach) TongSo From MUONSACH a, DOCGIA c, SACH d where a.MaDG = c.MaDG and a.MaSach = d.MaSach and a.NgayTra < CURRENT_TIMESTAMP -1";
            SqlCommand comd = new SqlCommand(sql_tongsosach, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int tongso = Convert.ToInt16(reader.GetValue(0).ToString());
                labelTongSo.Text = "Tổng : " + tongso.ToString() + " Sách Chưa Trả";
                labelDanhsach.Text = "Danh Sách Các Sách Chưa Trả";
                reader.Close();
            }
        }


    }
}
