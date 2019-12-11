﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
   public class phongDAL
    {
        public DataTable hienthithongtinphong()
        {
            SqlConnection cnn = ketnoi.Get();         
            // Khai báo và khởi tạo đối tượng Command, truyền vào tên thủ tục tương ứng
            SqlCommand cmd = new SqlCommand("hienthiphong", cnn);
            // Khai báo kiểu thực thi là Thực thi thủ tục
            cmd.CommandType = CommandType.StoredProcedure; 
            cmd.Connection = cnn;
            cmd.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cnn.Close();
            return dt;
        }
        public void xoa_Phong(int maPhong)
        {

            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("xoa_phong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("maPhong", maPhong);
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public bool them_phong(bool loaiPhong, int maPhong, float donGia, bool tinhTrang )
        {
            SqlConnection cnn = ketnoi.Get();
            SqlCommand cmd = new SqlCommand("them_phong", cnn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("maPhong", maPhong);
            cmd.Parameters.AddWithValue("loaiPhong", loaiPhong);
            cmd.Parameters.AddWithValue("tinhTrang", tinhTrang);
            cmd.Parameters.AddWithValue("donGia", donGia);
            
            int i = cmd.ExecuteNonQuery();
            cnn.Close();
            if (i != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
