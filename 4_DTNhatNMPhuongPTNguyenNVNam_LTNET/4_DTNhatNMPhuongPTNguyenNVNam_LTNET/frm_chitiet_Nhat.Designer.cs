
namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    partial class frm_chitiet_Nhat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_close_nhat = new FontAwesome.Sharp.IconPictureBox();
            this.dtgrv_chitiet_Nguyen = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_trangchu_Nhat = new System.Windows.Forms.Label();
            this.txt_kh = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_nhanvien = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_HD_Nhat = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_ngaytra = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_ngaythue = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_thanhtien = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_chitiet_Nguyen)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_close_nhat
            // 
            this.txt_close_nhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.txt_close_nhat.ForeColor = System.Drawing.Color.Red;
            this.txt_close_nhat.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.txt_close_nhat.IconColor = System.Drawing.Color.Red;
            this.txt_close_nhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txt_close_nhat.IconSize = 44;
            this.txt_close_nhat.Location = new System.Drawing.Point(1011, 12);
            this.txt_close_nhat.Name = "txt_close_nhat";
            this.txt_close_nhat.Size = new System.Drawing.Size(47, 44);
            this.txt_close_nhat.TabIndex = 5;
            this.txt_close_nhat.TabStop = false;
            this.txt_close_nhat.Click += new System.EventHandler(this.txt_close_nhat_Click);
            // 
            // dtgrv_chitiet_Nguyen
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgrv_chitiet_Nguyen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrv_chitiet_Nguyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrv_chitiet_Nguyen.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrv_chitiet_Nguyen.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgrv_chitiet_Nguyen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrv_chitiet_Nguyen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrv_chitiet_Nguyen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv_chitiet_Nguyen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrv_chitiet_Nguyen.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv_chitiet_Nguyen.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrv_chitiet_Nguyen.DoubleBuffered = true;
            this.dtgrv_chitiet_Nguyen.EnableHeadersVisualStyles = false;
            this.dtgrv_chitiet_Nguyen.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgrv_chitiet_Nguyen.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dtgrv_chitiet_Nguyen.Location = new System.Drawing.Point(12, 299);
            this.dtgrv_chitiet_Nguyen.MultiSelect = false;
            this.dtgrv_chitiet_Nguyen.Name = "dtgrv_chitiet_Nguyen";
            this.dtgrv_chitiet_Nguyen.ReadOnly = true;
            this.dtgrv_chitiet_Nguyen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrv_chitiet_Nguyen.RowHeadersVisible = false;
            this.dtgrv_chitiet_Nguyen.RowHeadersWidth = 70;
            this.dtgrv_chitiet_Nguyen.RowTemplate.Height = 28;
            this.dtgrv_chitiet_Nguyen.Size = new System.Drawing.Size(1046, 219);
            this.dtgrv_chitiet_Nguyen.TabIndex = 6;
            // 
            // txt_trangchu_Nhat
            // 
            this.txt_trangchu_Nhat.AutoSize = true;
            this.txt_trangchu_Nhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trangchu_Nhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_trangchu_Nhat.Location = new System.Drawing.Point(361, 12);
            this.txt_trangchu_Nhat.Name = "txt_trangchu_Nhat";
            this.txt_trangchu_Nhat.Size = new System.Drawing.Size(204, 32);
            this.txt_trangchu_Nhat.TabIndex = 7;
            this.txt_trangchu_Nhat.Text = "Chi tiết hóa đơn ";
            // 
            // txt_kh
            // 
            this.txt_kh.AutoSize = true;
            this.txt_kh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_kh.Location = new System.Drawing.Point(31, 147);
            this.txt_kh.Name = "txt_kh";
            this.txt_kh.Size = new System.Drawing.Size(128, 28);
            this.txt_kh.TabIndex = 8;
            this.txt_kh.Text = "Khách Hàng ";
            // 
            // txt_nhanvien
            // 
            this.txt_nhanvien.AutoSize = true;
            this.txt_nhanvien.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nhanvien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_nhanvien.Location = new System.Drawing.Point(31, 201);
            this.txt_nhanvien.Name = "txt_nhanvien";
            this.txt_nhanvien.Size = new System.Drawing.Size(105, 28);
            this.txt_nhanvien.TabIndex = 9;
            this.txt_nhanvien.Text = "Nhân viên";
            // 
            // txt_HD_Nhat
            // 
            this.txt_HD_Nhat.AutoSize = true;
            this.txt_HD_Nhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HD_Nhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_HD_Nhat.Location = new System.Drawing.Point(31, 96);
            this.txt_HD_Nhat.Name = "txt_HD_Nhat";
            this.txt_HD_Nhat.Size = new System.Drawing.Size(125, 28);
            this.txt_HD_Nhat.TabIndex = 10;
            this.txt_HD_Nhat.Text = "Mã Hóa đơn";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(287, 250);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(310, 30);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Danh sách dịch vụ đã sử dụng";
            // 
            // txt_ngaytra
            // 
            this.txt_ngaytra.AutoSize = true;
            this.txt_ngaytra.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaytra.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_ngaytra.Location = new System.Drawing.Point(660, 147);
            this.txt_ngaytra.Name = "txt_ngaytra";
            this.txt_ngaytra.Size = new System.Drawing.Size(89, 28);
            this.txt_ngaytra.TabIndex = 13;
            this.txt_ngaytra.Text = "Ngày trả";
            // 
            // txt_ngaythue
            // 
            this.txt_ngaythue.AutoSize = true;
            this.txt_ngaythue.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ngaythue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_ngaythue.Location = new System.Drawing.Point(660, 96);
            this.txt_ngaythue.Name = "txt_ngaythue";
            this.txt_ngaythue.Size = new System.Drawing.Size(107, 28);
            this.txt_ngaythue.TabIndex = 12;
            this.txt_ngaythue.Text = "Ngày thuê";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.AutoSize = true;
            this.txt_thanhtien.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_thanhtien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_thanhtien.Location = new System.Drawing.Point(681, 546);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.Size = new System.Drawing.Size(121, 28);
            this.txt_thanhtien.TabIndex = 14;
            this.txt_thanhtien.Text = "Thành tiền :";
            // 
            // frm_chitiet_Nhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(76)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1070, 607);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_ngaytra);
            this.Controls.Add(this.txt_ngaythue);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txt_HD_Nhat);
            this.Controls.Add(this.txt_nhanvien);
            this.Controls.Add(this.txt_kh);
            this.Controls.Add(this.txt_trangchu_Nhat);
            this.Controls.Add(this.dtgrv_chitiet_Nguyen);
            this.Controls.Add(this.txt_close_nhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_chitiet_Nhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_chitiet_Nhat";
            this.Load += new System.EventHandler(this.frm_chitiet_Nhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_chitiet_Nguyen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox txt_close_nhat;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgrv_chitiet_Nguyen;
        private System.Windows.Forms.Label txt_trangchu_Nhat;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_kh;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_nhanvien;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_HD_Nhat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_ngaytra;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_ngaythue;
        private Bunifu.Framework.UI.BunifuCustomLabel txt_thanhtien;
    }
}