using System;

namespace prog11
{
    class Property
    {
        readonly string name = "Lawma";
        private string name2 = string.Empty;

        public string setname2
        {
            set { name2 = value; }
        }
        public string getname()
        {
            return name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Property stud = new Property();
            stud.setname2 = "Lawmzuala";
            Console.WriteLine(stud.getname());
            Console.ReadLine();

        }
    }
}


