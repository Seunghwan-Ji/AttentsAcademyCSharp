namespace _04_Operator_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수값을 입력하세요: ");
            string inputStr = Console.ReadLine(); // 문자열을 입력.

            // int inputValue = Console.Read(); // 한 문자 입력

            int inputValue = 0;
            
            try
            {
                inputValue = int.Parse(inputStr);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            bool ret = (0 < inputValue) && (inputValue < 10);

            if (ret == true)
            {
                Console.WriteLine($"x:{inputValue}가 0과 10 사이에 있다.");
            }
            else
            {
                Console.WriteLine($"x:{inputValue}가 0과 10 사이에 없다.");
            }

            // 숙제.
            // 박스(0, 0) ~ (10, 10)에 점(x, y)가 포함되는지 확인하는 로직 작성해서 실행해보세요.
        }
    }
}
