using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Sudoku
{
    [TestFixture]
    class CheckCorrectCellTest
    {
        CheckCorrectCell C = new CheckCorrectCell();
        CheckCorrectCell C2;
        solve S = new solve();

        [SetUp]
        public void Init()
        {
            C2 = new CheckCorrectCell(S.getSolve9x9());
            C.Table = S.getSolve9x9();
        }

        [Test]
        public void TableGetTest_01()
        {
            Assert.AreEqual(S.getSolve9x9(), C2.Table);
        }

        [Test]
        public void TableGetTest2_02()
        {
            Assert.AreEqual(S.getSolve9x9(), C.Table);
        }

        [Test]
        public void CheckCorrectCell9x9Test_01()
        {
            Assert.AreEqual(false, C.checkCorrectCell9x9(2,6));
        }

        [Test]
        public void CheckCorrectCell9x9Test_02()
        {
            C2.Table[2, 6] = 5;
            Assert.AreEqual(true, C2.checkCorrectCell9x9(2, 6));
        }

        [Test]
        public void CheckSmallPositionPart_01()
        {
            Assert.AreEqual(new int[] { 0, 0 }, C.checkSmallPositionPart(0,0));
        }

        [Test]
        public void CheckSmallPositionPart_02()
        {
            Assert.AreEqual(new int[] { 0, 3 }, C.checkSmallPositionPart(2, 4));
        }

        [Test]
        public void CheckSmallPositionPart_03()
        {
            Assert.AreEqual(new int[] { 0, 6 }, C2.checkSmallPositionPart(1, 8));
        }

        [Test]
        public void CheckSmallPositionPart_04()
        {
            Assert.AreEqual(new int[] { 3, 0 }, C2.checkSmallPositionPart(4, 1));
        }

        [Test]
        public void CheckSmallPositionPart_05()
        {
            Assert.AreEqual(new int[] { 3, 3 }, C2.checkSmallPositionPart(4, 5));
        }

        [Test]
        public void CheckSmallPositionPart_06()
        {
            Assert.AreEqual(new int[] { 3, 6 }, C2.checkSmallPositionPart(5, 7));
        }

        [Test]
        public void CheckSmallPositionPart_07()
        {
            Assert.AreEqual(new int[] { 6, 0 }, C2.checkSmallPositionPart(7, 1));
        }

        [Test]
        public void CheckSmallPositionPart_08()
        {
            Assert.AreEqual(new int[] { 6, 3 }, C2.checkSmallPositionPart(6, 3));
        }

        [Test]
        public void CheckSmallPositionPart_09()
        {
            Assert.AreEqual(new int[] { 6, 6 }, C2.checkSmallPositionPart(8, 8));
        }
        
    }
}
