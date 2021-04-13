using System;

namespace HelloWorld
{
    class jagged_arrays
    {
        public void jagged_arr()
        {
            int[][] j_arr = {
                new int[] {1,2,3},
                new int[] {4,5,6,7,8},
                new int[] {9,10,11}
            };
            for (int i = 0; i < j_arr.Length; i++)
            {
                for (int j = 0; j < j_arr[i].Length; j++)
                {
                    Console.Write(j_arr[i][j] + ",");
                }
                Console.WriteLine();
            }
        }
    }
    class two_dimentional_arr
    {
        public void two_dim()
        {
            int[,] two_arr = new int[3, 4] {
                {1,2,3,4},
                {5,6,7,8},
                {9,10,11,12}
            };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(two_arr[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            jagged_arrays obj = new jagged_arrays();
            Console.WriteLine("Jagged arrays:");
            obj.jagged_arr();
            Console.WriteLine("Two dimentional arrays");
            two_dimentional_arr obj2 = new two_dimentional_arr();
            obj2.two_dim();

        }
    }
}

