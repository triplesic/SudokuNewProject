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

        //private int[,] table = new int[4, 4];
        solve s = new solve();
        private int[,] table = new int[4,4];
        private int[,] table9x9 = new int[9, 9];

        private void button1_Click(object sender, EventArgs e)
        {
            //table = new solve().getSolve();
            mapArrayToTable(table);
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox15.BackColor = Color.White;
            textBox16.BackColor = Color.White;

        }

        private void mapArrayToTable(int[,] tableInt)
        {

            enableTable();

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

        private void mapArrayToTable9x9(int[,] tableInt9x9)
        {
            enableTable9x9();

            string[,] table = new string[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (tableInt9x9[i, j] == 0)
                    {
                        table[i, j] = "";
                    }
                    else
                    {
                        table[i, j] = tableInt9x9[i, j].ToString();
                    }

                }
            }

            //--------------------------------- line 1 ----------------------------------------------------
            if (table[0, 0] != "")
            {
                Box1.Enabled = false;
            }
            Box1.Text = table[0, 0].ToString();

            if (table[0, 1] != "")
            {
                Box2.Enabled = false;
            }
            Box2.Text = table[0, 1].ToString();

            if (table[0, 2] != "")
            {
                Box3.Enabled = false;
            }
            Box3.Text = table[0, 2].ToString();

            if (table[0, 3] != "")
            {
                Box4.Enabled = false;
            }
            Box4.Text = table[0, 3].ToString();

            if (table[0, 4] != "")
            {
                Box5.Enabled = false;
            }
            Box5.Text = table[0, 4].ToString();

            if (table[0, 5] != "")
            {
                Box6.Enabled = false;
            }
            Box6.Text = table[0, 5].ToString();

            if (table[0, 6] != "")
            {
                Box7.Enabled = false;
            }
            Box7.Text = table[0, 6].ToString();

            if (table[0, 7] != "")
            {
                Box8.Enabled = false;
            }
            Box8.Text = table[0, 7].ToString();

            if (table[0, 8] != "")
            {
                Box9.Enabled = false;
            }
            Box9.Text = table[0, 8].ToString();

            //--------------------------------- line 2 ----------------------------------------------------
            if (table[1, 0] != "")
            {
                Box10.Enabled = false;
            }
            Box10.Text = table[1, 0].ToString();

            if (table[1, 1] != "")
            {
                Box11.Enabled = false;
            }
            Box11.Text = table[1, 1].ToString();

            if (table[1, 2] != "")
            {
                Box12.Enabled = false;
            }
            Box12.Text = table[1, 2].ToString();

            if (table[1, 3] != "")
            {
                Box13.Enabled = false;
            }
            Box13.Text = table[1, 3].ToString();

            if (table[1, 4] != "")
            {
                Box14.Enabled = false;
            }
            Box14.Text = table[1, 4].ToString();

            if (table[1, 5] != "")
            {
                Box15.Enabled = false;
            }
            Box15.Text = table[1, 5].ToString();

            if (table[1, 6] != "")
            {
                Box16.Enabled = false;
            }
            Box16.Text = table[1, 6].ToString();

            if (table[1, 7] != "")
            {
                Box17.Enabled = false;
            }
            Box17.Text = table[1, 7].ToString();

            if (table[1, 8] != "")
            {
                Box18.Enabled = false;
            }
            Box18.Text = table[1, 8].ToString();


            //--------------------------------- line 3 ----------------------------------------------------
            if (table[2, 0] != "")
            {
                Box19.Enabled = false;
            }
            Box19.Text = table[2, 0].ToString();

            if (table[2, 1] != "")
            {
                Box20.Enabled = false;
            }
            Box20.Text = table[2, 1].ToString();

            if (table[2, 2] != "")
            {
                Box21.Enabled = false;
            }
            Box21.Text = table[2, 2].ToString();

            if (table[2, 3] != "")
            {
                Box22.Enabled = false;
            }
            Box22.Text = table[2, 3].ToString();

            if (table[2, 4] != "")
            {
                Box23.Enabled = false;
            }
            Box23.Text = table[2, 4].ToString();

            if (table[2, 5] != "")
            {
                Box24.Enabled = false;
            }
            Box24.Text = table[2, 5].ToString();

            if (table[2, 6] != "")
            {
                Box25.Enabled = false;
            }
            Box25.Text = table[2, 6].ToString();

            if (table[2, 7] != "")
            {
                Box26.Enabled = false;
            }
            Box26.Text = table[2, 7].ToString();

            if (table[2, 8] != "")
            {
                Box27.Enabled = false;
            }
            Box27.Text = table[2, 8].ToString();


            //--------------------------------- line 4 ----------------------------------------------------
            if (table[3, 0] != "")
            {
                Box28.Enabled = false;
            }
            Box28.Text = table[3, 0].ToString();

            if (table[3, 1] != "")
            {
                Box29.Enabled = false;
            }
            Box29.Text = table[3, 1].ToString();

            if (table[3, 2] != "")
            {
                Box30.Enabled = false;
            }
            Box30.Text = table[3, 2].ToString();

            if (table[3, 3] != "")
            {
                Box31.Enabled = false;
            }
            Box31.Text = table[3, 3].ToString();

            if (table[3, 4] != "")
            {
                Box32.Enabled = false;
            }
            Box32.Text = table[3, 4].ToString();

            if (table[3, 5] != "")
            {
                Box33.Enabled = false;
            }
            Box33.Text = table[3, 5].ToString();

            if (table[3, 6] != "")
            {
                Box34.Enabled = false;
            }
            Box34.Text = table[3, 6].ToString();

            if (table[3, 7] != "")
            {
                Box35.Enabled = false;
            }
            Box35.Text = table[3, 7].ToString();

            if (table[3, 8] != "")
            {
                Box36.Enabled = false;
            }
            Box36.Text = table[3, 8].ToString();

            //--------------------------------- line 5 ----------------------------------------------------
            if (table[4, 0] != "")
            {
                Box37.Enabled = false;
            }
            Box37.Text = table[4, 0].ToString();

            if (table[4, 1] != "")
            {
                Box38.Enabled = false;
            }
            Box38.Text = table[4, 1].ToString();

            if (table[4, 2] != "")
            {
                Box39.Enabled = false;
            }
            Box39.Text = table[4, 2].ToString();

            if (table[4, 3] != "")
            {
                Box40.Enabled = false;
            }
            Box40.Text = table[4, 3].ToString();

            if (table[4, 4] != "")
            {
                Box41.Enabled = false;
            }
            Box41.Text = table[4, 4].ToString();

            if (table[4, 5] != "")
            {
                Box42.Enabled = false;
            }
            Box42.Text = table[4, 5].ToString();

            if (table[4, 6] != "")
            {
                Box43.Enabled = false;
            }
            Box43.Text = table[4, 6].ToString();

            if (table[4, 7] != "")
            {
                Box44.Enabled = false;
            }
            Box44.Text = table[4, 7].ToString();

            if (table[4, 8] != "")
            {
                Box45.Enabled = false;
            }
            Box45.Text = table[4, 8].ToString();

            //--------------------------------- line 6 ----------------------------------------------------
            if (table[5, 0] != "")
            {
                Box46.Enabled = false;
            }
            Box46.Text = table[5, 0].ToString();

            if (table[5, 1] != "")
            {
                Box47.Enabled = false;
            }
            Box47.Text = table[5, 1].ToString();

            if (table[5, 2] != "")
            {
                Box48.Enabled = false;
            }
            Box48.Text = table[5, 2].ToString();

            if (table[5, 3] != "")
            {
                Box49.Enabled = false;
            }
            Box49.Text = table[5, 3].ToString();

            if (table[5, 4] != "")
            {
                Box50.Enabled = false;
            }
            Box50.Text = table[5, 4].ToString();

            if (table[5, 5] != "")
            {
                Box51.Enabled = false;
            }
            Box51.Text = table[5, 5].ToString();

            if (table[5, 6] != "")
            {
                Box52.Enabled = false;
            }
            Box52.Text = table[5, 6].ToString();

            if (table[5, 7] != "")
            {
                Box53.Enabled = false;
            }
            Box53.Text = table[5, 7].ToString();

            if (table[5, 8] != "")
            {
                Box54.Enabled = false;
            }
            Box54.Text = table[5, 8].ToString();

            //--------------------------------- line 7 ----------------------------------------------------
            if (table[6, 0] != "")
            {
                Box55.Enabled = false;
            }
            Box55.Text = table[6, 0].ToString();

            if (table[6, 1] != "")
            {
                Box56.Enabled = false;
            }
            Box56.Text = table[6, 1].ToString();

            if (table[6, 2] != "")
            {
                Box57.Enabled = false;
            }
            Box57.Text = table[6, 2].ToString();

            if (table[6, 3] != "")
            {
                Box58.Enabled = false;
            }
            Box58.Text = table[6, 3].ToString();

            if (table[6, 4] != "")
            {
                Box59.Enabled = false;
            }
            Box59.Text = table[6, 4].ToString();

            if (table[6, 5] != "")
            {
                Box60.Enabled = false;
            }
            Box60.Text = table[6, 5].ToString();

            if (table[6, 6] != "")
            {
                Box61.Enabled = false;
            }
            Box61.Text = table[6, 6].ToString();

            if (table[6, 7] != "")
            {
                Box62.Enabled = false;
            }
            Box62.Text = table[6, 7].ToString();

            if (table[6, 8] != "")
            {
                Box63.Enabled = false;
            }
            Box63.Text = table[6, 8].ToString();

            //--------------------------------- line 8 ----------------------------------------------------
            if (table[7, 0] != "")
            {
                Box64.Enabled = false;
            }
            Box64.Text = table[7, 0].ToString();

            if (table[7, 1] != "")
            {
                Box65.Enabled = false;
            }
            Box65.Text = table[7, 1].ToString();

            if (table[7, 2] != "")
            {
                Box66.Enabled = false;
            }
            Box66.Text = table[7, 2].ToString();

            if (table[7, 3] != "")
            {
                Box67.Enabled = false;
            }
            Box67.Text = table[7, 3].ToString();

            if (table[7, 4] != "")
            {
                Box68.Enabled = false;
            }
            Box68.Text = table[7, 4].ToString();

            if (table[7, 5] != "")
            {
                Box69.Enabled = false;
            }
            Box69.Text = table[7, 5].ToString();

            if (table[7, 6] != "")
            {
                Box70.Enabled = false;
            }
            Box70.Text = table[7, 6].ToString();

            if (table[7, 7] != "")
            {
                Box71.Enabled = false;
            }
            Box71.Text = table[7, 7].ToString();

            if (table[7, 8] != "")
            {
                Box72.Enabled = false;
            }
            Box72.Text = table[7, 8].ToString();

            //--------------------------------- line 9 ----------------------------------------------------
            if (table[8, 0] != "")
            {
                Box73.Enabled = false;
            }
            Box73.Text = table[8, 0].ToString();

            if (table[8, 1] != "")
            {
                Box74.Enabled = false;
            }
            Box74.Text = table[8, 1].ToString();

            if (table[8, 2] != "")
            {
                Box75.Enabled = false;
            }
            Box75.Text = table[8, 2].ToString();

            if (table[8, 3] != "")
            {
                Box76.Enabled = false;
            }
            Box76.Text = table[8, 3].ToString();

            if (table[8, 4] != "")
            {
                Box77.Enabled = false;
            }
            Box77.Text = table[8, 4].ToString();

            if (table[8, 5] != "")
            {
                Box78.Enabled = false;
            }
            Box78.Text = table[8, 5].ToString();

            if (table[8, 6] != "")
            {
                Box79.Enabled = false;
            }
            Box79.Text = table[8, 6].ToString();

            if (table[8, 7] != "")
            {
                Box80.Enabled = false;
            }
            Box80.Text = table[8, 7].ToString();

            if (table[8, 8] != "")
            {
                Box81.Enabled = false;
            }
            Box81.Text = table[8, 8].ToString();
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
            textBox1.BackColor = Color.White;
            textBox2.BackColor = Color.White;
            textBox3.BackColor = Color.White;
            textBox4.BackColor = Color.White;
            textBox5.BackColor = Color.White;
            textBox6.BackColor = Color.White;
            textBox7.BackColor = Color.White;
            textBox8.BackColor = Color.White;
            textBox9.BackColor = Color.White;
            textBox10.BackColor = Color.White;
            textBox11.BackColor = Color.White;
            textBox12.BackColor = Color.White;
            textBox13.BackColor = Color.White;
            textBox14.BackColor = Color.White;
            textBox15.BackColor = Color.White;
            textBox16.BackColor = Color.White;
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
            clearTable9x9();
            enableTable9x9();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            clearTable();
            enableTable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            table9x9 = s.getSolve9x9();
            mapArrayToTable9x9(table9x9);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            table9x9 = s.getSolve9x9();
            int[,] gen = new int[9, 9];
            Random r = new Random();
            int x, y;

            for (int i = 0; i < 36; i++)
            {
                x = r.Next(9);
                y = r.Next(9);
                
                if (gen[x, y] != 0 && i != 0)
                {
                    i--;
                }
                else
                {
                    gen[x, y] = table9x9[x, y];
                }

                gen[x, y] = table9x9[x, y];
            }           
            mapArrayToTable9x9(gen);
        }

        private void enableTable()
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
        }

        private void enableTable9x9()
        {
            Box1.Enabled = true;
            Box2.Enabled = true;
            Box3.Enabled = true;
            Box4.Enabled = true;
            Box5.Enabled = true;
            Box6.Enabled = true;
            Box7.Enabled = true;
            Box8.Enabled = true;
            Box9.Enabled = true;

            Box10.Enabled = true;
            Box11.Enabled = true;
            Box12.Enabled = true;
            Box13.Enabled = true;
            Box14.Enabled = true;
            Box15.Enabled = true;
            Box16.Enabled = true;
            Box17.Enabled = true;
            Box18.Enabled = true;

            Box19.Enabled = true;
            Box20.Enabled = true;
            Box21.Enabled = true;
            Box22.Enabled = true;
            Box23.Enabled = true;
            Box24.Enabled = true;
            Box25.Enabled = true;
            Box26.Enabled = true;
            Box27.Enabled = true;

            Box28.Enabled = true;
            Box29.Enabled = true;
            Box30.Enabled = true;
            Box31.Enabled = true;
            Box32.Enabled = true;
            Box33.Enabled = true;
            Box34.Enabled = true;
            Box35.Enabled = true;
            Box36.Enabled = true;

            Box37.Enabled = true;
            Box38.Enabled = true;
            Box39.Enabled = true;
            Box40.Enabled = true;
            Box41.Enabled = true;
            Box42.Enabled = true;
            Box43.Enabled = true;
            Box44.Enabled = true;
            Box45.Enabled = true;

            Box46.Enabled = true;
            Box47.Enabled = true;
            Box48.Enabled = true;
            Box49.Enabled = true;
            Box50.Enabled = true;
            Box51.Enabled = true;
            Box52.Enabled = true;
            Box53.Enabled = true;
            Box54.Enabled = true;

            Box55.Enabled = true;
            Box56.Enabled = true;
            Box57.Enabled = true;
            Box58.Enabled = true;
            Box59.Enabled = true;
            Box60.Enabled = true;
            Box61.Enabled = true;
            Box62.Enabled = true;
            Box63.Enabled = true;

            Box64.Enabled = true;
            Box65.Enabled = true;
            Box66.Enabled = true;
            Box67.Enabled = true;
            Box68.Enabled = true;
            Box69.Enabled = true;
            Box70.Enabled = true;
            Box71.Enabled = true;
            Box72.Enabled = true;

            Box73.Enabled = true;
            Box74.Enabled = true;
            Box75.Enabled = true;
            Box76.Enabled = true;
            Box77.Enabled = true;
            Box78.Enabled = true;
            Box79.Enabled = true;
            Box80.Enabled = true;
            Box81.Enabled = true;
        }

        private void clearTable()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
            textBox14.Text = "";
            textBox15.Text = "";
            textBox16.Text = "";
        }

        private void clearTable9x9()
        {
            Box1.Text = "";
            Box2.Text = "";
            Box3.Text = "";
            Box4.Text = "";
            Box5.Text = "";
            Box6.Text = "";
            Box7.Text = "";
            Box8.Text = "";
            Box9.Text = "";

            Box10.Text = "";
            Box11.Text = "";
            Box12.Text = "";
            Box13.Text = "";
            Box14.Text = "";
            Box15.Text = "";
            Box16.Text = "";
            Box17.Text = "";
            Box18.Text = "";
            Box19.Text = "";


            Box20.Text = "";
            Box21.Text = "";
            Box22.Text = "";
            Box23.Text = "";
            Box24.Text = "";
            Box25.Text = "";
            Box26.Text = "";
            Box27.Text = "";
            Box28.Text = "";
            Box29.Text = "";


            Box30.Text = "";
            Box31.Text = "";
            Box32.Text = "";
            Box33.Text = "";
            Box34.Text = "";
            Box35.Text = "";
            Box36.Text = "";
            Box37.Text = "";
            Box38.Text = "";
            Box39.Text = "";


            Box40.Text = "";
            Box41.Text = "";
            Box42.Text = "";
            Box43.Text = "";
            Box44.Text = "";
            Box45.Text = "";
            Box46.Text = "";
            Box47.Text = "";
            Box48.Text = "";
            Box49.Text = "";


            Box50.Text = "";
            Box51.Text = "";
            Box52.Text = "";
            Box53.Text = "";
            Box54.Text = "";
            Box55.Text = "";
            Box56.Text = "";
            Box57.Text = "";
            Box58.Text = "";
            Box59.Text = "";


            Box60.Text = "";
            Box61.Text = "";
            Box62.Text = "";
            Box63.Text = "";
            Box64.Text = "";
            Box65.Text = "";
            Box66.Text = "";
            Box67.Text = "";
            Box68.Text = "";
            Box69.Text = "";


            Box70.Text = "";
            Box71.Text = "";
            Box72.Text = "";
            Box73.Text = "";
            Box74.Text = "";
            Box75.Text = "";
            Box76.Text = "";
            Box77.Text = "";
            Box78.Text = "";
            Box79.Text = "";


            Box80.Text = "";
            Box81.Text = "";

        }
    }
}
