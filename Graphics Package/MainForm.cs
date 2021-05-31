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
    public partial class MainForm : Form
    {
        public MainForm()
        { 
            InitializeComponent();
        }

        private void LineAlgorithmsForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            LineAlgorithmsForm form = new LineAlgorithmsForm();
            form.Closed += (s, arg) => this.Close();
            form.Show();
        }

        private void CircleButtonForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            CircleForm circleForm = new CircleForm();
            circleForm.Closed += (s, arg) => this.Close();
            circleForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            EllipseForm ellipseForm = new EllipseForm();
            ellipseForm.Closed += (s, arg) => this.Close();
            ellipseForm.Show();
        }
    }
}
