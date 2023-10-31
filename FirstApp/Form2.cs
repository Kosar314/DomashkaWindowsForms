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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            /*
            for (int i = 1; i <= 7; i++)
            {
                FieldValidation(textBox1);
            }
            */
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
    }
}
