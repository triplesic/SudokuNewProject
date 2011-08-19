using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sudoku
{
    class Chooselv : LevelChooser
    {
        public int selectedlv(String txtlv, int dimension)
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

        //    }else if(dimension==4){

        //        if (txtlv.Equals("Easy"))
        //        {
        //            return  7;

        //        }
        //        else if (txtlv.Equals("Normal"))
        //        {
        //            return  6;

        //        }
        //        else if (txtlv.Equals("Hard"))
        //        {
        //            return  5;

        //        }
        //        else
        //        {
        //            return  0;
        //        }
        //    }else
        //    {
        //        return  0;
        //    }
        //}
