using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    class Ketnoi
    {
        public SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I3CH2RE\SQLEXPRESS;Initial Catalog=khachsannet;Integrated Security=True");
        public void Ketnoicsdl()
        {
            try
            {
                if (conn.State == 0) //Kiem tra xem ket noi co mo khong
                {

                    conn.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Ngatketnoi()
        {
            if (conn.State != 0) //Kiểm tra kết nối có mở không, nếu kết nối mở thì đóng lại
            {
                conn.Close();
            }
        }
        //Hàm hiển thị
        public DataTable HienthiDL(string sql)
        {
            Ketnoicsdl();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        //Hàm thực thi
        public SqlCommand ThucthiDL(string sql)
        {
            Ketnoicsdl();
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            return cmd;
        }

        public string LayMotGiaTri(string sql)
        {


            SqlCommand command = new SqlCommand(sql, conn);
            Ketnoicsdl();
            string tk = string.Empty;
            using (SqlDataReader re = command.ExecuteReader())
            {
                if (re.Read())
                {
                    tk = re["loai"].ToString();
                }
                return tk;

            }

        }
        public string thongke(string sql)
        {
            Ketnoicsdl();
            SqlCommand cmd = new SqlCommand(sql, conn);
            object result = cmd.ExecuteScalar(); 
            Ngatketnoi(); 

            return result.ToString(); 
        }



    }
}
