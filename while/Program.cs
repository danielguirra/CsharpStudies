using System.Globalization;
using System;

namespace While
{
   public class Program
   {
      static void Main()
      {
         Console.WriteLine("Calcula raiz quadrada");
         Console.Write("Digite um numero :");

         double x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

         while (x > 0)
         {

            double z = Math.Sqrt(x);
            System.Console.WriteLine($"Raiz do numero é :{z:F3}");
            Console.Write("Digite um novo numero :");
            x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
         }

         System.Console.WriteLine("O valor a ser calculado não pode ser negativo");
      }
   }
}