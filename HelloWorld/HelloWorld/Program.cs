using System;
// 'using' is importing libraries that you need

namespace HelloWorld
// 'namespace' is used to group and organize code
{
  class Program
  {
    static void Main(string[] args)
    // 'Main' is the first method that run in our program
    // 'static' means this method will not change dynamically while our program is running
    // 'void' means this method return nothing
    // 'string[]' means this method can get an array of arguments
    // 'args' is the name of this array of arguments inside our method
    {
      Console.WriteLine("Hello World!");
      // This line call prints 'Hello World' ins our console
    }
  }
}
