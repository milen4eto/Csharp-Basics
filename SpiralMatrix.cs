using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            text = text.ToLower();
            char[] textArray = text.ToCharArray();

            int[,] matrix = new int[n, n];
            int row = 0;
            int col = 0;
            string direction = "right";
            int maxRotations = n * n;
            int k = 0;
            int sumMax = 0;
            int index = 0;

            for (int i = 1; i <= maxRotations; i++)
            {
                if (direction == "right" && (col > n - 1 || matrix[row, col] != 0))
                {
                    direction = "down";
                    col--;
                    row++;
                }
                if (direction == "down" && (row > n - 1 || matrix[row, col] != 0))
                {
                    direction = "left";
                    row--;
                    col--;
                }
                if (direction == "left" && (col < 0 || matrix[row, col] != 0))
                {
                    direction = "up";
                    col++;
                    row--;
                }

                if (direction == "up" && row < 0 || matrix[row, col] != 0)
                {
                    direction = "right";
                    row++;
                    col++;
                }

                if (k < textArray.Length)
                {
                    matrix[row, col] = ((int)textArray[k]-96)*10;
                }
                else
                {
                    k = 0;
                    matrix[row, col] = ((int)textArray[k] - 96) * 10;
                }


                if (direction == "right")
                {
                    col++;
                }
                if (direction == "down")
                {
                    row++;
                }
                if (direction == "left")
                {
                    col--;
                }
                if (direction == "up")
                {
                    row--;
                }
                k++;
            }

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    sum += matrix[i,j];
                }
                if (sum > sumMax)
                {
                    sumMax = sum;
                    index = i;
                }
                    sum = 0;
            }
            Console.WriteLine("{0} - {1}", index, sumMax);

            // Display Matrix
            //for (int r = 0; r < n; r++)
            //{
            //    for (int c = 0; c < n; c++)
            //    {
            //        Console.Write("{0,4}", matrix[r, c]);
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
