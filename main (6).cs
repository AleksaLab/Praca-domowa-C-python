using System;

class Program {
  public static void Main (string[] args) 
    {
      int number = int.Parse(Console.ReadLine());

      Console.Write(number + ": ");

      for (int i = 2; i <= number; i++)
      {
        while (number % i == 0)
        {
          Console.Write(i + " ");
          number /= i;
        }
    }
  }
}