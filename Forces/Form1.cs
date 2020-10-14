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

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click_1(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
        //use code
        try
        {
            //Read text from textboxes
            double Force = double.Parse(textBox1.Text);
            double Angle = double.Parse(textBox2.Text);
            //Calculate forces Fx and Fy
            double Fx = Force * cos(Angle);
            double Fy = Force * sin(Angle);
            //Outpit answers to labels
            label1.Text = "Fx = " + Fx;
            label2.Text = "Fy = " + Fy;
        }
            //use catch to output error message
            catch
       {
            MessageBox.Show("Error on input.");
       }

}
            

        
        
}
           


    }
}
