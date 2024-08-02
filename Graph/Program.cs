namespace Graph
{
    internal class Program
    {
        //단방향 연결 그래프
        static bool[,] graph1 =
            {
                { true,true,false,false},
                {false,true,true,false },
                { true, false, true, false},
                {false,true,true, false },
            };

        //양방향 가중치 그래프(단절은 높은값으로 표현)
        const int INF = 99999;  //끊어져있다는 것을 표현하기 위해 가중치를 크게 잡음
        static int[,] graph2 =
        {
            {0,4,INF, INF },
            {4,0,8,3 },
            {INF,8,0,3},
            {INF,3,3,0},
        };
        static void Main(string[] args)
        {

            // bool connect = graph1[2, 1];
            // int distance = graph2[0, 1];
            //여기서 오류나면 static 붙였나 잘 확인

            List<int>[] graph = new List<int>[4];
            for (int i  = 0;i<graph.Length;i++)
            {
                graph[i] = new List<int>(); 
                //이부분이 정확히 뭐를 행동하는지 잘 모르겠다..
                // 그래프에 리스트의 숫자(4)만큼 추가한다?
            }

            // 연결 추가
            graph[0].Add(1); // = graph2[0,1] = true;
            graph[0].Add(3);    //0에 3을 연결한다.
            graph[2].Add(2);
            graph[3].Add(0);

            // 연결 제거
            graph[0].Remove(1); // = graph2[0,1] = false;

            // 연결 확인
            graph[0].Contains(1); //bool connect = graph2[0,1];
        }
    }

    public abstract class Graph
    {
       public abstract void Connect(int from, int to);
        public abstract void DisConnect(int from, int to);
        public abstract bool IsConnect(int from, int to);
    }

    //행렬 그래프
    public class MatrixGraph : Graph
    {
        private bool[,] graph;

        public MatrixGraph(int vertex)
        {
            graph = new bool[vertex, vertex];
        }

        public override void Connect(int from, int to )
        {
            graph[from, to] = true; 
        }

        public override void DisConnect(int from, int to)
        {
            graph[from, to] = false;
        }

        public override bool IsConnect(int from, int to)
        {
            return graph[from, to];
        }
    }

    //리스트 그래프
    public class ListGraph : Graph
    {
        private List<int>[] graph;

        public ListGraph(int vertex)
        {
            graph = new List<int>[vertex];
            for (int i = 0; i<vertex; i++)
            {
                graph[i] = new List<int>();
            }
        }

        public override void Connect(int from, int to)
        {
            graph[from].Add(to);
        }

        public override void DisConnect(int form, int to)
        {
            graph[form].Remove(to);
        }

        public override bool IsConnect(int form, int to)    
        {
            return graph[form].Contains(to);
        }

    }

}
