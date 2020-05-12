using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxsese
{
    public partial class Form1 : Form
    {
        TextBox textBox1;
        TextBox textBox2;
        string global_variable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1 = new TextBox
            {
                Location = new Point(500, 50),
                Size = new Size(200,10)
            };
            textBox1.TextChanged += TextBox_TextChanged;
            this.Controls.Add(textBox1);
            this.Controls.Remove(textBox2);
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            global_variable = (sender as TextBox).Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox2 = new TextBox
            {
                Location = new Point(500, 80),
                Size = new Size(200, 10)
            };
            textBox2.TextChanged += TextBox_TextChanged;
            this.Controls.Add(textBox2);
            this.Controls.Remove(textBox1);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(global_variable);
        }
    }
}
