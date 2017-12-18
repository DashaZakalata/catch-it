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

        private void Close(object sender, EventArgs e)
        {
            //Включение таймера
            timer0.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Задаем интервал для медленного исчезновения
            timer0.Interval = 3000;
            //Когдапроходит заданное время
            if (this.Opacity <= 0)
            {
                //Таймер останавливается
                timer0.Stop();
                //Форма закрывается
                this.Hide();
            }

            Form F = new Game();
            F.ShowDialog();
        }

        private void next_Click(object sender, EventArgs e)
        {
            Hide();
            Form F1 = new Game();
            F1.Show();
        }
    }
}

