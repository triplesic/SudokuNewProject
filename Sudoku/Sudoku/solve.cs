using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class solve
    {
        public int[ , ] getSolve() { 
        
            int [ , ] table = new int[4,4];

            table[0,0] = 1;
            table[0,1] = 2;
            table[0,2] = 3;
            table[0,3] = 4;

            table[1,0] = 3;
            table[1,1] = 4;
            table[1,2] = 1;
            table[1,3] = 2;

            table[2,0] = 4;
            table[2,1] = 1;
            table[2,2] = 2;
            table[2,3] = 3;

            table[3,0] = 2;
            table[3,1] = 3;
            table[3,2] = 4;
            table[3,3] = 1;

        return table;

        }
    }
}
