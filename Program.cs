using System;


namespace Curse
{
   public class Program
   {

      static void Main()
      {
         System.Console.WriteLine("Calcular valor maior de tres valores");
         System.Console.WriteLine("Digite os tres valores");


         int x = int.Parse(Console.ReadLine());
         int y = int.Parse(Console.ReadLine());
         int z = int.Parse(Console.ReadLine());

         int result = CalcularMaior(x, y, z);

         System.Console.WriteLine("O maior valor é : " + result);

      }

      static int CalcularMaior(int a, int b, int c)
      {
         if (a > b && a > c)
         {
            return a;
         }
         else if (b > c)
         {
            return b;
         }
         else
         {
            return c;
         }
      }


   }
}