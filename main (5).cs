using System;

class Program {
  public static void Main (string[] args) {
    int nr = int.Parse(Console.ReadLine()); 
    for (int i = 2; i < nr; i++)
        if (nr % i == 0)
        {
            Console.WriteLine("Nie jest liczbą pierwszą");
            break;
        }
        else
        {
            Console.WriteLine("Jest liczbą pierwszą");
            break;
        }
        Console.ReadLine();
  }
}