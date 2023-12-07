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
    public partial class frm_HoaDon_Nguyen : Form
    {
        Ketnoi cnn = new Ketnoi();
        
        public frm_HoaDon_Nguyen()
        {
            InitializeComponent();
            
        }
        private void XemChiTiet(string maHD,string Hoten,string nhanvien,DateTime ngaythue,DateTime ngaytra,float thanhtien)
        {
            frm_chitiet_Nhat formChiTiet = new frm_chitiet_Nhat(maHD,Hoten,nhanvien,ngaythue,ngaytra,thanhtien);
            formChiTiet.ShowDialog();
        }
        private void frm_HoaDon_Nguyen_Load(object sender, EventArgs e)
        {
            string sql1 = "SELECT Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen,Hoadon.giaphong1ngay, Phong.tenphong,Hoadon.ngaythue,Hoadon.ngaytra,Hoadon.thanhtien," +
              "CASE WHEN Hoadon.thanhtoan = 1 THEN N'Đã thanh Toán' ELSE N'Chưa thanh toán' END AS thanhtien " +
              "FROM Hoadon " +
              "INNER JOIN Khachhang ON Hoadon.MaKH = Khachhang.Makh " +
              "INNER JOIN Nhavien ON Hoadon.maNV = Nhavien.MaNV " +
              "INNER JOIN Phong ON Hoadon.maphong = Phong.Maphong where Hoadon.thanhtoan=1 ";
            cnn.HienthiDL(sql1);
            dtgv_Hoadon_Nhat.DataSource = cnn.HienthiDL(sql1);

            dtgv_Hoadon_Nhat.Columns[0].HeaderText = "Mã HD";

            dtgv_Hoadon_Nhat.Columns[1].HeaderText = "Khách hàng";
            dtgv_Hoadon_Nhat.Columns[1].Width = 190;
            dtgv_Hoadon_Nhat.Columns[2].HeaderText = "Nhân viên";
            dtgv_Hoadon_Nhat.Columns[2].Width = 190;
            dtgv_Hoadon_Nhat.Columns[3].HeaderText = "Giá phòng";
            dtgv_Hoadon_Nhat.Columns[4].HeaderText = "Mã phòng";
            dtgv_Hoadon_Nhat.Columns[5].HeaderText = "Ngày thuê";
            dtgv_Hoadon_Nhat.Columns[6].HeaderText = "Ngày trả";
            dtgv_Hoadon_Nhat.Columns[7].HeaderText = "Thành tiên";
            dtgv_Hoadon_Nhat.Columns[8].HeaderText = "Thanh toán";

            dtgv_Hoadon_Nhat.RowTemplate.Height = 30;
            btn_chitiet_Nhat.Enabled = false;
            btn_xoa_Nhat.Enabled = false;
        }

        private void btn_tim_Nhat_Click(object sender, EventArgs e)
        {
        
            string sql1 = "SELECT Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen,Hoadon.giaphong1ngay, Phong.tenphong,Hoadon.ngaythue,Hoadon.ngaytra,Hoadon.thanhtien," +
              "CASE WHEN Hoadon.thanhtoan = 1 THEN N'Đã thanh Toán' ELSE N'Chưa thanh toán' END AS thanhtien " +
              "FROM Hoadon " +
              "INNER JOIN Khachhang ON Hoadon.MaKH = Khachhang.Makh " +
              "INNER JOIN Nhavien ON Hoadon.maNV = Nhavien.MaNV " +
              "INNER JOIN Phong ON Hoadon.maphong = Phong.Maphong where Hoadon.MaHD like '%" + txt_tim_Nguyen.Text.Trim() + "%' ";
            cnn.HienthiDL(sql1);
            dtgv_Hoadon_Nhat.DataSource = cnn.HienthiDL(sql1);

        }

        private void txt_tim_Nguyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql1 = "SELECT Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen,Hoadon.giaphong1ngay, Phong.tenphong,Hoadon.ngaythue,Hoadon.ngaytra,Hoadon.thanhtien," +
              "CASE WHEN Hoadon.thanhtoan = 1 THEN N'Đã thanh Toán' ELSE N'Chưa thanh toán' END AS thanhtien " +
              "FROM Hoadon " +
              "INNER JOIN Khachhang ON Hoadon.MaKH = Khachhang.Makh " +
              "INNER JOIN Nhavien ON Hoadon.maNV = Nhavien.MaNV " +
              "INNER JOIN Phong ON Hoadon.maphong = Phong.Maphong where Hoadon.MaHD like '%" + txt_tim_Nguyen.Text.Trim() + "%' ";
                cnn.HienthiDL(sql1);
                dtgv_Hoadon_Nhat.DataSource = cnn.HienthiDL(sql1);
            }
        }

        private void dtgv_Hoadon_Nhat_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Hmaf thông báo
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

        private void dtgv_Hoadon_Nhat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_khachhang_Nhat.Text = dtgv_Hoadon_Nhat.CurrentRow.Cells[1].Value.ToString();
            txt_maloai_Nam.Text = dtgv_Hoadon_Nhat.CurrentRow.Cells[0].Value.ToString();
            txt_tenphongNam.Text = dtgv_Hoadon_Nhat.CurrentRow.Cells[4].Value.ToString();
            btn_chitiet_Nhat.Enabled = true;
            txt_maloai_Nam.Enabled = false;
            txt_tenphongNam.Enabled = false;
            btn_xoa_Nhat.Enabled = true;
        }

        private void btn_chitiet_Nhat_Click(object sender, EventArgs e)
        {
            string maHD = txt_maloai_Nam.Text;
            string hoten = dtgv_Hoadon_Nhat.CurrentRow.Cells["TenKH"].Value.ToString();
            string Nhanvien = dtgv_Hoadon_Nhat.CurrentRow.Cells["hoTen"].Value.ToString();
            DateTime ngaythue = Convert.ToDateTime(dtgv_Hoadon_Nhat.CurrentRow.Cells["ngaythue"].Value);
            DateTime ngaytra = Convert.ToDateTime(dtgv_Hoadon_Nhat.CurrentRow.Cells["ngaytra"].Value);
            float thanhtien = float.Parse(dtgv_Hoadon_Nhat.CurrentRow.Cells["thanhtien"].Value.ToString());
            XemChiTiet(maHD,hoten,Nhanvien,ngaythue,ngaytra,thanhtien);
        }

        private void btn_xoa_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    // Thực hiện xóa khi người dùng xác nhận
                    string delete = "delete from HDchitiet where MaHD='" + txt_maloai_Nam.Text + "'";
                    cnn.ThucthiDL(delete);
                    string deletes = "delete from Hoadon where MaHD='" + txt_maloai_Nam.Text + "'";
                    cnn.ThucthiDL(deletes);
                    string sql1 = "SELECT Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen,Hoadon.giaphong1ngay, Phong.tenphong,Hoadon.ngaythue,Hoadon.ngaytra,Hoadon.thanhtien," +
                      "CASE WHEN Hoadon.thanhtoan = 1 THEN N'Đã thanh Toán' ELSE N'Chưa thanh toán' END AS thanhtien " +
                      "FROM Hoadon " +
                      "INNER JOIN Khachhang ON Hoadon.MaKH = Khachhang.Makh " +
                      "INNER JOIN Nhavien ON Hoadon.maNV = Nhavien.MaNV " +
                      "INNER JOIN Phong ON Hoadon.maphong = Phong.Maphong ";
                    cnn.HienthiDL(sql1);
                    dtgv_Hoadon_Nhat.DataSource = cnn.HienthiDL(sql1);
                    Toast_thancong("Success!", "Xóa thành công");
                }
            }
            catch
            {

            }
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string tenbang = " Danh sách Hóa đơn ";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatExcel.DichVu(dtgv_Hoadon_Nhat, saveFileDialog.FileName, tenbang);
                    MessageBox.Show("Xuất thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dtgv_Hoadon_Nhat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
