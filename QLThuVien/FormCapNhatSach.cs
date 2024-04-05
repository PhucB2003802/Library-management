using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace QLThuVien
{
    public partial class FormCapNhatSach : System.Windows.Forms.Form
    {

        public SqlConnection conn = new SqlConnection();
        Ham chucnang = new Ham();
        public string auto_link = AppDomain.CurrentDomain.BaseDirectory + "\\Hinh\\";

        public string tennhanvien;
        public FormCapNhatSach(string userName)
        {
            InitializeComponent();
            labelTen.Text = "Xin chào : " + userName;
            tennhanvien = userName;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chucnang.ketnoi(conn);
            chucnang.HienThicbox(cbLoaiSach, "SELECT MaLoai, TenLoai FROM LOAISACH", conn, "Tenloai", "Maloai");
            chucnang.HienThiDg(dataGridView1, "Select a.MaSach,a.TenSach,a.TacGia,a.NXB, b.TenLoai,a.Anh From Sach a,LOAISACH b where a.MaLoai = b.MaLoai;", conn);

            string sql_maxmasach = "SELECT MAX(SUBSTRING(Masach, 3, 3)) FROM SACH";
            SqlCommand comd = new SqlCommand(sql_maxmasach, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int masachmoi = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (masachmoi < 10)
                {
                    txtMasach.Text = "MS00" + masachmoi;
                }
                else
                {
                    txtMasach.Text = "MS0" + masachmoi;
                }
                txtMasach.Enabled = false;
                reader.Close();
            }
        }

        private void btThemsach_Click(object sender, EventArgs e)
        {
            string sql_maxmasach = "SELECT MAX(SUBSTRING(MaSach, 3, 3)) FROM SACH";
            SqlCommand comd = new SqlCommand(sql_maxmasach, conn);
            SqlDataReader reader = comd.ExecuteReader();
            if (reader.Read())
            {
                int masachmoi = Convert.ToInt16(reader.GetValue(0).ToString()) + 1;
                if (masachmoi < 10)
                {
                    txtMasach.Text = "MS00" + masachmoi;
                }
                else
                {
                    txtMasach.Text = "MS0" + masachmoi;
                }
                txtMasach.Enabled = false;
                reader.Close();
            }

            txtTensach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "Them NXB";
            cbLoaiSach.Text = "Them The Loai";
            pictureAnhsach.Image = null;

            btSuasach.Enabled = false;
            btXoasach.Enabled = false;
            btLuusach.Enabled = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMasach.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTensach.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTacGia.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNXB.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            cbLoaiSach.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pictureAnhsach.Image = new Bitmap(auto_link + dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString());
            labelAnh.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            btSuasach.Enabled = true;
            btXoasach.Enabled=true;
            btLuusach.Enabled = false;
        }

        private void btTimkiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTimKiem.Text;
            string sql_tim = "Select a.MaSach,a.TenSach,a.TacGia,a.NXB, b.TenLoai,a.Anh From Sach a,LOAISACH b where a.MaLoai = b.MaLoai AND (a.MaSach like'%" + tukhoa + "%' OR a.TenSach like  N'%" + tukhoa + "%')";
            chucnang.HienThiDg(dataGridView1, sql_tim, conn);
        }

        private void btLuusach_Click(object sender, EventArgs e)
        {
            string ms = txtMasach.Text;
            string ts = txtTensach.Text;
            string ttg = txtTacGia.Text;
            string nxb = txtNXB.Text;
            string tl = cbLoaiSach.SelectedValue.ToString();


            string sql_themsach = "INSERT INTO SACH values ('"+ms+"',N'"+ts+"',N'"+ttg+"',N'"+nxb+"',N'"+tl+"','"+Path.GetFileName(labelAnh.Text)+"')";
            SqlCommand comd = new SqlCommand(sql_themsach, conn);
            try
            {
                comd.ExecuteNonQuery();
                MessageBox.Show("Thêm Thành Công");
                File.Copy(labelAnh.Text, auto_link + Path.GetFileName(labelAnh.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(sql_themsach + "Loi: " + ex.Message);
            }
            
            chucnang.HienThiDg(dataGridView1, "Select a.MaSach,a.TenSach,a.TacGia,a.NXB, b.TenLoai,a.Anh From Sach a,LOAISACH b where a.MaLoai = b.MaLoai;", conn);
            txtTensach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "Them NXB";
            cbLoaiSach.Text = "Them The Loai";
            pictureAnhsach.Image = null;
        }

        private void btLoadanh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            DialogResult result = openFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                pictureAnhsach.Image = new Bitmap(openFile.FileName);
                labelAnh.Text = openFile.FileName;
            }
        }

        private void btHuybo_Click(object sender, EventArgs e)
        {
            txtMasach.Text = "";
            txtTensach.Text = "";
            txtTacGia.Text = "";
            txtNXB.Text = "Them NXB";
            cbLoaiSach.Text = "Them The Loai";
            pictureAnhsach.Image = null;
            btThemsach.Enabled = true;
            btSuasach.Enabled = true;
            btXoasach.Enabled = true;
            btLuusach.Enabled = true;
            
        }

        private void btXoasach_Click(object sender, EventArgs e)
        {
            string sql_xoasach = "delete from Sach where MaSach ='" + txtMasach.Text + "'";
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn xóa " + txtTensach.Text + "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                try
                {

                    chucnang.CapNhat(sql_xoasach, conn);
                    chucnang.HienThiDg(dataGridView1, "Select a.MaSach,a.TenSach,a.TacGia,a.NXB, b.TenLoai,a.Anh From Sach a,LOAISACH b where a.MaLoai = b.MaLoai;", conn);
                    MessageBox.Show("Xóa Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể Xóa" + ex.Message, "Thông báo");

                }
            }
            
        }

        private void btSuasach_Click(object sender, EventArgs e)
        {
            string sql_suasach = "UPDATE SACH SET MaSach ='" + txtMasach.Text + "',TenSach = N'" + txtTensach.Text + "',TacGia = N'" + txtTacGia.Text + "',NXB = N'" + txtNXB.Text + "',Maloai = '" + cbLoaiSach.SelectedValue.ToString() + "',Anh = '" + labelAnh.Text + "' Where MaSach = '" + txtMasach.Text + "'";
            DialogResult chon = MessageBox.Show("Bạn có chắc muốn sữa " + txtTensach.Text + "", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (chon == DialogResult.Yes)
            {
                try
                {
                    
                    chucnang.CapNhat(sql_suasach, conn);
                    chucnang.HienThiDg(dataGridView1, "Select a.MaSach,a.TenSach,a.TacGia,a.NXB, b.TenLoai,a.Anh From Sach a,LOAISACH b where a.MaLoai = b.MaLoai;", conn);
                    MessageBox.Show("Sửa Thành Công");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể sữa" + ex.Message, "Thông báo");

                }
            }
            
        }

        private void btMuon_Click(object sender, EventArgs e)
        {
            FormMuon_TraSach frmuon = new FormMuon_TraSach(tennhanvien);
            this.Hide();
            frmuon.ShowDialog();
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

    }
}
