using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {

            double unitAmount = double.Parse(textBox1.Text);
            double tot;
            if(unitAmount >=0 && unitAmount<=45)
            {
                tot = unitAmount * 45;
            }
            else if(unitAmount >=46 && unitAmount <=90)
            {
                tot = unitAmount * 90;
            }

            else if(unitAmount >=91 && unitAmount<=120)
            {
                tot = unitAmount * 120;
            }
            else
            {
                tot = unitAmount * 200;
            }

            textBox2.Text = tot.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
