namespace primeNumbers
{
    class Program 
    {
        public static void Main (string[] args) 
        {
            
            Console.ReadKey();

        } 

        public void Prime (int num)
        {
                bool isPrime = true;

                for (int i = 2; i <= num; i++)  
                {
                    for (int j = 0; j <= num; j++)
                    {
                        if (i != j && i% j== 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.WriteLine("prime" + i);
                    }
                    isPrime = true;
                }
        }
    }
}
