using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Activity_2
{
    //Angel McDaniel
    public partial class Activity2 : Form
    {
        string numConverter;

        public Activity2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            outputBox2.Text = numConverter;

            string message = outputBox2.Text;
            string title = "Message Box";
            MessageBox.Show(message, title);
        }

        private void inputBox1_TextChanged(object sender, EventArgs e)
        {
            double tempDouble;

            try
            {
                tempDouble = Convert.ToDouble(inputBox1.Text);
                tempDouble *= 3;
                tempDouble = Math.Round(tempDouble, 4);
                numConverter = tempDouble.ToString("0.000");
                //numConverter = Convert.ToString(tempDouble);
            }
            catch
            {
                numConverter = "Error";
            }
        }

        private void outputBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
