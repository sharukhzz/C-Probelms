using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int index = 0;
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
            List<string> list;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < coloumn; j++)
                {
                    if (matrix[i, j] == target)
                    {
                        list = new List<string>();
                        list.Add(i + ","+j +"("+matrix[i,j]+")");
                        di.Add(index, list);
                        index++;
                    }
                }
            }
            int total = (int)Math.Pow(2, coloumn);
            Rowcoloumn(matrix, total,row,coloumn,target,di,list=new List<string>());
            Coloumnrow(matrix, total, row,coloumn, target, di, list = new List<string>());
            List<string> li = new List<string>();
            List<int> lii = new List<int>();
            foreach(KeyValuePair<int,List<string>> ele in di)
            {
                if(li.Contains(String.Join("",ele.Value)))
                {
                    lii.Add(ele.Key);
                }
                else
                {
                    li.Add(String.Join("", ele.Value));
                }
            }
            foreach(var del in lii)
            {
                di.Remove(del);
            }
            foreach (KeyValuePair<int, List<string>> elements in di)
            {
                Console.WriteLine("Key : "+elements.Key);
                Console.WriteLine("Value : "+String.Join(" ", elements.Value));
            }
            Console.ReadLine();
        }
        public static void Coloumnrow(int[,] matrix, int total, int row, int coloumn, int target, Dictionary<int, List<string>> di, List<string> list)
        {
            int count = 0;
            int c = 0, sum = 0, cc = 0, flag1 = 0 ;
            while (total * coloumn >= count)
            {
                if (c < coloumn)
                {
                    list = new List<string>();
                    for (int i = 0; i < row; i++)
                    {
                        sum += matrix[i,c];
                        list.Add(i + "," + c + "(" + matrix[i, c] + ")");
                        if (sum == target)
                        {
                            
                            di.Add(index, list);
                            index++;
                            if (i != row - 1 && flag1 == 0)
                            {
                                sum = 0;
                                flag1 = 1;
                            }

                        }
                    }
                    sum = 0;
                    count++;
                    c++;
                    flag1 = 0;
                }
                if(cc<coloumn)
                {
                    flag1 = 0;
                    list = new List<string>();
                    for (int i = 0; i < coloumn; i++)
                    {
                        sum -= matrix[i,cc];
                        list.Add(i + "," + cc+ "(" + matrix[i, cc] + ")");
                        if (sum == target)
                        {
                            
                            di.Add(index, list);
                            index++;
                            if (i != row - 1 && flag1 == 0)
                            {
                                sum = 0;
                                flag1 = 1;
                            }

                        }
                    }
                    sum = 0;
                    count++;
                    cc++;
                    flag1 = 0;
                }
                else
                {
                    count = total * coloumn + 1;
                }            
            }
        }
        public static void Rowcoloumn(int[,] matrix, int total,int row,int coloumn,int target,Dictionary<int,List<string>> di,List<string> list)
        {
            int count = 0,flag1=0;
            int r = 0,sum=0,rr=0;
            while(total*row>=count)
            {
                if (r < row)
                {
                    list = new List<string>();
                    for (int i = 0; i < coloumn; i++)
                    {
                        sum += matrix[r, i];
                        list.Add(r + "," + i + "(" + matrix[r,i] + ")");
                        if (sum == target)
                        {
                            
                                di.Add(index, list);
                                index++;
                                if (i != coloumn - 1 && flag1==0)
                                {
                                    sum = 0;
                                    flag1 = 1;
                                }
                        }
                    }
                    flag1 = 0;
                    count++;
                    r++;
                }
                if (rr < row)
                {
                    list = new List<string>();
                    for (int i = 0; i < coloumn; i++)
                    {
                        sum -= matrix[rr, i];
                        list.Add(rr + "," + i + "(" + matrix[rr, i] + ")");
                        if (sum == target)
                        {
                            foreach (var elements in di)
                            {                              
                                di.Add(index, list);
                                index++;                             
                                if (i != coloumn - 1 && flag1==0)
                                {
                                    sum = 0;
                                    flag1 = 1;
                                }
                            }
                        }
                    }
                    flag1 = 0;
                    sum = 0;
                    count++;
                    rr++;
                }
                else
                {
                    count = total * row+1;
                }
            }
        }
    }
}
