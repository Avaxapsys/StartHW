using System;
using System.Collections.Generic;
using System.Text;

namespace StartHW
{
    public static class Loop
    {
        public static int FirstTask(int a, int b)
        {
            //Пользователь вводит 2 числа (A и B). Возвести число A в степень B
            if (a == 0 || b == 0)
            {
                throw new Exception("Some of number equal 0");
            }
            int result = a;

            for (int i = 1; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        public static List<int> SecondTask(int a)
        {
            //Пользователь вводит 1 число (A). Вывести все числа от 1 до 1000, которые делятся на A
            List<int> result = new List<int>(); 
            if (a <= 0)
            {
                throw new Exception("Input number must be more then 0");
            }

            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }

        public static int ThirdTask(int a)
        {
            //Пользователь вводит 1 число(A).Найдите количество положительных целых чисел, квадрат которых меньше A
            if (a <= 0)
            {
                throw new Exception("Input number must be more then 0");
            }
            int result = 0;
            for (int i = 1; i <= a; i++)
            {
                if (Math.Pow(i, 2) >= a)
                    break;
                result++;
            }
            return result;
        }

        public static int FourthTask(int a)
        {
            //Пользователь вводит 1 число (A). Вывести наибольший делитель (кроме самого A) числа A
            if (a <= 0)
            {
                throw new Exception("Input number must be more then 0");
            }

            int result = 0;
            for (int i = a - 1; i > 0; i--)
            {
                if (a % i == 0)
                {
                    result = i;
                    break;
                }
            }

            return result;
        }

        public static int FifthTask(int a, int b)
        {
            /*Пользователь вводит 2 числа (A и B).
             *Вывести сумму всех чисел из диапазона от A до B, которые делятся без остатка на 7 */
            if (a == b)
            {
                throw new Exception("You've input the equal numbers");
            }
            int tempNumber = 0;
            if (a > b)
            {
                for (int i = b + 1; i < a; i++)
                {
                    if (i % 7 == 0)
                    {
                        tempNumber += i;
                    }
                }
            }
            else if (a < b)
            {
                for (int i = a + 1; i < b; i++)
                {
                    if (i % 7 == 0)
                    {
                        tempNumber += i;
                    }
                }
            }
            return tempNumber;
        }

        public static int SixthTask(int a)
        {
            /*Пользователь вводит 1 число (N). Выведите N-ое число ряда фибоначчи. 
             *В ряду фибоначчи каждое следующее число является суммой двух предыдущих.
             *Первое и второе считаются равными 1 */
            if (a < 2)
            {
                throw new Exception("Please put the much size number, first & second are 1");
            }
            int tempFirst = 1;
            int tempSecond = 1;
            int fibonacci = 0;
            Console.Write($"Fibonacci for {a}: ");

            for (int i = 3; i <= a; i++)
            {
                fibonacci = tempFirst + tempSecond;
                tempFirst = tempSecond;
                tempSecond = fibonacci;
            }
            return fibonacci;
        }

         public static int SeventhTask(int a, int b)
        {
            //Пользователь вводит 2 числа. Найти их наибольший общий делитель используя алгоритм Евклида
            if (a == b)
            {
                throw new Exception("You've input the equal numbers");
            }

            while (a != b)
            {
                if (a > b)
                {
                    a -= b;
                }
                else
                {
                    b -= a;
                }
            }
            int nod = b;
            return nod;
        }

        public static int EighthTask(int a)
        {
            /*Пользователь вводит целое положительное число, которое является кубом целого числа N.
             *Найдите число N методом половинного деления */
            if (a <=0)
            {
                throw new Exception("Input number must be more then 0");
            }

            //int n_number = 1;
            //int mid = a % 2;
            //mid = mid == 0 ? a / 2 : (a - n_number) / 2;
            //int up = mid;
            //int down = mid;
            //int result = 0;

            //for (; n_number <= a; n_number++)
            //{
            //    if (Math.Pow(up, 3) == a)
            //    {
            //        result = up;
            //        break;
            //    }
            //    if (Math.Pow(down, 3) == a)
            //    {
            //        result = down;
            //        break;
            //    }
            //    up++;
            //    down--;
            //}

            int min = 0;
            int max = a;
            int result = 0;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (Math.Pow(mid, 3) == a)
                {
                    result = mid;
                    break;
                }
                else if (Math.Pow(mid, 3) < a)
                {
                    min = mid;
                }
                else
                {
                    max = mid;
                }
            }
            return result;
        }

        public static int NinthTask(int a)
        {
            //Пользователь вводит 1 число. Найти количество нечетных цифр этого числа
            if (a <= 0)
            {
                throw new Exception("Input number must be more then 0");
            }
            int odd = 0;
            int tempNumber;

            while (a > 0)
            {
                tempNumber = a % 10;
                if (tempNumber % 2 != 0)
                {
                    odd++;
                }
                a /= 10;
            }

            return odd;
        }

        public static int TenthTask(int a)
        {
            /*Пользователь вводит 1 число. Найти число, которое является зеркальным
             *отображением последовательности цифр заданного числа */
            if (a <= 0)
            {
                throw new Exception("Input number must be more then 0");
            }
            int reversedNumber = 0;

            while (a != 0)
            {
                int remainNumber = a % 10;
                reversedNumber *= 10;
                reversedNumber += remainNumber;
                a /= 10;
            }
            return reversedNumber;

        }

        public static List<int> EleventhTask(int a)
        {
            /*ользователь вводит целое положительное  число (N). 
             *Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных */
            if (a <= 0)
            {
                throw new Exception("Input number must be more then 0");
            }
            int odd = 0;
            int even = 0;
            int tempNumber = 0;
            int operNumber = 0;
            List<int> result = new List<int>();

            for (int i = 1; i <= a; i++)
            {
                operNumber = i;
                while (operNumber > 0)
                {
                    tempNumber = operNumber % 10;
                    if (tempNumber % 2 != 0)
                    {
                        odd += tempNumber;
                    }
                    else
                    {
                        even += tempNumber;
                    }
                    operNumber /= 10;
                }
                if (even > odd)
                {
                    result.Add(i);
                }
                odd = 0;
                even = 0;
            }
            return result;
        }

        public static bool TwelfthTask(int a, int b)
        {
            /*Пользователь вводит 2 числа. Сообщите, есть ли в написании двух чисел одинаковые цифры.
             *Например, для пары 123 и 3456789, ответом будет являться “ДА”, а, для пары 500 и 99 - “НЕТ” */
            if (a == b)
            {
                throw new Exception("IYou've input the equal numbers");
            }
            int tempNumber_1 = 0;
            int tempNumber_2 = 0;
            int tempnumber_3 = 0;
            bool result = false;

            while (a / 10 > 0 || a % 10 > 0)
            {
                tempNumber_1 = a % 10;
                tempnumber_3 = b;
                while (tempnumber_3 / 10 > 0 || tempnumber_3 % 10 > 0)
                {
                    tempNumber_2 = tempnumber_3 % 10;
                    if (tempNumber_2 == tempNumber_1)
                    {
                        result = true;
                        break;
                    }
                    tempnumber_3 /= 10;
                }
                if (result == true)
                {
                    break;
                }
                a /= 10;

            }
            return result;
        }
    }
}

