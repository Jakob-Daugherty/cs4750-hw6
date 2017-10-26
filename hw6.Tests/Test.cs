using NUnit.Framework;
using System;
using System.Linq;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
using hw6;

namespace hw6.Tests
{
    [TestFixture]
    public class Test
    {
        [Test]
        public void TestCase()
        {
        }
    }

    [TestFixture]
    public class TestBoard
    {
        [Test]
        public void Test_Game_04()
        {
            Board board = new Board();

            board.SetSquareValue(1,1,6);
            board.SetSquareValue(1,2,7);
            board.SetSquareValue(2,2,2);
            board.SetSquareValue(2,3,5);
            board.SetSquareValue(3,2,9);
            board.SetSquareValue(3,4,5);
            board.SetSquareValue(3,5,6);
            board.SetSquareValue(3,7,2);

            board.SetSquareValue(4,1,3);
            board.SetSquareValue(4,5,8);
            board.SetSquareValue(4,7,9);
            board.SetSquareValue(5,7,8);
            board.SetSquareValue(5,9,1);
            board.SetSquareValue(6,4,4);
            board.SetSquareValue(6,5,7);

            board.SetSquareValue(7,3,8);
            board.SetSquareValue(7,4,6);
            board.SetSquareValue(7,8,9);
            board.SetSquareValue(8,8,1);
            board.SetSquareValue(9,1,1);
            board.SetSquareValue(9,3,6);
            board.SetSquareValue(9,5,5);
            board.SetSquareValue(9,8,7);

            Assert.AreEqual(0, board.Squares.Count(x => !x.IsSolved));
        }

        [Test]
        public void Test_Game_03()
        {
            Board board = new Board();

            board.SetSquareValue(1,3,5);
            board.SetSquareValue(1,5,1);
            board.SetSquareValue(2,3,2);
            board.SetSquareValue(2,6,4);
            board.SetSquareValue(2,8,3);
            board.SetSquareValue(3,1,1);
            board.SetSquareValue(3,3,9);
            board.SetSquareValue(3,7,2);
            board.SetSquareValue(3,9,6);

            board.SetSquareValue(4,1,2);
            board.SetSquareValue(4,5,3);
            board.SetSquareValue(5,2,4);
            board.SetSquareValue(5,7,7);
            board.SetSquareValue(6,1,5);
            board.SetSquareValue(6,6,7);
            board.SetSquareValue(6,9,1);

            board.SetSquareValue(7,4,6);
            board.SetSquareValue(7,6,3);
            board.SetSquareValue(8,2,6);
            board.SetSquareValue(8,4,1);
            board.SetSquareValue(9,5,7);
            board.SetSquareValue(9,8,5);

            Assert.AreEqual(0, board.Squares.Count(x => !x.IsSolved));
        }

        [Test]
        public void Test_Game_02()
        {
            Board board = new Board();

            board.SetSquareValue(1,3,1);
            board.SetSquareValue(1,6,2);
            board.SetSquareValue(2,3,5);
            board.SetSquareValue(2,6,6);
            board.SetSquareValue(2,8,3);
            board.SetSquareValue(3,1,4);
            board.SetSquareValue(3,2,6);
            board.SetSquareValue(3,6,5);

            board.SetSquareValue(4,4,1);
            board.SetSquareValue(4,6,4);
            board.SetSquareValue(5,1,6);
            board.SetSquareValue(5,4,8);
            board.SetSquareValue(5,7,1);
            board.SetSquareValue(5,8,4);
            board.SetSquareValue(5,9,3);
            board.SetSquareValue(6,5,9);
            board.SetSquareValue(6,7,5);
            board.SetSquareValue(6,9,8);

            board.SetSquareValue(7,1,8);
            board.SetSquareValue(7,5,4);
            board.SetSquareValue(7,6,9);
            board.SetSquareValue(7,8,5);
            board.SetSquareValue(8,1,1);
            board.SetSquareValue(8,4,3);
            board.SetSquareValue(8,5,2);
            board.SetSquareValue(9,3,9);
            board.SetSquareValue(9,7,3);

            Assert.AreEqual(0, board.Squares.Count(x => !x.IsSolved));
        }

        [Test]
        public void Test_Game_01()
        {
            Board board = new Board();

            board.SetSquareValue(1, 3, 4);
            board.SetSquareValue(1, 5, 5);
            board.SetSquareValue(1, 9, 2);

            board.SetSquareValue(2, 1, 1);
            board.SetSquareValue(2, 4, 2);

            board.SetSquareValue(3, 1, 7);
            board.SetSquareValue(3, 3, 5);
            board.SetSquareValue(3, 4, 1);
            board.SetSquareValue(3, 6, 8);
            board.SetSquareValue(3, 7, 9);

            board.SetSquareValue(4, 1, 3);
            board.SetSquareValue(4, 2, 5);
            board.SetSquareValue(4, 3, 2);
            board.SetSquareValue(4, 6, 1);
            board.SetSquareValue(4, 7, 7);
            board.SetSquareValue(4, 8, 8);

            board.SetSquareValue(5, 2, 6);
            board.SetSquareValue(5, 5, 7);
            board.SetSquareValue(5, 8, 5);

            board.SetSquareValue(6, 2, 8);
            board.SetSquareValue(6, 3, 7);
            board.SetSquareValue(6, 4, 6);
            board.SetSquareValue(6, 7, 4);
            board.SetSquareValue(6, 8, 3);
            board.SetSquareValue(6, 9, 1);

            board.SetSquareValue(7, 3, 6);
            board.SetSquareValue(7, 4, 3);
            board.SetSquareValue(7, 6, 7);
            board.SetSquareValue(7, 7, 5);
            board.SetSquareValue(7, 9, 8);

            board.SetSquareValue(8, 6, 2);
            board.SetSquareValue(8, 9, 4);

            board.SetSquareValue(9, 1, 8);
            board.SetSquareValue(9, 5, 1);
            board.SetSquareValue(9, 7, 3);

            Assert.AreEqual(0, board.Squares.Count(x => !x.IsSolved));
        }
    }
}
