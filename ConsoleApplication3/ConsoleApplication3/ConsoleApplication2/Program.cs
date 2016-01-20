using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void WalkDirectoryTree(DirectoryInfo d, int depth)
        {
            foreach(FileInfo file in d.GetFiles())
            {
                Console.WriteLine("Depth = {0}, File = {1}", depth, file.Name);
            }
            foreach(DirectoryInfo directory  in d.GetDirectories())
            {
                Console.WriteLine("Depth = {0}, Directory = {1}", depth, directory.Name);
                WalkDirectoryTree(directory, depth + 1);
            }
        }
        static void Main(string[] args)
        {
            try {
                DirectoryInfo d = new DirectoryInfo(@"C:\Windows");
                if (d.Exists)
                    Console.WriteLine("EXISTS");
                else
                    Console.WriteLine("DOESN'T EXISTS");
                WalkDirectoryTree(d, 0);
                Console.ReadKey();
            } catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
