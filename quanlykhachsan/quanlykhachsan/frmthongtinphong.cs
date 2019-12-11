using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace quanlykhachsan
{
    public partial class frmthongtinphong : Form
    {
        public frmthongtinphong()
        {
            InitializeComponent();
        }
        int temp;
        private void hienthi()
        {
            phongBLL pbll = new phongBLL();
            grThongTinPhong.DataSource = pbll.hienthithongtinphong();
        }
        private void trangthai(bool t)
        {
            txtPhong.Enabled = t;
            txtDonGiaPhong.Enabled = t;
            cbLoaiPhong.Enabled = t;
            cbTinhTrang.Enabled = t;
        }
        private void frm_load(object sender, EventArgs e)
        {
            hienthi();
            trangthai(false);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = grThongTinPhong.Rows[e.RowIndex];
            txtPhong.Text = row.Cells["maPhong"].Value.ToString();
            txtDonGiaPhong.Text = row.Cells["donGia"].Value.ToString();
            cbLoaiPhong.Text= row.Cells["loaiPhong"].Value.ToString();          
            cbTinhTrang.Text =row.Cells["tinhTrang"].Value.ToString();           
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            trangthai(true);
            temp = 1;
            txtPhong.Clear();
            txtDonGiaPhong.Clear();
            cbTinhTrang.ResetText();
            cbLoaiPhong.ResetText();

            //btnluu.Enabled = true;
            //btnsua.Enabled = false;
            //btnxoa.Enabled = false;
            //btnhuy.Enabled = true;

        }
        private bool traveTinhTrang()
        {
            if (cbTinhTrang.Text == "Bận")
                return true;
            else
                return false;
        }
        private bool traveLoaiPhong()
        {

            if (cbLoaiPhong.Text == "Thường")
                return true;
            else if (cbLoaiPhong.Text == "Trung")
                return false;
            else
                return false;
        }

        private void btnluuphong_Click(object sender, EventArgs e)
        {
            trangthai(false);
            if (temp == 1)
            {
                phongBLL pBLL = new phongBLL();
                pBLL.them_phong(int.Parse(txtPhong.Text), traveTinhTrang(), traveLoaiPhong(), float.Parse(txtDonGiaPhong.Text));

                hienthi();
            }
            //else
            //{
            //    nhanvienBLL nvBLL = new nhanvienBLL();
            //    nvBLL.sua_nhanvien(txttennv.Text, travegioitinh(), dtngaysinh.Value, txtscm.Text, txtdiachi.Text, txtsdt.Text, dtngayvaolam.Value, int.Parse(txtmanv.Text));
            //    hienthi();
            //}
            //btnluu.Enabled = false;
            //btnhuy.Enabled = false;
            //btnsua.Enabled = true;
            //btnthem.Enabled = true;
            //btnxoa.Enabled = true;
        }

        private void btnxoaphong_Click(object sender, EventArgs e)
        {
            phongBLL pBLL = new phongBLL();
            DialogResult luu = MessageBox.Show("Bạn chắc chắn xóa??", "Thông báo thêm mới", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (luu == DialogResult.Yes)
            {
                pBLL.xoa_Phong(int.Parse(txtPhong.Text));
                hienthi();
            }
        }

        private void btnthoatphong_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
