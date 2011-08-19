using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sudoku
{
    [TestFixture]
    class Generate4Test
    {
        [Test]
        public void testGenOK1()
        {
            solve s = new solve();           
            GenerateNumber g = new Generate4();
            LevelChooser lv = new Chooselv4();
            int[,] test = new int[4, 4];           
            Assert.AreNotEqual(test,g.generatePosition(s.getSolve(), lv.selectedlv("Easy")));
        }
        [Test]
        public void testGenOK2()
        {
            solve s = new solve();
            GenerateNumber g = new Generate4();
            LevelChooser lv = new Chooselv4();
            int[,] test = new int[4, 4];
            Assert.AreNotEqual(test, g.generatePosition(s.getSolve(), lv.selectedlv("Normal")));
        }

        [Test]
        public void testGenOK3()
        {
            solve s = new solve();
            GenerateNumber g = new Generate4();
            LevelChooser lv = new Chooselv4();
            int[,] test = new int[4, 4];
            Assert.AreNotEqual(test, g.generatePosition(s.getSolve(), lv.selectedlv("Hard")));
        }   


    }
}
