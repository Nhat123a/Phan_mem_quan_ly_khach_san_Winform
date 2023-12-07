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
    public partial class frm_gioithieu_Nguyen : Form
    {
        public frm_gioithieu_Nguyen()
        {
            InitializeComponent();
        }

        
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Dangnhap_Nam frm = new frm_Dangnhap_Nam();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
