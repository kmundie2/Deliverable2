using System;

namespace Deliverable2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}. Do you want to do the COIN FLIP CHALLENGE? Yes/No");
            string answer = Console.ReadLine();

            if (answer == "Yes")
            {
                Random random = new Random();
                int score = 0;

                for (int i = 1; i <= 10; i++)
                {
                    int coin = random.Next(0, 2);
                    Console.WriteLine($"Round {i}: Heads or Tails?");
                    string guess = Console.ReadLine();
                    if ((guess == "Heads" && coin == 0) || (guess == "Tails" && coin == 1))
                    {
                        score++;
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                    }
                }
                Console.WriteLine($"Thank You {name}. You got a score of {score}!");
            }
            else
            {
                Console.WriteLine("You are a coward " + name);
            }
        }
    }
}
