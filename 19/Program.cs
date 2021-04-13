using System;

namespace HelloWorld
{
    class Error
    {
        public int a = 10;
        public int b = 5;
        public int c = 5;
        public int x = 0;
        public void divide()
        {
            try
            {
                this.x = this.a / (this.b - this.c);
            }
            catch (Exception e)
            {

                Console.WriteLine("Error, Division by zero");
            }
            finally
            {
                Console.WriteLine("The try catch block has finished executing");
            }
        }
    }
    class program
    {
        static void Main(String[] args)
        {
            Error obj = new Error();
            obj.divide();
        }
    }
}

