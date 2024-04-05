using System.Drawing;
using System.Windows.Forms;

namespace QLThuVien
{
    partial class FormDocGia
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaDG = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDatlai = new System.Windows.Forms.Button();
            this.btXoaDG = new System.Windows.Forms.Button();
            this.btSuaDG = new System.Windows.Forms.Button();
            this.btThemDG = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDocGia = new FontAwesome.Sharp.IconButton();
            this.btThongKe = new FontAwesome.Sharp.IconButton();
            this.btMuon = new FontAwesome.Sharp.IconButton();
            this.btCapNhat = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelTen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(9, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1252, 357);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Độc Giả";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 304);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dateTimePickerNgaysinh);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtMaDG);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(6, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(677, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điền Thông Tin Độc Giả";
            // 
            // dateTimePickerNgaysinh
            // 
            this.dateTimePickerNgaysinh.Location = new System.Drawing.Point(211, 130);
            this.dateTimePickerNgaysinh.Name = "dateTimePickerNgaysinh";
            this.dateTimePickerNgaysinh.Size = new System.Drawing.Size(356, 30);
            this.dateTimePickerNgaysinh.TabIndex = 11;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtDiaChi.Location = new System.Drawing.Point(211, 170);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(356, 30);
            this.txtDiaChi.TabIndex = 10;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtHoTen.Location = new System.Drawing.Point(211, 84);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(356, 30);
            this.txtHoTen.TabIndex = 8;
            // 
            // txtMaDG
            // 
            this.txtMaDG.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.txtMaDG.Location = new System.Drawing.Point(211, 45);
            this.txtMaDG.Name = "txtMaDG";
            this.txtMaDG.Size = new System.Drawing.Size(356, 30);
            this.txtMaDG.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(8, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ngày Sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(10, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Họ Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(8, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã Độc Giả:";
            // 
            // btnDatlai
            // 
            this.btnDatlai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatlai.ForeColor = System.Drawing.Color.Teal;
            this.btnDatlai.Location = new System.Drawing.Point(6, 138);
            this.btnDatlai.Name = "btnDatlai";
            this.btnDatlai.Size = new System.Drawing.Size(99, 38);
            this.btnDatlai.TabIndex = 12;
            this.btnDatlai.Text = "Đặt lại";
            this.btnDatlai.UseVisualStyleBackColor = true;
            this.btnDatlai.Click += new System.EventHandler(this.btnDatlai_Click);
            // 
            // btXoaDG
            // 
            this.btXoaDG.BackColor = System.Drawing.Color.Red;
            this.btXoaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoaDG.ForeColor = System.Drawing.Color.White;
            this.btXoaDG.Location = new System.Drawing.Point(190, 138);
            this.btXoaDG.Name = "btXoaDG";
            this.btXoaDG.Size = new System.Drawing.Size(105, 44);
            this.btXoaDG.TabIndex = 2;
            this.btXoaDG.Text = "Xóa";
            this.btXoaDG.UseVisualStyleBackColor = false;
            this.btXoaDG.Click += new System.EventHandler(this.btXoaDG_Click);
            // 
            // btSuaDG
            // 
            this.btSuaDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSuaDG.ForeColor = System.Drawing.Color.Teal;
            this.btSuaDG.Location = new System.Drawing.Point(190, 26);
            this.btSuaDG.Name = "btSuaDG";
            this.btSuaDG.Size = new System.Drawing.Size(105, 35);
            this.btSuaDG.TabIndex = 1;
            this.btSuaDG.Text = "Sửa";
            this.btSuaDG.UseVisualStyleBackColor = true;
            this.btSuaDG.Click += new System.EventHandler(this.btSuaDG_Click);
            // 
            // btThemDG
            // 
            this.btThemDG.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemDG.ForeColor = System.Drawing.Color.Teal;
            this.btThemDG.Location = new System.Drawing.Point(6, 26);
            this.btThemDG.Name = "btThemDG";
            this.btThemDG.Size = new System.Drawing.Size(99, 35);
            this.btThemDG.TabIndex = 0;
            this.btThemDG.Text = "Thêm";
            this.btThemDG.UseVisualStyleBackColor = true;
            this.btThemDG.Click += new System.EventHandler(this.btThemDG_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btDocGia);
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.btMuon);
            this.panel1.Controls.Add(this.btCapNhat);
            this.panel1.Location = new System.Drawing.Point(9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1265, 43);
            this.panel1.TabIndex = 12;
            // 
            // btDocGia
            // 
            this.btDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDocGia.ForeColor = System.Drawing.Color.Black;
            this.btDocGia.IconChar = FontAwesome.Sharp.IconChar.React;
            this.btDocGia.IconColor = System.Drawing.Color.Black;
            this.btDocGia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btDocGia.IconSize = 34;
            this.btDocGia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btDocGia.Location = new System.Drawing.Point(1001, 1);
            this.btDocGia.Name = "btDocGia";
            this.btDocGia.Size = new System.Drawing.Size(261, 42);
            this.btDocGia.TabIndex = 0;
            this.btDocGia.Text = "Độc Giả";
            this.btDocGia.UseVisualStyleBackColor = true;
            // 
            // btThongKe
            // 
            this.btThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThongKe.ForeColor = System.Drawing.Color.Black;
            this.btThongKe.IconChar = FontAwesome.Sharp.IconChar.Stairs;
            this.btThongKe.IconColor = System.Drawing.Color.Black;
            this.btThongKe.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btThongKe.IconSize = 34;
            this.btThongKe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThongKe.Location = new System.Drawing.Point(683, 0);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(276, 42);
            this.btThongKe.TabIndex = 0;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click_1);
            // 
            // btMuon
            // 
            this.btMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMuon.ForeColor = System.Drawing.Color.Black;
            this.btMuon.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.btMuon.IconColor = System.Drawing.Color.Black;
            this.btMuon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btMuon.IconSize = 34;
            this.btMuon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMuon.Location = new System.Drawing.Point(353, 1);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(284, 42);
            this.btMuon.TabIndex = 0;
            this.btMuon.Text = "Mượn-Trả Sách";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click_1);
            // 
            // btCapNhat
            // 
            this.btCapNhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapNhat.ForeColor = System.Drawing.Color.Black;
            this.btCapNhat.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btCapNhat.IconColor = System.Drawing.Color.Black;
            this.btCapNhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btCapNhat.IconSize = 34;
            this.btCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCapNhat.Location = new System.Drawing.Point(32, 0);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(267, 42);
            this.btCapNhat.TabIndex = 0;
            this.btCapNhat.Text = "Cập Nhật Sách";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(409, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 32);
            this.label1.TabIndex = 13;
            this.label1.Text = "Hệ Thống Quản Lý Độc Giả";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDatlai);
            this.groupBox3.Controls.Add(this.btThemDG);
            this.groupBox3.Controls.Add(this.btSuaDG);
            this.groupBox3.Controls.Add(this.btXoaDG);
            this.groupBox3.Location = new System.Drawing.Point(701, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 201);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức Năng";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(1007, 74);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(50, 16);
            this.labelTen.TabIndex = 15;
            this.labelTen.Text = "label6";
            // 
            // FormDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 741);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormDocGia";
            this.Text = "UserManagement";
            this.Load += new System.EventHandler(this.FormDocGia_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private GroupBox groupBox2;
        private Button btXoaDG;
        private Button btSuaDG;
        private Button btThemDG;
        private TextBox txtDiaChi;
        private TextBox txtHoTen;
        private TextBox txtMaDG;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerNgaysinh;
        private Button btnDatlai;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btDocGia;
        private FontAwesome.Sharp.IconButton btThongKe;
        private FontAwesome.Sharp.IconButton btMuon;
        private FontAwesome.Sharp.IconButton btCapNhat;
        private Label label1;
        private GroupBox groupBox3;
        private Label labelTen;
    }
}