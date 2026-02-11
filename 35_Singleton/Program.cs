namespace _35_Singleton
{
    // 정적 프로퍼티: 클래스 이름으로 접근 가능

    // 싱글턴 패턴
    // 프로그램을 통털어서 클래스 instance가 하나만 생성하도록 제한할 때 사용.
    public sealed class Singleton
    // sealed: 상속 금지
    {

        public static Singleton _instance = null; // 정적멤버필드

        // private 생성자로 외부에서 인스턴스 생성 방지
        private Singleton()
        {
            Console.WriteLine("Singleton instance created");
        }

        public static Singleton Instance // 정적 프로퍼티
        {
            get
            {                
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                
                return _instance;
            }
        }

        public void DoSomething()
        {
            Console.WriteLine("Singleton is Working...");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // singleton sg = new Singleton(); // 외부에서 생성 불가
            Singleton.Instance.DoSomething();
        }
    }
}
