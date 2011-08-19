using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Chooselv4 : LevelChooser
    {
        public int selectedlv(String txtlv)
        {

            if (txtlv.Equals("Easy"))
            {
                return 7;

            }
            else if (txtlv.Equals("Normal"))
            {
                return 6;

            }
            else if (txtlv.Equals("Hard"))
            {
                return 5;

            }
            else
            {
                return 0;
            }


        }
    }
}
