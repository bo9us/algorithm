namespace divisor
{
    public class Solution
    {
        public int SumofDivisors(int n)
        {
            int sum = 0;
           
            for(int i = 1; i <= n; i++)
            {
                   if(n % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
        
            
        
    }

    class Program { 
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Console.Write("정수 n을 입력하시오: ");
        int n = int.Parse(Console.ReadLine());

        int result = solution.SumofDivisors(n);
        Console.WriteLine($"정수 {n}의 약수를 모두 더한 값: {result}");
            }
    }
}
