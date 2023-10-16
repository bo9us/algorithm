namespace baekJoon11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            long[] nums = new long[3];
            long total = 0;

            for(int i = 0; i < 3; i++)
            {
                nums[i] = long.Parse(s[i]);
                total += nums[i];
            }

            Console.WriteLine(total);
        }
    }
}