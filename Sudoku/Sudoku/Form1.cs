﻿using System;
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
        CheckCorrectCell CCC = new CheckCorrectCell();
        private int valueLevel4x4;
        private int valueLevel9x9;

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

            GenerateNumber gg = new Generate4();
            table = s.getSolve();
            mapArrayToTable(gg.generatePosition(table, valueLevel4x4));
            
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

            GenerateNumber gg = new Generate9();
            table = s.getSolve9x9();
            mapArrayToTable9x9(gg.generatePosition(table, valueLevel9x9));
            Box1.BackColor = Color.White;
            Box2.BackColor = Color.White;
            Box3.BackColor = Color.White;
            Box4.BackColor = Color.White;
            Box5.BackColor = Color.White;
            Box6.BackColor = Color.White;
            Box7.BackColor = Color.White;
            Box8.BackColor = Color.White;
            Box9.BackColor = Color.White;
            Box10.BackColor = Color.White;

            Box11.BackColor = Color.White;
            Box12.BackColor = Color.White;
            Box13.BackColor = Color.White;
            Box14.BackColor = Color.White;
            Box15.BackColor = Color.White;
            Box16.BackColor = Color.White;
            Box17.BackColor = Color.White;
            Box18.BackColor = Color.White;
            Box19.BackColor = Color.White;
            Box20.BackColor = Color.White;

            Box21.BackColor = Color.White;
            Box22.BackColor = Color.White;
            Box23.BackColor = Color.White;
            Box24.BackColor = Color.White;
            Box25.BackColor = Color.White;
            Box26.BackColor = Color.White;
            Box27.BackColor = Color.White;
            Box28.BackColor = Color.White;
            Box29.BackColor = Color.White;
            Box30.BackColor = Color.White;

            Box31.BackColor = Color.White;
            Box32.BackColor = Color.White;
            Box33.BackColor = Color.White;
            Box34.BackColor = Color.White;
            Box35.BackColor = Color.White;
            Box36.BackColor = Color.White;
            Box37.BackColor = Color.White;
            Box38.BackColor = Color.White;
            Box39.BackColor = Color.White;
            Box40.BackColor = Color.White;

            Box41.BackColor = Color.White;
            Box42.BackColor = Color.White;
            Box43.BackColor = Color.White;
            Box44.BackColor = Color.White;
            Box45.BackColor = Color.White;
            Box46.BackColor = Color.White;
            Box47.BackColor = Color.White;
            Box48.BackColor = Color.White;
            Box49.BackColor = Color.White;
            Box50.BackColor = Color.White;

            Box51.BackColor = Color.White;
            Box52.BackColor = Color.White;
            Box53.BackColor = Color.White;
            Box54.BackColor = Color.White;
            Box55.BackColor = Color.White;
            Box56.BackColor = Color.White;
            Box57.BackColor = Color.White;
            Box58.BackColor = Color.White;
            Box59.BackColor = Color.White;
            Box60.BackColor = Color.White;

            Box61.BackColor = Color.White;
            Box62.BackColor = Color.White;
            Box63.BackColor = Color.White;
            Box64.BackColor = Color.White;
            Box65.BackColor = Color.White;
            Box66.BackColor = Color.White;
            Box67.BackColor = Color.White;
            Box68.BackColor = Color.White;
            Box69.BackColor = Color.White;
            Box70.BackColor = Color.White;

            Box71.BackColor = Color.White;
            Box72.BackColor = Color.White;
            Box73.BackColor = Color.White;
            Box74.BackColor = Color.White;
            Box75.BackColor = Color.White;
            Box76.BackColor = Color.White;
            Box77.BackColor = Color.White;
            Box78.BackColor = Color.White;
            Box79.BackColor = Color.White;
            Box80.BackColor = Color.White;

            Box81.BackColor = Color.White;
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


        private int[,] mapTableToArray()
        {
            int[,] map = new int[9, 9];

                try { map[0, 0] = Convert.ToInt32(Box1.Text); }
                catch { }
                try { map[0, 1] = Convert.ToInt32(Box2.Text);}
                catch { }
                try { map[0, 2] = Convert.ToInt32(Box3.Text);}
                catch { }
                try { map[0, 3] = Convert.ToInt32(Box4.Text);}
                catch { }
                try { map[0, 4] = Convert.ToInt32(Box5.Text);}
                catch { }
                try { map[0, 5] = Convert.ToInt32(Box6.Text);}
                catch { }
                try { map[0, 6] = Convert.ToInt32(Box7.Text);}
                catch { }
                try { map[0, 7] = Convert.ToInt32(Box8.Text);}
                catch { }
                try { map[0, 8] = Convert.ToInt32(Box9.Text);}
                catch { }

                
                try {  map[1, 0] = Convert.ToInt32(Box10.Text);}
                catch { }
                try {  map[1, 1] = Convert.ToInt32(Box11.Text);}
                catch { }
                try { map[1, 2] = Convert.ToInt32(Box12.Text);}
                catch { }
                try { map[1, 3] = Convert.ToInt32(Box13.Text);}
                catch { }
                try { map[1, 4] = Convert.ToInt32(Box14.Text);}
                catch { }
                try {  map[1, 5] = Convert.ToInt32(Box15.Text);}
                catch { }
                try { map[1, 6] = Convert.ToInt32(Box16.Text);}
                catch { }
                try {  map[1, 7] = Convert.ToInt32(Box17.Text);}
                catch { }
                try { map[1, 8] = Convert.ToInt32(Box18.Text);}
                catch { }

                
                try { map[2, 0] = Convert.ToInt32(Box19.Text); }
                catch { }
                try { map[2, 1] = Convert.ToInt32(Box20.Text);}
                catch { }
                try { map[2, 2] = Convert.ToInt32(Box21.Text);}
                catch { }
                try {  map[2, 3] = Convert.ToInt32(Box22.Text);}
                catch { }
                try { map[2, 4] = Convert.ToInt32(Box23.Text);}
                catch { }
                try { map[2, 5] = Convert.ToInt32(Box24.Text);}
                catch { }
                try { map[2, 6] = Convert.ToInt32(Box25.Text);}
                catch { }
                try { map[2, 7] = Convert.ToInt32(Box26.Text);}
                catch { }
                try { map[2, 8] = Convert.ToInt32(Box27.Text);}
                catch { }


                try { map[3, 0] = Convert.ToInt32(Box28.Text);}
                catch { }
                try { map[3, 1] = Convert.ToInt32(Box29.Text);}
                catch { }
                try { map[3, 2] = Convert.ToInt32(Box30.Text);}
                catch { }
                try { map[3, 3] = Convert.ToInt32(Box31.Text);}
                catch { }
                try { map[3, 4] = Convert.ToInt32(Box32.Text);}
                catch { }
                try { map[3, 5] = Convert.ToInt32(Box33.Text);}
                catch { }
                try { map[3, 6] = Convert.ToInt32(Box34.Text);}
                catch { }
                try { map[3, 7] = Convert.ToInt32(Box35.Text);}
                catch { }
                try { map[3, 8] = Convert.ToInt32(Box36.Text);}
                catch { }


                try { map[4, 0] = Convert.ToInt32(Box37.Text);}
                catch { }
                try { map[4, 1] = Convert.ToInt32(Box38.Text);}
                catch { }
                try { map[4, 2] = Convert.ToInt32(Box39.Text);}
                catch { }
                try { map[4, 3] = Convert.ToInt32(Box40.Text);}
                catch { }
                try { map[4, 4] = Convert.ToInt32(Box41.Text);}
                catch { }
                try { map[4, 5] = Convert.ToInt32(Box42.Text);}
                catch { }
                try { map[4, 6] = Convert.ToInt32(Box43.Text);}
                catch { }
                try { map[4, 7] = Convert.ToInt32(Box44.Text);}
                catch { }
                try { map[4, 8] = Convert.ToInt32(Box45.Text);}
                catch { }


                try { map[5, 0] = Convert.ToInt32(Box46.Text); }
                catch { }
                try { map[5, 1] = Convert.ToInt32(Box47.Text); }
                catch { }
                try { map[5, 2] = Convert.ToInt32(Box48.Text); }
                catch { }
                try { map[5, 3] = Convert.ToInt32(Box49.Text); }
                catch { }
                try { map[5, 4] = Convert.ToInt32(Box50.Text);}
                catch { }
                try { map[5, 5] = Convert.ToInt32(Box51.Text);}
                catch { }
                try { map[5, 6] = Convert.ToInt32(Box52.Text);}
                catch { }
                try { map[5, 7] = Convert.ToInt32(Box53.Text);}
                catch { }
                try { map[5, 8] = Convert.ToInt32(Box54.Text);}
                catch { }


                try { map[6, 0] = Convert.ToInt32(Box55.Text); }
                catch { }
                try { map[6, 1] = Convert.ToInt32(Box56.Text);}
                catch { }
                try {map[6, 2] = Convert.ToInt32(Box57.Text); }
                catch { }
                try { map[6, 3] = Convert.ToInt32(Box58.Text);}
                catch { }
                try { map[6, 4] = Convert.ToInt32(Box59.Text);}
                catch { }
                try { map[6, 5] = Convert.ToInt32(Box60.Text);}
                catch { }
                try { map[6, 6] = Convert.ToInt32(Box61.Text);}
                catch { }
                try { map[6, 7] = Convert.ToInt32(Box62.Text);}
                catch { }
                try {  map[6, 8] = Convert.ToInt32(Box63.Text);}
                catch { }

                
                try { map[7, 0] = Convert.ToInt32(Box64.Text); }
                catch { }
                try { map[7, 1] = Convert.ToInt32(Box65.Text);}
                catch { }
                try { map[7, 2] = Convert.ToInt32(Box66.Text);}
                catch { }
                try { map[7, 3] = Convert.ToInt32(Box67.Text);}
                catch { }
                try { map[7, 4] = Convert.ToInt32(Box68.Text);}
                catch { }
                try { map[7, 5] = Convert.ToInt32(Box69.Text);}
                catch { }
                try { map[7, 6] = Convert.ToInt32(Box70.Text);}
                catch { }
                try { map[7, 7] = Convert.ToInt32(Box71.Text);}
                catch { }
                try { map[7, 8] = Convert.ToInt32(Box72.Text);}
                catch { }


                try { map[8, 0] = Convert.ToInt32(Box73.Text);}
                catch { }
                try { map[8, 1] = Convert.ToInt32(Box74.Text);}
                catch { }
                try { map[8, 2] = Convert.ToInt32(Box75.Text);}
                catch { }
                try { map[8, 3] = Convert.ToInt32(Box76.Text);}
                catch { }
                try { map[8, 4] = Convert.ToInt32(Box77.Text);}
                catch { }
                try { map[8, 5] = Convert.ToInt32(Box78.Text);}
                catch { }
                try { map[8, 6] = Convert.ToInt32(Box79.Text);}
                catch { }
                try { map[8, 7] = Convert.ToInt32(Box80.Text);}
                catch { }
                try { map[8, 8] = Convert.ToInt32(Box81.Text);}
                catch { }
                
            return map;
        }

        private void Box1_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray();

            CCC = new CheckCorrectCell(arr);

            if (CCC.checkCorrectCell9x9(0,0) && 
                
                Box1.Text != "")
            {
                Box1.BackColor = Color.Red;
            }
            else
                Box1.BackColor = Color.White;
            congratulations9x9();

        }

        private void Box2_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray();

            CCC = new CheckCorrectCell(arr);

            if (CCC.checkCorrectCell9x9(0, 1) &&

                Box2.Text != "")
            {
                Box2.BackColor = Color.Red;
            }
            else
                Box2.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box3_TextChanged(object sender, EventArgs e) {int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
         if (CCC.checkCorrectCell9x9(0, 2) &&
             Box3.Text != ""){
                Box3.BackColor = Color.Red;} else
                Box3.BackColor = Color.White;
         congratulations9x9();
        }

        private void Box4_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(0, 3) &&
                Box4.Text != "")
            {
                Box4.BackColor = Color.Red;
            }
            else
                Box4.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box5_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(0, 4) &&
                Box5.Text != "")
            {
                Box5.BackColor = Color.Red;
            }
            else
                Box5.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box6_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(0, 5) &&
                Box6.Text != "")
            {
                Box6.BackColor = Color.Red;
            }
            else
                Box6.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box7_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(0, 6) &&
                Box7.Text != "")
            {
                Box7.BackColor = Color.Red;
            }
            else
                Box7.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box8_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(0, 7) &&
                Box8.Text != "")
            {
                Box8.BackColor = Color.Red;
            }
            else
                Box8.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box9_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(0, 8) &&
                Box9.Text != "")
            {
                Box9.BackColor = Color.Red;
            }
            else
                Box9.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box10_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 0) &&
                Box10.Text != "")
            {
                Box10.BackColor = Color.Red;
            }
            else
                Box10.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box11_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 1) &&
                Box11.Text != "")
            {
                Box11.BackColor = Color.Red;
            }
            else
                Box11.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box12_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 2) &&
                Box12.Text != "")
            {
                Box12.BackColor = Color.Red;
            }
            else
                Box12.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box13_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 3) &&
                Box13.Text != "")
            {
                Box13.BackColor = Color.Red;
            }
            else
                Box13.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box14_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 4) &&
                Box14.Text != "")
            {
                Box14.BackColor = Color.Red;
            }
            else
                Box14.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box15_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 5) &&
                Box15.Text != "")
            {
                Box15.BackColor = Color.Red;
            }
            else
                Box15.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box16_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 6) &&
                Box16.Text != "")
            {
                Box16.BackColor = Color.Red;
            }
            else
                Box16.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box17_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 7) &&
                Box17.Text != "")
            {
                Box17.BackColor = Color.Red;
            }
            else
                Box17.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box18_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(1, 8) &&
                Box18.Text != "")
            {
                Box18.BackColor = Color.Red;
            }
            else
                Box18.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box19_TextChanged(object sender, EventArgs e)
        {
               int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 0) &&
                Box19.Text != "")
            {
                Box19.BackColor = Color.Red;
            }
            else
                Box19.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box20_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 1) &&
                Box20.Text != "")
            {
                Box20.BackColor = Color.Red;
            }
            else
                Box20.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box21_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 2) &&
                Box21.Text != "")
            {
                Box21.BackColor = Color.Red;
            }
            else
                Box21.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box22_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 3) &&
                Box22.Text != "")
            {
                Box22.BackColor = Color.Red;
            }
            else
                Box22.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box23_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 4) &&
                Box23.Text != "")
            {
                Box23.BackColor = Color.Red;
            }
            else
                Box23.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box24_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 5) &&
                Box24.Text != "")
            {
                Box24.BackColor = Color.Red;
            }
            else
                Box24.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box25_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 6) &&
                Box25.Text != "")
            {
                Box25.BackColor = Color.Red;
            }
            else
                Box25.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box26_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 7) &&
                Box26.Text != "")
            {
                Box26.BackColor = Color.Red;
            }
            else
                Box26.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box27_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(2, 8) &&
                Box27.Text != "")
            {
                Box27.BackColor = Color.Red;
            }
            else
                Box27.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box28_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 0) &&
                Box28.Text != "")
            {
                Box28.BackColor = Color.Red;
            }
            else
                Box28.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box29_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 1) &&
                Box29.Text != "")
            {
                Box29.BackColor = Color.Red;
            }
            else
                Box29.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box30_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 2) &&
                Box30.Text != "")
            {
                Box30.BackColor = Color.Red;
            }
            else
                Box30.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box31_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 3) &&
                Box31.Text != "")
            {
                Box31.BackColor = Color.Red;
            }
            else
                Box31.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box32_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 4) &&
                Box32.Text != "")
            {
                Box32.BackColor = Color.Red;
            }
            else
                Box32.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box33_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 5) &&
                Box33.Text != "")
            {
                Box33.BackColor = Color.Red;
            }
            else
                Box33.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box34_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 6) &&
                Box34.Text != "")
            {
                Box34.BackColor = Color.Red;
            }
            else
                Box34.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box35_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 7) &&
                Box35.Text != "")
            {
                Box35.BackColor = Color.Red;
            }
            else
                Box35.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box36_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(3, 8) &&
                Box36.Text != "")
            {
                Box36.BackColor = Color.Red;
            }
            else
                Box36.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box37_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 0) &&
                Box37.Text != "")
            {
                Box37.BackColor = Color.Red;
            }
            else
                Box37.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box38_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 1) &&
                Box38.Text != "")
            {
                Box38.BackColor = Color.Red;
            }
            else
                Box38.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box39_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 2) &&
                Box39.Text != "")
            {
                Box39.BackColor = Color.Red;
            }
            else
                Box39.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box40_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 3) &&
                Box40.Text != "")
            {
                Box40.BackColor = Color.Red;
            }
            else
                Box40.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box41_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 4) &&
                Box41.Text != "")
            {
                Box41.BackColor = Color.Red;
            }
            else
                Box41.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box42_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 5) &&
                Box42.Text != "")
            {
                Box42.BackColor = Color.Red;
            }
            else
                Box42.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box43_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 6) &&
                Box43.Text != "")
            {
                Box43.BackColor = Color.Red;
            }
            else
                Box43.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box44_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 7) &&
                Box44.Text != "")
            {
                Box44.BackColor = Color.Red;
            }
            else
                Box44.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box45_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(4, 8) &&
                Box45.Text != "")
            {
                Box45.BackColor = Color.Red;
            }
            else
                Box45.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box46_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 0) &&
                Box46.Text != "")
            {
                Box46.BackColor = Color.Red;
            }
            else
                Box46.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box47_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 1) &&
                Box47.Text != "")
            {
                Box47.BackColor = Color.Red;
            }
            else
                Box47.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box48_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 2) &&
                Box48.Text != "")
            {
                Box48.BackColor = Color.Red;
            }
            else
                Box48.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box49_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 3) &&
                Box49.Text != "")
            {
                Box49.BackColor = Color.Red;
            }
            else
                Box49.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box50_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 4) &&
                Box50.Text != "")
            {
                Box50.BackColor = Color.Red;
            }
            else
                Box50.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box51_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 5) &&
                Box51.Text != "")
            {
                Box51.BackColor = Color.Red;
            }
            else
                Box51.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box52_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 6) &&
                Box52.Text != "")
            {
                Box52.BackColor = Color.Red;
            }
            else
                Box52.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box53_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 7) &&
                Box53.Text != "")
            {
                Box53.BackColor = Color.Red;
            }
            else
                Box53.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box54_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(5, 8) &&
                Box54.Text != "")
            {
                Box54.BackColor = Color.Red;
            }
            else
                Box54.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box55_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 0) &&
                Box55.Text != "")
            {
                Box55.BackColor = Color.Red;
            }
            else
                Box55.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box56_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 1) &&
                Box56.Text != "")
            {
                Box56.BackColor = Color.Red;
            }
            else
                Box56.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box57_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 2) &&
                Box57.Text != "")
            {
                Box57.BackColor = Color.Red;
            }
            else
                Box57.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box58_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 3) &&
                Box58.Text != "")
            {
                Box58.BackColor = Color.Red;
            }
            else
                Box58.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box59_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 4) &&
                Box59.Text != "")
            {
                Box59.BackColor = Color.Red;
            }
            else
                Box59.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box60_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 5) &&
                Box60.Text != "")
            {
                Box60.BackColor = Color.Red;
            }
            else
                Box60.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box61_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 6) &&
                Box61.Text != "")
            {
                Box61.BackColor = Color.Red;
            }
            else
                Box61.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box62_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 7) &&
                Box62.Text != "")
            {
                Box62.BackColor = Color.Red;
            }
            else
                Box62.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box63_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(6, 8) &&
                Box63.Text != "")
            {
                Box63.BackColor = Color.Red;
            }
            else
                Box63.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box64_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 0) &&
                Box64.Text != "")
            {
                Box64.BackColor = Color.Red;
            }
            else
                Box64.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box65_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 1) &&
                Box65.Text != "")
            {
                Box65.BackColor = Color.Red;
            }
            else
                Box65.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box66_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 2) &&
                Box66.Text != "")
            {
                Box66.BackColor = Color.Red;
            }
            else
                Box66.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box67_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 3) &&
                Box67.Text != "")
            {
                Box67.BackColor = Color.Red;
            }
            else
                Box67.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box68_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 4) &&
                Box68.Text != "")
            {
                Box68.BackColor = Color.Red;
            }
            else
                Box68.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box69_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 5) &&
                Box69.Text != "")
            {
                Box69.BackColor = Color.Red;
            }
            else
                Box69.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box70_TextChanged(object sender, EventArgs e)
        {
             int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 6) &&
                Box70.Text != "")
            {
                Box70.BackColor = Color.Red;
            }
            else
                Box70.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box71_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 7) &&
                Box71.Text != "")
            {
                Box71.BackColor = Color.Red;
            }
            else
                Box71.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box72_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(7, 8) &&
                Box72.Text != "")
            {
                Box72.BackColor = Color.Red;
            }
            else
                Box72.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box73_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 0) &&
                Box73.Text != "")
            {
                Box73.BackColor = Color.Red;
            }
            else
                Box73.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box74_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 1) &&
                Box74.Text != "")
            {
                Box74.BackColor = Color.Red;
            }
            else
                Box74.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box75_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 2) &&
                Box75.Text != "")
            {
                Box75.BackColor = Color.Red;
            }
            else
                Box75.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box76_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 3) &&
                Box76.Text != "")
            {
                Box76.BackColor = Color.Red;
            }
            else
                Box76.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box77_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 4) &&
                Box77.Text != "")
            {
                Box77.BackColor = Color.Red;
            }
            else
                Box77.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box78_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 5) &&
                Box78.Text != "")
            {
                Box78.BackColor = Color.Red;
            }
            else
                Box78.BackColor = Color.White;
            congratulations9x9();
        }

        private void Box79_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8,6) &&
                Box79.Text != "")
            {
                Box79.BackColor = Color.Red;
            }
            else
                Box79.BackColor = Color.White;

            congratulations9x9();
        }

        private void Box80_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 7) &&
                Box80.Text != "")
            {
                Box80.BackColor = Color.Red;
            }
            else
                Box80.BackColor = Color.White;

            congratulations9x9();
        }

        private void Box81_TextChanged(object sender, EventArgs e)
        {
            int[,] arr = mapTableToArray(); CCC = new CheckCorrectCell(arr);
            if (CCC.checkCorrectCell9x9(8, 8) &&
                Box81.Text != "")
            {
                Box81.BackColor = Color.Red;
            }
            else
                Box81.BackColor = Color.White;

            congratulations9x9();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelChooser c1 = new Chooselv9();
            valueLevel9x9 = c1.selectedlv(comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LevelChooser c1 = new Chooselv4();
            valueLevel4x4 = c1.selectedlv(comboBox2.Text);
        }
        


        public void congratulations9x9()
        {
            if (Box1.Text != "" && Box2.Text != "" && Box3.Text != "" &&
                Box4.Text != "" && Box5.Text != "" && Box6.Text != "" &&
                Box7.Text != "" && Box8.Text != "" && Box9.Text != "" &&

                Box10.Text != "" && Box11.Text != "" && Box12.Text != "" &&
                Box13.Text != "" && Box14.Text != "" && Box15.Text != "" &&
                Box16.Text != "" && Box17.Text != "" && Box18.Text != "" &&

                Box19.Text != "" && Box20.Text != "" && Box21.Text != "" &&
                Box22.Text != "" && Box23.Text != "" && Box24.Text != "" &&
                Box25.Text != "" && Box26.Text != "" && Box27.Text != "" &&

                Box28.Text != "" && Box29.Text != "" && Box30.Text != "" &&
                Box31.Text != "" && Box32.Text != "" && Box33.Text != "" &&
                Box34.Text != "" && Box35.Text != "" && Box36.Text != "" &&

                Box37.Text != "" && Box38.Text != "" && Box39.Text != "" &&
                Box40.Text != "" && Box41.Text != "" && Box42.Text != "" &&
                Box43.Text != "" && Box44.Text != "" && Box45.Text != "" &&

                Box46.Text != "" && Box47.Text != "" && Box48.Text != "" &&
                Box49.Text != "" && Box50.Text != "" && Box51.Text != "" &&
                Box52.Text != "" && Box53.Text != "" && Box54.Text != "" &&

                Box55.Text != "" && Box56.Text != "" && Box57.Text != "" &&
                Box58.Text != "" && Box59.Text != "" && Box60.Text != "" &&
                Box61.Text != "" && Box62.Text != "" && Box63.Text != "" &&

                Box64.Text != "" && Box65.Text != "" && Box66.Text != "" &&
                Box67.Text != "" && Box68.Text != "" && Box69.Text != "" &&
                Box70.Text != "" && Box71.Text != "" && Box72.Text != "" &&

                Box73.Text != "" && Box74.Text != "" && Box75.Text != "" &&
                Box76.Text != "" && Box77.Text != "" && Box78.Text != "" &&
                Box79.Text != "" && Box80.Text != "" && Box81.Text != "")
            {

                if (Box1.BackColor != Color.Red && Box2.BackColor != Color.Red && Box3.BackColor != Color.Red &&
                    Box4.BackColor != Color.Red && Box5.BackColor != Color.Red && Box6.BackColor != Color.Red &&
                    Box7.BackColor != Color.Red && Box8.BackColor != Color.Red && Box9.BackColor != Color.Red &&

                    Box10.BackColor != Color.Red && Box11.BackColor != Color.Red && Box12.BackColor != Color.Red &&
                    Box13.BackColor != Color.Red && Box14.BackColor != Color.Red && Box15.BackColor != Color.Red &&
                    Box16.BackColor != Color.Red && Box17.BackColor != Color.Red && Box18.BackColor != Color.Red &&

                    Box19.BackColor != Color.Red && Box20.BackColor != Color.Red && Box21.BackColor != Color.Red &&
                    Box22.BackColor != Color.Red && Box23.BackColor != Color.Red && Box24.BackColor != Color.Red &&
                    Box25.BackColor != Color.Red && Box26.BackColor != Color.Red && Box27.BackColor != Color.Red &&

                    Box28.BackColor != Color.Red && Box29.BackColor != Color.Red && Box30.BackColor != Color.Red &&
                    Box31.BackColor != Color.Red && Box32.BackColor != Color.Red && Box33.BackColor != Color.Red &&
                    Box34.BackColor != Color.Red && Box35.BackColor != Color.Red && Box36.BackColor != Color.Red &&

                    Box37.BackColor != Color.Red && Box38.BackColor != Color.Red && Box39.BackColor != Color.Red &&
                    Box40.BackColor != Color.Red && Box41.BackColor != Color.Red && Box42.BackColor != Color.Red &&
                    Box43.BackColor != Color.Red && Box44.BackColor != Color.Red && Box45.BackColor != Color.Red &&

                    Box46.BackColor != Color.Red && Box47.BackColor != Color.Red && Box48.BackColor != Color.Red &&
                    Box49.BackColor != Color.Red && Box50.BackColor != Color.Red && Box51.BackColor != Color.Red &&
                    Box52.BackColor != Color.Red && Box53.BackColor != Color.Red && Box54.BackColor != Color.Red &&

                    Box55.BackColor != Color.Red && Box56.BackColor != Color.Red && Box57.BackColor != Color.Red &&
                    Box58.BackColor != Color.Red && Box59.BackColor != Color.Red && Box60.BackColor != Color.Red &&
                    Box61.BackColor != Color.Red && Box62.BackColor != Color.Red && Box63.BackColor != Color.Red &&

                    Box64.BackColor != Color.Red && Box65.BackColor != Color.Red && Box66.BackColor != Color.Red &&
                    Box67.BackColor != Color.Red && Box68.BackColor != Color.Red && Box69.BackColor != Color.Red &&
                    Box70.BackColor != Color.Red && Box71.BackColor != Color.Red && Box72.BackColor != Color.Red &&

                    Box73.BackColor != Color.Red && Box74.BackColor != Color.Red && Box75.BackColor != Color.Red &&
                    Box76.BackColor != Color.Red && Box77.BackColor != Color.Red && Box78.BackColor != Color.Red &&
                    Box79.BackColor != Color.Red && Box80.BackColor != Color.Red && Box81.BackColor != Color.Red)
                {
                    label2.Visible = true;
                }

            }
            else
            {

                label2.Visible = false;
            }
        }

    
    }
}
