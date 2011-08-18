using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Sudoku
{
    class solve
    {
        
        public int[,] genSolve()
        {
            Random ran = new Random();
            int[,] table = new int[4, 4];
            List<int> pp = new List<int>();
            pp.Add(1);
            pp.Add(2);
            pp.Add(3);
            pp.Add(4);

            List<int> rr = new List<int>();
            //rr = pp;
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);

            //input indext 00
            int index = ran.Next(4);
            if (index == 0)
            {
                table[0, 0] = rr[0];
            }
            else if (index == 1)
            {
                table[0, 0] = rr[1];
            }
            else if (index == 2)
            {
                table[0, 0] = rr[2];
            }
            else
            {
                table[0, 0] = rr[3];
            }
            rr.Remove(table[0, 0]);

            //input indext 01
            index = ran.Next(3);
            if (index == 0)
            {
                table[0, 1] = rr[0];
            }
            else if (index == 1)
            {
                table[0, 1] = rr[1];
            }
            else
            {
                table[0, 1] = rr[2];
            }
            rr.Remove(table[0, 1]);

            //input index 10
            index = ran.Next(3);
            if (index == 0)
            {
                table[1, 0] = rr[0];
            }
            else
            {
                table[1, 0] = rr[1];
            }
            rr.Remove(table[1, 0]);

            //input index 11
            table[1, 1] = rr[0];

            //input index 22
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            index = ran.Next(4);
            if (index == 0)
            {
                table[2, 2] = rr[0];
            }
            else if (index == 1)
            {
                table[2, 2] = rr[1];
            }
            else if (index == 2)
            {
                table[2, 2] = rr[2];
            }
            else
            {
                table[2, 2] = rr[3];
            }

            //input index 02
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[2, 2]);
            rr.Remove(table[0, 0]);
            rr.Remove(table[0, 1]);
            if (rr.Count == 1)
            {
                table[0, 2] = rr[0];
            }
            else
            {
                index = ran.Next(2);
                if (index == 0)
                {
                    table[0, 2] = rr[0];
                }
                else
                {
                    table[0, 2] = rr[1];
                }
            }

            //input index 12
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[2, 2]);
            rr.Remove(table[1, 0]);
            rr.Remove(table[1, 1]);
            if (rr.Count == 1)
            {
                table[1, 2] = rr[0];
            }
            else
            {
                index = ran.Next(2);
                if (index == 0)
                {
                    table[1, 2] = rr[0];
                }
                else
                {
                    table[1, 2] = rr[1];
                }
            }
            Boolean check2 = true;
            while (check2 == true)
            {
                //input index 20
                rr = new List<int>();
                rr.Add(1);
                rr.Add(2);
                rr.Add(3);
                rr.Add(4);
                rr.Remove(table[2, 2]);
                rr.Remove(table[0, 0]);
                rr.Remove(table[1, 0]);
                if (rr.Count == 1)
                {
                    table[2, 0] = rr[0];
                }
                else
                {
                    index = ran.Next(2);
                    if (index == 0)
                    {
                        table[2, 0] = rr[0];
                    }
                    else
                    {
                        table[2, 0] = rr[1];
                    }
                }


                //input index 21
                rr = new List<int>();
                rr.Add(1);
                rr.Add(2);
                rr.Add(3);
                rr.Add(4);
                rr.Remove(table[2, 2]);
                rr.Remove(table[0, 1]);
                rr.Remove(table[1, 1]);
                if (rr.Count == 1)
                {
                    table[2, 1] = rr[0];
                }
                else
                {
                    index = ran.Next(2);
                    if (index == 0)
                    {
                        table[2, 1] = rr[0];
                    }
                    else
                    {
                        table[2, 1] = rr[1];
                    }
                }
                check2 = ((table[0, 2] == table[2, 1] || table[1, 2] == table[2, 1]) && (table[0, 2] == table[2, 0] || table[1, 2] == table[2, 0]));
            }

            //input index 03
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[0, 0]);
            rr.Remove(table[0, 1]);
            rr.Remove(table[0, 2]);
            table[0, 3] = rr[0];

            //input index 13
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[1, 0]);
            rr.Remove(table[1, 1]);
            rr.Remove(table[1, 2]);
            table[1, 3] = rr[0];

            //input index 23
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[2, 0]);
            rr.Remove(table[2, 1]);
            rr.Remove(table[2, 2]);
            table[2, 3] = rr[0];

            //input index 30
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[0, 0]);
            rr.Remove(table[1, 0]);
            rr.Remove(table[2, 0]);
            table[3, 0] = rr[0];

            //input index 31
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[0, 1]);
            rr.Remove(table[1, 1]);
            rr.Remove(table[2, 1]);
            table[3, 1] = rr[0];

            //input index 32
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[0, 2]);
            rr.Remove(table[1, 2]);
            rr.Remove(table[2, 2]);
            table[3, 2] = rr[0];

            //input index 33
            rr = new List<int>();
            rr.Add(1);
            rr.Add(2);
            rr.Add(3);
            rr.Add(4);
            rr.Remove(table[0, 3]);
            rr.Remove(table[1, 3]);
            rr.Remove(table[2, 3]);
            table[3, 3] = rr[0];


            return table;

        }


        public int[,] getSolve()
        {
            int[,] table = new int[4, 4];
            table = genSolve();

            //table[0, 0] = 1;
            //table[0, 1] = 2;
            //table[0, 2] = 3;
            //table[0, 3] = 4;

            //table[1, 0] = 3;
            //table[1, 1] = 4;
            //table[1, 2] = 1;
            //table[1, 3] = 2;

            //table[2, 0] = 4;
            //table[2, 1] = 1;
            //table[2, 2] = 2;
            //table[2, 3] = 3;

            //table[3, 0] = 2;
            //table[3, 1] = 3;
            //table[3, 2] = 4;
            //table[3, 3] = 1;

            return table;
        }
    }
}