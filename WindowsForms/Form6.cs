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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void buttonCount_Click(object sender, EventArgs e)
        {
            double price = Convert.ToDouble(textBoxOnePrice.Text);
            double amount = Convert.ToDouble(textBoxAmount.Text);
            double cardDiscount;
            switch (comboBoxBonusCard.SelectedIndex)
            {
                case 0:
                    cardDiscount = 0;
                    break;
                case 1:
                    cardDiscount = 1;
                    break;
                case 2:
                    cardDiscount = 5;
                    break;
                case 3:
                    cardDiscount = 10;
                    break;
                default:
                    cardDiscount = 0;
                    break;
            }

            double discount = (price * amount * cardDiscount) / 100;

            textBoxFinalPrice.Text = $"{price * amount - discount}";
        }

        private bool CheckField(ref TextBox textBox, bool isIntCheck)
        {
            if (isIntCheck)
            {
                double placeHolder;
                if (!Double.TryParse(textBox.Text, out placeHolder))
                {
                    textBox.BackColor = Color.Red;
                    return false;
                }
                else
                {
                    textBox.BackColor = Color.White;
                    return true;
                }
            }

            if (textBox.Text == "")
            {
                textBox.BackColor = Color.Red;
                return false;
            }
            else
            {
                textBox.BackColor = Color.White;
                return true;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBoxOnePrice.Text = "0";
            textBoxAmount.Text = "0";
            textBoxFinalPrice.Text = "0";
            comboBoxBonusCard.SelectedIndex = 0;
        }
    }
}
