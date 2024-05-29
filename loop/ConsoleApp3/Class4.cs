using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    
    class Class4
    {
        public static void UI()
        {
            string date1 = "2020-01-15", date2 = "2019-12-31";
            DateTime obj = DateTime.Parse(date1);
            DateTime obj2 = DateTime.Parse(date2);
            int d =Math.Abs((int)(obj-obj2).TotalDays);
            Console.Write(d);

        }
        public static void U()
        {
            int[] arr = { 1024,512,256,128,64,32,16,8,4,2,1};
            Array.Sort(arr);
            int l = 0, c = 0, co = 0 ;
            List<int> li = new List<int>();
            while (c < arr.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int k = 0;
                    int a = arr[i];
                    if (a == 0)
                    {
                        k = 0;
                    }
                    else
                    {
                        while (a >= 1)
                        {
                            k += a % 2;
                            a = a / 2;

                        }
                    }
                    if (k == l)
                    {
                        li.Add(arr[i]);
                        Console.WriteLine(li[co]);
                        c++;
                        co++;
                        //Console.Write(c);
                    }
                }
                l++;
               
            }
            for(int i=0;i<li.Count();i++)
            {
                Console.Write(li[i] + " ");
               
            }
        }
        public Class4()
        {
            //var results = new List<IList<int>>();

            //if (numRows == 0) return results;
            //results.Add(new List<int>(1) { 1 });
            //if (numRows == 1) return results;
            //results.Add(new List<int>(2) { 1, 1 });
            //if (numRows == 2) return results;

            //for (int i = 2; i < numRows; i++)
            //{
            //    IList<int> result = new List<int>();
            //    result.Add(1);

            //    for (var j = 1; j < i; j++)
            //    {
            //        var number = results[i - 1][j - 1] + results[i - 1][j];
            //        result.Add(number);
            //    }

            //    result.Add(1);
            //    results.Add(result);
            //}

            //return results;
            //int n = 5;
            //List<int> li = new List<int>();
            //int c = 1;
            //li.Add(n);
            //while (n != 1)
            //{
            //    for (int i = 1; i < n; i++)
            //    {
            //        if (n % i == 1 )
            //        {
            //            li.Add(i);
            //            c++;
            //        }
            //        int k = 0;
            //        for(int j=0;j<li.Count;j++)
            //        {
            //            Console.WriteLine("ad is :" + li[j]);
            //            if (i == li[j])
            //            {
            //                if (k > 0)
            //                {
            //                    li.Remove(i);
            //                    Console.WriteLine("nn is : " + i);
            //                }
            //                k++;
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    n--;
            //}
            //foreach (var ny in li)
            //{
            //    Console.Write(ny + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("c is : " + c);
        }
    }
    }
   

