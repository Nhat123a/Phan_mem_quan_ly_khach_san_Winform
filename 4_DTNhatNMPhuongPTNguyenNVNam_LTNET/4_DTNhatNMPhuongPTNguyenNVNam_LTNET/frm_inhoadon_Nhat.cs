using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_inhoadon_Nhat : Form
    {
        Ketnoi cnn = new Ketnoi();
        private string MaHD;
        public frm_inhoadon_Nhat(string MaHD)
        {
            
            InitializeComponent();
            this.MaHD = MaHD;
        }

        private void frm_inhoadon_Nhat_Load(object sender, EventArgs e)
        {
            cnn.Ketnoicsdl();
            SqlDataAdapter da = new SqlDataAdapter("select * from view_hoadoan where MaHD ='"+MaHD+"'", cnn.conn);
            khachsannetDataSet ds = new khachsannetDataSet();
            da.Fill(ds, "view_hoadoan");
            ReportDataSource data = new ReportDataSource("view_hoadon",ds.Tables[0]);
            this.rpv_hoadon.LocalReport.DataSources.Clear();
            this.rpv_hoadon.LocalReport.DataSources.Add(data);
            // TODO: This line of code loads data into the 'qlkhachsanDataSet1.view_hoadoan' table. You can move, or remove it, as needed.
            this.view_hoadoanTableAdapter.Fill(this.khachsannetDataSet.view_hoadoan);
            rpv_hoadon.SetDisplayMode(DisplayMode.PrintLayout);
            rpv_hoadon.ZoomMode = ZoomMode.Percent;
            rpv_hoadon.ZoomPercent = 75;
            this.rpv_hoadon.RefreshReport();
        }

        private void rpv_hoadon_Load(object sender, EventArgs e)
        {

        }

        private void txt_close_nhat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
