using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app
{
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
            Opacity = 0;
            Timer timer = new Timer();
            timer.Tick += new EventHandler((sender, e) =>
            {
                if ((Opacity += 0.05d) == 1) timer.Stop();
            });
            timer.Interval = 100;
            timer.Start();

           
            }

        private void next_Click(object sender, EventArgs e)
        {
            Hide();
            Form F = new pusk();
            F.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
    


