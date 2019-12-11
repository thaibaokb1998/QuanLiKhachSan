namespace quanlykhachsan
{
    partial class frmthongtinpphongkh
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
            this.grThongTinPhongKH = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinPhongKH)).BeginInit();
            this.SuspendLayout();
            // 
            // grThongTinPhongKH
            // 
            this.grThongTinPhongKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grThongTinPhongKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grThongTinPhongKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.loaiPhong,
            this.tinhTrang,
            this.donGia});
            this.grThongTinPhongKH.Location = new System.Drawing.Point(1, 100);
            this.grThongTinPhongKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grThongTinPhongKH.Name = "grThongTinPhongKH";
            this.grThongTinPhongKH.ReadOnly = true;
            this.grThongTinPhongKH.Size = new System.Drawing.Size(1029, 434);
            this.grThongTinPhongKH.TabIndex = 16;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(352, 42);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(345, 38);
            this.label5.TabIndex = 15;
            this.label5.Text = "THÔNG TIN PHÒNG";
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDangXuat.Location = new System.Drawing.Point(252, 544);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(136, 49);
            this.btnDangXuat.TabIndex = 17;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            this.btnDangXuat.Click += new System.EventHandler(this.button1_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.thoat.Location = new System.Drawing.Point(597, 544);
            this.thoat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(136, 49);
            this.thoat.TabIndex = 18;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // frmthongtinpphongkh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 608);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.grThongTinPhongKH);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmthongtinpphongkh";
            this.Text = "frmthongtinpphongkh";
            this.Load += new System.EventHandler(this.frm_load);
            ((System.ComponentModel.ISupportInitialize)(this.grThongTinPhongKH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grThongTinPhongKH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Button thoat;
    }
}