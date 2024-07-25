//최상위문 오데로 갓낭..ㅠㅠ
using System;

namespace _240725
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Customer customer = new Customer();
            Restaurant restaurant = new Restaurant();

            customer.Enter(restaurant);
            */

            MyDel delegate1 = Plus;
            Console.Writeline("<Plus>)");
            Console.WriteLine($"10+20 = {Plus(10,20)}");
            Console.WriteLine($"10+20 = {delegate1(10,20)}");

            delegate1 = Minus;
            Console.Writeline("<Minus>)");
            Console.WriteLine($"10+20 = {Minus(10,20)}");
            Console.WriteLine($"10+20 = {delegate1(10,20)}");

            StrDel delegate2 = Message;
            Message("안녕하세요");
            delegate2("아녕하세요");
            

        }

        // 델리게이트 반환형 델리게이트이름(매개변수);
        public delegate float MyDel(float left, float right);
        //변수형에 따라 사용가능한게 다르다?
        public delegate string StrDel(string str);

        public static float Plus(float left, float right) {return left + right;}
        public static float Minus(float left, float right) {return left - right;}

        public static void Message(string text) {Console.WriteLine(text);}


        //일반화 델리게이트
        //어차피 델리게이트 많이 쓸건데 c#에서 미리 만들어 놓은 델리게이트
        public static void GenericDel()
        {
            Func<float, double, int> func1 = Function;

            Action<int, float> action1 = action1;
        }

        public static int Function(float a, double b) { return 0; }
        public static void Action1(int a, float b) { }

        /*
        public class Customer
        {
            public void Enter(Restaurant restaurant)
            {

            }
        }

        public class Restaurant
        {
            private int curCustomer;
            private int maxCustomer;

            public bool IsAcceptable()
            {
                return curCustomer < maxCustomer;
            }

            public void Enter()
            {
                if (IsAcceptable())
                {
                }
        }
        }*/
    }
}
