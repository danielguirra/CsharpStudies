

namespace Program
{
   class Produto
   {
      public string nome;
      public double preco;
      public int quantidade;

      public double ValorTotalEmEstoque()
      {
         return preco * quantidade;
      }

      public void AdicionarProdutos(int quantidadeToadd)
      {
         quantidade += quantidadeToadd;
      }

      public void RemoverProdutos(int quantidadeRemove)
      {
         quantidade -= quantidadeRemove;
      }

      public override string ToString()
      {
         return nome +
               ", Valor : $" + preco.ToString("f2", System.Globalization.CultureInfo.InvariantCulture) +
               ", "
               + quantidade + " unidades" + ", valor total de : $" +
               ValorTotalEmEstoque().ToString("f2", System.Globalization.CultureInfo.InvariantCulture);
      }

   }
}
