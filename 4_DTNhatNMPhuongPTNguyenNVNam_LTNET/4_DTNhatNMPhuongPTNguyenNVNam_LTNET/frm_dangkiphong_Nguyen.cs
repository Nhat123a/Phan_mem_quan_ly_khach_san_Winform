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
    public partial class frm_dangkiphong_Nguyen : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_dangkiphong_Nguyen()
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
        private void txt_close_nhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Lấy mã khách hàng
        private void maKH()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("select Makh, tenKH from Khachhang", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();

            

            while (da.Read())
            {
                txt_maKH_Nguyen.Items.Add(da["tenKH"].ToString());
                txt_maKH_Nguyen.DisplayMember = (da["tenKH"].ToString());
            }

            

            da.Close();
        }
        //Lấy ra tên nhân viên
        private void maNV()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("select MaNV, hoTen from Nhavien", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();
            while (da.Read())
            {
                txt_maNV_Nguyen.Items.Add(da["hoTen"].ToString());
                txt_maNV_Nguyen.DisplayMember = (da["hoTen"].ToString());
            }

            

            da.Close();
        }
        //Lấy ra tên nhân viên
        private void maPhong()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("SELECT Phong.Maphong, Phong.tenphong, Loaiphong.gia1ngay, Loaiphong.tenloaiphong FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai where tinhtrang =0", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();

            while (da.Read())
            {
                txt_maphong_Nguyen.Items.Add(da["tenphong"].ToString());
                txt_gia.Text = da["gia1ngay"].ToString();
                
            }
            
            da.Close();
        }
        private void frm_dangkiphong_Nguyen_Load(object sender, EventArgs e)
        {
            txt_gia.BackColor = Color.White;
            txt_gia.Text = "0";
            maPhong();
            maNV();
            maKH();
            string sql = "SELECT  Phong.tenphong, Loaiphong.gia1ngay, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai";
            cnn.HienthiDL(sql);
            dtgrv_locphong_Nhat.DataSource = cnn.HienthiDL(sql);
            
            dtgrv_locphong_Nhat.Columns[0].HeaderText = "Tên phòng";
            
            dtgrv_locphong_Nhat.Columns[1].HeaderText = "Giá";
            dtgrv_locphong_Nhat.Columns[2].HeaderText = "Loại Phòng";
            dtgrv_locphong_Nhat.Columns[3].HeaderText = "Trạng Thái";
            dtgrv_locphong_Nhat.RowTemplate.Height = 30;
            txt_gia.Enabled = false;
            dtgrv_locphong_Nhat.Columns[1].DefaultCellStyle.Format = "###,###";
        }

        private void btn_tim_Nhat_Click(object sender, EventArgs e)
        {
            string sql;
            if (rd_phongtrong_Nhat.Checked)
            {
                sql = "SELECT Phong.tenphong,Loaiphong.gia1ngay, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai where tinhtrang =0";
                dtgrv_locphong_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_conguoi_Nguyen.Checked)
            {
                sql = "SELECT  Phong.tenphong,Loaiphong.gia1ngay, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai where tinhtrang =1";
                dtgrv_locphong_Nhat.DataSource = cnn.HienthiDL(sql);
            }
        }
        //Sinh mã tự động
        public void tangma()
        {
            DataTable dt = cnn.HienthiDL("SELECT * From Hoadon");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "HD00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã khách đã có
                h = "HD";//ký tự mặc định của mã khách
                k = Convert.ToInt32(dt.Rows[dt.Rows.Count - 1][0].ToString().Substring(2, 5));
                k = k + 1;
                if (k < 10)

                    h = h + "0000";
                else if (k < 100)
                    h = h + "000";
                else if (k < 1000)
                    h = h + "00";
                else if (k < 10000)
                    h = h + "0";
                h = h + k.ToString();

            }
            txt_maHD_Nguyen.Text = h;

        }
        private void rd_phongtrong_Nhat_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_maHD_Nguyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tangma();
            }
        }

        private void btn_thoat_Nguyen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_maHD_Nguyen.Text) || string.IsNullOrEmpty(txt_maKH_Nguyen.Text) || string.IsNullOrEmpty(txt_maNV_Nguyen.Text))
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    // Lấy mã loại phòng từ tên loại phòng được chọn
                    string sql1 = "SELECT Maphong FROM Phong WHERE tenphong = N'" + txt_maphong_Nguyen.Text + "'";
                    SqlCommand cmdGetMaLoai = new SqlCommand(sql1, cnn.conn);
                    string maPhong = cmdGetMaLoai.ExecuteScalar().ToString();

                    // Lấy mã loại phòng từ tên loại phòng được chọn
                    string sql2 = "SELECT Makh FROM Khachhang WHERE tenKH = N'" + txt_maKH_Nguyen.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(sql2, cnn.conn);
                    string maKH = cmd2.ExecuteScalar().ToString();
                    // Lấy mã loại phòng từ tên loại phòng được chọn
                    string sql3 = "SELECT MaNV FROM Nhavien WHERE hoTen = N'" + txt_maNV_Nguyen.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(sql3, cnn.conn);
                    string maNV = cmd3.ExecuteScalar().ToString();

                    string sql = "Insert into Hoadon(MaHD,MaKH,maNV,giaphong1ngay,maphong,ngaythue,thanhtoan) values('" + txt_maHD_Nguyen.Text + "','" + maKH + "','" + maNV + "','" + txt_gia.Text + "','" + maPhong + "','" + txt_ngaythue_Nguyen.Value + "',0)";
                    cnn.ThucthiDL(sql);
                    string sql5 = "Update Phong Set tinhtrang=1 where Maphong='" + maPhong + "'";
                    cnn.ThucthiDL(sql5);
                    Toast_thancong("Success!", "Thuê thành công");
                    lammoi();
                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Đang lỗi rồi");
            }

        }

        public void lammoi()
        {
            txt_maKH_Nguyen.Text = "";
            txt_maNV_Nguyen.Text = "";
            txt_maHD_Nguyen.Text = "";
            txt_gia.Text = "";
            txt_maphong_Nguyen.Text = "";
            txt_maHD_Nguyen.Focus();

        }
        private void txt_maphong_Nguyen_onItemSelected(object sender, EventArgs e)
        {

        }
        //Khi chọn combobox sẽ láy dc giá 1 ngày 
        private void txt_maphong_Nguyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (txt_maphong_Nguyen.SelectedItem != null)
            {
                string selectedPhong = txt_maphong_Nguyen.SelectedItem.ToString();

               
                cnn.Ketnoicsdl();
                SqlCommand cd = new SqlCommand("SELECT Loaiphong.gia1ngay FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai WHERE Phong.tenphong = @tenphong", cnn.conn);
                cd.Parameters.AddWithValue("@tenphong", selectedPhong);

                SqlDataReader da = cd.ExecuteReader();
               
                if (da.Read())
                {
                    txt_gia.Text = da["gia1ngay"].ToString();
                }

                da.Close();
            }
        }

        private void txt_maKH_Nguyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("select Makh,CMT,dienthoai,tenKH from Khachhang where tenKH=N'"+txt_maKH_Nguyen.Text+"' ", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();
            while (da.Read())
            {
                int dienthoaiNumber = Convert.ToInt32(da["dienthoai"]); 
                string dienthoai = dienthoaiNumber.ToString("D10");
                txt_dienthoai_Nhat.Text = dienthoai;
                string cmt = da["CMT"].ToString();
                txt_socm_Nguyen.Text = cmt;
            }
            da.Close();
        }
    }
}
