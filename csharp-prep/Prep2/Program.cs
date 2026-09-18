using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade?");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A");
        }

        else if (grade >= 80)

        {
            Console.WriteLine("Your grade is a B");
        }
        else if (grade >= 70)

        {
            Console.WriteLine("Your grade is a C");
        }

        else if (grade >= 60)
        {
            Console.WriteLine("Your grade is a D");
        }

        else if (grade < 60)
        {
            Console.WriteLine("Your grade is a F");
        }
    }

}