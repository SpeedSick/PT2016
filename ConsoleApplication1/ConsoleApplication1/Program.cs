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
        int[] a;
        public BigInteger()
        {
            n = 0;
        }
        public BigInteger(string s)
        {
            n = s.Length;
            for (int i = 0; i < n; ++i)
                a[i] = s[n - i - 1] - '0';
        }
        public override string ToString()
        {
            string s = "";
            foreach(int i in a)
            {
                s += Convert.ToString(a[i]);
            }
            return s;
        }
    }
    class Complex
    {
        public int a, b;
        public Complex()
        {
            a = b = 0;
        }
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public override string ToString()
        {
            return a + "/" + b;
        }
        public static Complex operator +(Complex A, Complex B)
        {
            return new Complex(A.a + B.a, A.b + B.b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string t = Console.ReadLine();
            BigInteger a = new BigInteger(s), b = new BigInteger(t);
            Console
        }
    }
}
