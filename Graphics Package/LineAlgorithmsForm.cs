using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Package
{
    public partial class LineAlgorithmsForm : Form
    {

        public int getX1()
        {
            return Int32.Parse(point_x1.Text); 
        }
        public int getX2()
        {
            return Int32.Parse(point_x2.Text);
        }
        public int getY1()
        {
            return Int32.Parse(point_y1.Text);
        }
        public int getY2()
        {
            return Int32.Parse(point_y2.Text);
        }

        private void setPixel(Graphics graphics, int x, int y, Color color)
        {
            Brush brushColor = new SolidBrush(color);
            graphics.FillRectangle(brushColor, x, y, 2, 2);
        }

        public LineAlgorithmsForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel_DDA.CreateGraphics();
            drawLine_DDA(getX1(), getY1(), getX2(), getY2(), graphics, Color.Blue);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel_Bresenham.CreateGraphics();
            drawLine_BRESENHAM(getX1(), getY1(), getX2(), getY2(), graphics, Color.Red);
        }

        private void panel_DDA_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void panel_Bresenham_Paint(object sender, PaintEventArgs e)
        {

        }

        

        // Method For Draw Line Using DDA
        private void drawLine_DDA(int x1, int y1, int x2, int y2, Graphics graphics, Color color)
        {
            int steps;
            int dx = x2 - x1, dy = y2 - y1;
            float xIncrement, x;
            float yIncrement, y;

            x = (float)x1;
            y = (float)y1;

            steps = Math.Abs(dx) > Math.Abs(dy) ? Math.Abs(dx) : Math.Abs(dy);

            xIncrement = (float)dx / (float)steps;
            yIncrement = (float)dy / (float)steps;

            textBox1.Text = "";
            do
            {
                textBox1.Text = textBox1.Text + "(" + ((int)Math.Round(x)).ToString() + " , " + ((int)Math.Round(y)).ToString() + ")      ";
                setPixel(graphics, (int)Math.Round(x), (int)Math.Round(y), color);
                x += xIncrement;
                y += yIncrement;
                steps--;
            } while (steps >= 0);
        }

        // Method For Draw Line Using Bresenham

        private void drawLine_BRESENHAM(int x1, int y1, int x2, int y2, Graphics graphics, Color color) 
        {
            textBox2.Text = "";
            float dx, dy, p;
            dx = (x2 - x1);
            dy = (y2 - y1);

            float slope = dy / dx;

            if(x1 < x2 && slope >= 0 && slope <= 1)         // First Ocstant
            {
                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Frst Ocstant\n ";
                for(int i = x1; i <= x2; i++)
                {
                    textBox2.Text +=  "(X:" + X.ToString() + " , Y:" + Y.ToString() + ", P: " + p + " )      ";
                    if(p < 0)
                    {
                        setPixel(graphics, ++X, Y, color);
                        p += (2 * dy);
                    } else
                    {
                        setPixel(graphics, ++X, ++Y, color);
                        p += (2 * dy) - (2 * dx);
                    }
                }
            }

            else if(y1 < y2 && slope > 1 && slope < 999999)         // Second Ocstant
            {
                swap(ref x1, ref y1, ref x2, ref y2);
                dx = Math.Abs(x2) - Math.Abs(x1);
                dy = Math.Abs(y2) - Math.Abs(y1);
                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Second Ocstant\n";
                for (int i = x1; i <= x2; i++)
                {
                    textBox2.Text = textBox2.Text + "(Y:" + Y.ToString() + " , X:" + X.ToString() + ", P: " + p + " )      ";
                    if(p < 0)
                    {
                        setPixel(graphics, Y, ++X, color);
                        p += (2 * dy);
                    } else
                    {
                        setPixel(graphics, ++Y, ++X, color);
                        p += (2 * dy) - (2 * dx);
                    }
                }
            }

            else if (y1 < y2 && slope < -1 && slope > -999999)            // Third Ocstant
            {
                swap(ref x1, ref y1, ref x2, ref y2);
                dx = Math.Abs(x2) - Math.Abs(x1);
                dy = Math.Abs(y2) - Math.Abs(y1);
                dy = -dy;
                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Third Ocstant\n";
                for (int i = x1; i <= x2; i++)
                {
                    textBox2.Text = textBox2.Text + "(Y:" + Y.ToString() + " , X:" + X.ToString() + ", P: " + p + " )      ";
                    if(p < 0)
                    {
                        setPixel(graphics, Y, ++X, color);
                        p += (2 * dy);
                    } else
                    {
                        setPixel(graphics, --Y, ++X, color);
                        p += (2 * dy) - (2 * dx);
                    }
                }
            }
            

            else if(x1 > x2 && slope <= 0 && slope >= -1)       // Fourth Ocstant
            {
                dx = -dx;
                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Fourth Ocstant\n";
                for (int i = x2; i <= x1; i++)
                {
                    textBox2.Text = textBox2.Text + "(X:" + X.ToString() + " , Y:" + Y.ToString() + ", P: " + p + " )      ";
                    if (p < 0)
                    {
                        setPixel(graphics, --X, Y, color);
                        p += (2 * dy);
                    } else
                    {
                        setPixel(graphics, --X, ++Y, color);
                        p += (2 * dy) - (2 * dx);
                    }

                }
            }

            else if(x1 > x2 && slope > 0 && slope <= 1)         // Fifth Ocstant
            {
                dx = -dx; dy = -dy;
                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Fifth Ocstant\n";
                for (int i = x2; i <= x1; i++)
                {
                    textBox2.Text = textBox2.Text + "(X:" + X.ToString() + " , Y:" + Y.ToString() + ", P: " + p + " )      ";
                    if(p < 0)
                    {
                        setPixel(graphics, --X, Y, color);
                        p += (2 * dy);
                    } else
                    {
                        setPixel(graphics, --X, --Y, color);
                        p += (2 * dy) - (2 * dx);
                    }
                }
            }

            else if (y1 > y2 && slope > 1 && slope < 999999)        // Sixth Ocstant
            {
                // Swap x1 and y1 ,,, Swap x2 and y2
                swap(ref x1, ref y1, ref x2, ref y2);

                dx = Math.Abs(x2) - Math.Abs(x1);
                dy = Math.Abs(y2) - Math.Abs(y1);
                dx = -dx; dy = -dy;

                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Sixth Ocstant\n";
                for (int i = x2; i <= x1; i++)
                {
                    textBox2.Text = textBox2.Text + "(Y:" + Y.ToString() + " , X:" + X.ToString() + ", P: " + p + " )      ";
                    if (p < 0)
                    {
                        setPixel(graphics, Y, --X, color);
                        p += (2 * dy);
                    }
                    else
                    {
                        setPixel(graphics, --Y, --X, color);
                        p += (2 * dy) - (2 * dx);
                    }
                }
            }

            else if(y1 > y2 && slope < -1 && slope < 999999)        // Seventh Ocstant
            {
                swap(ref x1, ref y1, ref x2, ref y2);

                dx = x2 - x1;
                dy = Math.Abs(y2) - Math.Abs(y1);
                dx = -dx;
                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Seventh Ocstant\n";
                for (int i = x2; i <= x1; i++)
                {
                    textBox2.Text = textBox2.Text + "(Y:" + Y.ToString() + " , X:" + X.ToString() + ", P: " + p + " )      ";
                    if(p < 0)
                    {
                        setPixel(graphics, Y, --X, color);
                        p += (2 * dy);
                    } else
                    {
                        setPixel(graphics, ++Y, --X, color);
                        p += (2 * dy) - (2 * dx);
                    }
                }
            }
            else if(x1 < x2 && slope <= 0 && slope >= -1)               // Eighth Ocstant
            {
                dy = -dy;
                p = (2 * dy) - dx;
                setPixel(graphics, x1, y1, color);
                int X = x1, Y = y1;
                textBox2.Text = "Eighth Ocstant\n";
                for (int i = x1; i <= x2; i++)
                {
                    textBox2.Text = textBox2.Text + "(X:" + X.ToString() + " , Y:" + Y.ToString() + ", P: " + p + " )      ";
                    if(p < 0)
                    {
                        setPixel(graphics, ++X, Y, color);
                        p += (2 * dy);
                    } else
                    {
                        setPixel(graphics, ++X, --Y, color);
                        p += (2 * dy) - (2 * dx);
                    }
                }
            }

        }
        private void swap(ref int x1, ref int y1, ref int x2, ref int y2)
        {
            int tempX1, tempX2;
            tempX1 = x1;
            x1 = y1;
            y1 = tempX1;

            tempX2 = x2;
            x2 = y2;
            y2 = tempX2;
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void point_x1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
