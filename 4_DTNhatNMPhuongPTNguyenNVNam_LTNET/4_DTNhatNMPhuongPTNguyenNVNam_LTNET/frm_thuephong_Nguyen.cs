using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_thuephong_Nguyen : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_thuephong_Nguyen()
        {
            InitializeComponent();
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {

        }
        private void hienthiphong()
        {
            // Lấy danh sách phòng từ cơ sở dữ liệu
            List<string[]> danhSachPhong = Laydanhsachphong();

            // Tạo động các button tương ứng
            int posX = 10;
            int posY = 10;
            int row = 0;
            foreach (string[] phong in danhSachPhong)
            {
                BunifuTileButton btnPhong = new BunifuTileButton();
                btnPhong.LabelText = phong[0];
                btnPhong.Font = new Font("Tahoma", 10, FontStyle.Regular);
                btnPhong.ForeColor = Color.FromArgb(221, 221, 221);
                btnPhong.Top = posY + row * btnPhong.Height;
                btnPhong.Image = Image.FromFile(@"C:\Users\ACE\OneDrive\Desktop\Tài liệu bài tập .net\4_DTNhatNMPhuongPTNguyenNVNam_LTNET\4_DTNhatNMPhuongPTNguyenNVNam_LTNET\Image\bed.png");
                btnPhong.Left = posX;
                btnPhong.Size = new Size(121, 118);
                posX += btnPhong.Width + 10;

                // Nếu nút hiện tại vượt quá chiều rộng của panel 1, thì xuống dòng.
                if (posX + btnPhong.Width > panel1.Width)
                {
                    posX = 10;
                    posY = 60;
                    row++;
                }
                panel1.Controls.Add(btnPhong);

                // Kiểm tra trạng thái phòng
                if (phong[1].Equals("True", StringComparison.OrdinalIgnoreCase))
                {
                    // Thay đổi background thành màu đỏ
                    btnPhong.BackColor = Color.Red;
                    btnPhong.colorActive = Color.Red;
                    btnPhong.color = Color.Red;

                    
                }
                //Sự kiện khi ckick vào butoon
                btnPhong.Click += (sender, e) =>
                {
                    cnn.Ketnoicsdl();
                    string sql1 = "SELECT Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen,Hoadon.giaphong1ngay, Phong.tenphong,Hoadon.ngaythue,Hoadon.ngaytra,Hoadon.thanhtien," +
                      "CASE WHEN Hoadon.thanhtoan = 1 THEN N'Đã thanh Toán' ELSE N'Chưa thanh toán' END AS thanhtien " +
                      "FROM Hoadon " +
                      "INNER JOIN Khachhang ON Hoadon.MaKH = Khachhang.Makh " +
                      "INNER JOIN Nhavien ON Hoadon.maNV = Nhavien.MaNV " +
                      "INNER JOIN Phong ON Hoadon.maphong = Phong.Maphong  where Hoadon.thanhtoan = 0 AND Phong.tenphong='" + btnPhong.LabelText+"'";
                    SqlCommand cd = new SqlCommand(sql1, cnn.conn);;
                    SqlDataReader da = cd.ExecuteReader();
                    if (da.Read())
                    {
                        string tenphong=da["tenphong"].ToString();
                        string hoadon = da["MaHD"].ToString();
                        string ngaythue = da["ngaythue"].ToString();
                        string nhanvien = da["hoTen"].ToString();
                        string kh = da["TenKH"].ToString();
                        frm_chitietphong_Nhat roomDetailsForm = new frm_chitietphong_Nhat();
                        roomDetailsForm.TenPhong = tenphong;
                        roomDetailsForm.MaHD = hoadon;
                        roomDetailsForm.Ngathue = ngaythue;
                        roomDetailsForm.KH = kh;
                        roomDetailsForm.nhanvien = nhanvien;
                        roomDetailsForm.Show();
                    }
                    da.Close();
                    
                };

            }
        }

        private List<string[]> Laydanhsachphong()
        {
            List<string[]> danhSachPhong = new List<string[]>();

            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("select tenphong,tinhtrang from Phong", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();
            while (da.Read())
            {
                danhSachPhong.Add(new string[] { da["tenphong"].ToString(), da["tinhtrang"].ToString() });
            }
            da.Close();

            return danhSachPhong;
        }


        private void frm_thuephong_Nguyen_Load_1(object sender, EventArgs e)
        {
            hienthiphong();
            string sql = "SELECT MaHD, MaKH, maNV, giaphong1ngay, maphong, ngaythue, CASE WHEN thanhtoan = 1 THEN N'Đã thanh Toán' ELSE N'Chưa thanh toán' END AS thanhtien FROM Hoadon WHERE thanhtoan = 0";
            cnn.HienthiDL(sql);
            dtgrv_hoadon_Nhat.DataSource = cnn.HienthiDL(sql);

            dtgrv_hoadon_Nhat.Columns[0].HeaderText = "Mã hóa đơn";

            dtgrv_hoadon_Nhat.Columns[1].HeaderText = "Mã khách";
            dtgrv_hoadon_Nhat.Columns[2].HeaderText = "Mã nhân viên";
            dtgrv_hoadon_Nhat.Columns[3].HeaderText = "Giá phòng";
            dtgrv_hoadon_Nhat.Columns[4].HeaderText = "Mã phòng";
            dtgrv_hoadon_Nhat.Columns[5].HeaderText = "Ngày thuê";
            dtgrv_hoadon_Nhat.Columns[6].HeaderText = "Trạng thái";
            dtgrv_hoadon_Nhat.RowTemplate.Height = 30;
        }

        private void btn_thuephong_Nhat_Click(object sender, EventArgs e)
        {
            frm_dangkiphong_Nguyen frm = new frm_dangkiphong_Nguyen();
            frm.ShowDialog();
        }

        private void dtgrv_hoadon_Nhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_dichvu_Nhat_Click(object sender, EventArgs e)
        {
            frm_dichvuthem_Nguyen frm = new frm_dichvuthem_Nguyen();
            frm.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
