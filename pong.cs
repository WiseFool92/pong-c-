using System;

class Pong
{
  static void Main()
  {
    Console.WriteLine("Choose a #");
    string numberInput = Console.ReadLine();
    int number = int.Parse(numberInput);

    for (int index = 0; index < number; index++)
    {
      if (index % 3 == 0 && index % 5 == 0 )
      {
        Console.WriteLine("ping-pong");
      }
    }
  }
}