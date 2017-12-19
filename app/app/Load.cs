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

            /*Timer timer0 = new Timer();
           

            Form F = new Game();
            Form F1 = new Load();
            F1.Load += delegate (object s, EventArgs e) {
                timer0.Interval = 5000; //время ожидания
                timer0.Tick += new EventHandler(delegate (object _s, EventArgs _e) {
                    timer0.Stop();
                    //здесь обработка полей формы
                    F1.Visible=false;
                });
                timer0.Start();
            };

            F.ShowDialog();


            /*timer0.Tick += new EventHandler(timer0_Tick); //через 5 сек генерируется событие, обработчик t_Tick

            delegate (object _s, EventArgs _e) {
                timer.Stop();
                //здесь обработка полей формы
                form.Close();
            });
            timer.Start();
        };*/

            
        }

       /* void timer0_Tick(object sender, EventArgs e) // тут просто закрываю форму 
        {
            Hide();
            Form F = new Game();
            F.Show();
            

        }*/


        private void next_Click(object sender, EventArgs e)
        {
            Hide();
            Form F = new Game();
            F.Show();
        }
    }
}
    


