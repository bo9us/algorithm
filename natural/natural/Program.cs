using System.Reflection.Metadata.Ecma335;

namespace natural
{
    public class Solution
    {
        public int[] ReverseDigits(int n)
        {
            List<int> result = new List<int>();

            if (n == 0)
            {
                result.Add(0);
                return result.ToArray();
            }

            while (n > 0)
            {
                int digit = n % 10;
                result.Add(digit);
                n /= 10;
            }

            return result.ToArray();
        }
        
        
        public static void Main(string[] args)
        {
            int n = 12345;
            Solution solution = new Solution();
            int[] reverseDigits = solution.ReverseDigits(n);

            Console.Write("[");
            foreach (int digit in reverseDigits)
            {
                Console.Write(digit + ",");
            }
            Console.Write("]");
        }
    }
}