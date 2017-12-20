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
        
        public Password()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form F1 = new Load();
            F1.Show();
            string pas = "OOP";
            if (textBox1.Text == pas)
            {
                Hide();
                F1.Show();
            }
            else
                MessageBox.Show("Wrong password! Error");
        }

        private void Password_Load(object sender, EventArgs e)
        {
        }
    }
}
            
            
      
