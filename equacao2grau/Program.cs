using System;


namespace Program
{
   public class Program
   {
      static void Main()
      {
         Console.WriteLine("Calcula Equação do 2Grau");

         System.Console.WriteLine("Determine o valor de A:");
         int a = Int16.Parse(System.Console.ReadLine());

         System.Console.WriteLine("Determine o valor de B:");
         int b = Int16.Parse(System.Console.ReadLine());

         System.Console.WriteLine("Determine o valor de C:");
         int c = Int16.Parse(System.Console.ReadLine());

         double delta = Math.Pow(b, 2) - 4 * a * c;

         double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
         double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

         System.Console.WriteLine("x1: " + x1);
         System.Console.WriteLine("x2: " + x2);

      }
   }
}