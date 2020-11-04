using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsTask2
{
    public partial class Form1 : Form
    {

        Bitmap bitmap;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BrLine(int x1, int y1, int x2, int y2)
        {
            bitmap = new Bitmap(this.Width, this.Height);

            int addX, addY, dX, dY, err, es, el, x, y, slideX, slideY;
            dX = x2 - x1; dY = y2 - y1;
            x = x1; y = y1;

            if (dX > 0) { slideX = 1; }
            else if (dX < 0) { slideX = -1; }
            else { slideX = 0; }
            addX = slideX;

            if (dY > 0) slideY = 1;
            else if (dY < 0) slideY = -1;
            else slideY = 0;
            addY = slideY;

            dX = Math.Abs(dX);
            dY = Math.Abs(dY);

            if (dX > dY)
            {
                addY = 0;
                es = dY;
                el = dX;
            }
            else
            {
                addX = 0;
                es = dX;
                el = dY;
            }

            err = el / 2;
            bitmap.SetPixel(x, y, Color.Black);

            for (int i = 0; i < el; i++)
            {
                err -= es;
                if (err < 0)
                {
                    err += el;
                    x += slideX;
                    y += slideY;
                }
                else
                {
                    x += addX;
                    y += addY;
                }

                bitmap.SetPixel(x, y, Color.Black);
            }

            pictureBox1.Image = bitmap;
           

        }
        private void BrCircle(int x, int y, int R)
        {
            bitmap = new Bitmap(this.Width, this.Height);

            int outX = x, outY = y;
            x = 0; y = R;
            int delta = (1 - 2 * R);
            int err = 0;

            while (y >= 0)
            {
                bitmap.SetPixel(outX + x, outY + y, Color.Black);
                bitmap.SetPixel(outX + x, outY - y, Color.Black);
                bitmap.SetPixel(outX - x, outY + y, Color.Black);
                bitmap.SetPixel(outX - x, outY - y, Color.Black);

                err = 2 * (delta + y) - 1;

                if ((delta < 0) && (err <= 0))
                {
                    x += 1;
                    delta += (2 * x + 1);
                    continue;
                }
                err = 2 * (delta - x) - 1;
                if ((delta > 0) && (err > 0))
                {
                    y -= 1;
                    delta = delta + (1 - 2 * y);
                    continue;
                }
                x += 1;
                delta += (2 * (x - y));
                y -= 1;
            }
            


            pictureBox1.Image = bitmap;
        }



        private void DrawLineButton_Click(object sender,
            EventArgs e)
        {
            int x1 = Convert.ToInt32(TbLineX1.Text),
               x2 = Convert.ToInt32(TbLineX2.Text),
               y1 = Convert.ToInt32(TbLineY1.Text),
               y2 = Convert.ToInt32(TbLineY2.Text);


            BrLine(x1, y1, x2, y2);


        }

        private void DrawCircleBtn_Click(object sender, EventArgs e)
        {
            BrCircle(150, 150, 100);
        }
    }
}
