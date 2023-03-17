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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private static
        int r;
        int R;

        private void button1_Click(object sender, EventArgs e)
        {
            r = 20;
            R = Convert.ToInt32(maskedTextBox1.Text);
            if (R >= 20)
            {
                double p = Convert.ToDouble(Math.PI * (Math.Pow(R, 2) - Math.Pow(r, 2)));
                textBox2.Text = Math.Round(p,2).ToString();
            }
            else
            {
                MessageBox.Show("Значение меньше 20");
            }

        }
    }
}

