using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class Form5_2 : Form
    {
        public Form5_2()
        {
            InitializeComponent();
        }

        private void buttonOutput1_Click(object sender, EventArgs e)
        {
            try
            {
                double R = Convert.ToDouble(inputTextBox.Text);
                textBox2.Text = Math.Round(2 * Math.PI * R, 2).ToString();
                textBox3.Text = Math.Round(Math.PI * (R * R), 2).ToString();
                textBox4.Text = Math.Round(4.0 / 3.0 * Math.PI * Math.Pow(R, 3), 2).ToString();
            }
            catch
            {
                MessageBox.Show("Неверное значение", "Ошибка!");
            }
        }

        private void buttonOutput2_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(inputTextBox2_1.Text);
                int b = int.Parse(inputTextBox2_2.Text);
                int c;

                c = a;
                a = b;
                b = c;

                textBox6.Text = a.ToString();
                textBox7.Text = b.ToString();
            }
            catch
            {
                MessageBox.Show("Неверное значение", "Ошибка!");
            }
        }
    }
}
