using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace minmaxfile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nick\Documents\Visual Studio 2015\Projects\minmaxfile\a.in";
            FileStream filestreamread = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(filestreamread);
            path = @"C:\Users\Nick\Documents\Visual Studio 2015\Projects\minmaxfile\a.out";
            FileStream filestreamwrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(filestreamwrite);
            int a, b;
            string[] token = reader.ReadLine().Split();
            a = int.Parse(token[0]); b = int.Parse(token[1]);
            writer.WriteLine(min(a, b) + " " + max(a, b));
            writer.Close();
            reader.Close();
        }

        private static int min(int a, int b)
        {
            if (a > b) return b;
            return a;
        }
        private static int max(int a, int b)
        {
            if (a > b) return a;
            return b;
        }
    }
}
    