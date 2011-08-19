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

            return table;
        }

        public int[,] getSolve9x9()
        {
            int[,] table = new int[9, 9];

            //แถวที่ 0

            table[0, 0] = 2;
            table[0, 1] = 3;
            table[0, 2] = 4;

            table[0, 3] = 9;
            table[0, 4] = 5;
            table[0, 5] = 6;

            table[0, 6] = 8;
            table[0, 7] = 1;
            table[0, 8] = 7;


            //แถวที่ 1
            table[1, 0] = 9;
            table[1, 1] = 5;
            table[1, 2] = 7;

            table[1, 3] = 8;
            table[1, 4] = 1;
            table[1, 5] = 4;

            table[1, 6] = 2;
            table[1, 7] = 6;
            table[1, 8] = 3;


            //แถวที่ 2
            table[2, 0] = 1;
            table[2, 1] = 8;
            table[2, 2] = 6;

            table[2, 3] = 3;
            table[2, 4] = 7;
            table[2, 5] = 2;

            table[2, 6] = 4;
            table[2, 7] = 5;
            table[2, 8] = 9;


            //แถวที่ 3
            table[3, 0] = 5;
            table[3, 1] = 4;
            table[3, 2] = 9;

            table[3, 3] = 6;
            table[3, 4] = 8;
            table[3, 5] = 1;

            table[3, 6] = 7;
            table[3, 7] = 3;
            table[3, 8] = 2;

            //แถวที่ 4
            table[4, 0] = 6;
            table[4, 1] = 1;
            table[4, 2] = 8;

            table[4, 3] = 7;
            table[4, 4] = 2;
            table[4, 5] = 3;

            table[4, 6] = 5;
            table[4, 7] = 9;
            table[4, 8] = 4;

            //แถวที่ 5
            table[5, 0] = 7;
            table[5, 1] = 2;
            table[5, 2] = 3;

            table[5, 3] = 4;
            table[5, 4] = 9;
            table[5, 5] = 5;

            table[5, 6] = 6;
            table[5, 7] = 8;
            table[5, 8] = 1;

            //แถวที่ 6
            table[6, 0] = 3;
            table[6, 1] = 9;
            table[6, 2] = 2;

            table[6, 3] = 5;
            table[6, 4] = 6;
            table[6, 5] = 7;

            table[6, 6] = 1;
            table[6, 7] = 4;
            table[6, 8] = 8;

            //แถวที่ 7
            table[7, 0] = 4;
            table[7, 1] = 7;
            table[7, 2] = 5;

            table[7, 3] = 1;
            table[7, 4] = 3;
            table[7, 5] = 8;

            table[7, 6] = 9;
            table[7, 7] = 2;
            table[7, 8] = 6;

            //แถวที่ 8
            table[8, 0] = 8;
            table[8, 1] = 6;
            table[8, 2] = 1;

            table[8, 3] = 2;
            table[8, 4] = 4;
            table[8, 5] = 9;

            table[8, 6] = 3;
            table[8, 7] = 7;
            table[8, 8] = 5;

            return table;
        }

        
    }
}