using NUnit.Framework;
using System;

namespace StartHW.Tests
{
    public class SingleDimentionalArrayTests
    {
        [TestCase(1, 0)]
        public void FirstTaskTest(int number, int expected)
        {
            //Найти минимальный элемент массива
            int[] array = MockArrays.SingleDimentionalArray(number);
            int actual = SingledementionalArray.FirstTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void FirstTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int actual = SingledementionalArray.FirstTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 9)]
        public void SecondTaskTest(int number, int expected)
        {
            //Найти максимальный элемент массива
            int[] array = MockArrays.SingleDimentionalArray(number);
            int actual = SingledementionalArray.SecondTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void SecondTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int actual = SingledementionalArray.SecondTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 1)]
        public void ThirdTaskTest(int number, int expected)
        {
            //Найти индекс минимального элемента массива
            int[] array = MockArrays.SingleDimentionalArray(number);
            int actual = SingledementionalArray.ThirdTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void ThirdTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int actual = SingledementionalArray.ThirdTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 3)]
        public void FourthTaskTest(int number, int expected)
        {
            //Найти индекс максимального элемента массива
            int[] array = MockArrays.SingleDimentionalArray(number);
            int actual = SingledementionalArray.FourthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void FourthTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int actual = SingledementionalArray.FourthTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 17)]
        public void FifthTaskTest(int number, int expected)
        {
            //Посчитать сумму элементов массива с нечетными индексами
            int[] array = MockArrays.SingleDimentionalArray(number);
            int actual = SingledementionalArray.FifthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void FifthTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int actual = SingledementionalArray.FifthTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(2, 3)]
        public void SixthTaskTest(int number, int resnumber)
        {
            //Сделать реверс массива (массив в обратном направлении)
            int[] array = MockArrays.SingleDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(resnumber);
            int[] actual = SingledementionalArray.SixthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void SixthTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int [] actual = SingledementionalArray.SixthTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 3)]
        public void SeventhTaskTest(int number, int expected)
        {
            //Посчитать количество нечетных элементов массива
            int[] array = MockArrays.SingleDimentionalArray(number);
            int actual = SingledementionalArray.SeventhTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void SeventhTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int actual = SingledementionalArray.SeventhTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 4)]
        public void EightTaskTest(int number, int resnumber)
        {
            //Поменять местами первую и вторую половину массива, например, для массива 1 2 3 4, результат 3 4 1 2,  или для 12345 - 45312
            int[] array = MockArrays.SingleDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(resnumber);
            int[] actual = SingledementionalArray.EighthTask(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void EightTaskNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int [] actual = SingledementionalArray.EighthTask(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 2)]
        public void BubleSortUpTest(int number, int resnumber)
            {
            //Bubble
            int[] array = MockArrays.SingleDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(resnumber);
            int[] actual = SingledementionalArray.BubleSort(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void BubleSortNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int [] actual = SingledementionalArray.BubleSort(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1,2)]
        public void InsertSortUpTest(int number, int resnumber)
        {
            //Insert
            int[] array = MockArrays.SingleDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(resnumber);
            int[] actual = SingledementionalArray.InsertSort(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void InsertSortNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int [] actual = SingledementionalArray.InsertSort(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 3)]
        public void SelectionSortDownTest(int number, int resnumber)
        {
            //Selection
            int[] array = MockArrays.SingleDimentionalArray(number);
            int[] expected = MockArrays.SingleDimentionalArray(resnumber);
            int[] actual = SingledementionalArray.SelectionSort(array);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9)]
        public void SelectionSortNullArgumentTest(int number)
        {
            int[] array = MockArrays.SingleDimentionalArray(number);
            try
            {
                int [] actual = SingledementionalArray.SelectionSort(array);
            }
            catch (ArgumentNullException)
            {
                Assert.Pass();
            }
        }
    }
}
