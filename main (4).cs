using System;

class Program {
  public static void Main (string[] args)
  {
    int number = int.Parse(Console.ReadLine()); 
    for (int i = 2; i < number; i++)
        if (number % i == 0)
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