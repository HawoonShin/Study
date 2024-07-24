namespace Study
{
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
        }
    }

    public static class Util
    {
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
    }
}
