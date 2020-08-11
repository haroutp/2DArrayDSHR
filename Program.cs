using System;
using System.Linq;

namespace _2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr =
            {
                new int[] {-9, -9, -9,  1, 1, 1},
                new int[] {0, -9,  0,  4, 3, 2},
                new int[] {-9, -9, -9,  1, 2, 3},
                new int[] {0,  0, 8,  6, 6, 0},
                new int[] {0,  0,  0, -2, 0, 0},
                new int[] {0,  0,  1,  2, 4, 0}
            };
            System.Console.WriteLine(hourglassSum(arr));
        }

        // Complete the hourglassSum function below.
        static int hourglassSum(int[][] arr) {
            int rows = arr.Length;
            int columns = arr[0].Length;

            // the constraints specify -9 as a minimum member, -9 * 7 = 63
            int maxHourglass = -63;

            for (int i = 0; i < rows - 2; i++)
            {
                for (int j = 0; j < columns - 2; j++)
                {
                    int currentMaxHourglass = arr[i][j] + arr[i][j + 1] + arr[i][j + 2]
                                            + arr[i + 1][j + 1] + arr[i + 2][j] 
                                            + arr[i + 2][j + 1] + arr[i + 2][j + 2];
                    maxHourglass = Math.Max(currentMaxHourglass, maxHourglass);
                }
            }
            return maxHourglass;

        }
    }
}
