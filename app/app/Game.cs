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
    public partial class Game : Form
    {
        
        private readonly Timer updateTimer;
        private readonly Timer iconTimer;
        private int score = 0;


        public Game()
        {

            updateTimer = new Timer();
            updateTimer.Interval = 700; //переодичность, частота 150мсек
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Enabled = true;
            iconTimer = new Timer();
            iconTimer.Interval = 1200; //для генерации чисел изменения положения иконок
            iconTimer.Tick += iconTimer_Tick;
            iconTimer.Enabled = true;
            InitializeComponent();
            player.Focus(); //можем с ним шото делать
            DoubleBuffered = true; //убирает мелькание

        }


        public void dropIcon(Point[] start, PictureBox[] Icon)
        {
            Random tic = new Random();
            int rand = tic.Next(0, 1);

            int[] checkArr = new int[1]; //генерация разных значений
            for (int i = 0; i < start.Length; i++)
            {
                //checkArr[i] = rand;
                Icon[i].Location = start[rand];

            }
        }

        public void down(PictureBox[] icon) //движение иконки вниз
        {
            for (int i = 0; i < icon.Length; i++)
            {
                icon[i].Location = new Point(icon[i].Location.X, icon[i].Location.Y + 30);
            }
        }
        private void calcScore_Tick(object sender, EventArgs e)
        {
            
        }
        private void iconTimer_Tick(object sender, EventArgs e) //для генерации чисел в изменении положений иконок по оси Х
        {
            Random gen = new Random();
            int x;
            x = gen.Next(1, 5);
            PictureBox[] Icon = new PictureBox[] { Icon1, Icon2, Icon3, Icon4, Icon5 };
            up(Icon, x);
            for (int i = 0; i < Icon.Length; i++) // цикл для скрытия иконок при соприкосновении с человечком
            {
                if ((player.Location.Y - 50) < (Icon[i].Location.Y + 60) & (Icon[i].Location.Y + 60) < (player.Location.Y + 40) & player.Location.X < (Icon[i].Location.X + 60) & (Icon[i].Location.X + 60) < (player.Location.X + 146))
                {
                    Icon[i].Hide();//иконка скрывается при соприкосновении с человечком
                    score += 10;
                    TextBox.Text = score.ToString(); // cчитаются и выводятся очки

                }
                else if (player.Location.Y < (Icon[i].Location.Y + 85) & ((player.Location.X + 146) < Icon[i].Location.X | Icon[i].Location.X < player.Location.X))
                {
                    Icon[i].Hide();//иконка скрывается при падении мимо
                    score -= 10;
                    TextBox.Text = score.ToString(); // при промахе отнимаются очки 

                }
                if (score <= -30 | score >= 100)
                {
                    updateTimer.Stop();
                    iconTimer.Stop();
                }
                
                  
            }
            if (score <= -30)
            {
                Hide();
                MessageBox.Show("You are lose the game");

                Form F = new Exit();
                F.Show();
            }
            if (score >= 100)
            {
                Hide();
                MessageBox.Show("Congratulation! You are winner.");

                Form F = new Exit();
                F.Show();
            }
        }



        public void up(PictureBox[] icon, int x) //появление иконки еще раз (изменение координат)
        {
            for (int i = 0, c = 50; i < icon.Length & c < 600; i++, c += 80)
            {

                if (icon[i].Location.Y > 200)
                {

                    icon[i].Hide();

                    if (x == 1)  icon[i].Location = new Point(10 + c, -90 - c);
                                     
                    else if (x == 2) icon[i].Location = new Point(100 + c, -140 - c);
                                           
                    else if (x == 3) icon[i].Location = new Point(230 + c, -180 - c);
                   
                    else if (x == 4) icon[i].Location = new Point(300 + c, -220 - c);
                     
                    else  icon[i].Location = new Point(340 + c, -50 - c);
                
                    icon[i].Show();

                }
            }

        }

        private void UpdateTimer_Tick(object sender, EventArgs e)
        {

            PictureBox[] Icon = new PictureBox[] { Icon1, Icon2, Icon3, Icon4, Icon5 };
            down(Icon);

        }



        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            switch (keyData)
            {
                case Keys.Left:
                    {
                        if (player.Location.X < -10) player.Left = -10;
                        player.Left -= 10; }
                     break;
                case Keys.Right:
                    {
                        if (player.Location.X >500) player.Left = 500;
                        player.Left += 10;
                    }
                    break;
                default: return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iconTimer.Stop();
            updateTimer.Stop();
            Hide();
            Form F1 = new pusk();
            F1.Show();
        }


     
    }


  

}




       

        
    

