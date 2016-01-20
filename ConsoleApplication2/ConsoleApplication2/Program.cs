using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileInfo
            //DirectoryInfo
            FileInfo file = new FileInfo(@"C:\testfolder\inf1.txt");
            FileInfo file2 = new FileInfo(@"C:\testfolder\inf2.txt");
            // Console.WriteLine("File name " + file.Name + ", File fullname " + file.FullName);
            // Identical (^ is cout, v is printf())
            if (file.Exists)
            {
                Console.WriteLine("File name {0}, File fullname {1}", file.Name, file.FullName);
                Console.WriteLine(file.GetHashCode());
                Console.WriteLine(file2.GetHashCode());
            }
            else
            {
                Console.WriteLine("There is no such file");
            }
            Console.ReadKey();
        }
    }
}
