using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_quanlinhanvien_Phuong : Form
    {
        Ketnoi cnn = new Ketnoi();
        public frm_quanlinhanvien_Phuong()
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
        private void grb_thongtn_Nhat_Enter(object sender, EventArgs e)
        {

        }

        private void frm_quanlinhanvien_Phuong_Load(object sender, EventArgs e)
        {
            string sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien";
            cnn.HienthiDL(sql);
            dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
            dtgrv_nv_Nhat.Columns[0].HeaderText = "Mã NV";
            dtgrv_nv_Nhat.Columns[0].Width = 120;
            dtgrv_nv_Nhat.Columns[1].HeaderText = "Tên NV";
            dtgrv_nv_Nhat.Columns[1].Width = 200;
            dtgrv_nv_Nhat.Columns[2].HeaderText = "Ngày sinh";
            dtgrv_nv_Nhat.Columns[2].Width = 155;
            dtgrv_nv_Nhat.Columns[3].HeaderText = "Giới tính";
            dtgrv_nv_Nhat.Columns[3].Width = 130;
            dtgrv_nv_Nhat.Columns[6].HeaderText = "Tài khoản";
            dtgrv_nv_Nhat.Columns[4].HeaderText = "Mật Khẩu";
            dtgrv_nv_Nhat.Columns[5].HeaderText = "Loại TK";
            
            
            txt_gioitinh_Nam.Text = "Nam";
            txt_loai_nam.Text = "Quan Ly";
            btn_xoa_Nhat.Enabled = false;
            btn_capnhat_Nhat.Enabled = false;
        }
        //clear
        public void lammoi()
        {
            txt_manv_Nam.Text = "";
            txt_tennv_Nam.Text = "";
            txt_ngaysinh_Nam.Text = "";
            txt_user_Nam.Text = "";
            txt_pass_Nhat.Text = "";
            
            txt_manv_Nam.Focus();

        }
        //Hàm mã hóa pass MD5
        private string MahoaMD(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }

                return sb.ToString();
            }
        }
        private void btn_them_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txt_tennv_Nam.Text == "" )
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {

                    string matkhau = txt_pass_Nhat.Text;
                    string mahoamk = MahoaMD(matkhau);
                    string sql1 = "insert into Nhavien values('" + txt_manv_Nam.Text + "',N'" + txt_tennv_Nam.Text + "','"+ txt_ngaysinh_Nam.Value + "',N'" + txt_gioitinh_Nam.Text + "','" + mahoamk + "',N'" + txt_loai_nam.Text + "',N'" + txt_user_Nam.Text + "')";
                    cnn.ThucthiDL(sql1);
                    Toast_thancong("Success!", "thêm thành công");
                    lammoi();
                    string sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien";
                    cnn.HienthiDL(sql);
                    dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
                }


            }
            catch(Exception ex)
            {
                Toast_loi("Error!", "Đã tôn tại");
            }
        }

        private void txt_lammoi_Nhat_Click(object sender, EventArgs e)
        {
            lammoi();
            btn_them_Nhat.Enabled = true;
            btn_xoa_Nhat.Enabled = false;
            btn_capnhat_Nhat.Enabled = false;
            txt_manv_Nam.Enabled = true;
        }

        private void btn_capnhat_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_tennv_Nam.Text == "") {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    string matkhau = txt_pass_Nhat.Text;
                    string mahoamk = MahoaMD(matkhau);
                    string sql = "UPDATE Nhavien SET hoTen = N'" + txt_tennv_Nam.Text + "', ngaysinh = N'" + txt_ngaysinh_Nam.Value.ToString("dd/MM/yyyy") + "', gioitinh = N'" + txt_gioitinh_Nam.Text + "', matkhau = '" + mahoamk + "', loai = N'" + txt_loai_nam.Text + "', taikhoan = N'" + txt_user_Nam.Text + "' WHERE MaNV = '" + txt_manv_Nam.Text + "'";
                    cnn.ThucthiDL(sql);
                    Toast_thancong("Success!", "Cập nhật thành công");
                    // Cập nhật DataGridView sau khi cập nhật dữ liệu
                    string selectSql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien";
                    cnn.HienthiDL(selectSql);
                    dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(selectSql);
                }
            }
            catch
            {
                Toast_loi("Error!", "Không thể cập nhật");
            }
        }

        private void btn_xoa_Nhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_manv_Nam.Text == "")
                {
                    Toast_loi("Error!", "Thiếu thông tin");
                }
                else
                {
                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận Xóa", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (result == DialogResult.OK)
                    {
                        // Thực hiện xóa khi người dùng xác nhận
                        string delete = "delete from Nhavien where MaNV='" + txt_manv_Nam.Text + "'";
                        cnn.ThucthiDL(delete);

                        string sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien";
                        cnn.HienthiDL(sql);
                        dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
                        Toast_thancong("Success!", "Xóa thành công rồi");

                    }

                }
            }
            catch (Exception ex)
            {
                Toast_loi("Error!", "Không thể xóa ");

            };
        }

        private void dtgrv_nv_Nhat_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_manv_Nam.Text = dtgrv_nv_Nhat.CurrentRow.Cells[0].Value.ToString();
            txt_tennv_Nam.Text = dtgrv_nv_Nhat.CurrentRow.Cells[1].Value.ToString();
            DateTime ngaySinh;
            if (DateTime.TryParseExact(dtgrv_nv_Nhat.CurrentRow.Cells[2].Value.ToString(), "dd/MM/yyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out ngaySinh))
            {
                txt_ngaysinh_Nam.Value = ngaySinh;
            }
            txt_gioitinh_Nam.Text = dtgrv_nv_Nhat.CurrentRow.Cells[3].Value.ToString();
            txt_pass_Nhat.Text = dtgrv_nv_Nhat.CurrentRow.Cells[4].Value.ToString();
            txt_loai_nam.Text = dtgrv_nv_Nhat.CurrentRow.Cells[5].Value.ToString();
            txt_user_Nam.Text = dtgrv_nv_Nhat.CurrentRow.Cells[6].Value.ToString();
            txt_manv_Nam.Enabled = false;
            btn_them_Nhat.Enabled = false;
            btn_xoa_Nhat.Enabled = true;
            btn_capnhat_Nhat.Enabled = true;
        }
        public void tangma()
        {
            DataTable dt = cnn.HienthiDL("Select * from Nhavien");
            string h = "";

            if (dt.Rows.Count <= 0)
            {
                h = "NV00001";
            }

            else
            {
                int k;//lấy giá trị số trong chuỗi mã khách đã có
                h = "NV";//ký tự mặc định của mã 
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
            txt_manv_Nam.Text = h;

        }

        private void txt_manv_Nam_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tangma();
                txt_manv_Nam.Enabled = false;
            }
        }

        private void btn_tim_Nhat_Click(object sender, EventArgs e)
        {
            string sql;
            if (rd_ten_Nhat.Checked)
            {
                sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien WHERE hoTen like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_gioitinh_Nhat.Checked)
            {
                sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien WHERE gioitinh like N'%" + txt_timkim_Nhat.Text + "%' ";
                dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
            }
            if (rd_loai_nhat.Checked)
            {
                sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien WHERE loai like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
            }

        }

        private void txt_timkim_Nhat_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql;
                if (rd_ten_Nhat.Checked)
                {
                    sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien WHERE hoTen like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                    dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
                }
                if (rd_gioitinh_Nhat.Checked)
                {
                    sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien WHERE gioitinh like N'%" + txt_timkim_Nhat.Text + "%' ";
                    dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
                }
                if (rd_loai_nhat.Checked)
                {
                    sql = "select MaNV,hoTen,ngaysinh,gioitinh,matkhau,loai,taikhoan from Nhavien WHERE loai like '%" + txt_timkim_Nhat.Text.Trim() + "%' ";
                    dtgrv_nv_Nhat.DataSource = cnn.HienthiDL(sql);
                }
            }
        }

        private void txt_manv_Nam_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string tenbang = " Danh sách Nhân viên ";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Xuất dữ liệu";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    XuatExcel.DichVu(dtgrv_nv_Nhat, saveFileDialog.FileName, tenbang);
                    Toast_thancong("Success!", "Xuất excel thành công");
                }
                catch (Exception ex)
                {
                    Toast_loi("Error!", "Xuất lỗi rồi");
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pain_kh_Nguyen_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
