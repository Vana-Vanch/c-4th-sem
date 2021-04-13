using System;

namespace HelloWorld
{
    class Program
    {
        class IndexerClass
        {
            private string[] names = new string[10];
            public string this[int i]
            {
                get
                {
                    return names[i];
                }
                set
                {
                    names[i] = value;
                }
            }
        }
        static void Main(string[] args)
        {
            IndexerClass Team = new IndexerClass();
            Team[0] = "Siama";
            Team[1] = "Mawia";
            Team[2] = "Lala";
            Team[3] = "Rochana";
            Team[4] = "Thihnakutvawt";
            Team[5] = "Zaia";
            Team[6] = "Taitea";
            Team[7] = "Para";
            Team[8] = "Pari";
            Team[9] = "Dengziki";
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Team[i]);
            }
            Console.ReadKey();

        }
    }
}

