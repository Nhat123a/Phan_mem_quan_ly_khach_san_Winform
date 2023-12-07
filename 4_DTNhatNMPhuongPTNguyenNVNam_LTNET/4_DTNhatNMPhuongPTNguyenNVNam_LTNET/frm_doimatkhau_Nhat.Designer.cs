
namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    partial class frm_doimatkhau_Nhat
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
            this.txt_trangchu_Nhat = new System.Windows.Forms.Label();
            this.txt_close_nhat = new FontAwesome.Sharp.IconPictureBox();
            this.btn_capnhat_Nhat = new FontAwesome.Sharp.IconButton();
            this.txt_matkhaumoi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_matkhaucu = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_taikhoan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_trangchu_Nhat
            // 
            this.txt_trangchu_Nhat.AutoSize = true;
            this.txt_trangchu_Nhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_trangchu_Nhat.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_trangchu_Nhat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_trangchu_Nhat.Location = new System.Drawing.Point(215, 21);
            this.txt_trangchu_Nhat.Name = "txt_trangchu_Nhat";
            this.txt_trangchu_Nhat.Size = new System.Drawing.Size(321, 54);
            this.txt_trangchu_Nhat.TabIndex = 5;
            this.txt_trangchu_Nhat.Text = "ĐỔI MẬT KHẨU";
            // 
            // txt_close_nhat
            // 
            this.txt_close_nhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
            this.txt_close_nhat.ForeColor = System.Drawing.Color.Red;
            this.txt_close_nhat.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.txt_close_nhat.IconColor = System.Drawing.Color.Red;
            this.txt_close_nhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txt_close_nhat.IconSize = 44;
            this.txt_close_nhat.Location = new System.Drawing.Point(745, 3);
            this.txt_close_nhat.Name = "txt_close_nhat";
            this.txt_close_nhat.Size = new System.Drawing.Size(47, 44);
            this.txt_close_nhat.TabIndex = 4;
            this.txt_close_nhat.TabStop = false;
            this.txt_close_nhat.Click += new System.EventHandler(this.txt_close_nhat_Click);
            // 
            // btn_capnhat_Nhat
            // 
            this.btn_capnhat_Nhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_capnhat_Nhat.FlatAppearance.BorderSize = 0;
            this.btn_capnhat_Nhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_capnhat_Nhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_capnhat_Nhat.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btn_capnhat_Nhat.IconColor = System.Drawing.Color.SeaGreen;
            this.btn_capnhat_Nhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_capnhat_Nhat.IconSize = 45;
            this.btn_capnhat_Nhat.Location = new System.Drawing.Point(256, 525);
            this.btn_capnhat_Nhat.Name = "btn_capnhat_Nhat";
            this.btn_capnhat_Nhat.Size = new System.Drawing.Size(239, 73);
            this.btn_capnhat_Nhat.TabIndex = 11;
            this.btn_capnhat_Nhat.Text = "ĐỔI MẬT KHẨU";
            this.btn_capnhat_Nhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_capnhat_Nhat.UseVisualStyleBackColor = false;
            this.btn_capnhat_Nhat.Click += new System.EventHandler(this.btn_capnhat_Nhat_Click);
            // 
            // txt_matkhaumoi
            // 
            this.txt_matkhaumoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhaumoi.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhaumoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_matkhaumoi.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_matkhaumoi.HintText = "Mật khẩu mới";
            this.txt_matkhaumoi.isPassword = true;
            this.txt_matkhaumoi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_matkhaumoi.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_matkhaumoi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_matkhaumoi.LineThickness = 1;
            this.txt_matkhaumoi.Location = new System.Drawing.Point(184, 395);
            this.txt_matkhaumoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.txt_matkhaumoi.Name = "txt_matkhaumoi";
            this.txt_matkhaumoi.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.txt_matkhaumoi.Size = new System.Drawing.Size(371, 76);
            this.txt_matkhaumoi.TabIndex = 13;
            this.txt_matkhaumoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_matkhaumoi.OnValueChanged += new System.EventHandler(this.txt_pass_Nam_OnValueChanged);
            // 
            // txt_matkhaucu
            // 
            this.txt_matkhaucu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhaucu.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhaucu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_matkhaucu.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_matkhaucu.HintText = "Mật khẩu cũ";
            this.txt_matkhaucu.isPassword = true;
            this.txt_matkhaucu.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_matkhaucu.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.txt_matkhaucu.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_matkhaucu.LineThickness = 1;
            this.txt_matkhaucu.Location = new System.Drawing.Point(184, 268);
            this.txt_matkhaucu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.txt_matkhaucu.Name = "txt_matkhaucu";
            this.txt_matkhaucu.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.txt_matkhaucu.Size = new System.Drawing.Size(371, 76);
            this.txt_matkhaucu.TabIndex = 14;
            this.txt_matkhaucu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_matkhaucu.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // btn_taikhoan
            // 
            this.btn_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn_taikhoan.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_taikhoan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.btn_taikhoan.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.btn_taikhoan.HintText = "Tài Khoản";
            this.btn_taikhoan.isPassword = false;
            this.btn_taikhoan.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btn_taikhoan.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.btn_taikhoan.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.btn_taikhoan.LineThickness = 1;
            this.btn_taikhoan.Location = new System.Drawing.Point(184, 147);
            this.btn_taikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.btn_taikhoan.Name = "btn_taikhoan";
            this.btn_taikhoan.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.btn_taikhoan.Size = new System.Drawing.Size(371, 76);
            this.btn_taikhoan.TabIndex = 15;
            this.btn_taikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frm_doimatkhau_Nhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(72)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(795, 625);
            this.Controls.Add(this.btn_taikhoan);
            this.Controls.Add(this.txt_matkhaucu);
            this.Controls.Add(this.txt_matkhaumoi);
            this.Controls.Add(this.btn_capnhat_Nhat);
            this.Controls.Add(this.txt_trangchu_Nhat);
            this.Controls.Add(this.txt_close_nhat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_doimatkhau_Nhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doimatkhau_Nhat";
            this.Load += new System.EventHandler(this.frm_doimatkhau_Nhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox txt_close_nhat;
        private System.Windows.Forms.Label txt_trangchu_Nhat;
        private FontAwesome.Sharp.IconButton btn_capnhat_Nhat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_matkhaumoi;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_matkhaucu;
        private Bunifu.Framework.UI.BunifuMaterialTextbox btn_taikhoan;
    }
}