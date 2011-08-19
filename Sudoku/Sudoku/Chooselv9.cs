using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Chooselv9 : LevelChooser
    {
        public int selectedlv(String txtlv)
        {

                if (txtlv.Equals("Easy"))
                {
                    return 50;

                }
                else if (txtlv.Equals("Normal"))
                {
                    return 40;

                }
                else if (txtlv.Equals("Hard"))
                {
                    return 30;

                }
                else
                {
                    return 0;
                }
            
        }
    }
}

     