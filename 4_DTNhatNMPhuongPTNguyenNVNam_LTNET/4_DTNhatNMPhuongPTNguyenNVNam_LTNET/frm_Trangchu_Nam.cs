using FontAwesome.Sharp;
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
    public partial class frm_Trangchu_Nam : Form
    {
        Ketnoi cnn = new Ketnoi();
        public string loai;
        public string user;
        private string bit;
        private IconButton currentBtn;
        private frm_thongtin_Nhat thongtin;
        private DateTime startTime;
        public frm_Trangchu_Nam(string type ,string user)
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.user = user;
            loai = type;
            thongtin = new frm_thongtin_Nhat(user);
        }
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 0, 0);
            
        }
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(48, 129, 208);
                currentBtn.ForeColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;


            }
        }
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(22, 72, 99);
                currentBtn.ForeColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        //Thông báo
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
        public Image ByteToImg(string byteString)
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
        public void Thongtin()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("SELECT matkhau,MaNV,hoTen,gioitinh,ngaysinh,loai,img FROM Nhavien WHERE taikhoan ='" + user + "'", cnn.conn);

            SqlDataReader da = cd.ExecuteReader();

            if (da.Read())
            {

                bit = da["img"].ToString();

            }
            da.Close();
        }

        private Form currentformChild;
        private void openChildform(Form childForm)
        {

            if (currentformChild != null)
            {
                currentformChild.Close();
            }

            currentformChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pain_Main_Nhat.Controls.Add(childForm);
            pain_Main_Nhat.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }

        public void load_card()
        {
            string sql = "SELECT COUNT(*) FROM Hoadon";
            string hoadon = cnn.thongke(sql);
            txt_Hoadon_Nguyen.Text = hoadon;

            //Khách hàng
            string sql1 = "SELECT COUNT(*) FROM Khachhang";
            string kh = cnn.thongke(sql1);
            txt_Kh_Nguyen.Text = kh;
            //Nhân viên

            string sql2 = "SELECT COUNT(*) FROM Nhavien";
            string nv = cnn.thongke(sql2);
            txt_Nhanvien_Nam.Text = nv;
            //Phòng
            string sql3 = "SELECT COUNT(*) FROM Phong";
            string p = cnn.thongke(sql3);
            txt_Phong_Nam.Text = p;
            //Phòng
            string sql4 = "SELECT COUNT(*) FROM Loaiphong";
            string lp = cnn.thongke(sql4);
            txt_loaiphong.Text = lp;

            //Doanh thu 
            // Doanh thu
            string sql5 = "SELECT ISNULL(SUM(thanhtien), 0) FROM Hoadon";
            string doanhthu = cnn.thongke(sql5);
            if (!string.IsNullOrEmpty(doanhthu))
            {
                if (decimal.TryParse(doanhthu, out decimal doanhThuDecimal))
                {
                    // Hiển thị doanh thu trong TextBox với định dạng số ngàn
                    txt_doanhthu_Nhất.Text = doanhThuDecimal.ToString("N0");
                }
                else
                {
                    Toast_loi("Error!", "Lỗi khi chuyển");
                }
            }
            else
            {
                Toast_loi("Error!", "Chưa cóa dữ liệu");
            }
        }
        private void frm_Trangchu_Nam_Load(object sender, EventArgs e)
        {
            //Load card
            load_card();
            Thongtin();
            if (!string.IsNullOrEmpty(bit))
            {
                pictureBox2.Image = ByteToImg(bit);
            }

            pain_logout.Visible = false;
            pain_phong_Phuong.Height = 83;
            if(loai== "Nhân Viên")
            {
                btn_Hoadon_Nhat.Visible = false;
                btn_trangchu.Visible = false;
                btn_dichvu_Nhat.Visible = false;
                btn_phong_Nam.Visible = false;
                txt_chao_Nhat.Text = "Xin chào,"+user;
                btn_loaiphong_Phuong.Visible = false;

            }
            if(loai== "Quan Ly")
            {
                txt_chao_Nhat.Text = "Xin chào," + user;
            }
            btn_thongke_Nhat.Height = 83;
            
            time_hs.Start();
            startTime = DateTime.Now;
        }

        private void txt_close_nhat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pain_Main_Nhat_Paint(object sender, PaintEventArgs e)
        {
            load_card();
        }
        //Trang chủ
        private void btn_khachhang_Nhat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            if (currentformChild != null)
            {
                currentformChild.Close();
            }
            txt_trangchu_Nhat.Text = "Trang chủ";

        }
        //Khách hàng
        private void btn_Nhavien_Nhat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildform(new frm_quanlikhachhang_Nhat());
            txt_trangchu_Nhat.Text = "Khách hàng";
        }

        private void btn_thuephong_Nhat_Click(object sender, EventArgs e)
        {

        }
        private void ActivateButtonthue(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButtonthue();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(48, 129, 208);
                currentBtn.ForeColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                

            }
        }
        private void DisableButtonthue()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(22, 72, 99);
                currentBtn.ForeColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.FromArgb(250, 231, 201);
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
        private void btn_thuephong_Nhat_Click_1(object sender, EventArgs e)
        {
           


            if (pain_phong_Phuong.Height == 404)
            {
                pain_phong_Phuong.Height = 83;
            }
            else
            {
                ActivateButtonthue(sender, RGBColors.color1);
                pain_phong_Phuong.Height = 404;
            }
        }

        private void btn_dichvu_Nhat_Click(object sender, EventArgs e)
        {
            
            openChildform(new frm_quanlidichvu_Nhat());
            txt_trangchu_Nhat.Text = "Dịch vụ";
        }

        private void btn_thuephong_Nguyen_Click(object sender, EventArgs e)
        {
            openChildform(new frm_thuephong_Nguyen());
            txt_trangchu_Nhat.Text = "Quản lý thuê phòng ";
        }

        private void btn_phong_Nam_Click(object sender, EventArgs e)
        {
            openChildform(new frm_quanliphong_Nguyen());
            txt_trangchu_Nhat.Text = "Phòng ";
        }
        //Hóa đơn
        private void btn_thongke_Nhat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            openChildform(new frm_HoaDon_Nguyen());
            txt_trangchu_Nhat.Text = "Quản lý hóa đơn";
        }

       

        private void btn_traphong_Phuong_Click(object sender, EventArgs e)
        {
            openChildform(new frm_traPhong_Nguyen());
            txt_trangchu_Nhat.Text = "Quản lí Trả Phòng";
        }

        private void btn_loaiphong_Phuong_Click(object sender, EventArgs e)
        {
            openChildform(new frm_loaiphong_Nam());
            txt_trangchu_Nhat.Text = "Quản lí loại phòng";
        }

        private void pain_topnav_Nhat_Paint(object sender, PaintEventArgs e)
        {
            if (!string.IsNullOrEmpty(bit))
            {
                pictureBox2.Image = ByteToImg(bit);
            }
        }
        //Nhân viên
        private void btn_Hoadon_Nhat_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);

            openChildform(new frm_quanlinhanvien_Phuong());
            txt_trangchu_Nhat.Text = "Nhân Viên";
        }

      

        private void btn_bar_Nhat_Click(object sender, EventArgs e)
        {

            if (pain_logout.Visible == false)
            {
                pain_logout.Visible = true;
            }
            else
            {
                pain_logout.Visible = false;
            }
        }
        //Thống kê
        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            openChildform(new frm_Thongke_Phuong());
            txt_trangchu_Nhat.Text = "Báo cáo và thống kê";
        }

        private void btn_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                // Đóng cửa sổ hiện tại
                this.Close();

                // Mở cửa sổ đăng nhập
                frm_Dangnhap_Nam frm = new frm_Dangnhap_Nam();
                frm.Show();
                
            }
        }

        private void btn_changepass_Click(object sender, EventArgs e)
        {
            frm_doimatkhau_Nhat frm = new frm_doimatkhau_Nhat(user);
            frm.Show();
            pain_logout.Visible = false;
        }
        
        private void btn_ìno_Click(object sender, EventArgs e)
        {
            frm_thongtin_Nhat frm = new frm_thongtin_Nhat(user);
            frm.Show();
            pain_logout.Visible = false;
        }

        private void time_hs_Tick(object sender, EventArgs e)
        {
            txt_time.Text =DateTime.Now.ToString("hh:mm:ss");
            TimeSpan elapsedTime = DateTime.Now - startTime;
            txt_tg_sd.Text = "Thời gian truy cập: " + elapsedTime.ToString(@"hh\:mm\:ss");

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_doanhthu_Nhat_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pain_top_Nhat_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.BackColor = Color.Transparent;
        }

        private void txt_time_Click(object sender, EventArgs e)
        {

        }
    }
}
