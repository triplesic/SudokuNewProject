using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sudoku
{
    [TestFixture]
    class ChooselvTest
    {
        [Test]
        public void test4x4Choose()
        {
            LevelChooser lv = new Chooselv4();
            Assert.AreEqual(7,lv.selectedlv("Easy"));
            Assert.AreEqual(6, lv.selectedlv("Normal"));
            Assert.AreEqual(5, lv.selectedlv("Hard"));

        }

        [Test]
        public void test9x9Choose()
        {
            LevelChooser lv = new Chooselv9();
            Assert.AreEqual(50, lv.selectedlv("Easy"));
            Assert.AreEqual(40, lv.selectedlv("Normal"));
            Assert.AreEqual(30, lv.selectedlv("Hard"));

        }
    }
}
