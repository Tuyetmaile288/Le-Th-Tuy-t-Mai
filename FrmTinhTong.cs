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
    public partial class FrmTinhTong : Form
    {
        public FrmTinhTong()
        {
            InitializeComponent();
        }

        private void FrmTinhTong_Load(object sender, EventArgs e)
        {

        }

        private void txtA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
          (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
          || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;

        }

        private void txtB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
          (e.KeyChar == '-') || (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8)
          || (Convert.ToInt32(e.KeyChar) == 13))

                e.Handled = false;

            else e.Handled = true;

        }

        private void btnTong_Click(object sender, EventArgs e)
        {

            if (txtA.Text == "")
            {
                MessageBox.Show("Bạn chua nhap so b");
                txtA.Focus();
                return;
            }
            if (txtB.Text == "")
            {
                MessageBox.Show("ban chua nhap so b");
                txtB.Focus();
                return;
            }
            double tong = 0 ;
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
          


            if (a <= b)
            {
                for (double i = a; i <= b; i++)
                    tong += i;

            }
            if (a > b)
            {
                for (double i = b; i <= a; i++)
                    tong += i;
            }
            label2.Text = a.ToString();
            label4.Text = b.ToString();

            label5.Text = tong.ToString();

        }
      

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            //A.Text = "";
            //B.Text = "";
            lbTongday.Text = "";

        }

       

    }
}

