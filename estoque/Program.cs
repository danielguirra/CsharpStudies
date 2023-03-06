namespace Program
{
   class Program
   {
      static void Main()
      {
         Produto p = new Produto();

         Console.WriteLine("Deseje Criar um Produto? s/n");
         string newProduct = Console.ReadLine();
         if (newProduct == "s" || newProduct == "sim")
         {

            Console.Write("Nome :");
            p.nome = Console.ReadLine();

            Console.Write("Preço :");
            p.preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade :");
            p.quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine(p);
         }

         Console.WriteLine("Deseja adicionar produtos ? s/n");
         string addProducts = Console.ReadLine();
         if (addProducts == "s" || addProducts == "sim")
         {
            Console.Write("Quantidade a ser adicionada : ");
            int productsToAdd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(productsToAdd);
            Console.WriteLine("Foi Adicionado o total de " + productsToAdd);
            Console.WriteLine(p);
         }

         Console.WriteLine("Deseja remover produtos ? s/n");
         string removeProducts = Console.ReadLine();
         if (removeProducts == "s" || removeProducts == "sim")
         {
            Console.Write("Quantidade a ser Removida : ");
            int productsToRemove = int.Parse(Console.ReadLine());
            p.RemoverProdutos(productsToRemove);
            Console.WriteLine("Foi removido o total de " + productsToRemove);
            Console.WriteLine(p);
         }

         Console.WriteLine("Deseja finalizar ? s/n");
         string exitToProgram = Console.ReadLine();
         if (exitToProgram == "n" || exitToProgram == "nao")
         {
            Main();
         }
         else
         {
            return;
         }


      }
   }

}