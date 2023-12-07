
namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    partial class frm_Baocao_Nhat
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
            this.rv_baocao1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_close_nhat = new FontAwesome.Sharp.IconPictureBox();
            this.khachsannetDataSet3 = new _4_DTNhatNMPhuongPTNguyenNVNam_LTNET.khachsannetDataSet3();
            this.View_BaocaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.View_BaocaoTableAdapter = new _4_DTNhatNMPhuongPTNguyenNVNam_LTNET.khachsannetDataSet3TableAdapters.View_BaocaoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsannetDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_BaocaoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rv_baocao1
            // 
            this.rv_baocao1.AutoSize = true;
            this.rv_baocao1.DocumentMapWidth = 1;
            reportDataSource1.Name = "Baocao";
            reportDataSource1.Value = this.View_BaocaoBindingSource;
            this.rv_baocao1.LocalReport.DataSources.Add(reportDataSource1);
            this.rv_baocao1.LocalReport.ReportEmbeddedResource = "_4_DTNhatNMPhuongPTNguyenNVNam_LTNET.Baocao.rdlc";
            this.rv_baocao1.Location = new System.Drawing.Point(12, 54);
            this.rv_baocao1.Name = "rv_baocao1";
            this.rv_baocao1.ServerReport.BearerToken = null;
            this.rv_baocao1.Size = new System.Drawing.Size(1099, 759);
            this.rv_baocao1.TabIndex = 0;
            this.rv_baocao1.Load += new System.EventHandler(this.rv_baocao1_Load);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.txt_close_nhat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.SeaGreen;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 48);
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
            this.txt_close_nhat.Location = new System.Drawing.Point(1079, 2);
            this.txt_close_nhat.Name = "txt_close_nhat";
            this.txt_close_nhat.Size = new System.Drawing.Size(41, 43);
            this.txt_close_nhat.TabIndex = 5;
            this.txt_close_nhat.TabStop = false;
            this.txt_close_nhat.Click += new System.EventHandler(this.txt_close_nhat_Click);
            // 
            // khachsannetDataSet3
            // 
            this.khachsannetDataSet3.DataSetName = "khachsannetDataSet3";
            this.khachsannetDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // View_BaocaoBindingSource
            // 
            this.View_BaocaoBindingSource.DataMember = "View_Baocao";
            this.View_BaocaoBindingSource.DataSource = this.khachsannetDataSet3;
            // 
            // View_BaocaoTableAdapter
            // 
            this.View_BaocaoTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Baocao_Nhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1120, 825);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rv_baocao1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Baocao_Nhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_Baocao_Nhat_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_close_nhat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachsannetDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.View_BaocaoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rv_baocao1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox txt_close_nhat;
        private khachsannetDataSet3 khachsannetDataSet3;
        private System.Windows.Forms.BindingSource View_BaocaoBindingSource;
        private khachsannetDataSet3TableAdapters.View_BaocaoTableAdapter View_BaocaoTableAdapter;
    }
}