namespace _48_Clone
{
    /// <summary>
    /// 얕은 Copy
    /// </summary>
    class Top
    {
        public int a = 100;
        public int b = 200;

        public Top Copy()
        {
            return (Top)this.MemberwiseClone();
        }
    }

    class Child
    {
        public int age = 10;
        public int height = 20;
        public Top grand = new Top();

        public Child DeepCopy()
        {
            Child child = Copy();
            child.grand = this.grand.Copy();


            return child;
        }

        public Child Copy()
        {
            // MemberwiseClone(얕은 복사) : 객체를 복사할때 사용.
            return (Child)this.MemberwiseClone();  // 얕은 copy 객체 clone
        }
    }


    class Program
    {
        static void Main(string[] args)
        {


        }
    }
}
