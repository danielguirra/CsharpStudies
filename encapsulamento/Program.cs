
namespace Course
{
   class Program
   {
      static void Main(string[] args)
      {
         Produto p = new Produto("tv", 500.00, 10);

         p.SetNome("Teste nome");
         Console.WriteLine(p.GetNome());

      }


   }
}