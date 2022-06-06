using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Soma();
    }

    static void Soma()
    {
      Console.Clear();

      Console.Write("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 + v2;
      Console.Write($"O resultado da Soma é {resultado}");
    }
  }
}