namespace Study
{
    public struct Point(int a,int b)
    {
        public int x;
        public int y;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Util.Swap(ref a, ref b);

            Console.WriteLine($"a={a}, b={b}");
            
            float c = 2.5f;
            float d = 3.1f;
            Util.Swap(ref c, ref d);

            Console.WriteLine($"a={a}, b={b}");

            Point point1 = new Point(10,20);
            Point point2 = new Point(30,10);
            Util.Swap<Point>(ref point1, ref point2);
        }
    }

    public static class Util
    {
        // <T> : 일반화
        // 일반화로 사용하면 자료형의 일반화가 이루어 진다.

        //<일반화>
        // 일반화는 자료형의 형식을 지정하지 않고 함수를 정의
        // 기능을 구현한 뒤 사용 당시에 자료형의 형식을 지정해서 사용
        public static void Swap<T>(ref T left, ref T right)
        {
            T temp = left;
            left = right;
            right = temp;

        }

        //오버로딩 : 같은 이름의 함수를 다른 인자값(매개변수)를 통해 구현하는 경우 
        //          사용 당시에 집어넣는 자료형으로 함수를 구분할 수 있기 때문에 
        //          같은 이름의 함수를 사용하는 것을 허락하는 기술
        public static void Swap(ref int left, ref int right )
        {
            int temp = left;
            left = right;
            right = temp;
        }

        public static void Swap(ref float left, ref float right)
        {
            float temp = left;
            left = right;
            right = temp;
        }

        public static void Swap(ref Point left, ref Point right)
        {
            Point temp = left;
            left = right;
            right = temp;
        }
    }
}
