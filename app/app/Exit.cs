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
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) //exst
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e) //pusk
        {
            Hide();
            Form F1 = new pusk();
            F1.Show();
        }

        private void button3_Click(object sender, EventArgs e)//restart
        {
            Hide();
            Form F1 = new Game();
            F1.Show();
        }
    }
}
