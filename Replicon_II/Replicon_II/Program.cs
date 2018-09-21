using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Replicon_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            Console.WriteLine("Factorial Finding using traditional iteration method");
            
            Console.WriteLine("Please enter the number");
            number = Convert.ToInt32(Console.ReadLine());
            FactorialIteration(number);
            Console.WriteLine("factorial found using recursion"+FactRecursion(number));
            Console.ReadLine();
            Console.Clear();
           
        }

          public static void  FactorialIteration(int number)
                 {
                    // Declaring variable to handle user input and factorial storing variable
                   
                    long  fact=1;
                  
                    for (int i = number; i > 0; i--)
                    {
                        fact = fact * i;
                    }
                    Console.WriteLine("factorial found using iteration method:" + fact);
                
                }

           public static long FactRecursion(int n)
                   {
                    if (n > 1)
                       {
                       return n * FactRecursion(n - 1);
                        }
                        else
                            return 1;
                    }
    }
}
