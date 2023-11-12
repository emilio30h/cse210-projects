using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string magic = Console.ReadLine();
        int magic0 = int.Parse(magic);*/

        Random randomGenerator = new Random();
        int magic0 = randomGenerator.Next(1, 101);


        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guess0 = int.Parse(guess);
        

        while (guess0 != magic0)
        {
            if (guess0 < magic0)
            {
                Console.Write("Higher. ");
            }

            else if (guess0 > magic0)
            {
                Console.Write("Lower. ");
            }

            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            guess0 = int.Parse(guess);
        }

        Console.Write("You guessed it! ");
        
    }
}