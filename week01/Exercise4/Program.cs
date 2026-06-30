using System;

class Program
{
    static void Main(string[] args)
    {

        int userNumber = 0;
        List<int> numberList = new List<int>();
        int totalSum = 0;
        float average = 0;
        int highestNum = 0;

        do
        {
            Console.WriteLine("Enter a number to add to the list:");
            userNumber = int.Parse(Console.ReadLine());


            if (userNumber != 0)
            {
                numberList.Add(userNumber);
            }
            
        } while (userNumber != 0);

        foreach (int number in numberList)
        {
            totalSum = totalSum + number;

            if (number > highestNum)
            {
                highestNum = number;
            }
        }

        average = ((float)totalSum) / numberList.Count;

        Console.WriteLine($"The sum is: {totalSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The highest number is: {highestNum}");
    }
}