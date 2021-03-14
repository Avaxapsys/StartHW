using NUnit.Framework;
using System;

namespace StartHW.Tests
{
    public class MultiDimentionalTests
    {
        [TestCase(1, 5, false)]
        public void FindMinValueTest(int number, int expectedNumber, bool task)
        {
            //Найти минимальный элемент массива
            int[,] array = MockArrays.MultiDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(expectedNumber);
            int[] actual = MultidementionalArray.FindMinValue(array, task);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 7, true)]
        public void FindMinIndexTest(int number, int expectedNumber, bool task)
        {
            //Найти индекс минимального элемента массива
            int[,] array = MockArrays.MultiDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(expectedNumber);
            int[] actual = MultidementionalArray.FindMinValue(array, task);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, false)]
        public void FindMinNullArgumentTest(int number, bool task)
        {
            int[,] array = MockArrays.MultiDimentionalArray(number);
            try
            {
                int[] actual = MultidementionalArray.FindMinValue(array, task);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 6, false)]
        public void FindMaxValueTest(int number, int expectedNumber, bool task)
        {
            //Найти максимальный элемент массива
            int[,] array = MockArrays.MultiDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(expectedNumber);
            int[] actual = MultidementionalArray.FindMaxValue(array, task);
            Assert.AreEqual(expected, actual);
        }

            [TestCase(1, 8, true)]
        public void FindMaxIndexTest(int number, int expectedNumber, bool task)
        {
            //Найти индекс максимального элемента массива
            int[,] array = MockArrays.MultiDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(expectedNumber);
            int[] actual = MultidementionalArray.FindMaxValue(array, task);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, false)]
        public void FindMaxValueNullArgumentTest(int number, bool task)
        {
            int[,] array = MockArrays.MultiDimentionalArray(number);
            try
            {
                int[] actual = MultidementionalArray.FindMaxValue(array, task);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

            [TestCase(3, 4)]
        public void TranspondingTest(int number, int expectedNumber)
        {
            //Найти количество элементов массива, которые больше всех своих соседей одновременно
            int[,] array = MockArrays.MultiDimentionalArray(number);
            int[,] expected = MockArrays.MultiDimentionalArray(expectedNumber);
            int[,] actual = MultidementionalArray.Transponding(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        public void TranspondingNullArgumentTest(int number)
        {
            int[,] array = MockArrays.MultiDimentionalArray(number);
            try
            {
                int[,] actual = MultidementionalArray.Transponding(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

            [TestCase(2, 2)]
        public void CountBiggerNeighborTest(int number, int expected)
        {
            //Отразите массив относительно его главной диагонали
            int[,] array = MockArrays.MultiDimentionalArray(number);
            int actual = MultidementionalArray.CountBiggerNeighbor(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        public void CountBiggerNeighborNullArgumentTest(int number)
        {
            int[,] array = MockArrays.MultiDimentionalArray(number);
            try
            {
                int actual = MultidementionalArray.CountBiggerNeighbor(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }
    }
}
