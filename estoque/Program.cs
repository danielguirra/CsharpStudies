using System;
using Microsoft.Extensions.Configuration;

class A
{
   static void Main()
   {
      IConfiguration config = new ConfigurationBuilder()
          .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
          .Build();

      string myVariable = config["user"];

      Console.WriteLine(config);

      Console.ReadLine();
   }
}
