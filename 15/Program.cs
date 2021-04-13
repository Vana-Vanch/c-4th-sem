using System;

namespace HelloWorld
{
    class Program
    {
        static int A;
        int B;
        static Program()
        {
            Console.WriteLine("Static Constructor Executed");
            A = 10;
        }
        public Program(int b)
        {
            Console.WriteLine("Instance Constructor Executed");
            B = b;
        }
        private void Display()
        {
            Console.WriteLine("A = " + A);
            Console.WriteLine("B = " + B);
        }
        static void Main(string[] args)
        {
            Program P1 = new Program(20);
            Program P2 = new Program(30);
            P1.Display();
            P2.Display();
            Console.ReadKey();
        }
    }
}

