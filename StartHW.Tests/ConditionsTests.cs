using NUnit.Framework;
using System;

namespace StartHW.Tests
{
    public class ConditionsTests
    {
        [TestCase(20, 10, 30)]
        [TestCase(20, 20, 400)]
        [TestCase(10, 20, -10)]
        public void FirstTaskTest(int a, int b, int expected)
        {
            /*Пользователь вводит 2 числа (A и B). Если A>B,
             * подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B*/
            int actual = Conditions.FirstTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase (1,1)]
        public void FirstTaskExceptionTest(int a, int b)
        {
            try
            {
                int actual = Conditions.FirstTask(a, b); ;
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 2, 1)]
        [TestCase(-1, 2, 2)]
        [TestCase(1, -2, 4)]
        [TestCase(-1, -2, 3)]
        public void SecondTaskTest(int a, int b, int expected)
        {
            /*Пользователь вводит 2 числа (X и Y).
             Определить какой четверти принадлежит точка с координатами (X,Y)*/
            int actual = Conditions.SecondTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        public void SecondTaskExceptionTest(int a, int b)
        {
            try
            {
                int actual = Conditions.SecondTask(a, b); ;
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(10, 20, 45, new int [] {10, 20, 45})]
        [TestCase(20, 10, 45, new int[] { 10, 20, 45 })]
        [TestCase(45, 20, 10, new int[] { 10, 20, 45 })]
        [TestCase(20, 45, 10, new int[] { 10, 20, 45 })]
        public void ThirdTaskTest(int a, int b, int c, int [] expected)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания
            int[] actual = Conditions.ThirdTask(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 0)]
        public void ThirdTaskExceptionTest(int a, int b, int c)
        {
            try
            {
                int [] actual = Conditions.ThirdTask(a, b, c); ;
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(4, 7, 0, new double[] { 0, -1.75})]
        [TestCase(9, 16, 2, new double[] { -0.13529666854163688, -1.642481109236141})]
        [TestCase(9, 30, 25, new double[] { -1.6666666666666667, 0})]
        public void FourthTaskTest(double a, double b, double c, double [] expected)
        {
            /*Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X)
             * квадратного уравнения стандартного вида, где AX^2+BX+C=0 */
            double[] actual = Conditions.FourthTask(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 6, 2)]
        public void FourthTaskExceptionTest(double a, double b, double c)
        {
            try
            {
                double [] actual = Conditions.FourthTask(a, b, c); ;
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(0, "zero")]
        [TestCase(2, "two")]
        [TestCase(13, "thirteen")]
        [TestCase(22, "twenty two")]
        [TestCase(80, "eighty")]
        public void FifthTaskTest(int a, string expected)
        {
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа
            string actual = Conditions.FifthTask(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(100)]
        public void FifthTaskExceptionTest(int a)
        {
            try
            {
                string actual = Conditions.FifthTask(a); ;
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }
    }
}
