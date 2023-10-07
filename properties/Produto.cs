


class Produto
{

   private string _name;
   private double _preco;
   private int _quantidade;

   public Produto(string name, double preco, int quantidade)
   {
      _name = name;
      _preco = preco;
      _quantidade = quantidade;
   }

   public string Nome
   {
      get { return _name; }
      set
      {

         if (value != null && value.Length > 1)
         {
            _name = value;
         }
      }
   }


   public double Preco
   {
      get { return _preco; }
   }

   public double Quantidade
   {
      get { return _quantidade; }
   }
}


