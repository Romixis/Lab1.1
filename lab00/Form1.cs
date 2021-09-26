using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace lab00
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
                {
                    MessageBox.Show("Не все поля заполняны");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Не все поля заполняны");
            }

            try
            {
                double a, p, d, m;
                a = Convert.ToDouble(textBox2.Text);
                p = Convert.ToDouble(textBox1.Text);
                d = Convert.ToDouble(textBox3.Text);

                m = (Math.Pow(a, 3) - ((4 / 3) * 3.14 * (Math.Pow((d / 2), 3)))) * p;
                if (a < d)
                {
                    MessageBox.Show("Число \"a\" не должно быть меньше чем\"d\" ");
                }
                else
                {
                    textBox4.Text = Convert.ToString(m);
                }
            }

            catch 
            {
                MessageBox.Show("Ошибка в записи");
            }
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)// длина ребра
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) // значение плотности 
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e) // ответ
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e) //диагональ круга
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
