using System.Windows.Forms;

namespace QLThuVien
{
    partial class FormThongKe
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
            this.btDangmuon = new System.Windows.Forms.Button();
            this.btDaTra = new System.Windows.Forms.Button();
            this.btQuaHan = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelDanhsach = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btDocGia = new FontAwesome.Sharp.IconButton();
            this.btThongKe = new FontAwesome.Sharp.IconButton();
            this.btMuon = new FontAwesome.Sharp.IconButton();
            this.btCapNhat = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTongSo = new System.Windows.Forms.Label();
            this.btChuaTra = new System.Windows.Forms.Button();
            this.labelTen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btDangmuon
            // 
            this.btDangmuon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDangmuon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDangmuon.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDangmuon.ForeColor = System.Drawing.Color.Black;
            this.btDangmuon.Location = new System.Drawing.Point(92, 109);
            this.btDangmuon.Name = "btDangmuon";
            this.btDangmuon.Size = new System.Drawing.Size(203, 77);
            this.btDangmuon.TabIndex = 1;
            this.btDangmuon.Text = "Đang Mượn";
            this.btDangmuon.UseVisualStyleBackColor = false;
            this.btDangmuon.Click += new System.EventHandler(this.btDangmuon_Click);
            // 
            // btDaTra
            // 
            this.btDaTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDaTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDaTra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDaTra.Location = new System.Drawing.Point(370, 109);
            this.btDaTra.Name = "btDaTra";
            this.btDaTra.Size = new System.Drawing.Size(203, 77);
            this.btDaTra.TabIndex = 12;
            this.btDaTra.Text = "Trả Đúng Hạn";
            this.btDaTra.UseVisualStyleBackColor = false;
            this.btDaTra.Click += new System.EventHandler(this.btDaTra_Click);
            // 
            // btQuaHan
            // 
            this.btQuaHan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btQuaHan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btQuaHan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuaHan.Location = new System.Drawing.Point(652, 109);
            this.btQuaHan.Name = "btQuaHan";
            this.btQuaHan.Size = new System.Drawing.Size(201, 77);
            this.btQuaHan.TabIndex = 13;
            this.btQuaHan.Text = "Trả Quá Hạn";
            this.btQuaHan.UseVisualStyleBackColor = false;
            this.btQuaHan.Click += new System.EventHandler(this.btQuaHan_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 239);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1203, 336);
            this.dataGridView1.TabIndex = 14;
            // 
            // labelDanhsach
            // 
            this.labelDanhsach.AutoSize = true;
            this.labelDanhsach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanhsach.Location = new System.Drawing.Point(12, 206);
            this.labelDanhsach.Name = "labelDanhsach";
            this.labelDanhsach.Size = new System.Drawing.Size(0, 20);
            this.labelDanhsach.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btDocGia);
            this.panel1.Controls.Add(this.btThongKe);
            this.panel1.Controls.Add(this.btMuon);
            this.panel1.Controls.Add(this.btCapNhat);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1255, 43);
            this.panel1.TabIndex = 17;
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
            this.btDocGia.Location = new System.Drawing.Point(988, 1);
            this.btDocGia.Name = "btDocGia";
            this.btDocGia.Size = new System.Drawing.Size(256, 42);
            this.btDocGia.TabIndex = 0;
            this.btDocGia.Text = "Độc Giả";
            this.btDocGia.UseVisualStyleBackColor = true;
            this.btDocGia.Click += new System.EventHandler(this.btDocGia_Click_1);
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
            this.btThongKe.Size = new System.Drawing.Size(274, 42);
            this.btThongKe.TabIndex = 0;
            this.btThongKe.Text = "Thống Kê";
            this.btThongKe.UseVisualStyleBackColor = true;
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
            this.btMuon.Size = new System.Drawing.Size(281, 42);
            this.btMuon.TabIndex = 0;
            this.btMuon.Text = "Mượn-Trả Sách";
            this.btMuon.UseVisualStyleBackColor = true;
            this.btMuon.Click += new System.EventHandler(this.btMuon_Click);
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
            this.btCapNhat.Location = new System.Drawing.Point(38, 0);
            this.btCapNhat.Name = "btCapNhat";
            this.btCapNhat.Size = new System.Drawing.Size(273, 42);
            this.btCapNhat.TabIndex = 0;
            this.btCapNhat.Text = "Cập Nhật Sách";
            this.btCapNhat.UseVisualStyleBackColor = true;
            this.btCapNhat.Click += new System.EventHandler(this.btCapNhat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(362, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Hệ Thống Thống Kê Sách";
            // 
            // labelTongSo
            // 
            this.labelTongSo.AutoSize = true;
            this.labelTongSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongSo.Location = new System.Drawing.Point(875, 206);
            this.labelTongSo.Name = "labelTongSo";
            this.labelTongSo.Size = new System.Drawing.Size(0, 20);
            this.labelTongSo.TabIndex = 19;
            // 
            // btChuaTra
            // 
            this.btChuaTra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btChuaTra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChuaTra.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btChuaTra.Location = new System.Drawing.Point(931, 109);
            this.btChuaTra.Name = "btChuaTra";
            this.btChuaTra.Size = new System.Drawing.Size(201, 77);
            this.btChuaTra.TabIndex = 20;
            this.btChuaTra.Text = "Chưa Trả";
            this.btChuaTra.UseVisualStyleBackColor = false;
            this.btChuaTra.Click += new System.EventHandler(this.btChuaTra_Click);
            // 
            // labelTen
            // 
            this.labelTen.AutoSize = true;
            this.labelTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTen.Location = new System.Drawing.Point(986, 56);
            this.labelTen.Name = "labelTen";
            this.labelTen.Size = new System.Drawing.Size(50, 16);
            this.labelTen.TabIndex = 21;
            this.labelTen.Text = "label2";
            // 
            // FormThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 630);
            this.Controls.Add(this.labelTen);
            this.Controls.Add(this.btChuaTra);
            this.Controls.Add(this.labelTongSo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelDanhsach);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btQuaHan);
            this.Controls.Add(this.btDaTra);
            this.Controls.Add(this.btDangmuon);
            this.Name = "FormThongKe";
            this.Text = "FormThongKe";
            this.Load += new System.EventHandler(this.FormThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btDangmuon;
        private System.Windows.Forms.Button btDaTra;
        private System.Windows.Forms.Button btQuaHan;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelDanhsach;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btDocGia;
        private FontAwesome.Sharp.IconButton btThongKe;
        private FontAwesome.Sharp.IconButton btMuon;
        private FontAwesome.Sharp.IconButton btCapNhat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTongSo;
        private Button btChuaTra;
        private Label labelTen;
    }
}