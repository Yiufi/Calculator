using System;

namespace Calculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("O que deseja fazer?");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");

      Console.WriteLine("-----------------");
      Console.Write("Selecione um opção: ");
      short res = short.Parse(Console.ReadLine());
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
      Console.ReadKey();
    }

    static void Subtracao()
    {
      Console.Clear();

      Console.Write("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;
      Console.Write($"O resultado da Subtração é {resultado}");
      Console.ReadKey();
    }

    static void Divisao()
    {
      Console.Clear();

      Console.Write("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;
      Console.Write($"O resultado da Divisão é {resultado}");
      Console.ReadKey();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.Write("Primeiro valor: ");
      float v1 = float.Parse(Console.ReadLine());

      Console.Write("Segundo valor: ");
      float v2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = v1 - v2;
      Console.Write($"O resultado da Multiplicação é {resultado}");
      Console.ReadKey();
    }
  }
}