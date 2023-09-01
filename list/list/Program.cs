namespace list
{
    internal class Program
    {
        public static List<long> solution(int x, int n)
        {
            List<long> result = new List<long>();
            for (int i = 1; i <= n; i++)
            {
                result.Add((long)x * i);
            }
            return result;
        }
        static void Main(string[] args)
        {
            int x = 4;
            int n = 3;
            List<long> answer = solution(x, n);

            Console.WriteLine("Result:");
            foreach (long num in answer)
            {
                Console.Write(num + " ");
            }
        }
    }
}