using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class datetime
    {
        static void datemonthyear(int d,int a,int m,int d1,int a1,int m1)
        { 
            if (d1 > d )
            {
                int days = Math.Abs(d1 - d);
                if (m == 11)
                {
                   // days = days + 1;
                    int month = Math.Abs(12 - Math.Abs((m1 - m)) );
                    int age = (Math.Abs(a1 - a)) - 1;
                    Console.WriteLine(days + "days " + month + "month " + age + "year");
                }
                else if (m1 > m)
                {
                    int age = (Math.Abs(a1 - a));
                    int month = Math.Abs(m1 - m) ;
                    Console.WriteLine(days + "days " + month + "month " + age + "year");
                }
                else
                {
                    int age = (Math.Abs(a1 - a))-1;
                    int month = Math.Abs(12 - Math.Abs((m1 - m))-1);
                    Console.WriteLine(days + "days " + month + "month " + age + "year");
                }
            }
            else
            {
                int days = DateTime.DaysInMonth(a, m);
                int day = (days - d) + d1;
                if(m==11)
                {
                    //day = day ;
                    int month = Math.Abs(12 - Math.Abs((m1 - m)));
                    int age = (Math.Abs(a1 - a)) - 1;
                    Console.WriteLine(day + "days " + month + "month " + age + "year");
                }
                else if (m1 > m)
                {
                    int age = Math.Abs(a1 - a);
                    int month = Math.Abs(m1 - m) - 1;
                    Console.WriteLine(day + "days " + month + "month " + age + "year");
                }
                else
                {
                    int age = (Math.Abs(a1 - a)) - 1;
                    int month = Math.Abs(12 - Math.Abs((m1 - m))-1);
                    Console.WriteLine(day + "days " + month + "month " + age + "year");
                }
            }
        }
        static void month(int m,int m1,int a,int a1)
        {
            if (m1 > m)
            {
                int mo = Math.Abs(a1 - a) * 12 + Math.Abs(m1 - m);
                Console.WriteLine(mo + "month");
            }
            else
            {
                int age = (Math.Abs(a1 - a)) - 1;
                int mo = age * 12 + Math.Abs(12 - Math.Abs((m1 - m)));
                Console.WriteLine(mo + "month");
            }
        }
        static void weeks(DateTime cd,DateTime dt)
        {
            int td = (int)(cd - dt).TotalDays;
            int tw = td / 7;
            Console.WriteLine(tw + " weeks");
        }
        static void days(DateTime cd,DateTime dt)
        {
            int td = (int)(cd - dt).TotalDays;
            Console.WriteLine(td + " days");
        }
        static void hours(DateTime cd,DateTime dt)
        {
            int th = (int)(cd - dt).TotalHours;
            Console.WriteLine(th + " hours");
        }
        static void minutes(DateTime cd,DateTime dt)
        {
            int min = (int)(cd - dt).TotalMinutes;
            Console.WriteLine(min + "minutes");
        }
        static void seconds(DateTime cd, DateTime dt)
        {
            int sec = (int)(cd - dt).TotalSeconds;
            Console.WriteLine(sec + "seconds");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n1.input in date of birth format" + "\n2.number format");
            Console.Write("enter a number(1/2): ");
            int t = int.Parse(Console.ReadLine());
            if (t == 1)
            {
                Console.Write("enter a date of month:");
                string s = Console.ReadLine();
                DateTime dt = Convert.ToDateTime(s);
                int d = dt.Day;
                int a = dt.Year;
                int m = dt.Month;
                DateTime cd = DateTime.Now;
                int d1 = cd.Day;
                int a1 = cd.Year;
                int m1 = cd.Month;
                while (true)
                {
                    Console.WriteLine("\n1.datemonthyear" + "\n2.month" + "\n3.weeks" + "\n4.days" + "\n5.hours" + "\n6.minutes" + "\n7.seconds");
                    Console.Write("\nenter a number : ");
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            datemonthyear(d, a, m, d1, a1, m1);
                            break;
                        case 2:
                            month(m, m1, a, a1);
                            break;
                        case 3:
                            weeks(cd, dt);
                            break;
                        case 4:
                            days(cd, dt);
                            break;
                        case 5:
                            hours(cd, dt);
                            break;
                        case 6:
                            minutes(cd, dt);
                            break;
                        case 7:
                            seconds(cd, dt);
                            break;

                    }
                }
            }
            else
            {
                Console.Write("enter a number : ");
                //int n = int.Parse(Console.ReadLine());
                string se = Console.ReadLine();
                long n = long.Parse(se);
                while(true)
                {
                    Console.WriteLine("\n1.weektoday" + "\n2.weektohour" + "\n3.daystohour" + "\n4.daystominutes" + "\n5.hourtominute" + "\n6.hourtoseconds" + "\n7.secondstominutes"+"\n8.secondstohour"+"\n9.secondstoday"+"\n10.secondstoweek");
                    Console.Write("\nenter a number : ");
                    int input = int.Parse(Console.ReadLine());
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine(n * 7 + "days");
                            break;
                        case 2:
                            Console.WriteLine(n * 7 * 24 + "days");
                            break;
                        case 3:
                            Console.WriteLine(n * 24 + "hours");
                            break;
                        case 4:
                            Console.WriteLine(n * 24 * 60 + "minutes");
                            break;
                        case 5:
                            Console.WriteLine(n * 60+"minutes");
                            break;
                        case 6:
                            Console.WriteLine(n * 60 * 60 + "seconds");
                            break;
                        case 7:
                            Console.WriteLine(n / 60 + "minutes");
                            break;
                        case 8:
                            Console.WriteLine(n / 60 / 60 + "hours");
                            break;
                        case 9:
                            Console.WriteLine(n / 60 / 60 /24+ "days");
                            break;
                        case 10:
                            Console.WriteLine(n / 60 / 60 /24 /7+ "weeks");
                            break;
                    }
                }

            }       

        }
    }
}
