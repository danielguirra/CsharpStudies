using System;


namespace Course
{
   public class Produto
   {

      private string _nome { get; set; }
      private double _preco;

      private int _quantidade;



      public Produto(string nome, double preco, int quantidade)
      {
         _nome = nome;
         _preco = preco;
         _quantidade = quantidade;
      }


      public string GetNome()
      {
         return _nome;
      }

      public void SetNome(string nome)
      {
         _nome = nome;
      }

      public double GetPreco()
      {
         return _preco;
      }


      public int GetQuantidade()
      {
         return _quantidade;
      }



      public double ValorTotalEmEstoque()
      {
         return _preco * _quantidade;
      }

      public void AdicionarProdutos(int quantidade)
      {
         _quantidade += quantidade;
      }

      public void RemoverProdutos(int quantidade)
      {
         _quantidade += quantidade;
      }


      public override string ToString()
      {
         return _nome +
               ", Valor : $" + _preco.ToString("f2", System.Globalization.CultureInfo.InvariantCulture) +
               ", "
               + _quantidade + " unidades" + ", valor total de : $" +
               ValorTotalEmEstoque().ToString("f2", System.Globalization.CultureInfo.InvariantCulture);
      }
   }
}