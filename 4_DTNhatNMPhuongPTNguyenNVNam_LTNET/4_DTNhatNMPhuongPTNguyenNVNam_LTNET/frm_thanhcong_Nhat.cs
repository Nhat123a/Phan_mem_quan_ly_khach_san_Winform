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
    public partial class frm_thanhcong_Nhat : Form
    {
        public frm_thanhcong_Nhat(string title, string message)
        {

            InitializeComponent();
            label1.Text = title;
            txt_mes_Nhat.Text = message;
        }

        private void frm_thanhcong_Nhat_Load(object sender, EventArgs e)
        {
            Top = 900;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timer1.Start();
            iconPictureBox1.BackColor = Color.Transparent;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
