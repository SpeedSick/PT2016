using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture
{
    class BigInteger
    {
        int n;
        int[] a = new int[3000];
        public BigInteger()
        {
            n = 0;
        }
        public BigInteger(string s)
        {
            n = s.Length;
            for (int i = 0; i < n; ++i)
                a[i] = Convert.ToInt32(s[n - i - 1] - '0');
        }
        public override string ToString()
        {
            string s = "";
            for(int i = 0; i < n; ++i)
            {
                s += Convert.ToChar(a[n - i - 1] + '0');
            }
            return s;
        }
        static public BigInteger operator + (BigInteger x, BigInteger y)
        {
            BigInteger c = new BigInteger();
            int carry = 0;
            c.n = Math.Max(x.n, y.n);
            for(int i = 0; i < c.n; ++i)
            {
                c.a[i] = x.a[i] + y.a[i] + carry;
                carry = c.a[i] / 10;
                c.a[i] %= 10; 
            }
            if (carry > 0) c.a[c.n++] = carry;
            while (c.a[c.n - 1] == 0 && c.n > 0)
                c.n--;
            return c;
        }
        static public BigInteger operator *(BigInteger x, BigInteger y)
        {
            BigInteger c = new BigInteger();
            c.n = x.n + y.n;
            for (int i = 0; i < x.n; ++i)
            {
                for(int j = 0, carry = 0; j < y.n || carry > 0; ++j)
                {
                    c.a[i + j] += x.a[i] * y.a[j] + carry;
                    carry = c.a[i + j] / 10;
                    c.a[i + j] %= 10;
                }
            }
            while (c.a[c.n - 1] == 0 && c.n > 0)
                c.n--;
            return c;
        }
        public static BigInteger operator -(BigInteger a, BigInteger b)
        {
            BigInteger c = new BigInteger();
            c.n = Math.Max(a.n, b.n);
            for (int i = 0; i < c.n; i++)
                c.a[i] = a.a[i] - b.a[i];
            for (int i = 0; i < c.n; i++)
                if (c.a[i] < 0)
                {
                    c.a[i] += 10;
                    c.a[i + 1]--;
                }
            while (c.a[c.n - 1] == 0 && c.n > 0)
                c.n--;
            return c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            BigInteger a = new BigInteger(s), b = new BigInteger(t);
            Console.WriteLine(a + b);
            Console.WriteLine(b * a);
            Console.WriteLine(a - b);
        }
    }
}
