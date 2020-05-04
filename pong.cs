using System;

class Pong
{
  static void Main()
  {
    Console.WriteLine("Choose a #");
    string numberInput = Console.ReadLine();
    int number = Int32.Parse(numberInput);

    for (int index = 0; index <= number; index++)
    {
      if (index == 0)
      {
        Console.WriteLine(index);
      }
      else if (index % 3 == 0 && index % 5 == 0 )
      {
        Console.WriteLine("ping-pong");
      } 
      else if (index % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}