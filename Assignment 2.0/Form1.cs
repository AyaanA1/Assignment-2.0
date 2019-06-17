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

        public string Resistance { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            //Program is calculating the resistance in series.
            double R1, R2, R3, R4, Resistance;

            try
            {
                R1 = Convert.ToDouble(textBox1.Text);
            }
            catch
            {
                R1 = 0;
            }
            try
            {
                R2 = Convert.ToDouble(textBox2.Text);
            }
            catch
            {
                R2 = 0;
            }
            try
            {
                R3 = Convert.ToDouble(textBox3.Text);
            }
            catch
            {
                R3 = 0;
            }
            try
            {
                R4 = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                R4 = 0;
            }
        
            Resistance = R1 + R2 + R3 + R4;
            label5.Text = "Resistance =" + Resistance;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Program is calculating the resistance in parallel.
            double R1, R2, R3, R4, Resistance;
            try
            {
                R1 = Convert.ToDouble(textBox5.Text);
            }
            catch
            {
                R1 = double.PositiveInfinity;
            }
            try
            {
                R2 = Convert.ToDouble(textBox6.Text);
            }
            catch
            {
                R2 = double.PositiveInfinity;
            }
            try
            {
                R3 = Convert.ToDouble(textBox7.Text);
            }
            catch
            {
                R3 = double.PositiveInfinity;
            }
            try
            {
                R4 = Convert.ToDouble(textBox8.Text);
            }
            catch
            {
                R4 = double.PositiveInfinity;
            }
            Resistance = 1 / (1 / R1 + 1 / R2 + 1 / R3 + 1 / R4);
            label10.Text = "Resistance =" + Resistance;
        }
    }
}