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
    public partial class frm_succes_nhat : Form
    {
        public frm_succes_nhat( string title,string message)
        {
            InitializeComponent();
            label1.Text = title;
            txt_mes_Nhat.Text = message;
            
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_succes_nhat_Load(object sender, EventArgs e)
        {
            iconPictureBox1.BackColor = Color.Transparent;
            Top = 900;
            Left = Screen.PrimaryScreen.Bounds.Width - Width - 20;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
