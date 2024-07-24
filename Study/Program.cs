namespace Study
{
    internal class Program
    {
        //일반적으로 인터페이스의 이름은 I로 시작함
        public interface IEnteralbe
        {
            //인터페이스는 구현 안하는 것이 원칙
            public void Enter();
        }

        public interface IOpenable
        {
            public void Opne();
        }

        public class Duengeon : IEnteralbe
        {
            public void Enter()
            {
                Console.WriteLine("던전에 입장합니다.");
            }
        }

        // ??여기 왜 오류뜸???
        /*
        public class Chest : IOpenable 
        {
            public void Open()
            {
                Console.WriteLine("상자를 엽니다.");
            }
        }*/
        

        public class Door : IEnteralbe, IOpenable
        {
            public void Enter()
            {

                Console.WriteLine("던전에 입장합니다.");
                    }
            public void Opne()
            {
                Console.WriteLine("문을 엽니다.");
            }
        }

        /*
         * 여기서 부터 놓침...ㄷㄷ
        public class Enterance
        {
            public void Enter();
        }

        public class Player
        {
            public void Enter(Entrance entrens
                {
                entrans
            })
        }*/

        static void Main(string[] args)
        {
            
        }
    }

    
}
