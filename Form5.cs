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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            int n = 1;
            double S = 1/Math.Sqrt(n);
            double eps = Convert.ToDouble(maskedTextBox1.Text);
            while (S>eps)
            {
                sum = sum + S;
                n++;
                S = 1 / Math.Sqrt(n);
            }
            if (eps > 0)
            {
                textBox1.Text = Math.Round(sum, 2).ToString();
            }
            else
            {
                MessageBox.Show("Вы ввели отрицательный eps");
            }
        }
    }
}
