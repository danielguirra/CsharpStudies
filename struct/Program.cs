

namespace Program
{
   class Program
   {
      static void Main(string[] args)
      {
         Point p = new Point();

         Console.WriteLine(p.ToString());//x:0 y:0

         p.x = 10;
         Console.WriteLine(p.ToString());//x:10 y:0

         p.y = 11;
         Console.WriteLine(p.ToString());//x:10 y:11

      }
   }
}