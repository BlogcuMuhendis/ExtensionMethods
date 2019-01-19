using System;
 

namespace DateTimeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tarih = DateTime.Now;
            Console.WriteLine(tarih.DateWithTime());
  
            Console.ReadLine();
        }
    }
}
