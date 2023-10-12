using System;

class Program 
{
    public static void Main(string[] args) 
    {
        Console.WriteLine("Enter a number between 1 and 10,000 to check if it's a perfect number:");

        if (int.TryParse(Console.ReadLine(), out int inputNumber) && inputNumber >= 1 && inputNumber <= 10000)
        {
            if (IsPerfect(inputNumber))
            {
                Console.WriteLine($"{inputNumber} is a Perfect Number.");
            }
            else
            {
                Console.WriteLine($"{inputNumber} is NOT a Perfect Number.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 1 and 10,000.");
        }
    }

    public static bool IsPerfect(int number)
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
