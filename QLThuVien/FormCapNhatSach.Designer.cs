using System.Windows.Forms;

namespace QLThuVien
{
    partial class FormCapNhatSach    {
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
            this.btLoadanh = new System.Windows.Forms.Button();
            this.pictureAnhsach = new System.Windows.Forms.PictureBox();
            this.cbLoaiSach = new System.Windows.Forms.ComboBox();
            this.labelAnh = new System.Windows.Forms.Label();
            this.labelLoaisach = new System.Windows.Forms.Label();
            this.labelNXB = new System.Windows.Forms.Label();
            this.labelTacgia = new System.Windows.Forms.Label();
            this.txtNXB = new System.Windows.Forms.TextBox();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.txtTensach = new System.Windows.Forms.TextBox();
            this.labelTensach = new System.Windows.Forms.Label();
            this.txtMasach = new System.Windows.Forms.TextBox();
            this.labelMasach = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btLuusach = new System.Windows.Forms.Button();
            this.btHuybo = new System.Windows.Forms.Button();
            this.btXoasach = new System.Windows.Forms.Button();
            this.btSuasach = new System.Windows.Forms.Button();
            this.btThemsach = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimkiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDocGia = new FontAwesome.Sharp.IconButton();
            this.btThongKe = new FontAwesome.Sharp.IconButton();
            this.btMuon = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTen = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnhsach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btLoadanh);
            this.groupBox1.Controls.Add(this.pictureAnhsach);
            this.groupBox1.Controls.Add(this.cbLoaiSach);
            this.groupBox1.Controls.Add(this.labelAnh);
            this.groupBox1.Controls.Add(this.labelLoaisach);
            this.groupBox1.Controls.Add(this.labelNXB);
            this.groupBox1.Controls.Add(this.labelTacgia);
            this.groupBox1.Controls.Add(this.txtNXB);
            this.groupBox1.Controls.Add(this.txtTacGia);
            this.groupBox1.Controls.Add(this.txtTensach);
            this.groupBox1.Controls.Add(this.labelTensach);
            this.groupBox1.Controls.Add(this.txtMasach);
            this.groupBox1.Controls.Add(this.labelMasach);
            this.groupBox1.Location = new System.Drawing.Point(0, 68);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(395, 480);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btLoadanh
            // 
            this.btLoadanh.Location = new System.Drawing.Point(12, 319);
            this.btLoadanh.Name = "btLoadanh";
            this.btLoadanh.Size = new System.Drawing.Size(92, 34);
            this.btLoadanh.TabIndex = 9;
            this.btLoadanh.Text = "Hình";
            this.btLoadanh.UseVisualStyleBackColor = true;
            this.btLoadanh.Click += new System.EventHandler(this.btLoadanh_Click);
            // 
            // pictureAnhsach
            // 
            this.pictureAnhsach.Location = new System.Drawing.Point(118, 281);
            this.pictureAnhsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureAnhsach.Name = "pictureAnhsach";
            this.pictureAnhsach.Size = new System.Drawing.Size(276, 173);
            this.pictureAnhsach.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureAnhsach.TabIndex = 10;
            this.pictureAnhsach.TabStop = false;
            // 
            // cbLoaiSach
            // 
            this.cbLoaiSach.FormattingEnabled = true;
            this.cbLoaiSach.Location = new System.Drawing.Point(140, 204);
            this.cbLoaiSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiSach.Name = "cbLoaiSach";
            this.cbLoaiSach.Size = new System.Drawing.Size(224, 24);
            this.cbLoaiSach.TabIndex = 13;
            // 
            // labelAnh
            // 
            this.labelAnh.AutoSize = true;
            this.labelAnh.Location = new System.Drawing.Point(137, 353);
            this.labelAnh.Name = "labelAnh";
            this.labelAnh.Size = new System.Drawing.Size(0, 16);
            this.labelAnh.TabIndex = 0;
            // 
            // labelLoaisach
            // 
            this.labelLoaisach.AutoSize = true;
            this.labelLoaisach.Location = new System.Drawing.Point(28, 207);
            this.labelLoaisach.Name = "labelLoaisach";
            this.labelLoaisach.Size = new System.Drawing.Size(76, 16);
            this.labelLoaisach.TabIndex = 0;
            this.labelLoaisach.Text = "Loại Sách : ";
            // 
            // labelNXB
            // 
            this.labelNXB.AutoSize = true;
            this.labelNXB.Location = new System.Drawing.Point(28, 164);
            this.labelNXB.Name = "labelNXB";
            this.labelNXB.Size = new System.Drawing.Size(88, 16);
            this.labelNXB.TabIndex = 0;
            this.labelNXB.Text = "Nhà Xuất Bản";
            // 
            // labelTacgia
            // 
            this.labelTacgia.AutoSize = true;
            this.labelTacgia.Location = new System.Drawing.Point(28, 123);
            this.labelTacgia.Name = "labelTacgia";
            this.labelTacgia.Size = new System.Drawing.Size(64, 16);
            this.labelTacgia.TabIndex = 0;
            this.labelTacgia.Text = "Tác Giả : ";
            // 
            // txtNXB
            // 
            this.txtNXB.Location = new System.Drawing.Point(140, 158);
            this.txtNXB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNXB.Name = "txtNXB";
            this.txtNXB.Size = new System.Drawing.Size(224, 22);
            this.txtNXB.TabIndex = 4;
            // 
            // txtTacGia
            // 
            this.txtTacGia.Location = new System.Drawing.Point(140, 117);
            this.txtTacGia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(224, 22);
            this.txtTacGia.TabIndex = 3;
            // 
            // txtTensach
            // 
            this.txtTensach.Location = new System.Drawing.Point(140, 68);
            this.txtTensach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTensach.Name = "txtTensach";
            this.txtTensach.Size = new System.Drawing.Size(224, 22);
            this.txtTensach.TabIndex = 2;
            // 
            // labelTensach
            // 
            this.labelTensach.AutoSize = true;
            this.labelTensach.Location = new System.Drawing.Point(28, 74);
            this.labelTensach.Name = "labelTensach";
            this.labelTensach.Size = new System.Drawing.Size(74, 16);
            this.labelTensach.TabIndex = 0;
            this.labelTensach.Text = "Tên Sách : ";
            // 
            // txtMasach
            // 
            this.txtMasach.Location = new System.Drawing.Point(140, 25);
            this.txtMasach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMasach.Name = "txtMasach";
            this.txtMasach.Size = new System.Drawing.Size(224, 22);
            this.txtMasach.TabIndex = 1;
            // 
            // labelMasach
            // 
            this.labelMasach.AutoSize = true;
            this.labelMasach.Location = new System.Drawing.Point(28, 31);
            this.labelMasach.Name = "labelMasach";
            this.labelMasach.Size = new System.Drawing.Size(69, 16);
            this.labelMasach.TabIndex = 0;
            this.labelMasach.Text = "Mã Sách : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(865, 539);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.btLuusach);
            this.groupBox3.Controls.Add(this.btHuybo);
            this.groupBox3.Controls.Add(this.btXoasach);
            this.groupBox3.Controls.Add(this.btSuasach);
            this.groupBox3.Controls.Add(this.btThemsach);
            this.groupBox3.Location = new System.Drawing.Point(0, 552);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(394, 149);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // btLuusach
            // 
            this.btLuusach.Location = new System.Drawing.Point(83, 93);
            this.btLuusach.Name = "btLuusach";
            this.btLuusach.Size = new System.Drawing.Size(89, 41);
            this.btLuusach.TabIndex = 13;
            this.btLuusach.Text = "Lưu";
            this.btLuusach.UseVisualStyleBackColor = true;
            this.btLuusach.Click += new System.EventHandler(this.btLuusach_Click);
            // 
            // btHuybo
            // 
            this.btHuybo.Location = new System.Drawing.Point(227, 93);
            this.btHuybo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btHuybo.Name = "btHuybo";
            this.btHuybo.Size = new System.Drawing.Size(87, 43);
            this.btHuybo.TabIndex = 3;
            this.btHuybo.Text = "Hủy Bỏ";
            this.btHuybo.UseVisualStyleBackColor = true;
            this.btHuybo.Click += new System.EventHandler(this.btHuybo_Click);
            // 
            // btXoasach
            // 
            this.btXoasach.Location = new System.Drawing.Point(285, 31);
            this.btXoasach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btXoasach.Name = "btXoasach";
            this.btXoasach.Size = new System.Drawing.Size(88, 42);
            this.btXoasach.TabIndex = 12;
            this.btXoasach.Text = "Xóa";
            this.btXoasach.UseVisualStyleBackColor = true;
            this.btXoasach.Click += new System.EventHandler(this.btXoasach_Click);
            // 
            // btSuasach
            // 
            this.btSuasach.Location = new System.Drawing.Point(160, 31);
            this.btSuasach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSuasach.Name = "btSuasach";
            this.btSuasach.Size = new System.Drawing.Size(87, 42);
            this.btSuasach.TabIndex = 11;
            this.btSuasach.Text = "Sữa";
            this.btSuasach.UseVisualStyleBackColor = true;
            this.btSuasach.Click += new System.EventHandler(this.btSuasach_Click);
            // 
            // btThemsach
            // 
            this.btThemsach.Location = new System.Drawing.Point(31, 31);
            this.btThemsach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btThemsach.Name = "btThemsach";
            this.btThemsach.Size = new System.Drawing.Size(89, 42);
            this.btThemsach.TabIndex = 10;
            this.btThemsach.Text = "Thêm";
            this.btThemsach.UseVisualStyleBackColor = true;
            this.btThemsach.Click += new System.EventHandler(this.btThemsach_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(128, 20);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(268, 22);
            this.txtTimKiem.TabIndex = 9;
            // 
            // btTimkiem
            // 
            this.btTimkiem.BackColor = System.Drawing.Color.Transparent;
            this.btTimkiem.Location = new System.Drawing.Point(3, 15);
            this.btTimkiem.Name = "btTimkiem";
            this.btTimkiem.Size = new System.Drawing.Size(119, 33);
            this.btTimkiem.TabIndex = 14;
            this.btTimkiem.Text = "Tìm Kiếm";
            this.btTimkiem.UseVisualStyleBackColor = false;
            this.btTimkiem.Click += new System.EventHandler(this.btTimkiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.txtTimKiem);
            this.groupBox2.Controls.Add(this.btTimkiem);
            this.groupBox2.Location = new System.Drawing.Point(394, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 585);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btDocGia);
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.btMuon);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1266, 43);
            this.panel1.TabIndex = 10;
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
            this.btDocGia.Location = new System.Drawing.Point(1014, 1);
            this.btDocGia.Name = "btDocGia";
            this.btDocGia.Size = new System.Drawing.Size(241, 42);
            this.btDocGia.TabIndex = 0;
            this.btDocGia.Text = "Độc Giả";
            this.btDocGia.UseVisualStyleBackColor = true;
            this.btDocGia.Click += new System.EventHandler(this.btDocGia_Click);
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
            this.btThongKe.Location = new System.Drawing.Point(670, 0);
            this.btThongKe.Name = "btThongKe";
            this.btThongKe.Size = new System.Drawing.Size(257, 42);
            this.btThongKe.TabIndex = 0;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.UseVisualStyleBackColor = true;
            this.btThongKe.Click += new System.EventHandler(this.btThongKe_Click);
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
            this.btMuon.Location = new System.Drawing.Point(342, 1);
            this.btMuon.Name = "btMuon";
            this.btMuon.Size = new System.Drawing.Size(276, 42);
            this.btMuon.TabIndex = 0;
            this.btMuon.Text = "Mượn-Trả Sách";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 34;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(12, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(270, 42);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Cập Nhật Sách";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(432, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 32);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hệ Thống Cập Nhật Sách";
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(1011, 59);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(50, 16);
            this.labelTen.TabIndex = 12;
            this.labelTen.Text = "label2";
            // 
            // FormCapNhatSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1267, 717);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormCapNhatSach";
            this.Text = "FormCapNhatSach";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAnhsach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelLoaisach;
        private System.Windows.Forms.Label labelNXB;
        private System.Windows.Forms.Label labelTacgia;
        private System.Windows.Forms.TextBox txtTensach;
        private System.Windows.Forms.Label labelTensach;
        private System.Windows.Forms.TextBox txtMasach;
        private System.Windows.Forms.Label labelMasach;
        private System.Windows.Forms.PictureBox pictureAnhsach;
        private System.Windows.Forms.Label labelAnh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btHuybo;
        private System.Windows.Forms.Button btXoasach;
        private System.Windows.Forms.Button btSuasach;
        private System.Windows.Forms.Button btThemsach;
        private System.Windows.Forms.ComboBox cbLoaiSach;
        private System.Windows.Forms.TextBox txtTacGia;
        private System.Windows.Forms.Button btLuusach;
        private System.Windows.Forms.Button btLoadanh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btTimkiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNXB;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btThongKe;
        private FontAwesome.Sharp.IconButton btMuon;
        private FontAwesome.Sharp.IconButton btDocGia;
        private Label labelTen;
    }
}

