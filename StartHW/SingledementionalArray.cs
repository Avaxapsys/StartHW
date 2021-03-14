using System;
using System.Collections.Generic;
using System.Text;

namespace StartHW
{
    public static class SingledementionalArray
    {
        public static int FirstTask(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int min = 10;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        public static int SecondTask(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        public static int ThirdTask(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int min = 10;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FourthTask(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            int max = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            return index;
        }

        public static int FifthTask(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int sum = 0;
            for (int i = 1; i < array.Length; i += 2)
            {
                sum += array[i];
            }

            return sum;
        }

        public static int [] SixthTask(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int count = 0;
            int[] result = new int[array.Length];

            for (int i = array.Length - 1; i >= 0; i--)
            {
                result[count] = array[i];
                count++;
            }

            return result;
        }

        public static int SeventhTask(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int quantity = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    quantity++;
                }
            }

            return quantity;
        }

        public static int [] EighthTask(int[] array)
        {
            //int mid = array.Length / 2;
            //int[] first = array[..mid];
            //int[] second = array[mid..];

            //Console.Write("{0}", String.Join("", second));
            //Console.WriteLine("{0}", String.Join("", first));
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int[] hotFriedArray = new int[array.Length];
            do
            {
                int i = 0;
                int j = 0;
                for (j = array.Length / 2; j < array.Length; j++)
                {
                    hotFriedArray[j] = array[i];
                    i++;
                }

                j = (array.Length+1) / 2;
                for (i = 0; i < array.Length / 2; i++)
                {
                    hotFriedArray[i] = array[j];
                    j++;
                }
            }
            while (false);

            return hotFriedArray;
        }

        public static int [] BubleSort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
        public static int [] SelectionSort(int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            for (int i = 0; i < array.Length; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] > array[iMin])
                    {
                        iMin = j;
                    }
                }
                int minValue = array[iMin];
                array[iMin] = array[i];
                array[i] = minValue;
            }
            return array;
        }

        public static int [] InsertSort (int[] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            for (int i = 1; i < array.Length; i++)
            {
                int value = array[i];
                int position = i;

                while (position > 0 && array[position - 1] > value)
                {
                    array[position] = array[position - 1];
                    position--;
                }
                array[position] = value;

            }
            return array;
        }
        public static int[] CreateArray(int a)
        {
            Random rnd = new Random();
            int[] array = new int[a];
            for (int i = 0; i < array.Length; i++)
            {
                    array[i] = rnd.Next(1, 9);
            }
            return array;
        }
    }
}
