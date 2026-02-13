namespace _41_Method_Hiding
{
    // Method hiding (메소드 숨기기)
    // 1. 부모 클래스의 메소드를 수정할 수 없을 때.
    // 2. 부모 메소드의 영향을 주지 않고 특정 메소드 다시 구현해야 하는 경우.


    // 사전식 정의: 자식의 멤버(변수, 메소드)와 부모의 멤버간의 서로 메소드를 가르는 것을 메소드 하이딩.

    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }

        public void MyMethod(string str)
        {
            Console.WriteLine($"Base.MyMethod{str}");
        }
    }

    class Derived : Base
    {
        public new void MyMethod() // 메소드 Hiding
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    class Derived2 : Base
    {

    }


    class Deriveds : Derived
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
            base.MyMethod();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Derived2 derivedObj2 = new Derived2(); //
            derivedObj2.MyMethod(); // 부모의 MyMethod 호출

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();

        }
    }
}
