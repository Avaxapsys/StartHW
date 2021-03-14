using System;
using System.Collections.Generic;
using System.Text;

namespace StartHW
{
    public static class Conditions
    {
        public static int FirstTask(int a, int b)
        {
            /*Пользователь вводит 2 числа (A и B). Если A>B,
             * подсчитать A+B, если A=B, подсчитать A*B, если A<B, подсчитать A-B*/
            if (b == 0 || a == 0)
            {
                throw new Exception("Some of numbers are equal");
            }
            int result = 0;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else if (a < b)
            {
                result = a - b;
            }

            return result;
        }

        public static int SecondTask(int a, int b)
        {
            /*Пользователь вводит 2 числа (X и Y).
             Определить какой четверти принадлежит точка с координатами (X,Y)*/
            if (b == 0 || a == 0)
            {
                throw new Exception("Some of numbers are equal");
            }

            int result = 0;
            if (a < 0)
            {
                result = b < 0 ? 3 : 2;
            }
            else if (a > 0)
            {
                result = b < 0 ? 4 : 1;
            }

            return result;
        }

        public static int [] ThirdTask(int a, int b, int c)
        {
            //Пользователь вводит 3 числа (A, B и С). Выведите их в консоль в порядке возрастания
            int[] result = new int [3];
            if(a == b || a == c || b == c)
            {
                throw new Exception("Some of numbers are equal");
            }

            if (a < b)
            {
                if (a < c)
                {
                    if (b < c)
                    {
                        result = new int [] {a, b, c};
                    }
                    else
                    {
                      result = new int[] { a, c, b };
                    }
                }
                else
                {
                    result = new int[] { c, a, b };
                }
            }
            else
            {
                if (b < c)
                {
                    if (a < c)
                    {
                        result = new int[] { b, a, c };
                    }
                    else
                    {
                        result = new int[] { b, c, a };
                    }
                }
                else
                {
                    result = new int[] { c, b, a };
                }
            }
            return result;
        }

        public static double [] FourthTask(double a, double b, double c)
        {
            /*Пользователь вводит 3 числа (A, B и С). Выведите в консоль решение(значения X)
             * квадратного уравнения стандартного вида, где AX^2+BX+C=0 */
            double diskrim = b * b - 4 * a * c;
            double[] result = new double [2];

            if (diskrim > 0)
            {
                result[0] = (-b + Math.Sqrt(diskrim)) / (2 * a);
                result[1] = (-b - Math.Sqrt(diskrim)) / (2 * a);
            }
            else if (diskrim == 0)
            {
                result[0] = -b / (2 * a);
            }
            else
            {
                throw new Exception("Oops, try again with other digits");
            }

            return result;
        }

        public static string FifthTask(int a)
        {
            //Пользователь вводит двузначное число. Выведите в консоль прописную запись этого числа
            if (a > 99)
            {
                throw new Exception("The number has more then two digits");
            }

            string result = "";
            string[] unit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven",
                                "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] teen = { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            if (a < 20)
                result += unit[a];
            else
            {
                result += teen[a / 10];
                if ((a % 10) > 0)
                    result += " " + unit[a % 10];
            }
            return result;
        }
    }
}
