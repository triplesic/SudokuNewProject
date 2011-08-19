using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Generate9 : GenerateNumber
    {
        public int[,] generatePosition(int[,] table, int value)
        {
            int[,] gen = new int[9, 9];
            Random r = new Random();
            int x, y;

            for (int i = 0; i < value; i++)
            {
                x = r.Next(9);
                y = r.Next(9);

                if (gen[x, y] != 0 && i != 0)
                {
                    i--;
                }
                else
                {
                    gen[x, y] = table[x, y];
                }

                gen[x, y] = table[x, y];
            }
            return gen;
        }

      
    }
}
