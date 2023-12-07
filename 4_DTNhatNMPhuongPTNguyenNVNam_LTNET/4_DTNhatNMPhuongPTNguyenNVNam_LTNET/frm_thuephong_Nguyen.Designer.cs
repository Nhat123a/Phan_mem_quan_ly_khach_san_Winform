
namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    partial class frm_thuephong_Nguyen
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgrv_hoadon_Nhat = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuProgressBar2 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.btn_thuephong_Nhat = new FontAwesome.Sharp.IconButton();
            this.btn_dichvu_Nhat = new FontAwesome.Sharp.IconButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_hoadon_Nhat)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1145, 430);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgrv_hoadon_Nhat);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(12, 448);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1377, 282);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dtgrv_hoadon_Nhat
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dtgrv_hoadon_Nhat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgrv_hoadon_Nhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgrv_hoadon_Nhat.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgrv_hoadon_Nhat.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dtgrv_hoadon_Nhat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgrv_hoadon_Nhat.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgrv_hoadon_Nhat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaShell;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv_hoadon_Nhat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgrv_hoadon_Nhat.ColumnHeadersHeight = 45;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgrv_hoadon_Nhat.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgrv_hoadon_Nhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgrv_hoadon_Nhat.DoubleBuffered = true;
            this.dtgrv_hoadon_Nhat.EnableHeadersVisualStyles = false;
            this.dtgrv_hoadon_Nhat.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtgrv_hoadon_Nhat.HeaderForeColor = System.Drawing.Color.SeaShell;
            this.dtgrv_hoadon_Nhat.Location = new System.Drawing.Point(3, 33);
            this.dtgrv_hoadon_Nhat.MultiSelect = false;
            this.dtgrv_hoadon_Nhat.Name = "dtgrv_hoadon_Nhat";
            this.dtgrv_hoadon_Nhat.ReadOnly = true;
            this.dtgrv_hoadon_Nhat.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgrv_hoadon_Nhat.RowHeadersVisible = false;
            this.dtgrv_hoadon_Nhat.RowHeadersWidth = 70;
            this.dtgrv_hoadon_Nhat.RowTemplate.Height = 28;
            this.dtgrv_hoadon_Nhat.Size = new System.Drawing.Size(1371, 246);
            this.dtgrv_hoadon_Nhat.TabIndex = 1;
            this.dtgrv_hoadon_Nhat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgrv_hoadon_Nhat_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.bunifuProgressBar2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.bunifuProgressBar1);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(1196, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(207, 220);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chú thích";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 29);
            this.label2.TabIndex = 7;
            this.label2.Text = "Phòng đã thuê";
            // 
            // bunifuProgressBar2
            // 
            this.bunifuProgressBar2.BackColor = System.Drawing.Color.Red;
            this.bunifuProgressBar2.BorderRadius = 5;
            this.bunifuProgressBar2.Location = new System.Drawing.Point(23, 150);
            this.bunifuProgressBar2.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.bunifuProgressBar2.MaximumValue = 100;
            this.bunifuProgressBar2.Name = "bunifuProgressBar2";
            this.bunifuProgressBar2.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuProgressBar2.Size = new System.Drawing.Size(137, 25);
            this.bunifuProgressBar2.TabIndex = 6;
            this.bunifuProgressBar2.Value = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Phòng trống";
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(23, 79);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.SeaGreen;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(137, 22);
            this.bunifuProgressBar1.TabIndex = 4;
            this.bunifuProgressBar1.Value = 0;
            // 
            // btn_thuephong_Nhat
            // 
            this.btn_thuephong_Nhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_thuephong_Nhat.FlatAppearance.BorderSize = 0;
            this.btn_thuephong_Nhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thuephong_Nhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thuephong_Nhat.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_thuephong_Nhat.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btn_thuephong_Nhat.IconColor = System.Drawing.Color.SeaGreen;
            this.btn_thuephong_Nhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_thuephong_Nhat.IconSize = 45;
            this.btn_thuephong_Nhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_thuephong_Nhat.Location = new System.Drawing.Point(1196, 279);
            this.btn_thuephong_Nhat.Name = "btn_thuephong_Nhat";
            this.btn_thuephong_Nhat.Size = new System.Drawing.Size(193, 66);
            this.btn_thuephong_Nhat.TabIndex = 13;
            this.btn_thuephong_Nhat.Text = "Thuê Phòng";
            this.btn_thuephong_Nhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_thuephong_Nhat.UseVisualStyleBackColor = false;
            this.btn_thuephong_Nhat.Click += new System.EventHandler(this.btn_thuephong_Nhat_Click);
            // 
            // btn_dichvu_Nhat
            // 
            this.btn_dichvu_Nhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btn_dichvu_Nhat.FlatAppearance.BorderSize = 0;
            this.btn_dichvu_Nhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dichvu_Nhat.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dichvu_Nhat.ForeColor = System.Drawing.Color.DimGray;
            this.btn_dichvu_Nhat.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            this.btn_dichvu_Nhat.IconColor = System.Drawing.Color.SeaGreen;
            this.btn_dichvu_Nhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_dichvu_Nhat.IconSize = 45;
            this.btn_dichvu_Nhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dichvu_Nhat.Location = new System.Drawing.Point(1196, 373);
            this.btn_dichvu_Nhat.Name = "btn_dichvu_Nhat";
            this.btn_dichvu_Nhat.Size = new System.Drawing.Size(193, 66);
            this.btn_dichvu_Nhat.TabIndex = 14;
            this.btn_dichvu_Nhat.Text = "Dịch vụ";
            this.btn_dichvu_Nhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dichvu_Nhat.UseVisualStyleBackColor = false;
            this.btn_dichvu_Nhat.Click += new System.EventHandler(this.btn_dichvu_Nhat_Click);
            // 
            // frm_thuephong_Nguyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.ClientSize = new System.Drawing.Size(1415, 742);
            this.Controls.Add(this.btn_dichvu_Nhat);
            this.Controls.Add(this.btn_thuephong_Nhat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_thuephong_Nguyen";
            this.Text = "frm_thuephong_Nguyen";
            this.Load += new System.EventHandler(this.frm_thuephong_Nguyen_Load_1);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrv_hoadon_Nhat)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtgrv_hoadon_Nhat;
        private FontAwesome.Sharp.IconButton btn_thuephong_Nhat;
        private FontAwesome.Sharp.IconButton btn_dichvu_Nhat;
    }
}