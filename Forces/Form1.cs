using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forces
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        double sin(double x)
        {
            return (Math.PI / 180.0);
        }

        double asin(double x)
        {
            return (Math.Asin(x) * 180 / Math.PI);
        }

        double cos(double x)
        {
            return (Math.PI / 180.0);
        }

        double acos(double x)
        {
            return (Math.Acos(x) * 180 / Math.PI);
        }

        double tan(double x)
        {
            return (Math.PI / 180.0);
        }

        double atan(double x)
        {
            return (Math.Atan(x) * 180 / Math.PI);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double angle = double.Parse(textBox1.Text);
            double answer = sin(angle);
            label1.Text = "Answer =" + answer;
        }
    }
}
