using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;

namespace quanlykhachsan
{
    public partial class frmdangnhap : Form
    {
        public frmdangnhap()
        {
            InitializeComponent();
        }

        private void btndangnhap_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-9IJMMGS\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True;User ID=sa;Password=12345");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From [dbo].[nguoidung] where taiKhoan = '" + txtTaiKhoan.Text + "' and matKhau = '" + txtMatKhau.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if ((dt.Rows[0][0]).ToString() == "1")
            {
                this.Hide(); // Form Đăng Nhập sẽ ẩn đi => MainForm sẽ load lên
                frmmainquanlykhachsan frm = new frmmainquanlykhachsan();
                frm.Show();
            }
            else
            {
                lbtb.Text = "Tài khoản hoặc mật khẩu sai.vui lòng thử lại!!";

            }
            if (cbKhach.Checked == true)
            {
                trangthai(false);
                this.Hide(); // Form Đăng Nhập sẽ ẩn đi => MainForm sẽ load lên
                frmthongtinpphongkh frm = new frmthongtinpphongkh(); //chi xem duoc thong tin phong
                frm.Show();

            }
           
        }
        private void trangthai( bool t)
        {
            txtTaiKhoan.Enabled = t;
            txtMatKhau.Enabled = t;
        }

        private void frm_load(object sender, EventArgs e)
        {
          
        }

        private void cbkhach_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKhach.Checked == true)
            {
                trangthai(false);
                txtMatKhau.Clear();
                txtTaiKhoan.Clear();
            }
            else
            {
                trangthai(true);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit(); ;
        }
    }
}
