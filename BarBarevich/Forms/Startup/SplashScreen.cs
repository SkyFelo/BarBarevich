using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarBarevich.Forms.Startup
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = Color.White;

            Timer timer = new Timer();
            timer.Interval = 12000; 
            timer.Tick += (s, e) =>
            {
                timer.Stop();
                this.Close();
            };
            timer.Start();
        }
    }
}
