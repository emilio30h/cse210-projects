using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        int UserInput = -1;

        List<int> numbers = new List<int>();

        while (UserInput != 0)
        {
            Console.WriteLine("Enter a list of numbers, type 0 when finished: ");
            UserInput = int.Parse(Console.ReadLine());

            if (UserInput != 0)
            {
                numbers.Add(UserInput);
            }
        }


        //Calculating the sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}. ");

        // Calculating the average of the numbers
        float average = (float)sum / (numbers.Count);
        Console.WriteLine($"The average is: {average}. ");

        // Finding the maximum number
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max =  number;
            }
        }

        Console.WriteLine($"The maximum is {max}");
    }
}