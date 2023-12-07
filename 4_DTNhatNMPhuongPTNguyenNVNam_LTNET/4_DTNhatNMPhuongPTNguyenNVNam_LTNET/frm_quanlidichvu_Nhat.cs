using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_quanlidichvu_Nhat : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_quanlidichvu_Nhat()
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
        public void lammoi()
        {
            txt_madv_Nhat.Text = "";
            txt_tendv_Nhat.Text = "";
            txt_giadv_Nhat.Text = "";
            txt_madv_Nhat.Focus();

        }
        private void frm_quanlidichvu_Nhat_Load(object sender, EventArgs e)
        {
            string sql = "select * from Dichvu";
            cnn.HienthiDL(sql);
            dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql);

            dtgrv_dv_Nhat.Columns[0].HeaderText = "Mã dịch vụ";
            dtgrv_dv_Nhat.Columns[0].Width = 150;
            dtgrv_dv_Nhat.Columns[1].HeaderText = "Tên dịch vụ";
            dtgrv_dv_Nhat.Columns[2].HeaderText = "Giá dịch vụ";
            dtgrv_dv_Nhat.Columns[2].DefaultCellStyle.Format = "###,###";
            btn_capnhat_Nhat.Enabled = false;
            btn_xoa_Nhat.Enabled = false;
            


        }

        private void btn_them_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tendv_Nhat.Text == "" || txt_giadv_Nhat.Text == "" )
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {

                    string sql1 = "insert into Dichvu values('" + txt_madv_Nhat.Text + "',N'" + txt_tendv_Nhat.Text + "','" + txt_giadv_Nhat.Text + "')";
                    cnn.ThucthiDL(sql1);
                    Toast_thancong("Success!", "Thêm thành công ");
                    lammoi();
                    string sql = "select*from Dichvu";
                    cnn.HienthiDL(sql);
                    dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql);
                }


            }
            catch(Exception ex)
            {
                Toast_loi("Error!", "Đã tồn tại rồi");
            }
        }

        private void btn_capnhat_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_madv_Nhat.Text == "" || txt_tendv_Nhat.Text == "" || txt_giadv_Nhat.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    string sql = "UPDATE Dichvu SET tenDv = N'" + txt_tendv_Nhat.Text + "', gia = '" + txt_giadv_Nhat.Text + "' WHERE MaDv = '" + txt_madv_Nhat.Text + "'";
                    cnn.ThucthiDL(sql);
                    Toast_thancong("Success!", "Cập nhật thành công ");
                    // Cập nhật DataGridView sau khi cập nhật dữ liệu
                    string selectSql = "SELECT * FROM Dichvu";
                    cnn.HienthiDL(selectSql);
                    dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(selectSql);
                }
            }
            catch
            {
                Toast_loi("Error!", "Cập nhật lỗi rồi ");
            }
        }

        private void btn_xoa_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_madv_Nhat.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        // Thực hiện xóa khi người dùng xác nhận
                        string delete = "delete from Dichvu where MaDv='" + txt_madv_Nhat.Text + "'";
                        cnn.ThucthiDL(delete);

                        string sql = "select * from Dichvu";
                        cnn.HienthiDL(sql);
                        dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql);

                        Toast_thancong("Success!", "Xóa thành công ");
                    }

                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Xóa bị lỗi thử lại");
            };
        }
        public void tangma()
        {
            DataTable dt = cnn.HienthiDL("Select * from Dichvu");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "DV00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã khách đã có
                h = "DV";//ký tự mặc định của mã khách
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
            txt_madv_Nhat.Text = h;

        }
        private void txt_lammoi_Nhat_Click(object sender, EventArgs e)
        {
            lammoi();
            txt_madv_Nhat.Enabled = true;
            btn_them_Nhat.Enabled = true;
            btn_xoa_Nhat.Enabled = false;
            btn_capnhat_Nhat.Enabled = false;
        }

        private void txt_madv_Nhat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tangma();
                txt_madv_Nhat.Enabled = false;
            }
        }

        private void dtgrv_dv_Nhat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_madv_Nhat.Text = dtgrv_dv_Nhat.CurrentRow.Cells[0].Value.ToString();
            txt_tendv_Nhat.Text = dtgrv_dv_Nhat.CurrentRow.Cells[1].Value.ToString();
            txt_giadv_Nhat.Text = dtgrv_dv_Nhat.CurrentRow.Cells[2].Value.ToString();
            
            txt_madv_Nhat.Enabled = false;
            btn_them_Nhat.Enabled = false;
            btn_xoa_Nhat.Enabled = true;
            btn_capnhat_Nhat.Enabled = true;
        }

        private void btn_tim_Nhat_Click(object sender, EventArgs e)
        {
            string sql;
            if (rd_ten_Nhat.Checked)
            {
                sql = "SELECT * FROM Dichvu WHERE tenDv like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_ma_Nhat.Checked)
            {
                sql = "SELECT * FROM Dichvu WHERE MaDv like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql);
            }
        }

        private void txt_timkim_Nhat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql;
                if (rd_ten_Nhat.Checked)
                {
                    sql = "SELECT * FROM Dichvu WHERE tenDv like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                    dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql);
                }
                if (rd_ma_Nhat.Checked)
                {
                    sql = "SELECT * FROM Dichvu WHERE MaDv like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                    dtgrv_dv_Nhat.DataSource = cnn.HienthiDL(sql);
                }
            }
        }

        private void btn_excel_Nhat_Click(object sender, EventArgs e)
        {
            string tenbang = " Danh sách dịch vụ ";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatExcel.DichVu(dtgrv_dv_Nhat, saveFileDialog.FileName, tenbang);
                    Toast_thancong("Success!", "Xuất excel thành công ");
                }
                catch (Exception ex)
                {
                    Toast_loi("Error!", "Bị lỗi khi xuất");
                }
            }


        }
    }
}
