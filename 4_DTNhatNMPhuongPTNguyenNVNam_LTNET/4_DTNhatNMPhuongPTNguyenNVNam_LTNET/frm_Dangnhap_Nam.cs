using FontAwesome.Sharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_Dangnhap_Nam : Form
    {
        Ketnoi cnn = new Ketnoi();
        private string user = ""; 
        private string pass = "";
        public frm_Dangnhap_Nam()
        {
            InitializeComponent();

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

        private void btn_dangnhap_Nam_Click(object sender, EventArgs e)
        {
            string user = txt_user_Nam.Text.Trim();
            string pass = txt_pass_Nam.Text.Trim();
            if (user == "" || pass == "")
            {
                showToast("Error !", "Thiếu thông tin rồi");
                txt_user_Nam.Focus();
            }
            else
            {
                string mk = MahoaMD(pass);
                string sql = "select loai from Nhavien where taikhoan = N'" + user + "' and matkhau =N'" + mk + "'";
                string Type = cnn.LayMotGiaTri(sql);
                if (Type == "")
                {
                    showToast("Error !","Vui lòng thử lại");
                }
                else
                {
                    this.Hide();
                    frm_Trangchu_Nam frm = new frm_Trangchu_Nam(Type,user);
                    frm.Show();
                }

            }
        }
        private void showToast(string title,string message)
        {
            frm_succes_nhat frm = new frm_succes_nhat(title,message);
            frm.Show();
        }


        private void frm_Dangnhap_Nam_Load(object sender, EventArgs e)
        {
            lb_phanmem_phuong.BackColor = Color.Transparent;
            lb_ql_Phuong.BackColor = Color.Transparent;
            pictureBox1.BackColor = Color.Transparent;
            lb_nhom_Phuong.BackColor = Color.Transparent;
            txt_pass_Nam.isPassword = true;
            btn_close_Nguyen.BackColor = Color.Transparent;
        }

        private void btn_close_Nguyen_Click(object sender, EventArgs e)
        {
            this.Close();

            frm_gioithieu_Nguyen frm = new frm_gioithieu_Nguyen();
            frm.Show();
        }

        private void txt_pass_Nam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                if (txt_pass_Nam.Text.Trim() == "")
                    showToast("Error !", "Không được để trống");
                else
                    btn_dangnhap_Nam.Focus();
        }

        private void txt_user_Nam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txt_user_Nam.Text.Trim() == "")

                    showToast("Error !", "Không được để trống");
                else
                    txt_pass_Nam.Focus();
            }
            else if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private void txt_pass_Nam_OnValueChanged(object sender, EventArgs e)
        {
            txt_pass_Nam.isPassword = true;
        }

        private void pain_login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_user_Nam_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
