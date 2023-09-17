using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        

        int user = -1;
        while (user != 0)
        {
            Console.Write("Enter a number (0 to quit) if you finish: ");
            
            string userResponse = Console.ReadLine();
            user = int.Parse(userResponse);
            

            if (user != 0)
            {
                numbers.Add(user);
            }
        }


        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

 
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

        int minPositive = int.MaxValue;

        foreach (int num in numbers)
        {
        if (num > 0 && num < minPositive)
        {
            minPositive = num;
        }
}

Console.WriteLine("The smallest positive number is: " + minPositive);
    }
}