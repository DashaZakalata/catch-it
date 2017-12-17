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
                updateTimer.Interval = 1000; //переодичность, частота 150мсек
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
            PictureBox[] Icon = new PictureBox[] { Icon1, Icon2, Icon3, Icon4, Icon5 };
            up(Icon, x);
            for (int i = 0; i < Icon.Length; i++) // цикл для скрытия иконок при соприкосновении с человечком
            {
                if ((player.Location.Y - 50) < (Icon[i].Location.Y + 60) & (Icon[i].Location.Y + 60) < (player.Location.Y + 20) & player.Location.X < (Icon[i].Location.X + 60) & (Icon[i].Location.X + 60) < (player.Location.X + 146))
                {
                    Icon[i].Hide(); //иконка скрывается при соприкосновении с человечком
                }
            }
                
        }

        public void up(PictureBox[] icon, int x) //появление иконки еще раз (изменение координат)
        {
            for (int i = 0, c = 50; i < icon.Length & c < 600; i++, c+=80)
            {

                if (icon[i].Location.Y > 300)
                {
                    if (x == 1)  icon[i].Location = new Point(10 + c, -40);
                                     
                    else if (x == 2) icon[i].Location = new Point(100 + c, -40);
                                           
                    else if (x == 3) icon[i].Location = new Point(230 + c, -40);
                   
                    else if (x == 4) icon[i].Location = new Point(300 + c, -40);
                     
                    else  icon[i].Location = new Point(370 + c, -40);
                
                    icon[i].Show();
                    
                }
             
            }
          
        }
       
        private void UpdateTimer_Tick(object sender, EventArgs e)
            {
             /*   Point start1 = new Point(100, 0);
                Point start2 = new Point(200, -40);
                Point start3 = new Point(270, -100);
                Point start4 = new Point(340, 0);
                Point start5 = new Point(400, -70);
            Point[] start = new Point[] { start1, start2, start3, start4, start5 }; //количество позиций
            */
                PictureBox[] Icon = new PictureBox[] { Icon1, Icon2, Icon3, Icon4, Icon5 };           
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



