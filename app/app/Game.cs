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
        private int score = 10;

        public Game()
        {
<<<<<<< HEAD:app/app/Game.cs


            updateTimer = new Timer();
            updateTimer.Interval = 700; //переодичность, частота 150мсек
            updateTimer.Tick += UpdateTimer_Tick;
            updateTimer.Enabled = true;
            iconTimer = new Timer();
            iconTimer.Interval = 1800; //для генерации чисел изменения положения иконок
            iconTimer.Tick += iconTimer_Tick;
            iconTimer.Enabled = true;
            InitializeComponent();
            player.Focus(); //можем с ним шото делать
            DoubleBuffered = true; //убирает мелькание

=======
            private readonly Timer updateTimer;
            private readonly Timer iconTimer;
            private int score = 0;

        public Form1()
            {
                updateTimer = new Timer();
                updateTimer.Interval = 700; //переодичность, частота 150мсек
                updateTimer.Tick += UpdateTimer_Tick;
                updateTimer.Enabled = true;
                iconTimer = new Timer();
                iconTimer.Interval = 1600; //для генерации чисел изменения положения иконок
                iconTimer.Tick += iconTimer_Tick;
                iconTimer.Enabled = true;
                InitializeComponent();
                player.Focus(); //можем с ним шото делать
                DoubleBuffered = true; //убирает мелькание
            
>>>>>>> Anna:app/app/Form1.cs
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
               else if (player.Location.Y < (Icon[i].Location.Y + 80) & ((player.Location.X + 146) < Icon[i].Location.X | Icon[i].Location.X < player.Location.X))
                { 
                    Icon[i].Hide();//иконка скрывается при падении мимо
                    score -= 10;
                    TextBox.Text = score.ToString(); // при промахе отнимаются очки 
                    
                }
                if(score >= 100 | score <= -30)
                {
                    updateTimer.Stop();
                    iconTimer.Stop();
                }
<<<<<<< HEAD:app/app/Game.cs
=======
                
>>>>>>> Anna:app/app/Form1.cs

            }

        }

        public void up(PictureBox[] icon, int x) //появление иконки еще раз (изменение координат)
        {
            for (int i = 0, c = 50; i < icon.Length & c < 600; i++, c += 80)
            {

                if (icon[i].Location.Y > 200)
                {
<<<<<<< HEAD:app/app/Game.cs
                    if (x == 1) icon[i].Location = new Point(10 + c, -70);

                    else if (x == 2) icon[i].Location = new Point(100 + c, -70);

                    else if (x == 3) icon[i].Location = new Point(230 + c, -70);

                    else if (x == 4) icon[i].Location = new Point(300 + c, -70);

                    else icon[i].Location = new Point(370 + c, -70);

=======
                    icon[i].Hide();

                    if (x == 1)  icon[i].Location = new Point(10 + c, -90);
                                     
                    else if (x == 2) icon[i].Location = new Point(100 + c, -120);
                                           
                    else if (x == 3) icon[i].Location = new Point(230 + c, -140);
                   
                    else if (x == 4) icon[i].Location = new Point(300 + c, -160);
                     
                    else  icon[i].Location = new Point(370 + c, -180);
                
>>>>>>> Anna:app/app/Form1.cs
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
            Hide();
            Form F1 = new pusk();
            F1.Show();
        }


        /*  private void button1_Click(object sender, EventArgs e)
          {
              Hide();

              Form F1 = new Wstart();
              F1.Show();
          }*/

    }


   



    /*private void DrawImageRectRect(PaintEventArgs e) для перерисовки, что б не мигала картинка
{

// Create image.
Image newImage = Image.FromFile("SampImag.jpg"); 

// Create rectangle for displaying image.
Rectangle destRect = new Rectangle(100, 100, 450, 150);

// Create rectangle for source image.
Rectangle srcRect = new Rectangle(50, 50, 150, 150);
GraphicsUnit units = GraphicsUnit.Pixel;

// Draw image to screen.
e.Graphics.DrawImage(newImage, destRect, srcRect, units);
}*/

    //Boolean y = mainCar.Location.Y.Equals(point.Y); - сравнение когда ыконка попадет на человечка

}




       

        
    

