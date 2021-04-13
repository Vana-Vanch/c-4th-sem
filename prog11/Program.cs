using System;

namespace prog11
{
    class Parent
    {
        public void show()
        {
            Console.WriteLine("This is a parent class");
        }
    }
    class new_child : Parent
    {
        new public void show()
        {
            Console.WriteLine("Can i override");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            new_child obj2 = new new_child();
            obj2.show();
            Parent obj1 = new Parent();
            obj1.show();

            Console.ReadLine();
        }
    }
}

