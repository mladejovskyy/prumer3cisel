using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prumer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cislo1;
            cislo1 = Convert.ToInt32(inputNumber.Text);
            int cislo2;
            cislo2 = Convert.ToInt32(inputNumber2.Text);
            int cislo3;
            cislo3 = Convert.ToInt32(inputNumber3.Text);

            int sum;
            sum = cislo1 + cislo2 + cislo3;

            float num;
            num = 3;

            float prumer;
            prumer = sum / num;

           outputNumber.Text = Convert.ToString(prumer);

        }
    }
}
