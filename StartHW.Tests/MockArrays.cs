using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartHW.Tests
{
    public static class MockArrays
    {
        public static int [] SingleDimentionalArray(int number)
        {
            int[] result = new int[0];
             switch(number){
                case 1:
                    result = new int[] { 8, 0, 5, 9, 4, 6, 7, 2 };
                    break;
                case 2:
                    result = new int[] { 0, 2, 4, 5, 6, 7, 8, 9 };
                    break;
                case 3:
                    result = new int[] { 9, 8, 7, 6, 5, 4, 2, 0 };
                    break;
                case 4:
                    result = new int[] { 4, 6, 7, 2, 8, 0, 5, 9 };
                    break;
                case 5:
                    result = new int[] { 1 };
                    break;
                case 6:
                    result = new int[] { 16 };
                    break;
                case 7:
                    result = new int[] { 1, 1 };
                    break;
                case 8:
                    result = new int[] { 2, 3 };
                    break;
                case 9:
                    result = new int[] {};
                    break;
            }
            return result;
        }

        public static int[,] MultiDimentionalArray(int number)
        {
            int[,] result = new int[0,0];
            switch (number)
            {
                case 1:
                    result = new int[,]
                    {
                        { 8, 2, 5, 9 },
                        { 7, 1, 4, 2 },
                        { 7, 2, 3, 16 },
                        { 9, 6, 5, 9 },
                    };
                    break;
                case 2:
                    result = new int[,]
                    {
                        { 9, 5, 8, 4 },
                        { 7, 3, 6, 2 },
                    };
                    break;
                case 3:
                    result = new int[,]
                    {
                        { 1, 2, 3 },
                        { 4, 5, 6 },
                        { 7, 8, 9 },
                    };
                    break;
                case 4:
                    result = new int[,]
                    {
                        { 1, 4, 7 },
                        { 2, 5, 8 },
                        { 3, 6, 9 },
                    };
                    break;
                case 5:
                    result = new int[,] { };
                    break;
            }
            return result;
        }
    }
}
