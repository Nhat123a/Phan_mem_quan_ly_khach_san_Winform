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
    public partial class frm_Thongke_Phuong : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_Thongke_Phuong()
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
        private void maPhong()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("SELECT Phong.Maphong, Phong.tenphong FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();

            while (da.Read())
            {
                txt_phong_Phuong.Items.Add(da["tenphong"].ToString());
            }


            da.Close();
        }
        private void frm_Thongke_Phuong_Load(object sender, EventArgs e)
        {
            maPhong();
            //Doanh thu 
            DataTable dt = cnn.HienthiDL("Select * from view_doanhthu");
            chart1.ChartAreas["ChartArea1"].AxisX.Title = "Tháng";
            chart1.ChartAreas["ChartArea1"].AxisY.Title = "Doanh thu";
            foreach (DataRow row in dt.Rows)
            {

                int thang = Convert.ToInt32(row["Thang"]);
                decimal doanhThu = Convert.ToDecimal(row["Doanhthu"]);

                // Thêm điểm dữ liệu vào biểu đồ
                chart1.Series["Doanh thu"].Points.AddXY(thang, doanhThu);
            }

        }

        private void btn_thongke_Click(object sender, EventArgs e)
        {
            if (txt_phong_Phuong.Text == "")
            {
                Toast_loi("Error!", "Vui lòng chọn phòng");
            }
            else
            {
                cnn.Ketnoicsdl();
                string sql3 = "SELECT maphong FROM Phong WHERE tenphong = N'" + txt_phong_Phuong.Text + "'";
                SqlCommand cmd3 = new SqlCommand(sql3, cnn.conn);
                string phong = cmd3.ExecuteScalar().ToString();

                string sql = "SELECT  Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen, Phong.tenphong,Hoadon.thanhtien " +
                    "FROM Hoadon INNER JOIN Khachhang ON Khachhang.Makh = Hoadon.MaKH " +
                    "INNER JOIN Nhavien ON Nhavien.MaNV = Hoadon.maNV INNER JOIN Phong ON Phong.Maphong = Hoadon.maphong " +
                    "WHERE Hoadon.maphong = '" + phong + "' GROUP BY Hoadon.MaHD, Khachhang.TenKH, Nhavien.hoTen, Phong.tenphong,Hoadon.thanhtien";
                cnn.HienthiDL(sql);
                dtgrv_thongke_Phuong.DataSource = cnn.HienthiDL(sql);
                dtgrv_thongke_Phuong.Columns[0].HeaderText = "Mã hóa đơn";
                dtgrv_thongke_Phuong.Columns[1].HeaderText = "Khách hàng";
                dtgrv_thongke_Phuong.Columns[2].HeaderText = "Nhân viên";
                dtgrv_thongke_Phuong.Columns[3].HeaderText = "Phòng";
                dtgrv_thongke_Phuong.Columns[4].HeaderText = "Thành tiền";
                dtgrv_thongke_Phuong.RowTemplate.Height = 30;

                double tongtien = 0;
                for (int i = 0; i < dtgrv_thongke_Phuong.Rows.Count; i++)
                {
                    tongtien += Convert.ToDouble(dtgrv_thongke_Phuong.Rows[i].Cells[4].Value);
                }
                txt_tien_Phuong.Text =  tongtien.ToString("N0") + "VNĐ";
                dtgrv_thongke_Phuong.Columns[4].DefaultCellStyle.Format = "###,###";

            }
        }

        private void btn_baocao_Nhat_Click(object sender, EventArgs e)
        {
            frm_Baocao_Nhat frm = new frm_Baocao_Nhat();
            frm.ShowDialog();
        }

        private void btn_doanhthuThang_Phuong_Click(object sender, EventArgs e)
        {
            string tenbang = " Danh sách doanh thu theo tháng";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatExcel.DichVu(dtgrv_thongke_Phuong, saveFileDialog.FileName, tenbang);
                    MessageBox.Show("Xuất thành công", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi" + ex, "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }

        }

        private void dtgrv_thongke_Phuong_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 1) 
            {
                if (e.Value != null && e.Value != DBNull.Value)
                {
                   // ĐỊnh dạng 
                    e.Value = string.Format("{0:#,##0}", e.Value);
                    e.FormattingApplied = true;
                }
            }
        }

        private void btn_doanhthu_thang_Click(object sender, EventArgs e)
        {
            txt_tien_Phuong.Text = "0";
            string sql = "SELECT ThangTable.Thang, ISNULL(SUM(Hoadon.thanhtien), 0) AS Doanhthu FROM (VALUES (1), (2), (3), (4), (5), (6), (7), (8), (9), (10), (11), (12)) AS ThangTable(Thang) " +
                "LEFT JOIN Hoadon ON MONTH(Hoadon.ngaytra) = ThangTable.Thang " +
                "GROUP BY ThangTable.Thang ORDER BY Doanhthu DESC";
            cnn.HienthiDL(sql);
            dtgrv_thongke_Phuong.DataSource = cnn.HienthiDL(sql);
            dtgrv_thongke_Phuong.Columns[1].DefaultCellStyle.Format = "###,###";
            dtgrv_thongke_Phuong.Columns[0].HeaderText = "Tháng ";
            dtgrv_thongke_Phuong.Columns[1].HeaderText = "Tổng doanh thu khách sạn ";
        }
    }
}
