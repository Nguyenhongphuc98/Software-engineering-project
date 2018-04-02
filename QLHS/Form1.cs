using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void bntDangNhap_Click(object sender, EventArgs e)
        {
            FMain f = new FMain();
            this.Hide();
            f.ShowDialog();
            this.ShowDialog();
        }
    }
}
