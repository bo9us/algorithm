using System;
using static System.Console;

namespace baekJoon9

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = ReadLine().Split();
            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]);
            int c = int.Parse(s[2]);

            WriteLine((a + b) % c);
            WriteLine((a % c) + (b % c) % c);
            WriteLine((a + b) % c);
            WriteLine((a % c) + (b % c) % c);
        }
    }
}