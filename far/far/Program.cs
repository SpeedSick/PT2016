using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace far
{
    class Program
    {
        int n = 0;
        static void Main(string[] args)
        {
            string path = @"C:\work\train\";
            Console.Clear();
            DirectoryInfo cur = new DirectoryInfo(path);
            FileInfo[] files = cur.GetFiles();
            DirectoryInfo[] directories = cur.GetDirectories();
            while(true)
            {
                Print();
                ConsoleKeyInfo x = Console.ReadKey();
                if(x.Modifiers & x)
                if(x.Key.ToString() == "RightArrow")

            }
        }
        private static void Print(FileInfo[] files, DirectoryInfo[] directories)
        {
            if(n != 0)

        }
    }
}
