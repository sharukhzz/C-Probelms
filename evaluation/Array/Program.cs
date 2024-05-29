using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        private static int ind = 0;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no of rows : ");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the no of coloumn : ");
            int coloumn = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the target : ");
            int target = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, coloumn];
            Console.WriteLine("Enter the elements one by one in new line : ");
            Dictionary<int, List<string>> di = new Dictionary<int, List<string>>();
            List<List<int>> array = new List<List<int>>();
            List<int> li = new List<int>();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    li.Add(matrix[i, j]);
                }
                array.Add(new List<int>(li));
                li.Clear();
                Console.WriteLine();
            }
            for(int i=0;i<coloumn;i++)
            {
                for(int j=0;j<row;j++)
                {
                    li.Add(matrix[j,i]);
                }
                array.Add(new List<int>(li));
                li.Clear();
            }
            Console.WriteLine(matrix.GetLength(1));
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    if (i == j)
                    {
                        li.Add(matrix[i,j]);
                    }

                }                
            }
            array.Add(new List<int>(li));
            li.Clear();
            int x = 0, y = coloumn - 1;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    if (i == x && j==y)
                    {
                        li.Add(matrix[i, j]);
                        x++;
                        y--;
                    }

                }
            }
            array.Add(new List<int>(li));
            li.Clear();
            foreach (var n in array)
            {
                Console.WriteLine(String.Join("", n));
                Dfs(di, n.ToArray(), target, 0, 0, new List<string>());
            }

            List<string> li2 = new List<string>();
            List<int> lii = new List<int>();
            foreach (KeyValuePair<int, List<string>> ele in di)
            {
                if (li2.Contains(String.Join("", ele.Value)))
                {
                    lii.Add(ele.Key);
                }
                else
                {
                    li2.Add(String.Join("", ele.Value));
                }
            }
            foreach (var del in lii)
            {
                di.Remove(del);
            }

            foreach (KeyValuePair<int, List<string>> elements in di)
            {
                Console.WriteLine("Key : " + elements.Key);
                Console.WriteLine("Value : " + String.Join(" ", elements.Value));
            }
            Console.ReadLine();
        }
        public static void Dfs(Dictionary<int, List<string>> di,int[] matrix,int target,int sum,int index,List<string> list)
        {
            if (sum == target)
            {
                di.Add(ind, new List<string>(list));
                ind++;
            }
            if (index>=matrix.Length)
            {
                return;
            }        
           Dfs(di, matrix, target, sum + matrix[index], index + 1,new List<string>(list) {matrix[index]+""});
            Dfs(di, matrix, target, sum-matrix[index], index + 1,new List<string>(list) { -matrix[index] + "" });
            Dfs(di, matrix, target, sum , index + 1,new List<string> (list));
        }
    }
}
