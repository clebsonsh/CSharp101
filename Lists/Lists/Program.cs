using System;
using System.Collections.Generic;

namespace Lists
{
  class Program
  {
    static void Main(string[] args)
    {
      var names = new List<string> { "Clebson", "Ana", "Felipe" };
      names.Add("Maria");
      names.Add("Bill");
      names.Remove("Ana");
      foreach (string name in names)
      {
        Console.WriteLine($"Hello { name.ToUpper() }");
      }
    }
  }
}
