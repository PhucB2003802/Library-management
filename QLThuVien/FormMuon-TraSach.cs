using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace QLThuVien
{
    public partial class FormMuon_TraSach : Form
    {
        public string auto_link = AppDomain.CurrentDomain.BaseDirectory + "\\Hinh\\";
        public SqlConnection conn = new SqlConnection();
        Ham chucnang = new Ham();

        public string tennhanvien;
        public FormMuon_TraSach(string user)
        {
            InitializeComponent();
            labelTen.Text = "Xin chào : "+user;
            tennhanvien = user;

        }

        private void FormMuon_TraSach_Load(object sender, EventArgs e)
        {
            chucnang.ketnoi(conn);
            chucnang.HienThicbox(cbMaDG, "Select MaDG,HoTen From DOCGIA", conn, "MaDG", "HoTen");
            chucnang.HienThiDg(dataGridView1, "Select a.MaSach,a.TenSach,a.TacGia,a.NXB, b.TenLoai,a.Anh From Sach a,LOAISACH b where a.MaLoai = b.MaLoai;", conn);
            chucnang.HienThiDg(dataGridView2, "Select a.MaDG,b.HoTen,a.MaSach,c.TenSach,a.NgayTra as NgayTraDuKien,a.Ghichu From MUONSACH a,DOCGIA b,SACH c where a.MaDG = b.MaDG and a.MaSach = c.MaSach and b.MaDG = '"+cbMaDG.Text+"';", conn);
            chucnang.HienThiDg(dataGridView4,"Select MaDG,HoTen From DocGia",conn);
            dateTimePicker3.MinDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Now;
            txtMaDGMuon.Enabled = false;
            txtMasachMuon.Enabled = false;
            txtMasachTra.Enabled = false;
            
        }


        private void btCapNhat_Click(object sender, EventArgs e)
        {
            FormCapNhatSach frmCapNhat = new FormCapNhatSach(tennhanvien);
            this.Hide();
            frmCapNhat.ShowDialog();
        }

        private void btThongKe_Click(object sender, EventArgs e)
        {
            FormThongKe fmThongke = new FormThongKe(tennhanvien);
            this.Hide();
            fmThongke.ShowDialog();
        }

        private void btDocGia_Click(object sender, EventArgs e)
        {
            FormDocGia fmDocGia = new FormDocGia(tennhanvien);
            this.Hide();
            fmDocGia.ShowDialog();
        }

 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasachMuon.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            pictureBox1.Image = new Bitmap(auto_link + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            txtMasachMuon.Enabled = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cbMaDG.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMasachTra.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            dateTimePicker2.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBoxTra.Text = dataGridView2.Rows[e.RowIndex].Cells[5].Value.ToString();

            
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDGMuon.Text = dataGridView4.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtMaDGMuon.Enabled = false;
        }
        private void btMuonSach_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn Mượn Sách " + txtMasachMuon.Text + "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                string sql_themmuonsach = "INSERT INTO MUONSACH VALUES('" + txtMaDGMuon.Text + "','" + txtMasachMuon.Text + "','" + dateTimePicker3.Value.ToString("yyyy-MM-dd") + "','" + txtBoxGhichuMuon.Text + "')";
                SqlCommand comd = new SqlCommand(sql_themmuonsach, conn);
                try
                {
                    comd.ExecuteNonQuery();
                    pictureBox1.Image = null;
                    txtMaDGMuon.Text = "Chọn Mã Độc Giả";
                    txtMasachMuon.Text = "Chọn Sách";
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sql_themmuonsach + "Loi: " + ex.Message);
                }
                chucnang.HienThiDg(dataGridView1, "Select a.MaSach,a.TenSach,a.TacGia,a.NXB, b.TenLoai,a.Anh From Sach a,LOAISACH b where a.MaLoai = b.MaLoai;", conn);
            }
        }



        private void btXoaMuon_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn Xoá sách " + txtMasachTra.Text+ "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                string sql_suamuon = "DELETE FROM MUONSACH WHERE MaDG = '" + cbMaDG.Text + "' and MaSach = '" + txtMasachTra.Text + "'";
                SqlCommand comd = new SqlCommand(sql_suamuon, conn);
                try
                {
                    comd.ExecuteNonQuery();
                    MessageBox.Show("Xóa Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sql_suamuon + "Loi: " + ex.Message);
                }
                chucnang.HienThiDg(dataGridView2, "Select a.MaDG,b.HoTen,a.MaSach,c.TenSach,a.NgayTra as NgayTraDuKien,a.Ghichu From MUONSACH a,DOCGIA b,SACH c where a.MaDG = b.MaDG and a.MaSach = c.MaSach and b.MaDG = '" + cbMaDG.Text + "';", conn);
            }
        }

        private void btTraSach_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn Trả Sách " + txtMasachTra.Text + "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                string sql_trasach = "INSERT INTO TRASACH VALUES('" + cbMaDG.Text + "','" + txtMasachTra.Text + "','"+dateTimePicker2.Value.ToString("yyyy-MM-dd")+"','" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "','" + txtBoxTra.Text + "')";
                SqlCommand comd = new SqlCommand(sql_trasach, conn);
                try
                {
                    comd.ExecuteNonQuery();
                    string sql_xoamuonsach = "Delete From MUONSACH WHERE MaDG='" + cbMaDG.Text + "' and MaSach = '" + txtMasachTra.Text + "' ";
                    chucnang.CapNhat(sql_xoamuonsach, conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sql_trasach + "Loi: " + ex.Message);
                }
                chucnang.HienThiDg(dataGridView2, "Select a.MaDG,b.HoTen,a.MaSach,c.TenSach,a.NgayTra as NgayTraDuKien,a.Ghichu From MUONSACH a,DOCGIA b,SACH c where a.MaDG = b.MaDG and a.MaSach = c.MaSach and b.MaDG = '" + cbMaDG.Text + "';", conn);

            }
        }

        private void btGiaHan_Click(object sender, EventArgs e)
        {
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn Gia Hạn " + txtMasachTra.Text + "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                string sql_giahan = "UPDATE MUONSACH SET MaDG ='" + cbMaDG.Text + "',MaSach = '" + txtMasachTra.Text + "',NgayTra = '" + dateTimePicker2.Value.ToString("yyyy-MM-dd") + "',GhiChu = '" + txtBoxTra.Text + "' Where MaDG = '" + cbMaDG.Text + "' and MaSach = '" + txtMasachTra.Text + "'";
                SqlCommand comd = new SqlCommand(sql_giahan, conn);
                try
                {
                    comd.ExecuteNonQuery();
                    MessageBox.Show("Gia Hạn Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(sql_giahan + "Loi: " + ex.Message);
                }
                chucnang.HienThiDg(dataGridView2, "Select a.MaDG,b.HoTen,a.MaSach,c.TenSach,a.NgayTra as NgayTraDuKien,a.Ghichu From MUONSACH a,DOCGIA b,SACH c where a.MaDG = b.MaDG and a.MaSach = c.MaSach and b.MaDG = '" + cbMaDG.Text + "';", conn);
            }
        }


        private void cbMaDG_SelectedIndexChanged(object sender, EventArgs e)
        {
            chucnang.HienThiDg(dataGridView2, "Select a.MaDG,b.HoTen,a.MaSach,c.TenSach,a.NgayTra as NgayTraDuKien,a.Ghichu From MUONSACH a,DOCGIA b,SACH c where a.MaDG = b.MaDG and a.MaSach = c.MaSach and b.MaDG = '"+ cbMaDG.Text + "';", conn);
        }


    }
    
}
