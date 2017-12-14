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

            public Form1()
            {
                updateTimer = new Timer();
                updateTimer.Interval = 1000; //переодичность, частота 150мсек
                updateTimer.Tick += UpdateTimer_Tick;
                updateTimer.Enabled = true;
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
                    icon[i].Location = new Point(icon[i].Location.X, icon[i].Location.Y + 100);
                }
            }

            private void UpdateTimer_Tick(object sender, EventArgs e)
            {
                Point start1 = new Point(100, 0);
                Point start2 = new Point(200, 0);
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



