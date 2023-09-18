namespace Parse
{
    public class Parse
    {
        public static void Main()
        {
            string str = "-12345";
            int result;

            if (int.TryParse(str, out result))
            {
                Console.WriteLine("정수로 변환된 값:  " + result);
            }
            else
            {
                Console.WriteLine("유효한 정수로 변환할 수 없습니다.");
            }
        }
    }
}