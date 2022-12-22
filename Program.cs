using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the Starting number: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the End number: ");
                int num2 = int.Parse(Console.ReadLine());

                bool isPrime = true;
                Console.WriteLine("Prime Numbers : ");
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = 2; j <= i; j++)
                    {

                        if (i != j && i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }

                    }
                    if (isPrime && i > 1)
                    {
                        Console.Write("\t" + i +"\n");
                    }
                    isPrime = true;
                }
                Console.WriteLine("--------------");

        }
    }
}
