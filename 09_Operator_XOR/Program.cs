namespace _202602041556_Xor_Operator
{
   internal class Program
   {
      static void Main(string[] args)
      {
            // xor (exclusive Or, 배타적 Or)
            // 1010
            // 1001
            // 0011

            int a = 2;   // 00000010
            int b = 3;  // 00000011
            int c = 0;

            c = a ^ b;
            //     a: 00000010
            //     b: 00000011
            // a ^ b: 00000001

            b = c ^ a;
            //     a: 00000010
            //     c: 00000001
            // a ^ c: 00000011

            a = c ^ b;
            //      b: 00000011
            //      c: 00000001
            //  c ^ b: 00000010

            // 문제
            // xor연산자와 대입연산자만 이용해서 a변수의 값과 b변수의 값을
            // 바꿔보세요..(다른 변수는 사용하지 마세요)
            a = 2;
            b = 3;


      }
   }
}

