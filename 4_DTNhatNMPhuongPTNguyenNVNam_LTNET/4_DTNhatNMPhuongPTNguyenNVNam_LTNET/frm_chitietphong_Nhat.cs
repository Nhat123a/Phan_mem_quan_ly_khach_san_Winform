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
    public partial class frm_chitietphong_Nhat : Form
    {
        Ketnoi cnn = new Ketnoi();
        public string TenPhong { get; set; }
        public string MaHD { get; set; }
        public string Ngathue { get; set; }
        public string KH { get; set; }
        public string nhanvien { get; set; }
        public frm_chitietphong_Nhat()
        {
            InitializeComponent();
        }

        private void frm_chitietphong_Nhat_Load(object sender, EventArgs e)
        {
            txt_trangchu_Nhat.Text = TenPhong;
            txt_HD_Nhat.Text = "Mã hóa đơn: " + MaHD;
            txt_ngaythue.Text = "Ngày thuê: " + DateTime.Parse(Ngathue).ToString("dd/MM/yyyy");

            txt_nhanvien.Text = "Nhân viên: " + nhanvien;
            txt_kh.Text = "Khách Hàng: " + KH;

            //bảng dịch vụ 
            string sql2 = "SELECT HDchitiet.MaHD,Dichvu.tenDv,HDchitiet.dongia,HDchitiet.soluong From HDchitiet INNER JOIN Dichvu ON HDchitiet.Madv=Dichvu.MaDv " +
                "Where HDchitiet.MaHD='" + MaHD + "' ";

            cnn.HienthiDL(sql2);
            dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql2);
            dtgrv_dv_Nhat.Columns[0].HeaderText = "Mã HD";
            dtgrv_dv_Nhat.Columns[0].Width = 120;
            dtgrv_dv_Nhat.Columns[1].HeaderText = "Mã DV";
            dtgrv_dv_Nhat.Columns[1].Width = 220;
            dtgrv_dv_Nhat.Columns[2].HeaderText = "Đơn giá";
            dtgrv_dv_Nhat.Columns[3].HeaderText = "Số lượng";
            dtgrv_dv_Nhat.RowTemplate.Height = 40;
            dtgrv_dv_Nhat.Columns[2].DefaultCellStyle.Format = "###,###";
        }

        private void txt_close_nhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
