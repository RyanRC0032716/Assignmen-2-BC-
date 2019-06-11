using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignmen_2__BC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Calculate the total resistance in the series circuit of 2 resistors
            try
            {
                Double R1, R2, Resistance;
                R1 = Convert.ToDouble(textBox1.Text);
                R2 = Convert.ToDouble(textBox2.Text);
                Resistance = R1 + R2;
                label3.Text = "Resistance = " + Resistance;

            }
            catch
            {
                MessageBox.Show("Error you dummy - Type in two numbers");
            }
        }
    }
}
