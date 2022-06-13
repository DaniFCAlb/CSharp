using System;

namespace SomarAteAoLimite
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            int[] array = {1, 2, 3, 4, 5};
            int sum = 0;

            foreach (int num in array)
            {
                sum += num;

            }
            Console.WriteLine(sum);
        }
        
    }
    
}