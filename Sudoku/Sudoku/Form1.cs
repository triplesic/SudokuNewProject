using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sudoku
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            solve s = new solve();
            int [ , ] table = new int [4,4];

            table = s.getSolve();

            textBox1.Text = table[0, 0].ToString();
            textBox2.Text = table[0, 1].ToString();
            textBox4.Text = table[0, 2].ToString();
            textBox7.Text = table[0, 3].ToString();

            textBox5.Text = table[1, 0].ToString();
            textBox6.Text = table[1, 1].ToString();
            textBox8.Text = table[1, 2].ToString();
            textBox3.Text = table[1, 3].ToString();

            textBox10.Text = table[2, 0].ToString();
            textBox11.Text = table[2, 1].ToString();
            textBox14.Text = table[2, 2].ToString();
            textBox15.Text = table[2, 3].ToString();

            textBox12.Text = table[3, 0].ToString();
            textBox9.Text = table[3, 1].ToString();
            textBox16.Text = table[3, 2].ToString();
            textBox13.Text = table[3, 3].ToString();
        }
    }
}
