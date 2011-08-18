using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    public class CheckCorrectCell
    {
        public int[,] table = new int[9, 9];
        private int[,] smallTable = new int[3, 3];

        public CheckCorrectCell()
        {
        }

        public CheckCorrectCell(int[,] iTable)
        {
            table = iTable;
        }

        public bool checkCorrectCell9x9(int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (table[x, y] == table[x, i] && y != i)
                {
                    return true;
                }
            }

            for (int j = 0; j < 9; j++)
            {
                if (table[x, y] == table[j, y] && x != j)
                {
                    return true;
                }
            }

            int[] rowCol = checkSmallPositionPart(x, y);
            int row = rowCol[0];
            int col = rowCol[1];

            for (int i = row; i < row + 3; i++)
            {
                for (int j = col; j < col + 3; j++)
                {
                    if (table[x, y] == table[i, j] && x != i && y != j)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int[] checkSmallPositionPart(int x, int y)
        {
            int[] result = new int[2];

            if (x < 3)
            {
                result[0] = 0;
            }
            else if (x >= 6)
            {
                result[0] = 6;
            }
            else
            {
                result[0] = 3;
            }

            if (y < 3)
            {
                result[1] = 0;
            }
            else if (y >= 6)
            {
                result[1] = 6;
            }
            else
            {
                result[1] = 3;
            }

            return result;
        }
    }
}
