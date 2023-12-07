using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_chitiet_Nhat : Form
    {
        Ketnoi cnn = new Ketnoi();
        private string maHD;
        private string Hoten;
        private string Nhanvien;
        private DateTime ngaythue;
        private DateTime ngaytra;
        private float thanhtien;
        public frm_chitiet_Nhat(string maHD,string Hoten,string nhanvien,DateTime ngaythue,DateTime ngaytra, float thanhtien)
        {
            InitializeComponent();
            this.maHD = maHD;
            this.Hoten = Hoten;
            this.Nhanvien = nhanvien;
            this.ngaythue = ngaythue;
            this.ngaytra = ngaytra;
            this.thanhtien = thanhtien;
        }

        private void frm_chitiet_Nhat_Load(object sender, EventArgs e)
        {
            string sql = "SELECT HDchitiet.MaHD,Dichvu.tenDv,HDchitiet.dongia,HDchitiet.soluong " +
                "from HDchitiet INNER JOIN  Dichvu ON HDchitiet.Madv=Dichvu.MaDv where HDchitiet.MaHD ='"+maHD+"'";
            cnn.HienthiDL(sql);
            dtgrv_chitiet_Nguyen.DataSource = cnn.HienthiDL(sql);

            dtgrv_chitiet_Nguyen.Columns[0].HeaderText = "Mã hóa đơn";

            dtgrv_chitiet_Nguyen.Columns[1].HeaderText = "Tên dịch vụ";
            dtgrv_chitiet_Nguyen.Columns[2].HeaderText = "Đơn giá";
            dtgrv_chitiet_Nguyen.Columns[3].HeaderText = "Số lượng";
            dtgrv_chitiet_Nguyen.RowTemplate.Height = 30;
            txt_HD_Nhat.Text = "Mã hóa đơn: " + maHD;
            txt_kh.Text = "Khách Hàng: " + Hoten;
            txt_nhanvien.Text = "Nhân viên: " + Nhanvien;
            txt_ngaythue.Text = "Ngày thuê phòng: " + ngaythue.ToString("dd/MM/yyyy");
            txt_ngaytra.Text = "Ngày trả phòng: " + ngaytra.ToString("dd/MM/yyyy");
            txt_thanhtien.Text = "Thành tiền: " + thanhtien.ToString("N0")+"VND";
        }

        private void txt_close_nhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
