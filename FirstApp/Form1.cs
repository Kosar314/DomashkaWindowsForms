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
    public partial class FMain : Form
    {
        public FMain()
        {
            InitializeComponent();
            this.Text = "Hello World!";
            this.BackColor = Color.Aquamarine;
            this.Width = 550;
            this.Height = 550;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;

            if (textBox1.Text != "" && textBox2.Text != "")
            {
                textBox1.BackColor = Color.White;
                textBox2.BackColor = Color.White;
                MessageBox.Show($"Привет, {textBox1.Text} из группы {textBox2.Text}!");
            }
            else
            {
                FieldValidation(textBox1);
                FieldValidation(textBox2);

                MessageBox.Show("Заполните обязательные поля");
            }
        }

        private void FieldValidation(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.BackColor = Color.Red;
            }
            else
            {
                txt.BackColor = Color.White;
            }
        }

        private void buttonRed_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void buttonBlue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void buttonGreen_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void buttonYellow_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            textBox3.Visible = false;
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            textBox3.Visible = true;
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            textBox4.Text = buttonStar.Text;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            textBox4.Text = buttonPlus.Text;
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            textBox4.Text = buttonZero.Text;
        }
    }
}
