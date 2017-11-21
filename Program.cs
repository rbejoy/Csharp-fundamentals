using System;

namespace fundamentals_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Loop that prints 1-255
            for (int num = 1; num < 256; num++)
            {
                Console.WriteLine(num);
            }

            //Print all values 1-100 divisable by 3 or 5 but not both
            for (int num = 1; num < 101; num++)
            {
                if(!(num % 15 == 0))
                {
                    if(num % 3 == 0 || num % 5 == 0)
                    {
                        Console.WriteLine(num);
                    }
                }
                
            }

            //FizzBuzz Modification
            for (int num = 1; num < 101; num++)
            {
                if(num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (num % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (num % 5 == 0)
                {
                   Console.WriteLine("Buzz");
                }
            }

        }
    }
}
