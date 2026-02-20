namespace _56_Composition_Exer
{
    class Point
    {
        private int _x, _y;

        public int X
        {
            get => _x;
        }

        public int Y
        {
            get => _y;
        }

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public Point(Point pt) // 복사 생성자
        {
            _x = pt._x;
            _y = pt._y;
        }

        public void Info()
        {
            Console.WriteLine($"x: {_x}, y: {_y}");
        }
    }

    class Line
    {
        private readonly Point _pt1, _pt2;

        public Line(int pt1x, int pt1y, int pt2x, int pt2y)
        {
            _pt1 = new Point(pt1x, pt1y);
            _pt2 = new Point(pt2x, pt2y);
        }

        public Line(Point pt1, Point pt2)
        {
            _pt1 = new Point(pt1);
            _pt2 = new Point(pt2);
        }

        public float GetLength()
        {
            int xBase = _pt2.X - _pt1.X;
            int yBase = _pt2.Y - _pt1.Y;

            return (float)Math.Sqrt(Math.Pow(xBase, 2) + Math.Pow(yBase, 2));
        }
    }

    // 삼각형 클래스(직각삼각형)
    // 사각형 클래스 (직각사각형)
    // 원클래스

    // 각각의 도형 클래스만들고 면적을 구하는 메소드를 추가한 후에
    // 각각의 도형객체만들고 면적을 출력해세요

    class Triangle
    {
        private Point _dot1;
        private Point _dot2;
        private Point _dot3;

        public Triangle(Point dot1, Point dot2, Point dot3)
        {
            _dot1 = dot1;
            _dot2 = dot2;
            _dot3 = dot3;
        }

        public float GetArea()
        {
            Line baseLine = new Line(_dot1, _dot2);
            Line height = new Line(_dot2, _dot3);
            return (baseLine.GetLength() * height.GetLength()) / 2;
        }
    }

    class Rectangle
    {
        private Point _dot1;
        private Point _dot2;
        private Point _dot3;
        private Point _dot4;

        public Rectangle(Point dot1, Point dot2, Point dot3, Point dot4)
        {
            _dot1 = dot1;
            _dot2 = dot2;
            _dot3 = dot3;
            _dot4 = dot4;
        }

        public float GetArea()
        {
            float baseline = new Line(_dot1, _dot2);
            float height = new Line(_dot2, _dot3);

            return baseLine.GetLength() * height.GetLength();
        }
    }

    class Cycle
    {
        private Line _Radius;

        public Cycle(Line radius)
        {
            _Radius = radius;
        }

        public float GetArea()
        {
            return (float)(2 * Math.PI * _Radius.GetLength());
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Line baseLine = new Line(new Point(0, 0), new Point(5, 0));
            Line height = new Line(new Point(5, 0), new Point(5, 10));

            Triangle triangle = new Triangle(baseLine, height);
            Console.WriteLine($"직각삼각형 면적: {triangle.GetArea()}");

            Rectangle rectangle = new Rectangle(baseLine, height);
            Console.WriteLine($"직각사각형 면적: {rectangle.GetArea()}");

            Line radius = new Line(new Point(0, 0), new Point(0, 5));
            Cycle cycle = new Cycle(radius);
            Console.WriteLine($"원 면적: {cycle.GetArea()}");
        }
    }
}
