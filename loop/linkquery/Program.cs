using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkquery
{
    class Program
    {
        static void Main(string[] args)
        {
                List<Student> students = new List<Student>();
                students.Add(new Student
                {
                    Name = "Sundar",
                    Dob = new DateTime(2003, 06, 26)
                });
                students.Add(new Student
                {
                    Name = "Bharath",
                    Dob = new DateTime(2004, 05, 13)
                });
                students.Add(new Student
                {
                    Name = "Sukant",
                    Dob = new DateTime(2005, 03, 30)
                });
                students.Add(new Student
                {
                    Name = "Sharuk",
                    Dob = new DateTime(1995, 06, 26)
                });

                List<Student> selected = students.FindAll(s => s.Name == "Sharuk");
                int find = students.Count(s => s.Name == "Sharuk");
            Console.Write(find);
                List<string> names = students.Select(i => i.Name).ToList();
                students.ForEach(i => Compute(i));
            }

            private static void Compute(Student s)
            {

            }
        }
        class Student
        {
            private DateTime dob;

            public string Name { get; set; }

            public DateTime Dob
            {
                get
                {
                    return dob;
                }
                set
                {
                    dob = value;
                    //age calculation
                    Age = Convert.ToInt32(DateTime.Now.Subtract(dob).TotalDays / 365);
                }
            }

            public int Age { get; private set; }

            public void Compute()
            {

            }
        }
    }

