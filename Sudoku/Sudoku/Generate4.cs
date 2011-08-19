using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Generate4 : GenerateNumber
    {
        public int[,] generatePosition(int[,] table, int value)
        {

            int[,] arrGen = new int[4, 4];
            Random r = new Random();
            int x, y;            

            for (int i = 0; i < value; i++)
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

            return arrGen;
        }
   
    }
    
}
