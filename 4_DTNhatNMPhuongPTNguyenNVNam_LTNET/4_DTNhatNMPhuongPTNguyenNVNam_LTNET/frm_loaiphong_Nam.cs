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
    public partial class frm_loaiphong_Nam : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_loaiphong_Nam()
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
        private void frm_loaiphong_Nam_Load(object sender, EventArgs e)
        {
            string sql = "select * from Loaiphong";
            cnn.HienthiDL(sql);
            dtgrv_loaiPhong_Nhat.DataSource = cnn.HienthiDL(sql);

            dtgrv_loaiPhong_Nhat.Columns[0].HeaderText = "Mã loại phòng";
            dtgrv_loaiPhong_Nhat.Columns[0].Width = 200;
            dtgrv_loaiPhong_Nhat.Columns[1].HeaderText = "Tên loại phòng";
            dtgrv_loaiPhong_Nhat.Columns[2].HeaderText = "Giá 1 ngày";
            dtgrv_loaiPhong_Nhat.Columns[3].HeaderText = "Mô tả";
            btn_xoa_Nhat.Enabled = false;
            btn_capnhat_Nhat.Enabled = false;
            dtgrv_loaiPhong_Nhat.RowTemplate.Height = 30;
            dtgrv_loaiPhong_Nhat.Columns[2].DefaultCellStyle.Format = "###,####";

        }
        public void lammoi()
        {
            txt_maloai_Nguyen.Text = "";
            txt_mota_Nhat.Text = "";
            txt_tenloaiphong_Nhat.Text = "";
            txt_gia1ngay_Phuong.Text = "";
            txt_maloai_Nguyen.Focus();

        }


        public void tangma()
        {
            DataTable dt = cnn.HienthiDL("Select * from Loaiphong");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "LP00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã khách đã có
                h = "LP";//ký tự mặc định của mã khách
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
            txt_maloai_Nguyen.Text = h;

        }


        private void btn_them_Nhat_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenloaiphong_Nhat.Text == "" || txt_gia1ngay_Phuong.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {

                    string sql1 = "insert into Loaiphong values('" + txt_maloai_Nguyen.Text + "',N'" + txt_tenloaiphong_Nhat.Text + "','" + txt_gia1ngay_Phuong.Text + "',N'" + txt_mota_Nhat.Text + "')";
                    cnn.ThucthiDL(sql1);
                    Toast_thancong("Success!", "Thêm thành công ");
                    lammoi();
                    string sql = "select*from Loaiphong";
                    cnn.HienthiDL(sql);
                    dtgrv_loaiPhong_Nhat.DataSource = cnn.HienthiDL(sql);
                }


            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Đã tồn tại");
            }
        }

        private void btn_capnhat_Nhat_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_tenloaiphong_Nhat.Text == "" || txt_gia1ngay_Phuong.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    string sql = "UPDATE Loaiphong SET tenloaiphong = N'" + txt_tenloaiphong_Nhat.Text + "', gia1ngay = '" + txt_gia1ngay_Phuong.Text + "',mota=N'" + txt_mota_Nhat.Text + "' WHERE Maloai = '" + txt_maloai_Nguyen.Text + "'";
                    cnn.ThucthiDL(sql);
                    Toast_thancong("Success!", "Cập nhật thành công");
                    // Cập nhật DataGridView sau khi cập nhật dữ liệu
                    string selectSql = "SELECT * FROM Loaiphong";
                    cnn.HienthiDL(selectSql);
                    dtgrv_loaiPhong_Nhat.DataSource = cnn.HienthiDL(selectSql);
                }
            }
            catch
            {
                Toast_loi("Error!", "Lỗi khi cập nhật");
            }
        }

        private void btn_xoa_Nhat_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txt_maloai_Nguyen.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        // Thực hiện xóa khi người dùng xác nhận
                        string delete = "delete from Loaiphong where Maloai='" + txt_maloai_Nguyen.Text + "'";
                        cnn.ThucthiDL(delete);

                        string sql = "select * from Loaiphong";
                        cnn.HienthiDL(sql);
                        dtgrv_loaiPhong_Nhat.DataSource = cnn.HienthiDL(sql);

                        Toast_thancong("Success!", "Xóa thành công ");
                    }

                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Xóa lỗi rồi ");
            };
        }

        private void dtgrv_loaiPhong_Nhat_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_maloai_Nguyen.Text = dtgrv_loaiPhong_Nhat.CurrentRow.Cells[0].Value.ToString();
            txt_tenloaiphong_Nhat.Text = dtgrv_loaiPhong_Nhat.CurrentRow.Cells[1].Value.ToString();
            txt_gia1ngay_Phuong.Text = dtgrv_loaiPhong_Nhat.CurrentRow.Cells[2].Value.ToString();
            txt_mota_Nhat.Text = dtgrv_loaiPhong_Nhat.CurrentRow.Cells[3].Value.ToString();

            txt_maloai_Nguyen.Enabled = false;
            btn_them_Nhat.Enabled = false;
            btn_xoa_Nhat.Enabled = true;
            btn_capnhat_Nhat.Enabled = true;
        }

        private void txt_timkim_Nhat_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql;
                if (rd_ten_Nhat.Checked)
                {
                    sql = "SELECT * FROM Loaiphong WHERE tenloaiphong like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                    dtgrv_loaiPhong_Nhat.DataSource = cnn.HienthiDL(sql);
                }
            }
        }

        private void btn_tim_Nhat_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (rd_ten_Nhat.Checked)
            {
                sql = "SELECT * FROM Loaiphong WHERE tenloaiphong like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                dtgrv_loaiPhong_Nhat.DataSource = cnn.HienthiDL(sql);
            }
        }

        private void txt_maloai_Nguyen_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tangma();
                txt_maloai_Nguyen.Enabled = false;
            }
        }

        private void txt_lammoi_Nhat_Click_1(object sender, EventArgs e)
        {
            lammoi();
            txt_maloai_Nguyen.Enabled = true;
            btn_them_Nhat.Enabled = true;
            btn_xoa_Nhat.Enabled = false;
            btn_capnhat_Nhat.Enabled = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
