using NUnit.Framework;
using System;

namespace StartHW.Tests
{
    public class VariablesTests
    {
        [TestCase(7, 2, -7.8)]
        [TestCase(1, 2, 9)]
        [TestCase(2, 1, -11)]
        [TestCase(10, 20, 45)]
        public void FirstTaskTest(double a, double b, double expected)
        {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль решение 5*A+B2B-A
            double actual = Variables.FirstTask (a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(10, 0)]
        [TestCase(0, 10)]
        [TestCase(0, 0)]
        public void FirstTaskTestArgumentNullException(double a, double b)
        {
            try
            {
                double actual = Variables.FirstTask(a, b);
            }
            catch(ArgumentNullException)
            {
                Assert.Pass();
            }
        }

        [TestCase(10, 10)]
        public void FirstTaskTestArgumentException(double a, double b)
        {
            try
            {
                double actual = Variables.FirstTask(a, b) ;
            }
            catch (ArgumentException)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 2, new int[] {2,1})]
        [TestCase(100, 0, new int[] { 0, 100 })]
        public void SecondTaskTest(int a, int b, int [] expected)
        {
            //Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.
            int[] actual = Variables.SecondTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1)]
        public void SecondTaskExceptionTest(int a, int b)
        {
            try
            {
                int [] actual = Variables.SecondTask(a, b); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(7.0, 2.0, new double[] { 3.5, 1.0 })]
        [TestCase(10.0, 2.0, new double[] { 5.0, 0 })]
        [TestCase(2.2, 1.1, new double[] { 2.0, 0 })]
        [TestCase(1001.5, 200.0, new double[] { 5.0075000000000003, 1.5})]
        public void ThirdTaskTest(double a, double b, double[] expected)
        {
            //Пользователь вводит 2 числа(A и B).Выведите в консоль результат деления A на B и остаток от деления.
            double[] actual = Variables.ThirdTask(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 0)]
        public void ThirdTaskExceptionTest(double a, double b)
        {
            try
            {
                double [] actual = Variables.ThirdTask(a, b); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(3, 6, 12, 2)]
        [TestCase(6.0, -5.0, -12.0, -1.1666666666666667)]
        [TestCase(1, 6, 6, 0)]
        public void FourthTaskTest(double a, double b, double c, double expected)
        {
            /*Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X)
             линейного уравнения стандартного вида, где A*X+B=C.*/
            double actual = Variables.FourthTask(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 1, 0)]
        public void FourthTaskExceptionTest(double a, double b, double c)
        {
            try
            {
                double actual = Variables.FourthTask(a, b, c); 
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }

        [TestCase(1, 1, 3, -1, new int[] {-1, 2})]
        [TestCase(-1, 1, 1, -1, new int[] { -1, 0 })]
        [TestCase(-1, 1, 3, -1, new int[] { 0, -1 })]
        public void FifthTaskTest(int a, int b, int c, int d, int [] expected)
        {
            /*Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. 
            Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.*/
            int[] actual = Variables.FifthTask(a, b, c, d);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 1, 4)]
        public void FifthTaskExceptionTest(int a, int b, int c, int d)
        {
            try
            {
                int [] actual = Variables.FifthTask(a, b, c, d); ;
            }
            catch (Exception)
            {
                Assert.Pass();
            }
        }
    }
}