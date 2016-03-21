using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIYX.yugioh.lifepointcounter
{
    public partial class MainCounterScreen : Form
    {
        public MainCounterScreen()
        {
            InitializeComponent();
        }

        private void MainCounterScreen_Load(object sender, EventArgs e)
        {
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        private void LifePointBar1_Click(object sender, EventArgs e)
        {
        }

        private void LifePointBar2_Click(object sender, EventArgs e)
        {
        }

        private void LifePointBar3_Click(object sender, EventArgs e)
        {
        }
    }
}
