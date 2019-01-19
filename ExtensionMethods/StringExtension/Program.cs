using StringExtension;
using System;

namespace StringExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            String metin = "Mert";
            String cumle = "extension methods";

           
            Console.WriteLine(cumle.ToUpperFirstCharacter());

            Console.ReadKey();
        }
    }
}
