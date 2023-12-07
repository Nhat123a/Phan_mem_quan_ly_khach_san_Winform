using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_thongtin_Nhat : Form
    {
        Ketnoi cnn = new Ketnoi();
        private string user;
        public frm_thongtin_Nhat(string user)
        {
            InitializeComponent();
            this.user = user;
        }
        public void Thongtin()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("SELECT matkhau,MaNV,hoTen,gioitinh,ngaysinh,loai,img FROM Nhavien WHERE taikhoan ='" + user + "'", cnn.conn);

            SqlDataReader da = cd.ExecuteReader();

            if (da.Read())
            {
                txt_id.Text = da["MaNV"].ToString();
                txt_gioitinh.Text = da["gioitinh"].ToString();
                txt_hoten.Text = da["hoTen"].ToString();
                txt_ngaysinh.Text = da["ngaysinh"].ToString();
                txt_chucvu.Text= da["loai"].ToString();
                bt = da["img"].ToString();
                
            }

            da.Close();
        }
        private void frm_thongtin_Nhat_Load(object sender, EventArgs e)
        {
            Thongtin();
            if (!string.IsNullOrEmpty(bt))
            {
                pic_img.Image = ByteToImg(bt);
            }

        }

        private void txt_close_nhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Đổi ảnh
        string a = " ";
        public  string bt = " ";
        byte[] converImgToByte()// ép kiểu sang byte
        {
            FileStream fs;
            fs = new FileStream(a, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        Image ByteToImg(string byteString)
        {
            if (!string.IsNullOrEmpty(byteString))
            {
                try
                {
                    byte[] imgBytes = Convert.FromBase64String(byteString);
                    using (MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length))
                    {
                        ms.Write(imgBytes, 0, imgBytes.Length);
                        Image image = Image.FromStream(ms, true);
                        return image;
                    }
                }
                catch (Exception ex)
                {
                    // Handle any exceptions or log them for debugging
                    MessageBox.Show("An error occurred while converting the image: " + ex.Message);
                }
            }

            return null; 
        }


        private void btn_capnhat_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                opf.Multiselect = true;
                if (opf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    a = opf.FileName;
                    bt = Convert.ToBase64String(converImgToByte());
                    pic_img.Image = ByteToImg(bt);
                }
                string sqlDoiAvatar = "UPDATE Nhavien SET img = '" + bt + "' WHERE MaNV = '" + txt_id.Text + "'";
                cnn.ThucthiDL(sqlDoiAvatar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi roi"+ex);
            }
        }
        public string GetAvatarImageData()
        {
            return bt;
        }
    }
}
