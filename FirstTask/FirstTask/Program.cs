using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] s = Console.ReadLine().Split();
            int[] a = new int[n + 1];
            int sz = 0;
            int[] primes = new int[n + 1];
            for (int i = 0; i < n; ++i)
            {
                a[i] = int.Parse(s[i]);
                if(isprime(a[i]))
                {
                    primes[sz++] = a[i];
                }
            }
            if (sz == 0)
                Console.WriteLine("No primes");
            else
            {
                string res = "";
                for (int i = 0; i < sz; ++i)
                    res += a[i] + " ";
                Console.WriteLine(res);
            }
        }

        public static bool isprime(int v)
        {
            if (v == 1) return false;
            for (int i = 2; i * i <= v; ++i)
                if (v % i == 0) return false;
            return true;
        }
    }
}
