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
    public partial class CircleForm : Form
    {

        private int getCenter_x()
        {
            return Int32.Parse(center_xTextbox.Text);
        }
        private int getCenter_Y()
        {
            return Int32.Parse(center_YTextbox.Text);
        }
        private int getRadius()
        {
            return Int32.Parse(radius_Textbox.Text);
        }
        private void setPixel(Graphics graphics, int x, int y, Color color)
        {
            Brush brushColor = new SolidBrush(color);
            graphics.FillRectangle(brushColor, x, y, 2, 2);
        }

        public CircleForm()
        {
            InitializeComponent();
        }
        
        private void DrawMidpointCicrle_Click(object sender, EventArgs e)
        {
            Graphics graphics = midPoint_Circle_panel.CreateGraphics();
            draw_MidPointCircle(getCenter_x(), getCenter_Y(), getRadius(), graphics, Color.Blue);
        }

        private void draw_MidPointCircle(int center_X, int center_Y, int radius, Graphics graphics, Color color)
        {
            int x = 0;
            int y = radius;
            int p = 1 - radius;
            circlePlotPoint1(graphics, center_X, center_Y, x, y, color);
            while (x <= y)
            {
                x++;
                if(p < 0)
                    p += (2 * x) + 1;
                else
                {
                    y--;
                    p += 2 * (x - y) + 1;
                }
                circlePlotPoint(graphics, center_X, center_Y, x, y, color);
            }
        }

        private void circlePlotPoint(Graphics graphics, int center_X, int center_Y, int x, int y, Color color)
        {
            setPixel(graphics, center_X + x, center_Y + y, color);
            float X = center_X + x;
            float Y = center_Y + y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, center_X - x, center_Y + y, color);
            X = center_X - x;
            Y = center_Y + y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, center_X + x, center_Y - y, color);
            X = center_X + x;
            Y = center_Y - y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, center_X - x, center_Y - y, color);
            X = center_X - x;
            Y = center_Y - y;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, center_X + y, center_Y + x, color);
            X = center_X + y;
            Y = center_Y + x;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, center_X - y, center_Y + x, color);
            X = center_X - y;
            Y = center_Y + x;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, center_X + y, center_Y - x, color);
            X = center_X + y;
            Y = center_Y - x;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            setPixel(graphics, center_X - y, center_Y - x, color);
            X = center_X - y;
            Y = center_Y - x;
            textBox1.Text += "x: " + X.ToString() + ", y: " + Y.ToString() + " ";
            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText(Environment.NewLine);
        }
        private void circlePlotPoint1(Graphics graphics, int center_X, int center_Y, int x, int y, Color color)
        {
            setPixel(graphics, center_X + x, center_Y + y, color);
            setPixel(graphics, center_X - x, center_Y + y, color);
            setPixel(graphics, center_X + x, center_Y - y, color);
            setPixel(graphics, center_X - x, center_Y - y, color);
            setPixel(graphics, center_X + y, center_Y + x, color);
            setPixel(graphics, center_X - y, center_Y + x, color);
            setPixel(graphics, center_X + y, center_Y - x, color);
            setPixel(graphics, center_X - y, center_Y - x, color);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainForm = new MainForm();
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();
        }
    }
}
