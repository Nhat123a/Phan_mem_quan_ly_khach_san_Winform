
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    partial class frm_Dangnhap_Nam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dangnhap_Nam));
            this.btn_dangnhap_Nam = new System.Windows.Forms.Button();
            this.pain_login = new System.Windows.Forms.Panel();
            this.pc_pass_Nguyen = new FontAwesome.Sharp.IconPictureBox();
            this.pc_user_Nguyen = new FontAwesome.Sharp.IconPictureBox();
            this.txt_pass_Nam = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_user_Nam = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btn_close_Nguyen = new FontAwesome.Sharp.IconPictureBox();
            this.lb_nhom_Phuong = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_ql_Phuong = new System.Windows.Forms.Label();
            this.lb_phanmem_phuong = new System.Windows.Forms.Label();
            this.pain_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pc_pass_Nguyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_user_Nguyen)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_Nguyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_dangnhap_Nam
            // 
            this.btn_dangnhap_Nam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(169)))), ((int)(((byte)(255)))));
            this.btn_dangnhap_Nam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dangnhap_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.btn_dangnhap_Nam.Location = new System.Drawing.Point(167, 611);
            this.btn_dangnhap_Nam.Name = "btn_dangnhap_Nam";
            this.btn_dangnhap_Nam.Size = new System.Drawing.Size(371, 66);
            this.btn_dangnhap_Nam.TabIndex = 5;
            this.btn_dangnhap_Nam.Text = "Đăng nhập";
            this.btn_dangnhap_Nam.UseVisualStyleBackColor = false;
            this.btn_dangnhap_Nam.Click += new System.EventHandler(this.btn_dangnhap_Nam_Click);
            // 
            // pain_login
            // 
            this.pain_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pain_login.Controls.Add(this.pc_pass_Nguyen);
            this.pain_login.Controls.Add(this.pc_user_Nguyen);
            this.pain_login.Controls.Add(this.txt_pass_Nam);
            this.pain_login.Controls.Add(this.txt_user_Nam);
            this.pain_login.Controls.Add(this.bunifuGradientPanel1);
            this.pain_login.Controls.Add(this.btn_dangnhap_Nam);
            this.pain_login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pain_login.Location = new System.Drawing.Point(0, 0);
            this.pain_login.Name = "pain_login";
            this.pain_login.Size = new System.Drawing.Size(688, 712);
            this.pain_login.TabIndex = 1;
            this.pain_login.Paint += new System.Windows.Forms.PaintEventHandler(this.pain_login_Paint);
            // 
            // pc_pass_Nguyen
            // 
            this.pc_pass_Nguyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pc_pass_Nguyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.pc_pass_Nguyen.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.pc_pass_Nguyen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.pc_pass_Nguyen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pc_pass_Nguyen.IconSize = 53;
            this.pc_pass_Nguyen.Location = new System.Drawing.Point(92, 470);
            this.pc_pass_Nguyen.Name = "pc_pass_Nguyen";
            this.pc_pass_Nguyen.Size = new System.Drawing.Size(53, 56);
            this.pc_pass_Nguyen.TabIndex = 10;
            this.pc_pass_Nguyen.TabStop = false;
            // 
            // pc_user_Nguyen
            // 
            this.pc_user_Nguyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.pc_user_Nguyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.pc_user_Nguyen.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.pc_user_Nguyen.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.pc_user_Nguyen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pc_user_Nguyen.IconSize = 53;
            this.pc_user_Nguyen.Location = new System.Drawing.Point(92, 358);
            this.pc_user_Nguyen.Name = "pc_user_Nguyen";
            this.pc_user_Nguyen.Size = new System.Drawing.Size(53, 56);
            this.pc_user_Nguyen.TabIndex = 9;
            this.pc_user_Nguyen.TabStop = false;
            // 
            // txt_pass_Nam
            // 
            this.txt_pass_Nam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_pass_Nam.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_pass_Nam.HintText = "Mật khẩu";
            this.txt_pass_Nam.isPassword = true;
            this.txt_pass_Nam.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_pass_Nam.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_pass_Nam.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_pass_Nam.LineThickness = 1;
            this.txt_pass_Nam.Location = new System.Drawing.Point(167, 460);
            this.txt_pass_Nam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 5);
            this.txt_pass_Nam.Name = "txt_pass_Nam";
            this.txt_pass_Nam.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.txt_pass_Nam.Size = new System.Drawing.Size(371, 76);
            this.txt_pass_Nam.TabIndex = 8;
            this.txt_pass_Nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_pass_Nam.OnValueChanged += new System.EventHandler(this.txt_pass_Nam_OnValueChanged);
            this.txt_pass_Nam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_pass_Nam_KeyDown);
            // 
            // txt_user_Nam
            // 
            this.txt_user_Nam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user_Nam.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_Nam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_user_Nam.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_user_Nam.HintText = "Tài khoản";
            this.txt_user_Nam.isPassword = false;
            this.txt_user_Nam.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_user_Nam.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_user_Nam.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.txt_user_Nam.LineThickness = 1;
            this.txt_user_Nam.Location = new System.Drawing.Point(167, 335);
            this.txt_user_Nam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 6);
            this.txt_user_Nam.Name = "txt_user_Nam";
            this.txt_user_Nam.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.txt_user_Nam.Size = new System.Drawing.Size(371, 85);
            this.txt_user_Nam.TabIndex = 7;
            this.txt_user_Nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_user_Nam.OnValueChanged += new System.EventHandler(this.txt_user_Nam_OnValueChanged);
            this.txt_user_Nam.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_user_Nam_KeyDown);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btn_close_Nguyen);
            this.bunifuGradientPanel1.Controls.Add(this.lb_nhom_Phuong);
            this.bunifuGradientPanel1.Controls.Add(this.pictureBox1);
            this.bunifuGradientPanel1.Controls.Add(this.lb_ql_Phuong);
            this.bunifuGradientPanel1.Controls.Add(this.lb_phanmem_phuong);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(228)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(688, 284);
            this.bunifuGradientPanel1.TabIndex = 6;
            // 
            // btn_close_Nguyen
            // 
            this.btn_close_Nguyen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(232)))));
            this.btn_close_Nguyen.ForeColor = System.Drawing.Color.Red;
            this.btn_close_Nguyen.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btn_close_Nguyen.IconColor = System.Drawing.Color.Red;
            this.btn_close_Nguyen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_close_Nguyen.IconSize = 52;
            this.btn_close_Nguyen.Location = new System.Drawing.Point(633, 3);
            this.btn_close_Nguyen.Name = "btn_close_Nguyen";
            this.btn_close_Nguyen.Size = new System.Drawing.Size(52, 56);
            this.btn_close_Nguyen.TabIndex = 4;
            this.btn_close_Nguyen.TabStop = false;
            this.btn_close_Nguyen.Click += new System.EventHandler(this.btn_close_Nguyen_Click);
            // 
            // lb_nhom_Phuong
            // 
            this.lb_nhom_Phuong.AutoSize = true;
            this.lb_nhom_Phuong.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nhom_Phuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.lb_nhom_Phuong.Location = new System.Drawing.Point(549, 204);
            this.lb_nhom_Phuong.Name = "lb_nhom_Phuong";
            this.lb_nhom_Phuong.Size = new System.Drawing.Size(103, 32);
            this.lb_nhom_Phuong.TabIndex = 3;
            this.lb_nhom_Phuong.Text = "Nhóm 4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lb_ql_Phuong
            // 
            this.lb_ql_Phuong.AutoSize = true;
            this.lb_ql_Phuong.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ql_Phuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.lb_ql_Phuong.Location = new System.Drawing.Point(215, 125);
            this.lb_ql_Phuong.Name = "lb_ql_Phuong";
            this.lb_ql_Phuong.Size = new System.Drawing.Size(437, 65);
            this.lb_ql_Phuong.TabIndex = 1;
            this.lb_ql_Phuong.Text = "Quản lý khách sạn";
            // 
            // lb_phanmem_phuong
            // 
            this.lb_phanmem_phuong.AutoSize = true;
            this.lb_phanmem_phuong.Font = new System.Drawing.Font("Segoe UI Semibold", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phanmem_phuong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(90)))), ((int)(((byte)(167)))));
            this.lb_phanmem_phuong.Location = new System.Drawing.Point(216, 65);
            this.lb_phanmem_phuong.Name = "lb_phanmem_phuong";
            this.lb_phanmem_phuong.Size = new System.Drawing.Size(239, 60);
            this.lb_phanmem_phuong.TabIndex = 0;
            this.lb_phanmem_phuong.Text = "Phần mềm";
            // 
            // frm_Dangnhap_Nam
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(688, 712);
            this.Controls.Add(this.pain_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Dangnhap_Nam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dangnhap_Nam";
            this.Load += new System.EventHandler(this.frm_Dangnhap_Nam_Load);
            this.pain_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pc_pass_Nguyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pc_user_Nguyen)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close_Nguyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btn_dangnhap_Nam;
        private Panel pain_login;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private PictureBox pictureBox1;
        private Label lb_ql_Phuong;
        private Label lb_phanmem_phuong;
        private Label lb_nhom_Phuong;
        private FontAwesome.Sharp.IconPictureBox btn_close_Nguyen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_user_Nam;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_pass_Nam;
        private FontAwesome.Sharp.IconPictureBox pc_user_Nguyen;
        private FontAwesome.Sharp.IconPictureBox pc_pass_Nguyen;
    }
}