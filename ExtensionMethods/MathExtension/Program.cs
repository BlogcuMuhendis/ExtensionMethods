using System;
 

namespace MathExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var number = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Cube: {0} - Square {1} - Factorial {2}", number.ToCube(),number.ToSquare(),number.ToFactorial());
            Console.WriteLine("-----------------------------------------");

            Console.Write("Multiply With: ");
            double multiplyBy = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Result is {0}", number.MultiplyBy(multiplyBy));
            Console.WriteLine("-----------------------------------------");


            double[] numberList = { 5.2, 7.0, 6.1 };

            double result = 1;

            foreach (var item in numberList)
            {
                result = result.MultiplyBy(item);
            }

            Console.WriteLine("numberList result is {0}", result);    

            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("{0}", number.IsPositive());
            Console.WriteLine("{0}", number.IsNegative());
            Console.ReadKey();
        }
    }
}
