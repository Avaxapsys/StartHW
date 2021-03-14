using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace StartHW.Tests
{
    public class LoopTests
    {
        [TestCase(2, 8, 256)]
        [TestCase(2, 1, 2)]
        public void FirstTaskTest(int a, int b, int expected)
        {
            //Пользователь вводит 2 числа (A и B). Возвести число A в степень B
            int actual = Loop.FirstTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0,1)]
        public void FirstTaskExceptionTest(int a, int b)
        {
            try
            {
                int actual = Loop.FirstTask(a, b); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(333, new int [] {333,666,999})]
        [TestCase(501, new int[] {501})]
        public void SecondTaskTest(int a,  int [] expected)
        {
            //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A
            List<int> actual = new List<int>(Loop.SecondTask(a));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void SecondTaskExceptionTest(int a)
        {
            try
            {
                List<int> actual = new List<int> (Loop.SecondTask(a)); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(27, 5)]
        [TestCase(3, 1)]
        [TestCase(1, 0)]
        public void ThirdTaskTest(int a, int expected)
        {
            //Пользователь вводит 1 число(A).Найдите количество положительных целых чисел, квадрат которых меньше A
            int actual = Loop.ThirdTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void ThirdTaskExceptionTest(int a)
        {
            try
            {
                int actual = Loop.ThirdTask(a); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(123, 41)]
        [TestCase(2, 1)]
        [TestCase(1, 0)]
        public void FourthTaskTest(int a, int expected)
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A
            int actual = Loop.FourthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void FourthTaskExceptionTest(int a)
        {
            try
            {
                int actual = Loop.FourthTask(a); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(3, 13, 7)]
        [TestCase(1, 14, 7)]
        [TestCase(14, 1, 7)]
        [TestCase(15, 1, 21)]
        [TestCase(21, 14, 0)]
        [TestCase(13, 14, 0)]
        [TestCase(13, 22, 35)]
        public void FifthTaskTest(int a, int b, int expected)
        {
            /*Пользователь вводит 2 числа (A и B).
             *Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7 */
            int actual = Loop.FifthTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(7, 7)]
        public void FifthTaskExceptionTest(int a, int b)
        {
            try
            {
                int actual = Loop.FifthTask(a, b); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(3, 2)]
        [TestCase(27, 196418)]
        public void SixthTaskTest(int a, int expected)
        {
            /*Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
             *В ряду фибоначчи каждое следующее число является суммой двух предыдущих.
             *Первое и второе считаются равными 1 */
            int actual = Loop.SixthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        public void SixthTaskExceptionTest(int a)
        {
            try
            {
                int actual = Loop.SixthTask(a); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(2, 1, 1)]
        [TestCase(30, 18, 6)]
        [TestCase(18, 30, 6)]
        [TestCase(661, 113, 1)]
        public void SeventhTaskTest(int a, int b, int expected)
        {
            //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида
            int actual = Loop.SeventhTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        public void SeventhTaskExceptionTest(int a, int b)
        {
            try
            {
                int actual = Loop.SeventhTask(a, b); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(27, 3)]
        [TestCase(8, 2)]
        public void EighthTaskTest(int a, int expected)
        {
            /*Пользователь вводит целое положительное число, которое является кубом целого числа N.
             *Найдите число N методом половинного деления */
            int actual = Loop.EighthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void EighthTaskExceptionTest(int a)
        {
            try
            {
                int actual = Loop.EighthTask(a); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 1)]
        [TestCase(2, 0)]
        [TestCase(2222, 0)]
        [TestCase(2727, 2)]
        public void NinthTaskTest(int a, int expected)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа
            int actual = Loop.NinthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void NinthTaskExceptionTest(int a)
        {
            try
            {
                int actual = Loop.NinthTask(a); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(20, 2)]
        [TestCase(12345, 54321)]
        public void TenthTaskTest(int a, int expected)
        {
            /*Пользователь вводит 1 число. Найти число, которое является зеркальным
             *отображением последовательности цифр заданного числа */
            int actual = Loop.TenthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void TenthTaskExceptionTest(int a)
        {
            try
            {
                int actual = Loop.TenthTask(a); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(30, new int [] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 })]
        [TestCase(3, new int[] { 2 })]
        public void EleventhTaskTest(int a, int[] expected)
        {
            /*Пользователь вводит целое положительное  число (N). 
            *Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных */
            List<int> actual = new List<int>(Loop.EleventhTask(a));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        public void EleventhTaskExceptionTest(int a)
        {
            try
            {
                List<int> actual = new List<int>(Loop.EleventhTask(a)); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(123, 3456789, true)]
        [TestCase(500, 99, false)]
        public void TwelfthTaskTest(int a, int b, bool expected)
        {
            /*Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
             *Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ” */
            bool actual = Loop.TwelfthTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        public void TwelfthTaskExceptionTest(int a, int b)
        {
            try
            {
                bool actual = Loop.TwelfthTask(a, b); ;
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }
    }
}
