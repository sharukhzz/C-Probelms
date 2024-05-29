using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codechef
{
    class Class2
    {

        private static int[] aa = new int[3];
        public static void Mat()
        {
            Console.Write("enter the no of row : ");
            int r = int.Parse(Console.ReadLine());
            Console.Write("enter the no of coloumn : ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the element : ");
            int[,] a = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("enter the target position of row : ");
            int tr = int.Parse(Console.ReadLine());
            Console.Write("enter the target position of coloumn : ");
            int tc = int.Parse(Console.ReadLine());
            int sr = 0, sc = 0, tb = 0,lr=0,dg=0;
            int f = 0,co=0;
            while (sr <= tr || sc <= tc)
            {
                if (sr != tr)
                {
                    tb += a[sr, sc];
                    sr++;
                    co++;
                    //Console.Write("sr : " + sr);
                }
                else
                {
                    if (sc != tc)
                    {
                        tb += a[sr, sc];
                        sc++;
                        co++;
                        //Console.Write("sc : " + sc);
                    }
                }
                if (sr == tr && sc == tc)
                {
                    tb += a[sr, sc];
                    break;
                }

            }
            Console.WriteLine("tb is : " + tb);
            Console.WriteLine("TopBottom step is : " + co);
            aa[f]=tb;
            f++;
            sr = 0;
            sc = 0;
            int co2 = 0;
            while(sr<=tr || sc<=tc)
            {
                if(sc!=tc)
                {
                    lr += a[sr, sc];
                    sc++;
                    co2++;
                }
                else
                {
                    if(sr!=tr)
                    {
                        lr += a[sr, sc];
                        sr++;
                        co2++;
                    }
                }
                if(sc==tc && sr==tr)
                {
                    lr += a[sr, sc];
                    break;
                }
            }
            Console.WriteLine("lr is : " + lr);
            Console.WriteLine("LeftRight step is : " + co2);
            aa[f] = lr;
            f++;
            if(co2<co)
            {
                co2 = co; 
            }
            sr = 0;
            sc = 0;
            co = 0;
            int flag = 0;
            if(tr>tc)
            {
                flag = 1;
            }
            while(sr <= tr || sc<=tc)
            {
                if (flag == 1)
                {
                    if (sc == sr && sc <= tc )
                    {
                        //Console.WriteLine("sr : " + sr);
                        //Console.WriteLine("sc : " + sc);
                        dg += a[sr, sc];
                        sc++;
                        sr++;
                        co++;
                       // Console.WriteLine("dg : " + dg);
                    }
                    else
                    {
                            sc--;
                            //Console.WriteLine("sr11 : " + sr);
                            //Console.WriteLine("sc11 : " + sc);
                            //Console.WriteLine("sd : ds : " + a[sr, sc]);
                            dg += a[sr, sc];
                        while (sr < tr)
                        {
                            sr++;
                            sc++;
                            co++;
                        }
                    }
                }
                if(flag==0)
                {
                    if (sc == sr && sr <= tr)
                    {
                        //Console.WriteLine("sr : " + sr);
                        //Console.WriteLine("sc : " + sc);
                        dg += a[sr, sc];
                        sc++;
                        sr++;
                        co++;
                        //Console.WriteLine("dg : " + dg);
                    }
                    else
                    {
                        sr--;
                        dg += a[sr, sc];
                        while (sc < tc)
                        {
                            sr++;
                            sc++;
                            co++;
                        }
                    }
                }
                if (sc == tc && sr == tr)
                {
                    break;
                }
            }
            Console.WriteLine("dg is : "+dg);
            Console.WriteLine("diagonal step is : " + co);
            aa[f] = dg;
            Array.Sort(aa);
            Console.WriteLine("minimum is : " + aa[0]);
            if (co2 < co)
            {
                Console.WriteLine("minimum no of step is :"+co2);
            }
            else
            {
                Console.WriteLine("minimum no of step is :" + co);
            }
        }
    }
}
