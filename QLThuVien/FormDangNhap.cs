using Microsoft.Win32;
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
    public partial class FormDangNhap : Form
    {
        public SqlConnection conn = new SqlConnection();
        Ham chucnang = new Ham();
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btDangky_Click(object sender, EventArgs e)
        {
            FormDangKy formRegister = new FormDangKy();
            this.Hide();
            formRegister.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chucnang.ketnoi(conn);
            bool res = chucnang.login(conn, txtUserName.Text, txtPassword.Text);
            if (res)
            {
                this.Hide();
            }
        }

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
