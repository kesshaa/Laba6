using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        //Task 1
        [TestMethod]
        public void TestMethod1_1()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 2, 3, 4, 5, 6, 7, 8 },
            { 3, 4, 5, 6, 7, 8, 9 },
            { 4, 5, 6, 7, 8, 9, 10 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 6, 7, 8, 9, 10, 11, 12 },
            { 7, 8, 9, 10, 11, 12, 13 }
            };

            int expected = 78;
            int actual = CheckPassword.Task1(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_2()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 }
            };

            int expected = 16;
            int actual = CheckPassword.Task1(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_3()
        {
            int[,] N = new int[7, 7]
            {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
            };

            int expected = 0;
            int actual = CheckPassword.Task1(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_4()
        {
            int[,] N = new int[7, 7]
            {
            { 1, -2, 3, -4, 5, -6, 7 },
            { -2, 3, -4, 5, -6, 7, -8 },
            { 3, -4, 5, -6, 7, -8, 9 },
            { -4, 5, -6, 7, -8, 9, -10 },
            { 5, -6, 7, -8, 9, -10, 11 },
            { -6, 7, -8, 9, -10, 11, -12 },
            { 7, -8, 9, -10, 11, -12, 13 }
            };

            int expected = 50;
            int actual =CheckPassword.Task1(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1_5()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 2, 3, 4, 5, 6, 7, 8 },
            { 3, 4, 5, 6, 7, 8, 9 },
            { 4, 5, 6, 7, 8, 9, 10 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 6, 7, 8, 9, 10, 11, 12 },
            { 7, 8, 9, 10, 11, 12, 13 }
            };
            int expected = 78;
            int actual = CheckPassword.Task1(N);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2_1()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 2, 3, 4, 5, 6, 7, 8 },
            { 3, 4, 5, 6, 7, 8, 9 },
            { 4, 5, 6, 7, 8, 9, 10 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 6, 7, 8, 9, 10, 11, 12 },
            { 7, 8, 9, 10, 11, 12, 13 }
            };

            double expected = 0;
            double actual = CheckPassword.Task2(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_2()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 }
            };

            double expected = 0;
            double actual = CheckPassword.Task2(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_3()
        {
            int[,] N = new int[7, 7]
            {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
            };

            double expected = 0;
            double actual = CheckPassword.Task2(N);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethod2_4()
        {
            int[,] N = new int[7, 7]
                 {
            { 1, -2, 3, -4, 5, -6, 7 },
            { -2, 3, -4, 5, -6, 7, -8 },
            { 3, -4, 5, -6, 7, -8, 9 },
            { -4, 5, -6, 7, -8, 9, -10 },
            { 5, -6, 7, -8, 9, -10, 11 },
            { -6, 7, -8, 9, -10, 11, -12 },
            { 7, -8, 9, -10, 11, -12, 13 }
        };

            double expected = 0;
            double actual = CheckPassword.Task2(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2_5()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 2, 3, 4, 5, 6, 7, 8 },
            { 3, 4, 5, 6, 7, 8, 9 },
            { 4, 5, 6, 7, 8, 9, 10 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 6, 7, 8, 9, 10, 11, 12 },
            { 7, 8, 9, 10, 11, 12, 13 }
            };

            double expected = 0;
            double actual = CheckPassword.Task2(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_1()
        {
            int[,] N = new int[5, 5]
            {
            { 1, 2, 3, 4, 5 },
            { 1, 2, 3, 4, 5 },
            { 1, 2, 6, 4, 5 },
            { 1, 2, 6, 6, 5 },
            { 1, 2, 6, 6, 6 }
            };

            int[] expected = new int[] { 0, 0, 0 };
            int[] actual = CheckPassword.Task3(N);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_2()
        {
            int[,] N = new int[5, 5]
            {
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1 }
            };

            int[] expected = new int[] { 0, 0, 0 };
            int[] actual = CheckPassword.Task3(N);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_3()
        {
            int[,] N = new int[5, 5]
            {
            { 1, 2, 3, 4, 5 },
            { 2, 1, 4, 3, 5 },
            { 3, 4, 1, 2, 5 },
            { 4, 3, 2, 1, 5 },
            { 5, 5, 5, 5, 5 }
            };

            int[] expected = new int[] { 0, 0, 0 };
            int[] actual = CheckPassword.Task3(N);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_4()
        {
            int[,] N = new int[5, 5]
            {
            { 1, 2, 3, 4, 5 },
            { 2, 1, 4, 3, 5 },
            { 3, 4, 1, 2, 5 },
            { 4, 3, 2, 1, 5 },
            { 5, 4, 3, 2, 1 }
            };

            int[] expected = new int[] { 0, 0, 0 };
            int[] actual = CheckPassword.Task3(N);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3_5()
        {
            int[,] N = new int[5, 5]
            {
            { 1, 2, 3, 4, 5 },
            { 2, 1, 4, 3, 5 },
            { 3, 4, 1, 2, 5 },
            { 4, 3, 2, 1, 5 },
            { 5, 5, 5, 5, 6 }
            };

            int[] expected = new int[] { 0, 0, 0 };
            int[] actual = CheckPassword.Task3(N);
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4_1()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 2, 3, 4, 5, 6, 7, 8 },
            { 3, 4, 5, 6, 7, 8, 9 },
            { 4, 5, 6, 7, 8, 9, 10 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 6, 7, 8, 9, 10, 11, 12 },
            { 7, 8, 9, 10, 11, 12, 13 }
            };

            int expected = 1;
            int actual = CheckPassword.Task4(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4_2()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 1, 1, 1, 1, 1, 1 }
            };

            int expected =28;
            int actual = CheckPassword.Task4(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4_3()
        {
            int[,] N = new int[7, 7]
            {
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 },
            { 0, 0, 0, 0, 0, 0, 0 }
            };

            int expected = 28;
            int actual = CheckPassword.Task4(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4_4()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 2, 3, 4, 5, 6, 7, 8 },
            { 3, 4, 5, 6, 7, 8, 9 },
            { 4, 5, 6, 7, 8, 9, 10 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 6, 7, 8, 9, 10, 11, 12 },
           { 11, 12, 13, 14, 15, 16, 17 }
           };

            int expected = 1;
            int actual = CheckPassword.Task4(N);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4_5()
        {
            int[,] N = new int[7, 7]
            {
            { 1, 2, 3, 4, 5, 6, 7 },
            { 2, 3, 4, 5, 6, 7, 8 },
            { 3, 4, 5, 6, 7, 8, 9 },
            { 4, 5, 6, 7, 8, 9, 10 },
            { 5, 6, 7, 8, 9, 10, 11 },
            { 6, 7, 8, 9, 10, 11, 12 },
            { 7, 8, 9, 10, 11, 12, 0 }
            };

            int expected = 0;
            int actual = CheckPassword.Task4(N);
            Assert.AreEqual(expected, actual);
        }


    }
}
