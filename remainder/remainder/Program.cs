namespace remainder
{
    public class Solution
    {
        public int solution(int n)
        {
            for(int x = 2; x <= n; x++)
            {
                if(n % x == 1)
                {
                    return x;
                }
            }
            return -1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int result = solution.solution(10);
            Console.WriteLine(result);
        }
    }
}