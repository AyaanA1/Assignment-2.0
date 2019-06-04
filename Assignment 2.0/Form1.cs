using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, Resistance;
            R1 = Convert.ToDouble(textBox1.Text);
            R2 = Convert.ToDouble(textBox2.Text);
            R3 = Convert.ToDouble(textBox3.Text);
            R4 = Convert.ToDouble(textBox4.Text);
            Resistance = R1 + R2 + R3 + R4;
            label5.Text = "Resistance" + Resistance;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double R1, R2, R3, R4, Resistance;
            R1 = Convert.ToDouble(textBox5.Text);
            R2 = Convert.ToDouble(textBox6.Text);
            R3 = Convert.ToDouble(textBox7.Text);
            R4 = Convert.ToDouble(textBox8.Text);
            Resistance = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
            label10.Text = "Resistance" + Resistance;
        }
    }
}
