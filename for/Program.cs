using System.Globalization;

namespace For
{
   public class Program
   {
      static void Main()
      {
         Console.Write("Quantos numero inteiros voce vai digitar ? :");
         int valueForLoop = int.Parse(Console.ReadLine());
         int soma = 0;

         for (int i = 0; i < valueForLoop; i++)
         {
            Console.Write($"Digite o {i + 1}:");
            int valueToSome = int.Parse(Console.ReadLine());
            soma = soma + valueToSome;
         }
         Console.WriteLine("SOMA: " + soma);
      }
   }
}