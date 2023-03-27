using System;

class Program {
  public static void Main (string[] args) 
    {
      int nr = int.Parse(Console.ReadLine());

      Console.Write(nr + ": ");

      for (int i = 2; i <= nr; i++)
      {
        while (nr % i == 0)
        {
          Console.Write(i + " ");
          nr /= i;
        }
    }
  }
}