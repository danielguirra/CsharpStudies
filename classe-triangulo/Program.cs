

namespace Program
{
   class AreaTriangulo
   {
      static void Main()
      {

         Triangulo x;
         Triangulo y;

         x = new Triangulo();
         y = new Triangulo();

         System.Console.WriteLine("Sistema para calcular a diferenca entre dois triangulos");

         Console.WriteLine("Digite os valor do triangulo x: ");
         x.A = double.Parse(Console.ReadLine());
         x.B = double.Parse(Console.ReadLine());
         x.C = double.Parse(Console.ReadLine());

         Console.WriteLine("\nDigite os valor do triangulo y: ");
         y.A = double.Parse(Console.ReadLine());
         y.B = double.Parse(Console.ReadLine());
         y.C = double.Parse(Console.ReadLine());

         double areaX = x.Area();

         double areaY = y.Area();

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