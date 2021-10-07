using System;

namespace Number_guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int rightnumber = rnd.Next(100);
            while (rightnumber < 101)
            {
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess == rightnumber)
                {
                    Console.WriteLine("Correct, new number");
                    rightnumber = rnd.Next(100);
                }
                else if (guess < rightnumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (guess > rightnumber)
                {
                    Console.WriteLine("Too high");
                    continue;
                }
            }
        }
    }
}