using System;

namespace HelloWorld
{
    class program1
    {
        public void even_odd(int[] arr)
        {
            string even = " ";
            string odd = " ";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    even += " " + arr[i];
                }
                else
                {
                    odd += " " + arr[i];
                }
            }
            Console.WriteLine("Even:" + even);
            Console.WriteLine("Odd:" + odd);
        }
    }
    class themain
    {
        static void Main()
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                int ele = Convert.ToInt32(Console.ReadLine());
                arr[i] = ele;
            }
            program1 obj = new program1();
            obj.even_odd(arr);
        }
    }
}

