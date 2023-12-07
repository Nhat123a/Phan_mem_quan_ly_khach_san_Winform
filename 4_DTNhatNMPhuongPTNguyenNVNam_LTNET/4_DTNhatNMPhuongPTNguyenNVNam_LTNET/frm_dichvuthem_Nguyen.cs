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
    public partial class frm_dichvuthem_Nguyen : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_dichvuthem_Nguyen()
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
        //Lấy ra tên nhân viên
        private void maHD()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("SELECT MaHD From Hoadon where thanhtoan = 0 ", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();

            while (da.Read())
            {
                txt_maHD_Nguyen.Items.Add(da["MaHD"].ToString());
                
            }


            da.Close();
        }
        //Load
        private void frm_dichvuthem_Nguyen_Load(object sender, EventArgs e)
        {
            maHD();
            string sql = "SELECT * From Dichvu";
            cnn.HienthiDL(sql);
            dtgrv_dichVu_Nguyen.DataSource = cnn.HienthiDL(sql);
            dtgrv_dichVu_Nguyen.Columns[0].HeaderText = "Mã dịch vụ";
            dtgrv_dichVu_Nguyen.Columns[1].HeaderText = "Tên dịch vụ";
            dtgrv_dichVu_Nguyen.Columns[2].HeaderText = "Giá";
            dtgrv_dichVu_Nguyen.RowTemplate.Height = 30;
            //Phiếu
            txt_gia_Nguyen.BackColor = Color.White;
            txt_madichvu_Nguyen.BackColor = Color.White;
            dtgrv_Phieu_Nguyen.RowTemplate.Height = 30;
            txt_madichvu_Nguyen.Enabled = false;
            txt_gia_Nguyen.Enabled = false;
        }

        private void dtgrv_dichVu_Nguyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_madichvu_Nguyen.Text = dtgrv_dichVu_Nguyen.CurrentRow.Cells[0].Value.ToString();
            txt_gia_Nguyen.Text = dtgrv_dichVu_Nguyen.CurrentRow.Cells[2].Value.ToString();
            
        }

        private void btn_thoat_Nguyen_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_them_Nhat_Click(object sender, EventArgs e)
        {
            if (txt_maHD_Nguyen.Text == "" || txt_madichvu_Nguyen.Text == "")
            {
                Toast_loi("Error!", "Thiếu thông tin");
            }
            else
            {
                string sql = "INSERT INTO HDchitiet VALUES('" + txt_maHD_Nguyen.Text + "','" + txt_madichvu_Nguyen.Text + "','" + txt_gia_Nguyen.Text + "','" + txt_soluong_Nguyen.Text + "')";
                cnn.ThucthiDL(sql);
                Toast_thancong("Success!", "Thêm thành công rồi");
                string sql1 = "SELECT  HDchitiet.MaHD, HDchitiet.Madv, HDchitiet.dongia, HDchitiet.soluong " +
              "FROM HDchitiet " +
              "INNER JOIN Hoadon ON HDchitiet.MaHD = Hoadon.MaHD " +
              "WHERE HDchitiet.MaHD = '" + txt_maHD_Nguyen.Text + "' AND Hoadon.thanhtoan = 0";
                cnn.HienthiDL(sql1);
                dtgrv_Phieu_Nguyen.DataSource = cnn.HienthiDL(sql1);

            }
        }

        private void btn_xoa_Nhat_Click(object sender, EventArgs e)
        {
            if (txt_maHD_Nguyen.Text == "")
            {
                Toast_loi("Error!", "Thiếu thông tin rồi");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    // Thực hiện xóa khi người dùng xác nhận
                    string delete = "delete from HDchitiet where Madv='" + txt_madichvu_Nguyen.Text + "'";
                    cnn.ThucthiDL(delete);
                    Toast_thancong("Success!", "Xóa thành công");
                    string sql1 = "SELECT  HDchitiet.MaHD, HDchitiet.Madv, HDchitiet.dongia, HDchitiet.soluong " +
                      "FROM HDchitiet " +
                      "INNER JOIN Hoadon ON HDchitiet.MaHD = Hoadon.MaHD " +
                      "WHERE HDchitiet.MaHD = '" + txt_maHD_Nguyen.Text + "' AND Hoadon.thanhtoan = 0";
                    cnn.HienthiDL(sql1);
                    dtgrv_Phieu_Nguyen.DataSource = cnn.HienthiDL(sql1);
                }

            }
        }

        private void dtgrv_Phieu_Nguyen_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_maHD_Nguyen.Text = dtgrv_Phieu_Nguyen.CurrentRow.Cells[0].Value.ToString();
            txt_madichvu_Nguyen.Text = dtgrv_Phieu_Nguyen.CurrentRow.Cells[1].Value.ToString();
            txt_gia_Nguyen.Text = dtgrv_Phieu_Nguyen.CurrentRow.Cells[2].Value.ToString();
            txt_soluong_Nguyen.Text = dtgrv_Phieu_Nguyen.CurrentRow.Cells[3].Value.ToString();
        }

        private void txt_maHD_Nguyen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql1 = "SELECT * From HDchitiet where MaHD='" + txt_maHD_Nguyen.Text + "'";
            cnn.HienthiDL(sql1);
            dtgrv_Phieu_Nguyen.DataSource = cnn.HienthiDL(sql1);
            dtgrv_Phieu_Nguyen.Columns[0].HeaderText = "Mã hóa đơn";
            dtgrv_Phieu_Nguyen.Columns[1].HeaderText = "Dich vụ";
            dtgrv_Phieu_Nguyen.Columns[2].HeaderText = "Giá";
            dtgrv_Phieu_Nguyen.Columns[3].HeaderText = "Số lượng";
        }
    }
}
