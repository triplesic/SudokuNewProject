using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sudoku
{
    class Generate9Test
    {
        [Test]
        public void testGenOK1()
        {
            solve s = new solve();
            GenerateNumber g = new Generate9();
            LevelChooser lv = new Chooselv9();
            int[,] test = new int[9, 9];
            Assert.AreNotEqual(test, g.generatePosition(s.getSolve9x9(), lv.selectedlv("Easy")));
        }
        [Test]
        public void testGenOK2()
        {
            solve s = new solve();
            GenerateNumber g = new Generate9();
            LevelChooser lv = new Chooselv9();
            int[,] test = new int[9, 9];
            Assert.AreNotEqual(test, g.generatePosition(s.getSolve9x9(), lv.selectedlv("Normal")));
        }

        [Test]
        public void testGenOK3()
        {
            solve s = new solve();
            GenerateNumber g = new Generate9();
            LevelChooser lv = new Chooselv9();
            int[,] test = new int[9, 9];
            Assert.AreNotEqual(test, g.generatePosition(s.getSolve9x9(), lv.selectedlv("Hard")));
        }
    }
}
