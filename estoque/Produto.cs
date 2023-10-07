

namespace Program
{
   class Produto
   {
      public string Nome;
      public double Preco;
      public int Quantidade;

      public Produto(string nome, double preco, int quantidade)
      {
         Nome = nome;
         Preco = preco;
         Quantidade = quantidade;
      }
      public double ValorTotalEmEstoque()
      {
         return Preco * Quantidade;
      }

      public void AdicionarProdutos(int quantidadeToadd)
      {
         Quantidade += quantidadeToadd;
      }

      public void RemoverProdutos(int quantidadeRemove)
      {
         Quantidade -= quantidadeRemove;
      }

      public override string ToString()
      {
         return Nome +
               ", Valor : $" + Preco.ToString("f2", System.Globalization.CultureInfo.InvariantCulture) +
               ", "
               + Quantidade + " unidades" + ", valor total de : $" +
               ValorTotalEmEstoque().ToString("f2", System.Globalization.CultureInfo.InvariantCulture);
      }

   }
}
