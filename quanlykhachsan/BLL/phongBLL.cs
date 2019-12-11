using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAL;

namespace BLL
{
   public class phongBLL
    {
        phongDAL Stclr = new phongDAL();
        public DataTable hienthithongtinphong()
        {
            return Stclr.hienthithongtinphong();
        }
        public void xoa_Phong(int maPhong)
        {
            Stclr.xoa_Phong(maPhong);

        }
        public bool them_phong(int maPhong, bool tinhTrang , bool loaiPhong, float donGia)
        {
            return Stclr.them_phong(loaiPhong, maPhong, donGia, tinhTrang);
        }
    }
}
