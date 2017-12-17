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
        public partial class Form1 : Form
        {
            private readonly Timer updateTimer;
            private readonly Timer iconTimer;

        public Form1()
            {
                updateTimer = new Timer();
                updateTimer.Interval = 500; //переодичность, частота 150мсек
                updateTimer.Tick += UpdateTimer_Tick;
                updateTimer.Enabled = true;
                iconTimer = new Timer();
                iconTimer.Interval = 500; //для генерации чисел изменения положения иконок
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

        private void iconTimer_Tick(object sender, EventArgs e) //для генерации чисел в изменении положений иконок по оси Х
        {
            Random gen = new Random(); 
            int x;
            x = gen.Next(1, 5);
            Random col = new Random(); 
            int r;
            r = col.Next(50, 100);
            PictureBox[] Icon = new PictureBox[] { Icon1, Icon2 };
            up(Icon, x, r);
            for (int i = 0; i < Icon.Length; i++) // цикл для скрытия иконок при соприкосновении с человечком
            {
                if ((player.Location.Y - 50) < (Icon[i].Location.Y + 60) & (Icon[i].Location.Y + 60) < (player.Location.Y + 141) & player.Location.X < (Icon[i].Location.X + 60) & (Icon[i].Location.X + 60) < (player.Location.X + 146))
                {
                    Icon[i].Hide(); //иконка скрывается при соприкосновении с человечком
                }
            }
                
        }

        public void up(PictureBox[] icon, int x, int r) //появление иконки еще раз (изменение координат)
        {
            for (int i = 0; i < icon.Length; i++)
            {
                if (icon[i].Location.Y > 300)
                {
                    if (x == 1)
                    {
                        icon[i].Location = new Point(50 + r, -40);
                        icon[i].Show();
                    }
                            
                        else if (x == 2)
                    {
                        icon[i].Location = new Point(150 + r, -40);
                        icon[i].Show();
                    }
                            
                        else if (x == 3)
                    {
                        icon[i].Location = new Point(250 + r, -40);
                        icon[i].Show();
                    }
                            
                        else if (x == 4)
                    {
                        icon[i].Location = new Point(350 + r, -40);
                        icon[i].Show();
                    }
                            
                        else {
                        icon[i].Location = new Point(400 + r, -40);
                        icon[i].Show();
                    }
                
                }
             
            }
        }
       
        private void UpdateTimer_Tick(object sender, EventArgs e)
            {
               Point start1 = new Point(200, 0);
                Point start2 = new Point(300, -100);
                Point[] start = new Point[] { start1, start2 }; //количество позиций

                PictureBox[] Icon = new PictureBox[] { Icon1, Icon2 };           
                down(Icon);
            

        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Left: player.Left -= 10; break;
                case Keys.Right: player.Left += 10; break;
                
                default: return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }

        private void Icon1_Click(object sender, EventArgs e)
        {

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
    }



