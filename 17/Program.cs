using System;

namespace HelloWorld
{
    public abstract class Abs
    {
        public abstract void show();

    }
    public class the1 : Abs
    {

        public override void show()
        {
            Console.WriteLine("class the1");
        }
    }
    public class the2 : Abs
    {
        public override void show()
        {
            Console.WriteLine("class the2");
        }
    }
    public class main_method
    {
        public static void Main()
        {
            Abs g;
            g = new the1();
            g.show();
            g = new the2();
            g.show();

        }
    }
}























