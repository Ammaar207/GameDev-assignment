using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanguageGame
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 40;

            if (panel2.Width >= 800)
            {
                timer1.Stop();
                HomeMenu HM = new HomeMenu();
                HM.Show();
                this.Hide();
            }
        }
    }
}
