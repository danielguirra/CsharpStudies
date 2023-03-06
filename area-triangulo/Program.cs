using System;

namespace Program
{
   class AreaTriangulo
   {
      static void Main()
      {

         double xA, xB, xC;
         double yA, yB, yC;

         System.Console.WriteLine("Sistema para calcular a diferenca entre dois triangulos");

         Console.WriteLine("Digite os valor do triangulo x: ");
         xA = double.Parse(Console.ReadLine());
         xB = double.Parse(Console.ReadLine());
         xC = double.Parse(Console.ReadLine());

         Console.WriteLine("\nDigite os valor do triangulo y: ");
         yA = double.Parse(Console.ReadLine());
         yB = double.Parse(Console.ReadLine());
         yC = double.Parse(Console.ReadLine());

         double p = (xA + xB + xC) / 2.0;
         double areaX = Math.Sqrt(p * (p * xA) * (p * xB) * (p * xC));

         p = (yA + yB + yC) / 2.0;
         double areaY = Math.Sqrt(p * (p * yA) * (p * yB) * (p * yC));

         Console.WriteLine("Area do triangulo x é : " + areaX.ToString("F4"));
         Console.WriteLine("Area do triangulo y é : " + areaY.ToString("F4"));

         if (areaX > areaY)
         {
            Console.WriteLine("Maior area é a do triangulo X");
         }
         else if (areaY > areaX)
         {
            Console.WriteLine("Maior area é a do triangulo Y");
         }
         else if (areaX == areaY)
         {
            Console.WriteLine("A area dos triangulos são iguais");
         }

      }
   }
}