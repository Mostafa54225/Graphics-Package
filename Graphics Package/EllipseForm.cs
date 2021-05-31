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
    public partial class EllipseForm : Form
    {
        public EllipseForm()
        {
            InitializeComponent();
        }

        private void EllipseForm_Load(object sender, EventArgs e)
        {

        }


        public int Xcenter_TextChanged()
        {
            return Int32.Parse(Xcenter.Text);
        }

        public int Ycenter_TextChanged()
        {
            return Int32.Parse(Ycenter.Text);
        }

        public int Rx_TextChanged()
        {
            return Int32.Parse(Rx.Text);
        }

        public int Ry_TextChanged()
        {
            return Int32.Parse(Ry.Text);
        }

        private void Draw_Ellipse_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel_Ellipse.CreateGraphics();
            draw_Ellipse(Xcenter_TextChanged(), Ycenter_TextChanged(),
                Rx_TextChanged(), Ry_TextChanged(), graphics, Color.Red);
        }

        private void setPixel(Graphics graphics, int Xc, int Yc, Color color)
        {
            Brush brushColor = new SolidBrush(color);
            graphics.FillRectangle(brushColor, Xc, Yc, 2, 2);
        }

        private int Round(float a)
        {
            return (int)(a + 0.5);
        }
        private void draw_Ellipse(int Xcenter, int Ycenter, int Rx, int Ry, Graphics graphics, Color color)
        {
            int Rx2 = Rx * Rx;
            int Ry2 = Ry * Ry;
            int TwoRx2 = 2 * Rx2;
            int TwoRy2 = 2 * Ry2;
            int p;
            int x = 0;
            int y = Ry;
            int px = 0;
            int py = TwoRx2 * y;

            ellipsePlotPoint1(Xcenter, Ycenter, x, y, graphics, color);
            /* Region 1 */

            p = Round(Ry2 - (Rx2 * Ry) + (int)(0.25 * Rx2));
            while (px < py)
            {
                x++;
                px += TwoRy2;
                if (p < 0)
                {
                    p += Ry2 + px;
                }
                else
                {
                    y--;
                    py -= TwoRx2;
                    p += Ry2 + px - py;

                }
                ellipsePlotPoint1(Xcenter, Ycenter, x, y, graphics, color);
                
            }
            /* Region 2 */
            p = Round(Ry2 * (int)(x + 0.5) * (int)(x + 0.5) + Rx2 * (y - 1) * (y - 1) - Rx2 * Ry2);
            while (y > 0)
            {
                y--;
                py -= TwoRx2;
                if (p > 0)
                {
                    p += Rx2 - py;
                }
                else
                {
                    x++;
                    px += TwoRy2;
                    p += Rx2 - py + px;
                }
                //textBox2.Text += "Xcenter(: " + Xcenter.ToString() + " , Ycenter: " + Ycenter.ToString() + ", x: " + x.ToString() + ", y: " + y.ToString();
                ellipsePlotPoint2(Xcenter, Ycenter, x, y, graphics, color);
            }


        }

        private void ellipsePlotPoint1(int xCenter, int yCenter, int x, int y, Graphics graphics, Color color)
        {
            
            setPixel(graphics, xCenter + x, yCenter + y, color);
            float X = xCenter + x;
            float Y = yCenter + y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, xCenter - x, yCenter + y, color);
            X = xCenter - x;
            Y = yCenter + y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, xCenter + x, yCenter - y, color);
            X = xCenter + x;
            Y = yCenter - y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, xCenter - x, yCenter - y, color);
            X = xCenter - x;
            Y = yCenter - y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            textBox1.AppendText(Environment.NewLine);

        }
        private void ellipsePlotPoint2(int xCenter, int yCenter, int x, int y, Graphics graphics, Color color)
        {

            setPixel(graphics, xCenter + x, yCenter + y, color);
            float X = xCenter + x;
            float Y = yCenter + y;
            textBox2.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, xCenter - x, yCenter + y, color);
            X = xCenter - x;
            Y = yCenter + y;
            textBox2.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, xCenter + x, yCenter - y, color);
            X = xCenter + x;
            Y = yCenter - y;
            textBox2.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, xCenter - x, yCenter - y, color);
            X = xCenter - x;
            Y = yCenter - y;
            textBox2.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            textBox2.AppendText(Environment.NewLine);

        }

        private void EllipseFormBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
