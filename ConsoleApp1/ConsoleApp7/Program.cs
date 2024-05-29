using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static private List<Students> li = new List<Students>();
        private static  int m = 0;
        static void Main(string[] args)
        {
            while (true)
            {
                label:
                Console.WriteLine("\n1.Addstudent\n2.remove\n3.filter\n4.sort\n5.update");
                Console.Write("enter the number : ");
                //int nu = int.Parse(Console.ReadLine());
                int nu;
                bool parse = int.TryParse(Console.ReadLine(), out nu);
                if (!parse)
                {
                    Console.WriteLine("invalid input enter again in number format");
                    goto label;
                }
                switch (nu)
                {
                    case 1:
                        Add();
                        break;
                    case 2:
                        Remove();
                        break;
                    case 3:
                        Filter();
                        break;
                    case 4:
                        Sort();
                        break;
                    case 5:
                        Update();
                        break;

                }
            }
            //}
            Console.ReadLine();
        }
        static void M(string text)
        {
            label1:
            Console.Write(text);
            if (!int.TryParse(Console.ReadLine(), out m))
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                goto label1;
            }
            if (m > 100 || m<0)
            {
                Console.WriteLine("invalid input enter again number should be less than 100");
                goto label1;
            }
        }
        static void Add()
        {
            label3:
            Console.Write("enter the number of students : ");
            int n;
            bool parse = int.TryParse(Console.ReadLine(), out n);
            if (!parse)
            {
                Console.WriteLine("invalid input enter again in number format");
                goto label3;
            }
            int p = n;
            int id = 0;
            while (n-- > 0)
            {
                Students stud = new Students();
                Console.WriteLine();
                label5:
                Console.Write("enter the name of student : ");
                string Name=(Console.ReadLine());
                if(string.IsNullOrEmpty(Name))
                {
                    Console.WriteLine("Invalid input. Please enter a valid string.");
                    goto label5;
                }
                else if(!Regex.Match(Name,"^[a-zA-Z]*$").Success)
                {
                    Console.WriteLine("Invalid input. Please enter a valid string.");
                    goto label5;
                }
                else
                {
                    stud.Name = Name;
                }

                M("Enter tamil mark : ");
                stud.Mark1 = m;
                //  int Mark1;
                /* if (!int.TryParse(Console.ReadLine(), out Mark1))
                 {
                     Console.WriteLine("Invalid input. Please enter a valid number.");
                     goto label1;
                 }
                 if (Mark1 > 100)
                 {
                     Console.WriteLine("invalid input enter again number should be less than 100");
                     goto label1;
                 }
                 else
                 {
                     stud.Mark1=Mark1;
                 }*/
                M("Enter English mark : ");
                stud.Mark2 = m;
                M("Enter computer science mark : ");
                stud.Mark3 = m;
                M("Enter physics mark : ");
                stud.Mark4 = m;
                M("Enter chemistry mark : ");
                stud.Mark5 = m;
                M("Enter Maths mark : ");
                stud.Mark6 = m;
                id++;
                stud.id = id;
                li.Add(stud);
                // li.Add(id);
                //stud.Percentage(out float percent);
                //stud.percent = percent;
                // Console.WriteLine(stud.Percent);
                //stud.Cutoff(out float cutoff);
                // stud.cutoff = cutoff;
            }
            // List<Students> desc = li.OrderByDescending(i => i.To).ToList();
            Print(li);
        }
        static void Remove()
        {
            label2:
            Console.Write("ENTER THE ID TO DELETE : ");
            int l = int.Parse(Console.ReadLine());
            if (l < li.Count)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                goto label2;
            }
            else
            {
                li.RemoveAt(l - 1);
                Print(li);
            }
        }
        static void Filter()
        {
            Console.WriteLine("\n1.name\n2.passorfail");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("enter the name to filter : ");
                    string s = Console.ReadLine();
                    Console.WriteLine("ID" + "   " + "rank" + " " + "name" + "       " + "total" + " " + "result" + " " + "percentage" + " " + "cutoff");
                    foreach (var d in li)
                    {
                        if (d.Name.Contains(s))
                        {
                            Console.WriteLine(d.id.ToString().PadRight(4 - d.id.ToString().Length + d.id.ToString().Length) + " " + d.rank.ToString().PadRight(4 - d.rank.ToString().Length + d.rank.ToString().Length) + " " + d.Name.PadRight(10 - d.Name.Length + d.Name.Length) + " " + d.To.ToString().PadRight(5 - d.To.ToString().Length + d.To.ToString().Length) + " " +
                                                 d.Passfail + "   " + d.Percent.ToString().PadRight(10 - d.Percent.ToString().Length + d.Percent.ToString().Length) + " " + d.Cut.ToString().PadRight(6 - d.Cut.ToString().Length + d.Cut.ToString().Length));
                        }
                    }
                    break;
                case 2:
                    Console.Write("enter pass/fail : ");
                    string s1 = Console.ReadLine();
                    Console.WriteLine("ID" + "   " + "rank" + " " + "name" + "       " + "total" + " " + "result" + " " + "percentage" + " " + "cutoff");
                    foreach (var d in li)
                    {
                        if (d.Passfail == s1)
                        {
                            Console.WriteLine(d.id.ToString().PadRight(4 - d.id.ToString().Length + d.id.ToString().Length) + " " + d.rank.ToString().PadRight(4 - d.rank.ToString().Length + d.rank.ToString().Length) + " " + d.Name.PadRight(10 - d.Name.Length + d.Name.Length) + " " + d.To.ToString().PadRight(5 - d.To.ToString().Length + d.To.ToString().Length) + " " +
                                                 d.Passfail + "   " + d.Percent.ToString().PadRight(10 - d.Percent.ToString().Length + d.Percent.ToString().Length) + " " + d.Cut.ToString().PadRight(6 - d.Cut.ToString().Length + d.Cut.ToString().Length));
                        }
                    }

                    break;
            }
        }
        static void Sort()
        {
            Console.WriteLine("\n1.name\n2.totalmark\n3.cutoff");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    List<Students> name = li.OrderBy(i => i.Name).ToList();
                    Print(name);
                    break;
                case 2:
                    List<Students> tm = li.OrderByDescending(i => i.To).ToList();
                    Print(tm);
                    break;
                case 3:
                    List<Students> desc = li.OrderByDescending(i => i.Cut).ToList();
                    Print(desc);
                    break;
            }
        }
        static void Print(List<Students> lii)
        {
            for (int j = 0; j < lii.Count; j++)
            {

                int c = 1;
                for (int k = 0; k < lii.Count; k++)
                {
                    if (lii[j].To < lii[k].To)
                    {
                        c++;
                    }
                }
                lii[j].rank = c;
            }
            Console.WriteLine("ID" + "   " + "rank" + " " + "name" + "       " + "total" + " " + "result" + " " + "percentage" + " " + "cutoff");
            foreach (var d in lii)
            {
                Console.WriteLine(d.id.ToString().PadRight(4 - d.id.ToString().Length + d.id.ToString().Length) + " " + d.rank.ToString().PadRight(4 - d.rank.ToString().Length + d.rank.ToString().Length) + " " + d.Name.PadRight(10 - d.Name.Length + d.Name.Length) + " " + d.To.ToString().PadRight(5 - d.To.ToString().Length + d.To.ToString().Length) + " " +
                 d.Passfail + "   " + d.Percent.ToString().PadRight(10 - d.Percent.ToString().Length + d.Percent.ToString().Length) + " " + d.Cut.ToString().PadRight(6 - d.Cut.ToString().Length + d.Cut.ToString().Length));
            }
        }
        static void Update()
        {
            Console.WriteLine("\n1.name\n2.mark");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.Write("enter the id to update : ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write("enter the name to update : ");
                    string s = Console.ReadLine();
                    foreach (var u in li)
                    {
                        if (u.id == id)
                        {
                            u.Name = s;
                        }
                    }
                    Console.WriteLine("ID" + "   " + "rank" + " " + "name" + "       " + "total" + " " + "result" + " " + "percentage" + " " + "cutoff");
                    foreach (var d in li)
                    {
                        Console.WriteLine(d.id.ToString().PadRight(4 - d.id.ToString().Length + d.id.ToString().Length) + " " + d.rank.ToString().PadRight(4 - d.rank.ToString().Length + d.rank.ToString().Length) + " " + d.Name.PadRight(10 - d.Name.Length + d.Name.Length) + " " + d.To.ToString().PadRight(5 - d.To.ToString().Length + d.To.ToString().Length) + " " +
                         d.Passfail + "   " + d.Percent.ToString().PadRight(10 - d.Percent.ToString().Length + d.Percent.ToString().Length) + " " + d.Cut.ToString().PadRight(6 - d.Cut.ToString().Length + d.Cut.ToString().Length));
                    }
                    break;
                case 2:
                    Console.WriteLine("\n1.tamil\n2.english\n3.computerscience\n4.physics\n5.chemistry\n6.maths");
                    Console.Write("enter the subject number to update : ");
                    int mm = int.Parse(Console.ReadLine());
                    switch(mm)
                    {
                        case 1:
                            Console.Write("enter the id to update : ");
                            int idd = int.Parse(Console.ReadLine());
                            Console.Write("enter tamil mark to update : ");
                            int y = int.Parse(Console.ReadLine());
                            foreach (var u in li)
                            {
                                if (u.id == idd)
                                {
                                    u.Mark1 = y;
                                    u.Mark6 = u.Mark6;
                                }
                            }
                            Print(li);
                            break;
                        case 2:
                            Console.Write("enter the id to update : ");
                            int idd1 = int.Parse(Console.ReadLine());
                            Console.Write("enter english mark to update : ");
                            int y1 = int.Parse(Console.ReadLine());
                            foreach (var u in li)
                            {
                                if (u.id == idd1)
                                {
                                    u.Mark2 = y1;
                                    u.Mark6 = u.Mark6;
                                }
                            }
                            Print(li);
                            break;
                        case 3:
                            Console.Write("enter the id to update : ");
                            int idd2 = int.Parse(Console.ReadLine());
                            Console.Write("enter computer science mark to update : ");
                            int y12 = int.Parse(Console.ReadLine());
                            foreach (var u in li)
                            {
                                if (u.id == idd2)
                                {
                                    u.Mark3 = y12;
                                    u.Mark6 = u.Mark6;
                                }
                            }
                            Print(li);
                            break;
                        case 4:
                            Console.Write("enter the id to update : ");
                            int idd4 = int.Parse(Console.ReadLine());
                            Console.Write("enter physics mark to update : ");
                            int y13 = int.Parse(Console.ReadLine());
                            foreach (var u in li)
                            {
                                if (u.id == idd4)
                                {
                                    u.Mark2 = y13;
                                    u.Mark6 = u.Mark6;
                                }
                            }
                            Print(li);
                            break;
                        case 5:
                            Console.Write("enter the id to update : ");
                            int idd5 = int.Parse(Console.ReadLine());
                            Console.Write("enter chemistry mark to update : ");
                            int y14 = int.Parse(Console.ReadLine());
                            foreach (var u in li)
                            {
                                if (u.id == idd5)
                                {
                                    u.Mark2 = y14;
                                    u.Mark6 = u.Mark6;
                                }
                            }
                            Print(li);
                            break;
                        case 6:
                            Console.Write("enter the id to update : ");
                            int idd6 = int.Parse(Console.ReadLine());
                            Console.Write("enter  mark to update : ");
                            int y15 = int.Parse(Console.ReadLine());
                            foreach (var u in li)
                            {
                                if (u.id == idd6)
                                {
                                    u.Mark2 = y15;
                                    u.Mark6 = u.Mark6;
                                }
                            }
                            Print(li);
                            break;
                    }
                    break;   

            }
        }
    }
}
  


