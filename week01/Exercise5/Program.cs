using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string name = PromptUserName();
        int favNumber = PromptUserNumber();

        int numSquared = SquareNumber(favNumber);
        
        DisplayResult(name, numSquared);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.WriteLine("Enter your favorite number:");
            int favNumber = int.Parse(Console.ReadLine());

            return favNumber;
        }

        static int SquareNumber(int number)
        {
            int numberSquared = number * number;

            return numberSquared;
        }

        static void DisplayResult(string userName, int squaredNum)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNum}");
        }
    }
}