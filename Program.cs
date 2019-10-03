using System;

namespace guess
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Random random = new Random();
      int randomNumber = random.Next(1, 101);
      bool won = false;
      while (!won)
      {
        Console.WriteLine("Guess a number between 1 - 100");
        string guess = Console.ReadLine();
        int num;
        if (Int32.TryParse(guess, out num))
        {
          if (num == randomNumber)
          {
            Console.Clear();
            Console.WriteLine("You Win!");
            won = true;
          }
          else if (num < randomNumber)
          {
            Console.Clear();
            Console.WriteLine("Nope too low, guess higher");
          }
          else
          {
            Console.Clear();
            Console.WriteLine("Nope too high, guess lower");
          }
        }

      }
      Console.WriteLine("Thank you for playing!");


    }
  }
}
