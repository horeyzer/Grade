using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Grade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(textBox3.Text);
            b = Convert.ToInt32(textBox4.Text);
            c = (a + b) / 2;
            textBox5.Text = c.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name, surname, math, eng, overall;
            name = textBox1.Text;
            surname = textBox2.Text;
            math = textBox3.Text;
            eng = textBox4.Text;
            overall = textBox5.Text;

            string s = name + surname + math + eng + overall;

            FileStream fs = new FileStream("data.txt",
                                            FileMode.Append,
                                            FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(s);
            sw.Close();
            fs.Close();
            MessageBox.Show(
                "You added one record", "MESSAGE",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Warning
                );

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
        }
    }
    }
