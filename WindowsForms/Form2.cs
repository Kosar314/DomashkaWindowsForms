using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            List<TextBox> list = new List<TextBox> { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            bool isAllGood = true;

            foreach (TextBox tb in list)
            {
                if (FieldValidation(tb) == false) { isAllGood = false; }
            }

            if (isAllGood == false)
            {
                MessageBox.Show("Заполните обязательные поля");
            }
        }

        private bool FieldValidation(TextBox txt)
        {
            if (txt.Text == "")
            {
                txt.BackColor = Color.Red;
                return false;
            }
            else
            {
                txt.BackColor = Color.White;
                return true;
            }
        }
    }
}
