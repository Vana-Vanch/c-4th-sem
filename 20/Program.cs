using System;

namespace HelloWorld
{
    class Test
    {
        public delegate int NewDelegate(int x, int y);

        static void Display(NewDelegate d)
        {
            Console.WriteLine(d(10, 20));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }

        static void Main(string[] args)
        {
            NewDelegate d1 = new NewDelegate(Add);
            Display(d1);
            Console.ReadKey();
        }

    }
}























