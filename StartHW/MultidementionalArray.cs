using System;
using System.Collections.Generic;
using System.Text;

namespace StartHW
{
    public static class MultidementionalArray
    {
        public static int [] FindMinValue(int [,] array, bool subject)
        {
            //for min value should be false, for index of min element should be true

            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            bool task = subject;
            int firstIndex = 0;
            int secondIndex = 0;
            int min = 10;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    if (array[i, j] < min){
                        min = array[i, j];
                        firstIndex = i;
                        secondIndex = j; 
                    }
                }
            }
            
           
            if (task == false)
            {
                int [] minValue = { min };
                return minValue;
            }
            else
            {
                int[] index = { firstIndex, secondIndex };
                return index;
            }
        }

        public static int[] FindMaxValue(int[,] array, bool subject)
        {
            //for max value should be false, for index of max element should be true

            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }
            bool task = subject;
            int firstIndex = 0;
            int secondIndex = 0;
            int max = 0;

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        firstIndex = i;
                        secondIndex = j;
                    }
                }
            }


            if (task == false)
            {
                int[] maxValue = { max };
                return maxValue;
            }
            else
            {
                int[] index = { firstIndex, secondIndex };
                return index;
            }
        }

        public static int [,] Transponding(int [,] array)
        {
            if (array == null || array.Length == 0)
                {
                throw new ArgumentNullException("Array is empty");
                }
            int[,] transedArray = new int [array.GetLength(1),array.GetLength(0)];

            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(0); j++)
                {
                    transedArray[i,j] = array[j,i];
                }
            }
            return transedArray;
        }

        public static int CountBiggerNeighbor(int [,] array)
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentNullException("Array is empty");
            }

            int count = 0;

            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if ((i <= 0 || array[i, j] > array[i - 1, j])
                        && (i >= array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j <= 0 || array[i, j] > array[i, j - 1])
                        && (j >= array.GetLength(1) - 1 || array[i, j] > array[i, j + 1]))
                    {
                        count++;
                    }
                }
            }
            return count;
        }


        public static int [,] CreateMultiArray(int a, int b)
        {
            Random rnd = new Random();
            int[,] array = new int[a, b];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = rnd.Next(1, 9);
                }
            }

            return array;
        }
    }
}
