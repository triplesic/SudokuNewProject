using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sudoku
{
    [TestFixture]
    class TestGenerate
    {
        [Test]
        public void testgeneratePosition()
        {
             GenerateNumber gg = new Generate9();
            solve s = new solve();
            int[,] table = s.getSolve9x9();
            GenerateNumber g = new Generate4();
            g.generatePosition()
        
        }
    }
}
