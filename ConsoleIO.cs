namespace NumberGame
{
    public class ConsoleIO
    {
        public static int GetMaxNumber()
        {
            while (true)
            {
                int maxNumber;

                Console.Write("Enter the maximum number: ");

                if (int.TryParse(Console.ReadLine(), out maxNumber))
                {
                    if (maxNumber < 1)
                    {
                        Console.WriteLine("Number must be positive.");
                    }
                    else
                    {
                        return maxNumber;
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid input enter a number please!");
                }
            }
        }
        public static int GetGuess()
        {
            while (true)
            {
                int guess;

                Console.Write("Guess the random number: ");

                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess < 1)
                    {
                        Console.WriteLine("Number must be positive.");
                    }
                    else
                    {
                        return guess;
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid input enter a number please!");
                }
            }
        }
        public static void SuccessMessage(int count)
        {
            Console.WriteLine($"You did it and it only took {count} tries");
        }
        public static void FailureMessage(string message)
        {
            Console.WriteLine($"Not it, try again, go {message}!");
        }
        public static void DuplicateGuess()
        {
            Console.WriteLine("You've already guessed this, try another number!");
        }
    }
}
