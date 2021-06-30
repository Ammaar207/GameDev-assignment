using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationalGame
{
    public partial class Splashscreen : Form
    {
        private int seconds;
        public Splashscreen()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(seconds == 5)
            {
                timer1.Stop();
                this.Close();

            }
        }
        private void Splashscreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
