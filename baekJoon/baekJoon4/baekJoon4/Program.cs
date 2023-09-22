using System.Data;

namespace baekJoon4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] strings = s.Split();

            int a = int.Parse(strings[0]);
            int b = int.Parse(strings[1]); 

            Console.WriteLine(a * b);
        }
    }
}