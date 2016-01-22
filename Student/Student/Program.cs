using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Student
    {
        public string firstname, lastname;
        public double gpa;
        public Student()
        {
            gpa = 0;
            firstname = lastname = "";
        }
        public Student(string a, double gpa)
        {
            string[] token = a.Split();
            firstname = token[0]; lastname = token[1];
            this.gpa = gpa;
        }
        public Student(string a, string b, double gpa)
        {
            firstname = a;
            lastname = b;
            this.gpa = gpa;
        }
        public override string ToString()
        {
            return firstname + " " + lastname + ", " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Student[] KBTU = new Student[110];
            for (int i = 0; i < n; ++i)
            {
                string s = Console.ReadLine();
                string[] token = s.Split();
                try {
                    KBTU[i] = new Student(token[0], token[1], Convert.ToDouble(token[2]));
                } 
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            for (int i = 0; i < n; ++i)
                Console.WriteLine(KBTU[i]);
            Console.ReadKey();
        }
    }
}
