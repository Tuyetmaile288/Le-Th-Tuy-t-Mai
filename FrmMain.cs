using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chuong4_bt1_part1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void tinhTongToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTinhTong c1 = new FrmTinhTong();
            c1.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

       

    }
}
