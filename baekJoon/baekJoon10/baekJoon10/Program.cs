namespace baekJoon10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            int A = Int32.Parse(a);

            int b1 = b[0] - '0';
            int b2 = b[1] - '0';
            int b3 = b[2] - '0';
            int b4 = Int32.Parse(b);

            Console.WriteLine(A * b3); //(3)
            Console.WriteLine(A * b2); //(4)
            Console.WriteLine(A * b1); //(5)
            Console.WriteLine(A * b4); //(6)

        }
    }
}