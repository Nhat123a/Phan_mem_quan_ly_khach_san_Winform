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
    public partial class frm_traPhong_Nguyen : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_traPhong_Nguyen()
        {
            InitializeComponent();
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
        private void maHD()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("SELECT MaHD From Hoadon where thanhtoan = 0", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();

            while (da.Read())
            {
                txt_maHD_Phuong.Items.Add(da["MaHD"].ToString());
            }


            da.Close();
        }
        private void frm_traPhong_Nguyen_Load(object sender, EventArgs e)
        {
            btn_hoadon_Nhat.Enabled = false;
            btn_thanhtoan.Enabled = false;
            maHD();
            txt_soNgay_Nguyen.Enabled=false;
            txt_soNgay_Nguyen.BackColor = Color.White;
            txt_tienThue_nam.Enabled = false;
            txt_tienThue_nam.BackColor = Color.White;
            txt_tienDV_nam.Enabled = false;
            txt_tienDV_nam.BackColor = Color.White;
            txt_thanhtien_Nguyen.Enabled = false;
            txt_thanhtien_Nguyen.BackColor = Color.White;

        }

        private void txt_maHD_Nguyen_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_maHD_Phuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_soNgay_Nguyen.Text = "";
            TongtienDV();
            //Bảng Hóa đơn
            string sql1 = "SELECT Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen, Phong.tenphong, " +
              "CASE WHEN Hoadon.thanhtoan = 1 THEN N'Đã thanh Toán' ELSE N'Chưa thanh toán' END AS thanhtien " +
              "FROM Hoadon " +
              "INNER JOIN Khachhang ON Hoadon.MaKH = Khachhang.Makh " +
              "INNER JOIN Nhavien ON Hoadon.maNV = Nhavien.MaNV " +
              "INNER JOIN Phong ON Hoadon.maphong = Phong.Maphong " +
              "WHERE Hoadon.MaHD='" + txt_maHD_Phuong.Text + "' AND Hoadon.thanhtoan = 0";

            cnn.HienthiDL(sql1);
            dtgrv_HD_Nhat.DataSource = cnn.HienthiDL(sql1);
            dtgrv_HD_Nhat.Columns[0].HeaderText = "Mã HD";
            dtgrv_HD_Nhat.Columns[0].Width = 120;
            dtgrv_HD_Nhat.Columns[1].HeaderText = "Mã KH";
            dtgrv_HD_Nhat.Columns[1].Width = 220;
            dtgrv_HD_Nhat.Columns[2].HeaderText = "Mã NV";
            dtgrv_HD_Nhat.Columns[2].Width = 220;
            dtgrv_HD_Nhat.Columns[3].HeaderText = "Mã Phòng";
            dtgrv_HD_Nhat.Columns[4].HeaderText = "Thanh toán";
            dtgrv_HD_Nhat.RowTemplate.Height = 30;

            //bảng dịch vụ 
            string sql2 = "SELECT HDchitiet.MaHD,Dichvu.tenDv,HDchitiet.dongia,HDchitiet.soluong From HDchitiet INNER JOIN Dichvu ON HDchitiet.Madv=Dichvu.MaDv " +
                "Where HDchitiet.MaHD='" + txt_maHD_Phuong.Text + "' ";

            cnn.HienthiDL(sql2);
            dtgrv_dichvu_Nhat.DataSource = cnn.HienthiDL(sql2);
            dtgrv_dichvu_Nhat.Columns[0].HeaderText = "Mã HD";
            dtgrv_dichvu_Nhat.Columns[0].Width = 120;
            dtgrv_dichvu_Nhat.Columns[1].HeaderText = "Mã DV";
            dtgrv_dichvu_Nhat.Columns[1].Width = 220;
            dtgrv_dichvu_Nhat.Columns[2].HeaderText = "Đơn giá";
            dtgrv_dichvu_Nhat.Columns[3].HeaderText = "Số lượng";
            dtgrv_dichvu_Nhat.RowTemplate.Height = 40;
        }

        private void txt_ngaytra_nguyen_onValueChanged(object sender, EventArgs e)
        {
            if (txt_maHD_Phuong.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hóa đơn để thanh toán ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DateTime ngayTra = txt_ngaytra_nguyen.Value;
                DateTime ngayThue = DateTime.MinValue;

                string sql = "SELECT DATEDIFF(day, ngaythue, '" + ngayTra.ToString("yyyy-MM-dd") + "') + 1 AS TongSoNgayThue, ngaythue FROM Hoadon WHERE MaHD = '" + txt_maHD_Phuong.Text + "'";

                cnn.Ketnoicsdl();
                int tongSoNgayThue = 0;
                int giaphong = 0;

                SqlCommand cmd = new SqlCommand(sql, cnn.conn);
                SqlDataReader da = cmd.ExecuteReader();
                if (da.Read())
                {
                    tongSoNgayThue = Convert.ToInt32(da["TongSoNgayThue"]);
                    ngayThue = Convert.ToDateTime(da["ngaythue"]);
                    txt_soNgay_Nguyen.Text = tongSoNgayThue.ToString();
                }
                da.Close();

                if (ngayTra < ngayThue)
                {
                    MessageBox.Show("Ngày trả không thể nhỏ hơn ngày thuê", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt_ngaytra_nguyen.Value = ngayThue.AddDays(1);
                }
                else
                {
                    string sql1 = "SELECT giaphong1ngay FROM Hoadon WHERE MaHD = '" + txt_maHD_Phuong.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(sql1, cnn.conn);
                    SqlDataReader da1 = cmd1.ExecuteReader();
                    if (da1.Read())
                    {
                        giaphong = Convert.ToInt32(da1["giaphong1ngay"]);
                    }
                    da1.Close();

                    int tongtienphong = giaphong * tongSoNgayThue;
                    txt_tienThue_nam.Text = tongtienphong.ToString();
                }

                cnn.Ngatketnoi();
            }
        }

        private void btn_thanhtien_Click(object sender, EventArgs e)
        {
            
            if (txt_tienThue_nam.Text == "")
            {
                Toast_loi("Error!", "Thiếu thông tin thanh toán");
            }
            else
            {
                btn_thanhtoan.Enabled = true;
                int tienthue = int.Parse(txt_tienThue_nam.Text);
                int tiendv = int.Parse(txt_tienDV_nam.Text);
                int thanhtien = tiendv + tienthue;
                txt_thanhtien_Nguyen.Text = thanhtien.ToString("N0");
            }
        }
        //hàm tính tổng tiền dịch vụ
        public void TongtienDV()
        {
            try
            {
                cnn.Ketnoicsdl();

                string sql = "SELECT MaHD, SUM(soluong * dongia) AS TongTienDichVu " +
                             "FROM HDchitiet " + // Thêm khoảng trắng sau tên bảng
                             "GROUP BY MaHD " +
                             "HAVING MaHD = '" + txt_maHD_Phuong.Text + "'";

                SqlCommand cmd = new SqlCommand(sql, cnn.conn);

                SqlDataReader da = cmd.ExecuteReader();
                int tongTienDichVu = 0;
                if (da.Read())
                {
                   tongTienDichVu = Convert.ToInt32(da["TongTienDichVu"]);
                    
                }
                txt_tienDV_nam.Text = tongTienDichVu.ToString();
                cnn.Ngatketnoi();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }

        private void btn_thanhtoan_Click(object sender, EventArgs e)
        {
            btn_hoadon_Nhat.Enabled = true;
            if (txt_thanhtien_Nguyen.Text == "")
            {
                Toast_loi("Error!", "Tính thành tiền đi ");
            }
            else
            {
                float thanhtien = float.Parse(txt_thanhtien_Nguyen.Text);
                string sql = "UPDATE Hoadon set ngaytra='" + txt_ngaytra_nguyen.Value.ToString("yyyy-MM-dd") + "'" +
                    ",thanhtien='"+thanhtien+ "',thanhtoan=1 where MaHD='"+txt_maHD_Phuong.Text+"'";
                cnn.ThucthiDL(sql);
                string sql2 = "Update Phong set tinhtrang=0 where Maphong = (SELECT maphong FROM Hoadon WHERE MaHD = '" + txt_maHD_Phuong.Text + "')";
                cnn.ThucthiDL(sql2);
                Toast_thancong("Success!", "Thanh toán thành công ");
            }
        }

        private void btn_hoadon_Nhat_Click(object sender, EventArgs e)
        {
            string maHD = txt_maHD_Phuong.Text;
            inhoadon(maHD);
        }
        public void inhoadon( string MaHD)
        {
            frm_inhoadon_Nhat frm = new frm_inhoadon_Nhat(MaHD);
            frm.ShowDialog();

        }
    }
}
