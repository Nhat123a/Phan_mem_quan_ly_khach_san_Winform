using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4_DTNhatNMPhuongPTNguyenNVNam_LTNET
{
    public partial class frm_Baocao_Nhat : Form
    {
        public frm_Baocao_Nhat()
        {
            InitializeComponent();
        }

        private void frm_Baocao_Nhat_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'khachsannetDataSet3.View_Baocao' table. You can move, or remove it, as needed.
            this.View_BaocaoTableAdapter.Fill(this.khachsannetDataSet3.View_Baocao);

            this.rv_baocao1.RefreshReport();
        }

        private void rv_baocao1_Load(object sender, EventArgs e)
        {
            rv_baocao1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            rv_baocao1.SetDisplayMode(DisplayMode.PrintLayout);
            rv_baocao1.ZoomMode = ZoomMode.Percent;
            rv_baocao1.ZoomPercent = 100;
            rv_baocao1.RefreshReport();

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
