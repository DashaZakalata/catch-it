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
    public partial class Password : Form
    {
        private readonly Timer timer0;
        public Password()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            string pas = "213";
            if (textBox1.Text == pas)
            {
                Hide();
                Form F1 = new Load();
                F1.Show();
            }
            else MessageBox.Show(" Wrong password! error");
        }

        private void Password_Load(object sender, EventArgs e)
        {

        }
    }
}
            
            
      
