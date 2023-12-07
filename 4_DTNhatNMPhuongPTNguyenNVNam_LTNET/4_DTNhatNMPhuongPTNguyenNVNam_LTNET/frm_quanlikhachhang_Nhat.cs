using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_quanlikhachhang_Nhat : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_quanlikhachhang_Nhat()
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
        private void grb_tacvu_Nam_Paint(object sender, PaintEventArgs e)
        {
            GroupBox groupBox = (GroupBox)sender;
            ControlPaint.DrawBorder(e.Graphics, groupBox.ClientRectangle, Color.SeaGreen, ButtonBorderStyle.Outset);
        }

        private void grb_thongtin_Nhat_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        //clear
        public void lammoi()
        {
            txt_makh_Nhat.Text = "";
            txt_tenKH_Nhat.Text = "";
            txt_cmt_Nhat.Text = "";
            txt_Quoctich_Nhat.Text = "";
            txt_sdt_Nhat.Text = "";
            txt_mota_Nhat.Text = "";
            txt_makh_Nhat.Focus();
            
        }
        private void btn_Themkh_Nguyen_Click(object sender, EventArgs e)
        {
            try
            {
                if ( txt_tenKH_Nhat.Text == "" || txt_cmt_Nhat.Text == "" || txt_Quoctich_Nhat.Text == "" || txt_sdt_Nhat.Text == "")
                {
                    Toast_loi("Error !", "Thiếu thông tin");
                }
                else
                {
                   
                    string sql1 = "insert into Khachhang values('"+txt_makh_Nhat.Text+"',N'" + txt_tenKH_Nhat.Text + "',N'" + txt_cmt_Nhat.Text + "',N'" + txt_Quoctich_Nhat.Text + "',N'" + txt_gioitinh_Nhat.Text + "',N'" + txt_sdt_Nhat.Text + "',N'" + txt_mota_Nhat.Text + "')";
                    cnn.ThucthiDL(sql1);
                    Toast_thancong("Success !", "Thêm thành công");
                    lammoi();
                    string sql = "select*from Khachhang";
                    cnn.HienthiDL(sql);
                    dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
                }


            }
            catch
            {
                Toast_loi("Error !", "Đã tồn tại ");
            }
        }

        private void pain_kh_Nguyen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_quanlikhachhang_Nhat_Load(object sender, EventArgs e)
        {
            string sql = "select * from Khachhang";
            cnn.HienthiDL(sql);
            dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
            
            dtgrv_kh_Nhat.Columns[0].HeaderText = "Mã KH";
            dtgrv_kh_Nhat.Columns[0].Width = 120;
            dtgrv_kh_Nhat.Columns[1].HeaderText = "Tên KH";
            dtgrv_kh_Nhat.Columns[1].Width = 200;
            dtgrv_kh_Nhat.Columns[2].HeaderText = "CMT";
            dtgrv_kh_Nhat.Columns[2].Width = 155;
            dtgrv_kh_Nhat.Columns[3].HeaderText = "Quốc tịch";
            dtgrv_kh_Nhat.Columns[3].Width = 100;
            dtgrv_kh_Nhat.Columns[4].HeaderText = "Giới tính";
            dtgrv_kh_Nhat.Columns[5].HeaderText = "SDT";
            dtgrv_kh_Nhat.Columns[6].HeaderText = "Mô tả";
            txt_gioitinh_Nhat.Text = "Nam";
            btn_capnhatkh_Phuong.Enabled = false;
            btn_xoa_Nhat.Enabled = false;
        }

        private void btn_capnhatkh_Phuong_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_makh_Nhat.Text == "" || txt_tenKH_Nhat.Text == "" || txt_cmt_Nhat.Text == "" || txt_Quoctich_Nhat.Text == "" || txt_sdt_Nhat.Text == "")
                {
                    Toast_loi("Error !", "Thiếu thông tin");
                }
                else
                {
                    string sql = "UPDATE Khachhang SET tenKH = N'" + txt_tenKH_Nhat.Text + "', CMT = N'" + txt_cmt_Nhat.Text + "', Quoctich = N'" + txt_Quoctich_Nhat.Text + "', gioitinh = N'" + txt_gioitinh_Nhat.Text + "', dienthoai = N'" + txt_sdt_Nhat.Text + "', mota = N'" + txt_mota_Nhat.Text + "' WHERE Makh = '" + txt_makh_Nhat.Text + "'";
                    cnn.ThucthiDL(sql);
                    Toast_thancong("Success !", "Cập nhật thành công");

                    // Cập nhật DataGridView sau khi cập nhật dữ liệu
                    string selectSql = "SELECT * FROM Khachhang";
                    cnn.HienthiDL(selectSql);
                    dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(selectSql);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi khi cập nhật!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void dtgrv_kh_Nhat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_makh_Nhat.Text = dtgrv_kh_Nhat.CurrentRow.Cells[0].Value.ToString();
            txt_tenKH_Nhat.Text = dtgrv_kh_Nhat.CurrentRow.Cells[1].Value.ToString();
            txt_cmt_Nhat.Text = dtgrv_kh_Nhat.CurrentRow.Cells[2].Value.ToString();
            txt_Quoctich_Nhat.Text = dtgrv_kh_Nhat.CurrentRow.Cells[3].Value.ToString();
            txt_gioitinh_Nhat.Text = dtgrv_kh_Nhat.CurrentRow.Cells[4].Value.ToString();
            txt_sdt_Nhat.Text = dtgrv_kh_Nhat.CurrentRow.Cells[5].Value.ToString();
            txt_mota_Nhat.Text = dtgrv_kh_Nhat.CurrentRow.Cells[6].Value.ToString();
            txt_makh_Nhat.Enabled = false;
            btn_Themkh_Nguyen.Enabled = false;
            btn_xoa_Nhat.Enabled = true;
            btn_capnhatkh_Phuong.Enabled = true;

        }

        private void txt_lammoi_Nhat_Click(object sender, EventArgs e)
        {
            lammoi();
            txt_makh_Nhat.Enabled = true;
            btn_Themkh_Nguyen.Enabled = true;
            btn_xoa_Nhat.Enabled = false;
            btn_capnhatkh_Phuong.Enabled = false;

        }

        private void btn_xoa_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_makh_Nhat.Text == "")
                {
                    Toast_loi("Error !", "Thiếu thông tin");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        // Thực hiện xóa khi người dùng xác nhận
                        string delete = "delete from Khachhang where Makh='" + txt_makh_Nhat.Text + "'";
                        cnn.ThucthiDL(delete);

                        string sql = "select * from Khachhang";
                        cnn.HienthiDL(sql);
                        dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
                        Toast_thancong("Success !", "Xóa thành công");

                    }

                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error !", "Bị lỗi rồi");
            };
        }

        private void btn_tim_Nhat_Click(object sender, EventArgs e)
        {
            string sql;
            if (rd_cmt_Nhat.Checked)
            {
                sql = "SELECT * FROM KhachHang WHERE CMT like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_quoctich_Nhat.Checked)
            {
                sql = "SELECT * FROM KhachHang WHERE Quoctich like N'%" + txt_timkim_Nhat.Text + "%' ";
                dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_ten_nhat.Checked)
            {
                sql = "SELECT * FROM KhachHang WHERE tenKH like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_sdt_Nhat.Checked)
            {
                sql = "SELECT * FROM KhachHang WHERE dienthoai like N'%" + txt_timkim_Nhat.Text + "%' ";
                dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
            }
        }



        public void tangma()
        {
            DataTable dt = cnn.HienthiDL("Select * from Khachhang");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "KH00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã khách đã có
                h = "KH";//ký tự mặc định của mã khách
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
            txt_makh_Nhat.Text = h;

        }


        private void txt_makh_Nhat_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tangma();
                txt_makh_Nhat.Enabled = false;
            }
        }

        private void txt_timkim_Nhat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql;
                if (rd_cmt_Nhat.Checked)
                {
                    sql = "SELECT * FROM KhachHang WHERE CMT like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                    dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
                }
                if (rd_quoctich_Nhat.Checked)
                {
                    sql = "SELECT * FROM KhachHang WHERE Quoctich like N'%" + txt_timkim_Nhat.Text + "%' ";
                    dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
                }
                if (rd_ten_nhat.Checked)
                {
                    sql = "SELECT * FROM KhachHang WHERE tenKH like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                    dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
                }
                if (rd_sdt_Nhat.Checked)
                {
                    sql = "SELECT * FROM KhachHang WHERE dienthoai like N'%" + txt_timkim_Nhat.Text + "%' ";
                    dtgrv_kh_Nhat.DataSource = cnn.HienthiDL(sql);
                }
            }
        }

        private void groupBox1_Leave(object sender, EventArgs e)
        {
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string tenbang = " Danh sách khách hàng";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatExcel.DichVu(dtgrv_kh_Nhat, saveFileDialog.FileName, tenbang);
                    Toast_thancong("Success !", "Xuất excel thành công");

                }
                catch (Exception ex)
                {
                    Toast_loi("Error !", "Xuất lỗi rồi");
                }
            }
        }

        private void txt_gioitinh_Nhat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
