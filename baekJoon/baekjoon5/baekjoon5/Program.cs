namespace baekjoon5
{
    internal class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            string[] strings = s.Split();

            double a = double.Parse(strings[0]);
            double b = double.Parse(strings[1]);

            Console.WriteLine(a/b);
        }
    }
}