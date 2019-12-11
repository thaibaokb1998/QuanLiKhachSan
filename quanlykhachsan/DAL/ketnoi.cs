using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    public class ketnoi
    {
        public static SqlConnection Get()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = @"Data Source=DESKTOP-9IJMMGS\SQLEXPRESS;Initial Catalog=demo;Integrated Security=True;User ID=sa;Password=12345";
            cnn.Open();
            return cnn;
        }
   }
}
