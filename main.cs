using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number between 1 and 10,000 to check if it's a perfect number:");
        int userNumber;
        if (int.TryParse(Console.ReadLine(), out userNumber) && userNumber >= 1 && userNumber <= 10000)
        {
            if (IsPerfect(userNumber))
            {
                Console.WriteLine($"{userNumber} is a perfect number.");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not a perfect number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number between 1 and 10,000.");
        }
    }

    static bool IsPerfect(int number)
    {
        int sum = 0;
        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }
        return sum == number;
    }
}
