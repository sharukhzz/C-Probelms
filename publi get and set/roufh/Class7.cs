using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roufh
{
    class Class7
    {
        static int count = 0;
        public static int[][] ImageSmoother(int[][] img)
        {
            int[,] res = new int[img.Length, img[0].Length];
            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = img[i][j];
                }
            }


            for (int i = 0; i < img.Length; i++)
            {
                for (int j = 0; j < img[i].Length; j++)
                {
                    count = 0;
                    int row = i, column = j;
                    img[i][j] = (get(row + 1, column, res) + get(row - 1, column, res) + get(row, column + 1, res) + get(row, column - 1, res) + get(row - 1, column - 1, res) + get(row + 1, column + 1, res) + get(row + 1, column - 1, res) + get(row - 1, column + 1, res) + get(row, column, res));
                    img[i][j] /= count;
                }
            }
            return img;
        }

        public static int get(int row, int column, int[,] img)
        {
            try
            {
                int n = img[row, column];
                count++;
                return n;
            }
            catch
            {
                return 0;
            }
        }
    }
}
