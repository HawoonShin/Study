namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Monster> monsterDic = new Dictionary<string, Monster>();

            //삽입
            monsterDic.Add("피카츄", new Monster("피카츄", MonsterType.Electric, 80));
            monsterDic.Add("파이리", new Monster("파이리", MonsterType.Electric, 80));
            monsterDic.Add("꼬북이", new Monster("꼬북이", MonsterType.Electric, 80));
            monsterDic.Add("이상해씨", new Monster("이상해씨", MonsterType.Electric, 80));

            //삭제
            monsterDic.Remove("이상해씨");

            //탐색
            //Monster find = monsterDic["피카츄"];
            //Console.WriteLine($"{find.name},{find.type},{find.hp}");

            if (monsterDic.ContainsKey("이상해씨"))     //포함 확인
            { 
                //여기 왜 나는 오류나지??? -> 위쪽에서 사용하니깐 오류난다.
                Monster find = monsterDic["이상해씨"];  //O(1)
                Console.WriteLine($"{find.name},{find.type},{find.hp}");

            }

            // Monster monster = monsterDic["피카츄"];
            // 여기 사실 틀렸어요! 순식간에 지나가서 잘 모르겠네...
            // monsterDic["피카츄"] = hp.100;
        }
    }

    public enum MonsterType { Fire, Water, Grass, Electric }

    public class Monster
    {
        public string name;
        public MonsterType type;
        public int hp;

        public Monster(string name, MonsterType type, int hp)
        {
            this.name = name;
            this.type = type;
            this.hp = hp;
        }
    }
}
