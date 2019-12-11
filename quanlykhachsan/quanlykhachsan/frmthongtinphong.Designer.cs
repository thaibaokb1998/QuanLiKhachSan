namespace quanlykhachsan
{
    partial class frmthongtinphong
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDonGiaPhong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbTinhTrang = new System.Windows.Forms.ComboBox();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.btnsuaphong = new System.Windows.Forms.Button();
            this.btnxoaphong = new System.Windows.Forms.Button();
            this.btnluuphong = new System.Windows.Forms.Button();
            this.btnthoatphong = new System.Windows.Forms.Button();
            this.cbLoaiPhong = new System.Windows.Forms.ComboBox();
            this.grThongTinPhong = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinPhong)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(392, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 38);
            this.label5.TabIndex = 13;
            this.label5.Text = "THÔNG TIN PHÒNG";
            // 
            // txtPhong
            // 
            this.txtPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPhong.Location = new System.Drawing.Point(251, 335);
            this.txtPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhong.Name = "txtPhong";
            this.txtPhong.Size = new System.Drawing.Size(211, 30);
            this.txtPhong.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(72, 337);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 38;
            this.label1.Text = "Phòng :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(72, 414);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Loại phòng :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(605, 337);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 22);
            this.label3.TabIndex = 42;
            this.label3.Text = "Tình trạng phòng :";
            // 
            // txtDonGiaPhong
            // 
            this.txtDonGiaPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtDonGiaPhong.Location = new System.Drawing.Point(784, 411);
            this.txtDonGiaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGiaPhong.Name = "txtDonGiaPhong";
            this.txtDonGiaPhong.Size = new System.Drawing.Size(211, 30);
            this.txtDonGiaPhong.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(605, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 22);
            this.label4.TabIndex = 44;
            this.label4.Text = "Đơn giá :";
            // 
            // cbTinhTrang
            // 
            this.cbTinhTrang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbTinhTrang.FormattingEnabled = true;
            this.cbTinhTrang.Items.AddRange(new object[] {
            "Rỗi",
            "Bận"});
            this.cbTinhTrang.Location = new System.Drawing.Point(784, 337);
            this.cbTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.cbTinhTrang.Name = "cbTinhTrang";
            this.cbTinhTrang.Size = new System.Drawing.Size(211, 30);
            this.cbTinhTrang.TabIndex = 46;
            // 
            // btnthemphong
            // 
            this.btnthemphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthemphong.Location = new System.Drawing.Point(165, 490);
            this.btnthemphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(97, 38);
            this.btnthemphong.TabIndex = 47;
            this.btnthemphong.Text = "Thêm";
            this.btnthemphong.UseVisualStyleBackColor = true;
            this.btnthemphong.Click += new System.EventHandler(this.btnthemphong_Click);
            // 
            // btnsuaphong
            // 
            this.btnsuaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnsuaphong.Location = new System.Drawing.Point(335, 490);
            this.btnsuaphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnsuaphong.Name = "btnsuaphong";
            this.btnsuaphong.Size = new System.Drawing.Size(97, 38);
            this.btnsuaphong.TabIndex = 48;
            this.btnsuaphong.Text = "Sửa";
            this.btnsuaphong.UseVisualStyleBackColor = true;
            // 
            // btnxoaphong
            // 
            this.btnxoaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnxoaphong.Location = new System.Drawing.Point(497, 490);
            this.btnxoaphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnxoaphong.Name = "btnxoaphong";
            this.btnxoaphong.Size = new System.Drawing.Size(97, 38);
            this.btnxoaphong.TabIndex = 49;
            this.btnxoaphong.Text = "Xóa";
            this.btnxoaphong.UseVisualStyleBackColor = true;
            this.btnxoaphong.Click += new System.EventHandler(this.btnxoaphong_Click);
            // 
            // btnluuphong
            // 
            this.btnluuphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnluuphong.Location = new System.Drawing.Point(680, 490);
            this.btnluuphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnluuphong.Name = "btnluuphong";
            this.btnluuphong.Size = new System.Drawing.Size(97, 38);
            this.btnluuphong.TabIndex = 50;
            this.btnluuphong.Text = "Lưu";
            this.btnluuphong.UseVisualStyleBackColor = true;
            this.btnluuphong.Click += new System.EventHandler(this.btnluuphong_Click);
            // 
            // btnthoatphong
            // 
            this.btnthoatphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnthoatphong.Location = new System.Drawing.Point(856, 490);
            this.btnthoatphong.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoatphong.Name = "btnthoatphong";
            this.btnthoatphong.Size = new System.Drawing.Size(97, 38);
            this.btnthoatphong.TabIndex = 51;
            this.btnthoatphong.Text = "Thoát";
            this.btnthoatphong.UseVisualStyleBackColor = true;
            this.btnthoatphong.Click += new System.EventHandler(this.btnthoatphong_Click);
            // 
            // cbLoaiPhong
            // 
            this.cbLoaiPhong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbLoaiPhong.FormattingEnabled = true;
            this.cbLoaiPhong.Items.AddRange(new object[] {
            "Thường",
            "Trung",
            "Vip"});
            this.cbLoaiPhong.Location = new System.Drawing.Point(251, 410);
            this.cbLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoaiPhong.Name = "cbLoaiPhong";
            this.cbLoaiPhong.Size = new System.Drawing.Size(211, 30);
            this.cbLoaiPhong.TabIndex = 52;
            // 
            // grThongTinPhong
            // 
            this.grThongTinPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grThongTinPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grThongTinPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.loaiPhong,
            this.tinhTrang,
            this.donGia});
            this.grThongTinPhong.Location = new System.Drawing.Point(44, 74);
            this.grThongTinPhong.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTinPhong.Name = "grThongTinPhong";
            this.grThongTinPhong.ReadOnly = true;
            this.grThongTinPhong.Size = new System.Drawing.Size(1029, 218);
            this.grThongTinPhong.TabIndex = 53;
            this.grThongTinPhong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Phòng";
            this.maPhong.Name = "maPhong";
            this.maPhong.ReadOnly = true;
            // 
            // loaiPhong
            // 
            this.loaiPhong.DataPropertyName = "loaiPhong";
            this.loaiPhong.HeaderText = "Loại Phòng";
            this.loaiPhong.Name = "loaiPhong";
            this.loaiPhong.ReadOnly = true;
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình Trạng";
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn Giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // frmthongtinphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 567);
            this.Controls.Add(this.grThongTinPhong);
            this.Controls.Add(this.cbLoaiPhong);
            this.Controls.Add(this.btnthoatphong);
            this.Controls.Add(this.btnluuphong);
            this.Controls.Add(this.btnxoaphong);
            this.Controls.Add(this.btnsuaphong);
            this.Controls.Add(this.btnthemphong);
            this.Controls.Add(this.cbTinhTrang);
            this.Controls.Add(this.txtDonGiaPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPhong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmthongtinphong";
            this.Text = "frmthongtinphong";
            this.Load += new System.EventHandler(this.frm_load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinPhong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDonGiaPhong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbTinhTrang;
        private System.Windows.Forms.Button btnthemphong;
        private System.Windows.Forms.Button btnsuaphong;
        private System.Windows.Forms.Button btnxoaphong;
        private System.Windows.Forms.Button btnluuphong;
        private System.Windows.Forms.Button btnthoatphong;
        private System.Windows.Forms.ComboBox cbLoaiPhong;
        private System.Windows.Forms.DataGridView grThongTinPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
    }
}