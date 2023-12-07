using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_doimatkhau_Nhat : Form
    {
        public static string MaNhanVien, MatKhau;
        Ketnoi cnn = new Ketnoi();
        private string user;
        public frm_doimatkhau_Nhat(string user)
        {
            
            InitializeComponent();
            this.user = user;
        }

        private void txt_close_nhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void frm_doimatkhau_Nhat_Load(object sender, EventArgs e)
        {
            btn_taikhoan.Text = user;
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            txt_matkhaucu.isPassword = true;
        }

        private void txt_pass_Nam_OnValueChanged(object sender, EventArgs e)
        {
            txt_matkhaumoi.isPassword = true;
        }
        private string MahoaMD(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }

        private void Toast_thancong(string title, string message)
        {
            frm_thanhcong_Nhat frm = new frm_thanhcong_Nhat(title, message);
            frm.Show();
        }
        private void Toast_loi(string title, string message)
        {
            frm_succes_nhat frm = new frm_succes_nhat(title, message);
            frm.Show();
        }
        public void doipass()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("SELECT matkhau,MaNV FROM Nhavien WHERE taikhoan ='" + user + "'", cnn.conn);

            SqlDataReader da = cd.ExecuteReader();

            if (da.Read())
            {
                MatKhau = da["matkhau"].ToString();
                MaNhanVien = da["MaNV"].ToString();
            }

            da.Close();

        }
        private void btn_capnhat_Nhat_Click(object sender, EventArgs e)
        {
            if (txt_matkhaucu.Text == "" || txt_matkhaumoi.Text == "")
            {
                Toast_loi("Error!", "Chưa điền thông tin");

            }
            else
            {
                doipass();
                string matkhaucu = txt_matkhaucu.Text;
                string mahoamkcu = MahoaMD(matkhaucu);

                // Mới
                string matkhau = txt_matkhaumoi.Text;
                string mahoamk = MahoaMD(matkhau);

                if (mahoamkcu == MatKhau)
                {
                    string sqlDoiMatKhau = "UPDATE Nhavien SET matkhau = '" + mahoamk + "' where MaNV = '" + MaNhanVien + "'";
                    cnn.ThucthiDL(sqlDoiMatKhau);
                    Toast_thancong("Success!", "Đổi mật khẩu thành công");

                    // Update MatKhau variable after changing the password in the database
                    MatKhau = mahoamk; // Update with the new hashed password
                }
                else if (mahoamkcu != MatKhau)
                {
                    Toast_loi("Error!", "Mật khẩu không khớp");
                }
            }
        }
    }
}
