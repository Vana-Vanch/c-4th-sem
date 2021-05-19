using System;

namespace program_nambar1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = new int[10];
            for(int i=0;i<arr.Length;i++){
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Solution obj = new Solution();
            obj.run(arr);
            Console.Read();
        }
    }
    class Solution{
        public void run(int[] arr){
        string even = " ";
        string odd =" ";
        for(int i=0;i<arr.Length;i++){
        if(arr[i]%2==0){
        even += " "+arr[i];

    }else{
    odd += " "+arr[i];
}
        }
    Console.WriteLine("Even:"+even);
    Console.WriteLine("Odd:"+odd);
    
        }
    }
}
