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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] arr = new int[41];
            for (int i = 1; i < arr.Length; i++)
            {
                arr[i] = i;
                textBox1.Text += arr[i].ToString() + ",";
            }
            Random rand = new Random();
            int[] arr1 = new int[5];
           
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = rand.Next(0, 41);
                textBox2.Text += arr1[i].ToString() + ", ";
            }
           
        }


    }
}

