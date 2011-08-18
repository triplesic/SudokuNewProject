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

        private int[,] table = new int[4, 4];
        solve s = new solve();

        private void button1_Click(object sender, EventArgs e)
        {
            table = s.getSolve();
            mapArrayToTable(table);
        }

        private void mapArrayToTable(int[,] tableInt)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
            textBox9.Enabled = true;
            textBox10.Enabled = true;
            textBox11.Enabled = true;
            textBox12.Enabled = true;
            textBox13.Enabled = true;
            textBox14.Enabled = true;
            textBox15.Enabled = true;
            textBox16.Enabled = true;


            string[,] table = new string[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tableInt[i,j] == 0)
                    {
                        table[i, j] = "";
                    }
                    else
                    {
                        table[i, j] = tableInt[i, j].ToString();
                    }
                    
                }
            }

            if (table[0, 0] != "")
            {
                textBox1.Enabled = false;
            }
            textBox1.Text = table[0, 0].ToString();

            if (table[0, 1] != "")
            {
                textBox2.Enabled = false;
            }
            textBox2.Text = table[0, 1].ToString();

            if (table[0, 2] != "")
            {
                textBox4.Enabled = false;
            }
            textBox4.Text = table[0, 2].ToString();

            if (table[0, 3] != "")
            {
                textBox7.Enabled = false;
            }
            textBox7.Text = table[0, 3].ToString();

            if (table[1, 0] != "")
            {
                textBox5.Enabled = false;
            }
            textBox5.Text = table[1, 0].ToString();

            if (table[1, 1] != "")
            {
                textBox6.Enabled = false;
            }
            textBox6.Text = table[1, 1].ToString();

            if (table[1, 2] != "")
            {
                textBox8.Enabled = false;
            }
            textBox8.Text = table[1, 2].ToString();

            if (table[1, 3] != "")
            {
                textBox3.Enabled = false;
            }
            textBox3.Text = table[1, 3].ToString();

            if (table[2, 0] != "")
            {
                textBox10.Enabled = false;
            }
            textBox10.Text = table[2, 0].ToString();

            if (table[2, 1] != "")
            {
                textBox11.Enabled = false;
            }
            textBox11.Text = table[2, 1].ToString();

            if (table[2, 2] != "")
            {
                textBox14.Enabled = false;
            }
            textBox14.Text = table[2, 2].ToString();

            if (table[2, 3] != "")
            {
                textBox15.Enabled = false;
            }
            textBox15.Text = table[2, 3].ToString();

            if (table[3, 0] != "")
            {
                textBox12.Enabled = false;
            }
            textBox12.Text = table[3, 0].ToString();

            if (table[3, 1] != "")
            {
                textBox9.Enabled = false;
            }
            textBox9.Text = table[3, 1].ToString();

            if (table[3, 2] != "")
            {
                textBox16.Enabled = false;
            }
            textBox16.Text = table[3, 2].ToString();

            if (table[3, 3] != "")
            {
                textBox13.Enabled = false;
            }
            textBox13.Text = table[3, 3].ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text == textBox2.Text || 
                    textBox1.Text == textBox4.Text || 
                    textBox1.Text == textBox7.Text || 
                    textBox1.Text == textBox5.Text || 
                    textBox1.Text == textBox6.Text || 
                    textBox1.Text == textBox10.Text || 
                    textBox1.Text == textBox12.Text)
                {
                    textBox1.BackColor = Color.Red;
                }else
                {
                    textBox1.BackColor = Color.White;
                }
            }
            else
            {
                textBox1.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                if (textBox2.Text == textBox1.Text || 
                    textBox2.Text == textBox4.Text || 
                    textBox2.Text == textBox7.Text || 
                    textBox2.Text == textBox5.Text || 
                    textBox2.Text == textBox6.Text || 
                    textBox2.Text == textBox11.Text || 
                    textBox2.Text == textBox9.Text)
                {
                    textBox2.BackColor = Color.Red;
                }
                else
                {
                    textBox2.BackColor = Color.White;
                }
            }
            else
            {
                textBox2.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text != "")
            {
                if (textBox4.Text == textBox1.Text ||
                    textBox4.Text == textBox2.Text ||
                    textBox4.Text == textBox7.Text ||
                    textBox4.Text == textBox8.Text ||
                    textBox4.Text == textBox3.Text ||
                    textBox4.Text == textBox14.Text ||
                    textBox4.Text == textBox16.Text)
                {
                    textBox4.BackColor = Color.Red;
                }
                else
                {
                    textBox4.BackColor = Color.White;
                }
            }
            else
            {
                textBox4.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                if (textBox7.Text == textBox1.Text ||
                    textBox7.Text == textBox2.Text ||
                    textBox7.Text == textBox4.Text ||
                    textBox7.Text == textBox8.Text ||
                    textBox7.Text == textBox3.Text ||
                    textBox7.Text == textBox15.Text ||
                    textBox7.Text == textBox3.Text)
                {
                    textBox7.BackColor = Color.Red;
                }
                else
                {
                    textBox7.BackColor = Color.White;
                }
            }
            else
            {
                textBox7.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                if (textBox5.Text == textBox6.Text ||
                    textBox5.Text == textBox8.Text ||
                    textBox5.Text == textBox3.Text ||
                    textBox5.Text == textBox1.Text ||
                    textBox5.Text == textBox2.Text ||
                    textBox5.Text == textBox10.Text ||
                    textBox5.Text == textBox12.Text)
                {
                    textBox5.BackColor = Color.Red;
                }
                else
                {
                    textBox5.BackColor = Color.White;
                }
            }
            else
            {
                textBox5.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                if (textBox6.Text == textBox5.Text ||
                    textBox6.Text == textBox8.Text ||
                    textBox6.Text == textBox3.Text ||
                    textBox6.Text == textBox1.Text ||
                    textBox6.Text == textBox2.Text ||
                    textBox6.Text == textBox11.Text ||
                    textBox6.Text == textBox9.Text)
                {
                    textBox6.BackColor = Color.Red;
                }
                else
                {
                    textBox6.BackColor = Color.White;
                }
            }
            else
            {
                textBox6.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                if (textBox8.Text == textBox5.Text ||
                    textBox8.Text == textBox6.Text ||
                    textBox8.Text == textBox3.Text ||
                    textBox8.Text == textBox4.Text ||
                    textBox8.Text == textBox7.Text ||
                    textBox8.Text == textBox14.Text ||
                    textBox8.Text == textBox16.Text)
                {
                    textBox8.BackColor = Color.Red;
                }
                else
                {
                    textBox8.BackColor = Color.White;
                }
            }
            else
            {
                textBox8.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                if (textBox3.Text == textBox5.Text ||
                    textBox3.Text == textBox6.Text ||
                    textBox3.Text == textBox8.Text ||
                    textBox3.Text == textBox4.Text ||
                    textBox3.Text == textBox7.Text ||
                    textBox3.Text == textBox15.Text ||
                    textBox3.Text == textBox13.Text)
                {
                    textBox3.BackColor = Color.Red;
                }
                else
                {
                    textBox3.BackColor = Color.White;
                }
            }
            else
            {
                textBox3.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text != "")
            {
                if (textBox10.Text == textBox11.Text ||
                    textBox10.Text == textBox14.Text ||
                    textBox10.Text == textBox15.Text ||
                    textBox10.Text == textBox1.Text ||
                    textBox10.Text == textBox5.Text ||
                    textBox10.Text == textBox12.Text ||
                    textBox10.Text == textBox9.Text)
                {
                    textBox10.BackColor = Color.Red;
                }
                else
                {
                    textBox10.BackColor = Color.White;
                }
            }
            else
            {
                textBox10.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                if (textBox11.Text == textBox10.Text ||
                    textBox11.Text == textBox14.Text ||
                    textBox11.Text == textBox15.Text ||
                    textBox11.Text == textBox2.Text ||
                    textBox11.Text == textBox6.Text ||
                    textBox11.Text == textBox9.Text ||
                    textBox11.Text == textBox12.Text)
                {
                    textBox11.BackColor = Color.Red;
                }
                else
                {
                    textBox11.BackColor = Color.White;
                }
            }
            else
            {
                textBox11.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text != "")
            {
                if (textBox14.Text == textBox10.Text ||
                    textBox14.Text == textBox11.Text ||
                    textBox14.Text == textBox15.Text ||
                    textBox14.Text == textBox4.Text ||
                    textBox14.Text == textBox8.Text ||
                    textBox14.Text == textBox6.Text ||
                    textBox14.Text == textBox13.Text)
                {
                    textBox14.BackColor = Color.Red;
                }
                else
                {
                    textBox14.BackColor = Color.White;
                }
            }
            else
            {
                textBox14.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text != "")
            {
                if (textBox15.Text == textBox10.Text ||
                    textBox15.Text == textBox11.Text ||
                    textBox15.Text == textBox14.Text ||
                    textBox15.Text == textBox7.Text ||
                    textBox15.Text == textBox3.Text ||
                    textBox15.Text == textBox13.Text ||
                    textBox15.Text == textBox16.Text)
                {
                    textBox15.BackColor = Color.Red;
                }
                else
                {
                    textBox15.BackColor = Color.White;
                }
            }
            else
            {
                textBox15.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text != "")
            {
                if (textBox12.Text == textBox9.Text ||
                    textBox12.Text == textBox16.Text ||
                    textBox12.Text == textBox13.Text ||
                    textBox12.Text == textBox1.Text ||
                    textBox12.Text == textBox5.Text ||
                    textBox12.Text == textBox10.Text ||
                    textBox12.Text == textBox11.Text)
                {
                    textBox12.BackColor = Color.Red;
                }
                else
                {
                    textBox12.BackColor = Color.White;
                }
            }
            else
            {
                textBox12.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text != "")
            {
                if (textBox9.Text == textBox12.Text ||
                    textBox9.Text == textBox16.Text ||
                    textBox9.Text == textBox13.Text ||
                    textBox9.Text == textBox2.Text ||
                    textBox9.Text == textBox6.Text ||
                    textBox9.Text == textBox11.Text ||
                    textBox9.Text == textBox10.Text)
                {
                    textBox9.BackColor = Color.Red;
                }
                else
                {
                    textBox9.BackColor = Color.White;
                }
            }
            else
            {
                textBox9.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text != "")
            {
                if (textBox16.Text == textBox12.Text ||
                    textBox16.Text == textBox9.Text ||
                    textBox16.Text == textBox13.Text ||
                    textBox16.Text == textBox4.Text ||
                    textBox16.Text == textBox8.Text ||
                    textBox16.Text == textBox14.Text ||
                    textBox16.Text == textBox15.Text)
                {
                    textBox16.BackColor = Color.Red;
                }
                else
                {
                    textBox16.BackColor = Color.White;
                }
            }
            else
            {
                textBox16.BackColor = Color.White;
            }
            congratulations();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text != "")
            {
                if (textBox13.Text == textBox12.Text ||
                    textBox13.Text == textBox9.Text ||
                    textBox13.Text == textBox16.Text ||
                    textBox13.Text == textBox7.Text ||
                    textBox13.Text == textBox3.Text ||
                    textBox13.Text == textBox15.Text ||
                    textBox13.Text == textBox14.Text)
                {
                    textBox13.BackColor = Color.Red;
                }
                else
                {
                    textBox13.BackColor = Color.White;
                }
            }
            else
            {
                textBox13.BackColor = Color.White;
            }
            congratulations();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            table = s.getSolve();
            Random r = new Random();
            int x, y;
            int[,] arrGen = new int[4, 4];

            for (int i = 0; i < 7; i++)
            {
                x = r.Next(4);
                y = r.Next(4);

                // Random duplicate
                if (arrGen[x, y] != 0 && i != 0)
                {
                    i--;
                }
                else
                {
                    arrGen[x, y] = table[x, y];
                }
            }
            mapArrayToTable(arrGen);
        }



        public void congratulations()
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" &&
                textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" &&
                textBox9.Text != "" && textBox10.Text != "" && textBox11.Text != "" && textBox12.Text != "" &&
                textBox13.Text != "" && textBox14.Text != "" && textBox15.Text != "" && textBox16.Text != "")
            {

                if (textBox1.BackColor != Color.Red && textBox2.BackColor != Color.Red && textBox3.BackColor != Color.Red && textBox4.BackColor != Color.Red &&
            textBox5.BackColor != Color.Red && textBox6.BackColor != Color.Red && textBox7.BackColor != Color.Red && textBox8.BackColor != Color.Red &&
            textBox9.BackColor != Color.Red && textBox10.BackColor != Color.Red && textBox11.BackColor != Color.Red && textBox12.BackColor != Color.Red &&
            textBox13.BackColor != Color.Red && textBox14.BackColor != Color.Red && textBox15.BackColor != Color.Red && textBox16.BackColor != Color.Red)
                {
                    label1.Visible = true;
                }

            }
            else {

                label1.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

    }
}
