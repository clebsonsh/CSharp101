using System;

namespace Loops
{
  class Program
  {
    static void Main(string[] args)
    {
      int counter = 0;
      while (counter < 10)
      {
        Console.WriteLine($"While loop - The counter is { counter }");
        counter++;
      }

      Console.WriteLine("\n----------------------------------------------\n");

      do
      {
        Console.WriteLine($"Do while loop - The counter is { counter }");
        counter++;
      } while (counter < 10);

      Console.WriteLine("\n----------------------------------------------\n");

      for (int index = 0; index < 10; index++)
      {
        Console.WriteLine($"For loop - The index is { index }");
      }
    }
  }
}
