using System;

namespace BranchesAndLoops
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Numbers between 1 and 20 evenly divisible by 3");

      int sum = 0;
      for (int i = 1; i <= 20; i++)
      {
        if (i % 3 == 0)
        {
          sum += i;
        }
      }

      Console.WriteLine($"The sum is { sum }");
    }
  }
}
