using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum2_if_else_kullanımı1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            if (cbMavi.Checked)
            {

                lblYaz.Text = "mavi yapıldı";
            }
        }
    }
}
