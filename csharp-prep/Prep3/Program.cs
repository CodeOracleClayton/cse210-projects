using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 11);

        int guess = -1;

        while ( guess != magicNumber)
        {
            Console.Write("What is your number? ");
            string answer = Console.ReadLine();
            guess = int.Parse(answer);

            if ( magicNumber > guess)
            {
                Console.WriteLine("Higher!");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower!");
            }

            else
            {
                Console.WriteLine("You have guessed it correctly!");
            }
        }
    }
}