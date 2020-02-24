using System;

class PingPong 
{
  static void Main()
  {
    Console.WriteLine("Gimme yo digit(s)");
    string userInput = Console.ReadLine();
    int userNumber = int.Parse(userInput);
    // bool divisi5 = userNumber % 5 == 0
    for (int i = 1; i <= userNumber; i++)
    {
      if(i % 5 == 0 && i % 3 == 0)
      {
        Console.WriteLine("pong-ping");
      }
      else if (i % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else if (i % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else 
      {
        Console.WriteLine(i);
      }
    }
  }
}