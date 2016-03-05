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
            string path = @"C:\Users\Nick\Documents\Visual Studio 2015\Projects\primeforlab2\a.in";
            FileStream filestreamread = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader reader = new StreamReader(filestreamread);
            path = @"C:\Users\Nick\Documents\Visual Studio 2015\Projects\primeforlab2\a.out";
            FileStream filestreamwrite = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter writer = new StreamWriter(filestreamwrite);
            string[] token = reader.ReadLine().Split();
            int[] a = new int[100000];
            int ans = -1;
            for (int i = 0; i < token.Length; ++i)
            {
                a[i] = Convert.ToInt32(token[i]);
                if (isprime(a[i]) && (a[i] < ans || ans == -1))
                    ans = a[i];
            }
            writer.WriteLine(ans);
            writer.Close();
            reader.Close();
        }

        private static bool isprime(int v)
        {
            if (v == 1) return false;
            for (int i = 2; i * i <= v; ++i)
                if (v % i == 0) return false;
            return true;
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
