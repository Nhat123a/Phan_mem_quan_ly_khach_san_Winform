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
    public partial class frm_quanliphong_Nguyen : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_quanliphong_Nguyen()
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void maloai()
        {
            cnn.Ketnoicsdl();
            SqlCommand cd = new SqlCommand("select Maloai,tenloaiphong from Loaiphong", cnn.conn);
            SqlDataReader da = cd.ExecuteReader();
            while (da.Read())
            {
                txt_loaiphong_Nhat.Items.Add(da["tenloaiphong"].ToString());
                txt_loaiphong_Nhat.DisplayMember = (da["tenloaiphong"].ToString());
            }
            da.Close();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frm_quanliphong_Nguyen_Load(object sender, EventArgs e)
        {
            maloai();
            string sql = "SELECT Phong.Maphong, Phong.tenphong,Loaiphong.gia1ngay,Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai";
            cnn.HienthiDL(sql);
            dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql);
            dtgrv_Phong_Nhat.Columns[0].HeaderText = "Mã  phòng";
            dtgrv_Phong_Nhat.Columns[0].Width = 200;
            dtgrv_Phong_Nhat.Columns[1].HeaderText = "Tên phòng";
            dtgrv_Phong_Nhat.Columns[2].HeaderText = "Giá 1 ngày";
            dtgrv_Phong_Nhat.Columns[3].HeaderText = "Loại Phòng";
            
            dtgrv_Phong_Nhat.Columns[4].HeaderText = "Trạng Thái";
            dtgrv_Phong_Nhat.Columns[2].DefaultCellStyle.Format = "###,####";
            btn_xoa_Nhat.Enabled = false;
            btn_capnhat_Nhat.Enabled = false;
            dtgrv_Phong_Nhat.RowTemplate.Height = 30;
        }
        public void lammoi()
        {
            txt_maphong_Nguyen.Text = "";
            txt_loaiphong_Nhat.Text = "";
            txt_tenphong_Nhat.Text = "";
            txt_maphong_Nguyen.Focus();

        }
        private void btn_them_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenphong_Nhat.Text == "" || txt_loaiphong_Nhat.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    // Lấy mã loại phòng từ tên loại phòng được chọn
                    string tenLoaiPhong = txt_loaiphong_Nhat.Text;
                    string sqlGetMaLoai = "SELECT Maloai FROM Loaiphong WHERE tenloaiphong = N'" + tenLoaiPhong + "'";
                    SqlCommand cmdGetMaLoai = new SqlCommand(sqlGetMaLoai, cnn.conn);
                    string maLoaiPhong = cmdGetMaLoai.ExecuteScalar().ToString();

                    // Thêm dữ liệu vào bảng Phong
                    string sql1 = "insert into Phong values('" + txt_maphong_Nguyen.Text + "',N'" + txt_tenphong_Nhat.Text + "','" + maLoaiPhong + "',0)";
                    cnn.ThucthiDL(sql1);
                    Toast_thancong("Success!", "Thêm thành công ");
                    lammoi();
                    string sql = "SELECT Phong.Maphong, Phong.tenphong,Loaiphong.gia1ngay, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai";
                    cnn.HienthiDL(sql);
                    dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql);
                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Đã tồn tại phòng");
            }
        }

        private void txt_lammoi_Nhat_Click(object sender, EventArgs e)
        {
            lammoi();
            txt_maphong_Nguyen.Enabled = true;
            btn_them_Nhat.Enabled = true;
            btn_xoa_Nhat.Enabled = false;
            btn_capnhat_Nhat.Enabled = false;
        }

        private void btn_capnhat_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenphong_Nhat.Text == "" || txt_loaiphong_Nhat.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    // Lấy mã loại phòng từ tên loại phòng được chọn
                    string tenLoaiPhong = txt_loaiphong_Nhat.Text;
                    string sqlGetMaLoai = "SELECT Maloai FROM Loaiphong WHERE tenloaiphong = N'" + tenLoaiPhong + "'";
                    SqlCommand cmdGetMaLoai = new SqlCommand(sqlGetMaLoai, cnn.conn);
                    string maLoaiPhong = cmdGetMaLoai.ExecuteScalar().ToString();

                    string sql = "UPDATE Phong SET tenphong = N'" + txt_tenphong_Nhat.Text + "', maloaiphong = '" + maLoaiPhong + "' where Maphong='"+txt_maphong_Nguyen.Text+ "' AND tinhtrang=0";
                    cnn.ThucthiDL(sql);
                    Toast_thancong("Success!", "Cập nhật thành công ");
                    // Cập nhật DataGridView sau khi cập nhật dữ liệu
                    string sql1 = "SELECT Phong.Maphong, Phong.tenphong,Loaiphong.gia1ngay, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai";
                    cnn.HienthiDL(sql1);
                    dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql1);
                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Xảy ra lỗi hehe");
            }
        }

        private void dtgrv_Phong_Nhat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_maphong_Nguyen.Text = dtgrv_Phong_Nhat.CurrentRow.Cells[0].Value.ToString();
            txt_tenphong_Nhat.Text = dtgrv_Phong_Nhat.CurrentRow.Cells[1].Value.ToString();
            txt_loaiphong_Nhat.Text = dtgrv_Phong_Nhat.CurrentRow.Cells[3].Value.ToString();

            txt_maphong_Nguyen.Enabled = false;
            btn_them_Nhat.Enabled = false;
            btn_xoa_Nhat.Enabled = true;
            btn_capnhat_Nhat.Enabled = true;
        }

        private void btn_xoa_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_maphong_Nguyen.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        // Thực hiện xóa khi người dùng xác nhận
                        string delete = "delete from Phong where Maphong='" + txt_maphong_Nguyen.Text + "'";
                        cnn.ThucthiDL(delete);

                        string sql = "SELECT Phong.Maphong, Phong.tenphong,Loaiphong.gia1ngay, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai";
                        cnn.HienthiDL(sql);
                        dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql);

                        Toast_thancong("Success!", "Xóa thành công ");
                    }

                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Xóa lỗi rồi hehe");
            };
        }
        public void tangma()
        {
            DataTable dt = cnn.HienthiDL("SELECT Phong.Maphong, Phong.tenphong, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "PH00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã khách đã có
                h = "PH";//ký tự mặc định của mã khách
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
            txt_maphong_Nguyen.Text = h;

        }

        private void txt_maphong_Nguyen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tangma();
                txt_maphong_Nguyen.Enabled = false;
            }
        }

        private void btn_tim_Nhat_Click(object sender, EventArgs e)
        {
            string sql;
            if (rd_maphong_Nhat.Checked)
            {
                 sql = "SELECT Phong.Maphong, Phong.tenphong, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai WHERE Maphong like '%" + txt_timkim_Nhat.Text.Trim() + "%'";

                dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_ten_Nhat.Checked)
            {
                sql = "SELECT Phong.Maphong, Phong.tenphong, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai WHERE tenphong like '%" + txt_timkim_Nhat.Text.Trim() + "%'";

                dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql);
            }
        }

        private void txt_timkim_Nhat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql;
                if (rd_maphong_Nhat.Checked)
                {
                    sql = "SELECT Phong.Maphong, Phong.tenphong, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai WHERE Maphong like '%" + txt_timkim_Nhat.Text.Trim() + "%'";

                    dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql);
                }
                if (rd_ten_Nhat.Checked)
                {
                    sql = "SELECT Phong.Maphong, Phong.tenphong, Loaiphong.tenloaiphong, CASE WHEN Phong.tinhtrang = 1 THEN N'Đã có người' ELSE N'Phòng trống' END AS trangthai FROM Phong INNER JOIN Loaiphong ON Phong.maloaiphong = Loaiphong.maloai WHERE tenphong like '%" + txt_timkim_Nhat.Text.Trim() + "%'";

                    dtgrv_Phong_Nhat.DataSource = cnn.HienthiDL(sql);
                }
            }
        }
    }
}
