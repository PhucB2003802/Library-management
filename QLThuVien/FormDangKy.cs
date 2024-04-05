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
    public partial class FormDangKy : Form
    {
        public SqlConnection conn = new SqlConnection();
        Ham chucnang = new Ham();

        public FormDangKy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chucnang.ketnoi(conn);
            chucnang.register(conn,txtFullName.Text,dateTimePickerDOB,txtAddress.Text,txtUserName.Text,txtPassword.Text);
            FormDangNhap fmdangnhap = new FormDangNhap();
            this.Hide();
            fmdangnhap.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormDangNhap fmdangnhap = new FormDangNhap();
            this.Hide();
            fmdangnhap.Show();
        }

        private void FormDangKy_Load(object sender, EventArgs e)
        {

        }
    }
}
