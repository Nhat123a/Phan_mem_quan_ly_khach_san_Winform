
namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    partial class frm_inhoadon_Nhat
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.view_hoadoanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rpv_hoadon = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_close_nhat = new FontAwesome.Sharp.IconPictureBox();
            this.khachsannetDataSet = new _4_DTNhatNMPhuongPTNguyenNVNam_LTNET.khachsannetDataSet();
            this.view_hoadoanTableAdapter = new _4_DTNhatNMPhuongPTNguyenNVNam_LTNET.khachsannetDataSetTableAdapters.view_hoadoanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.view_hoadoanBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsannetDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // view_hoadoanBindingSource
            // 
            this.view_hoadoanBindingSource.DataMember = "view_hoadoan";
            // 
            // rpv_hoadon
            // 
            reportDataSource1.Name = "view_hoadon";
            reportDataSource1.Value = this.view_hoadoanBindingSource;
            this.rpv_hoadon.LocalReport.DataSources.Add(reportDataSource1);
            this.rpv_hoadon.LocalReport.ReportEmbeddedResource = "_4_DTNhatNMPhuongPTNguyenNVNam_LTNET.view_hoadon.rdlc";
            this.rpv_hoadon.Location = new System.Drawing.Point(12, 50);
            this.rpv_hoadon.Name = "rpv_hoadon";
            this.rpv_hoadon.ServerReport.BearerToken = null;
            this.rpv_hoadon.Size = new System.Drawing.Size(913, 682);
            this.rpv_hoadon.TabIndex = 0;
            this.rpv_hoadon.Load += new System.EventHandler(this.rpv_hoadon_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.txt_close_nhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 44);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_close_nhat
            // 
            this.txt_close_nhat.BackColor = System.Drawing.Color.SeaGreen;
            this.txt_close_nhat.ForeColor = System.Drawing.Color.Red;
            this.txt_close_nhat.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.txt_close_nhat.IconColor = System.Drawing.Color.Red;
            this.txt_close_nhat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.txt_close_nhat.IconSize = 41;
            this.txt_close_nhat.Location = new System.Drawing.Point(888, 3);
            this.txt_close_nhat.Name = "txt_close_nhat";
            this.txt_close_nhat.Size = new System.Drawing.Size(41, 43);
            this.txt_close_nhat.TabIndex = 6;
            this.txt_close_nhat.TabStop = false;
            this.txt_close_nhat.Click += new System.EventHandler(this.txt_close_nhat_Click);
            // 
            // khachsannetDataSet
            // 
            this.khachsannetDataSet.DataSetName = "khachsannetDataSet";
            this.khachsannetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_hoadoanTableAdapter
            // 
            this.view_hoadoanTableAdapter.ClearBeforeFill = true;
            // 
            // frm_inhoadon_Nhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(944, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rpv_hoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_inhoadon_Nhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_inhoadon_Nhat";
            this.Load += new System.EventHandler(this.frm_inhoadon_Nhat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_hoadoanBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsannetDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpv_hoadon;
        private System.Windows.Forms.BindingSource view_hoadoanBindingSource;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox txt_close_nhat;
        private khachsannetDataSet khachsannetDataSet;
        private khachsannetDataSetTableAdapters.view_hoadoanTableAdapter view_hoadoanTableAdapter;
    }
}