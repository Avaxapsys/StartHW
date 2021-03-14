using System;
using System.Collections.Generic;
using System.Text;

namespace StartHW
{
    public static class Variables
    {
            public static double FirstTask(double firstNum, double secNum)
            {
            //Пользователь вводит 2 числа (A и B). Выведите в консоль решение 5*A+B2B-A
                
                if(firstNum == 0 || secNum == 0)
            {
                throw new ArgumentNullException("some of number is 0");
            }
                if(secNum-firstNum == 0)
            {
                throw new ArgumentException("The arguments wouldnt be equal");
            }
                double result = (5 * firstNum + Convert.ToInt32(Math.Pow(secNum, 2))) / (secNum - firstNum);

            return result;
            }

            public static int [] SecondTask(int firstNum, int secNum)
            {
            //Пользователь вводит 2 значения(A и B). Поменяйте содержимое переменных A и B местами.
                if (firstNum == secNum)
            {
                throw new Exception("The number are equal, keep it in mind");
            }

                int c = secNum;
                secNum = firstNum;
                firstNum = c;

                int[] result = new [] { firstNum, secNum };

            return result;
            }

            public static double [] ThirdTask(double firstNum, double secNum)
            {
            //Пользователь вводит 2 числа(A и B).Выведите в консоль результат деления A на B и остаток от деления.
                if(firstNum == 0 || secNum == 0)
                {
                    throw new Exception("some of number is 0");
                }
                
                if(firstNum < secNum)
                {
                throw new Exception("First argument shoul be more than second");
                }

                double result_1 = firstNum / secNum;
                double result_2 = firstNum % secNum;

                double[] result = { result_1, result_2 };

                return result;
            }

            public static double FourthTask(double firstNum, double secNum, double thirdNum)
            {
            /*Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значение X)
              линейного уравнения стандартного вида, где A*X+B=C.*/

                if(firstNum == 0)
                {
                    throw new Exception("First number can't equal 0");
                }   

                double result = (thirdNum - secNum) / firstNum;

                return result;
            }

            public static int [] FifthTask(int firstNum, int secNum, int thirdNum, int fourthNum)
            {
            /*Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости. 
              Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.*/

                if (secNum == fourthNum || firstNum == thirdNum)
                {
                    throw new Exception("Odd parameters should't be equal, even parameters should't be equal");
                } 
                int firstValue = (secNum - fourthNum) / (firstNum - thirdNum);
                int secondValue = fourthNum - firstValue * thirdNum;

                int[] result = { firstValue, secondValue };

                return result;
            }
        

    }
}

