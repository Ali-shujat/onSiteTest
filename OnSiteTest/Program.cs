using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace OnSiteTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(largestPair(49999));
        }

        private static int largestPair(int v)
        {
            List<string> stringList = new();
            int m = 0;
            v = Math.Abs(v);
            if (v < 10) return v;
            while (v >= 10) // if you want to accept single digits change this to v > 0
            {
                m = Math.Max(m, v % 100);
                v /= 10;
            }
            return m;
        }
    }
}
