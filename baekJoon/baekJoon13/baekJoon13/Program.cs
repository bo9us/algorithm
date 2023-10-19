namespace baekJoon13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] in_data = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            if (in_data[0] > in_data[1])
            {
                Console.WriteLine(">");
            }
            else if (in_data[0] < in_data[1])
            {
                Console.WriteLine("<");
            }
            else
            {
                Console.WriteLine("==");
            }
        }
    }
}