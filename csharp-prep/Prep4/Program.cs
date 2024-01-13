using System;

class Program
{
    static void Main(string[] args)
    {
            List<int> numbers = new List<int>();

            int answer = -1;

            while(answer != 0)
            {
                Console.Write("Please enter a number (Press 0 to finish) ");
                string response = Console.ReadLine();
                answer = int.Parse(response);

                if (answer != 0)
                {
                    numbers.Add(answer);
                }
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);

            float average = (sum) / numbers.Count();
            Console.WriteLine(average);

            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }

        Console.WriteLine($"The max is: {max}");
    }
}