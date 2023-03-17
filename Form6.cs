using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp38
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(maskedTextBox1.Text);
            double y = Convert.ToDouble(maskedTextBox2.Text);
            double radius = 1;
            double d = Math.Sqrt(x * x + y * y);
            if (d<=radius)
            {
                x -= 1;
                y += x;
                textBox1.Text = (x).ToString(); 
                textBox2.Text = (y).ToString();
            }
            else
            {
                MessageBox.Show("Вы ввели значение больше 1");
            }
        }
    }
}
