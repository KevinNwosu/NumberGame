namespace NumberGame
{
    public class NumberGameWorkflow
    {
        private Number _scrambler = new Number();
        private GuessResults _checker = new GuessResults();
        public bool CheckGuess(int guess, int randomNumber, int count, int maxNumber, int[] guessArray)
        {
            bool status = Array.Exists(guessArray, element => element == guess);
            if (!status)
            {
                _checker.StoreGuess(guess, guessArray);



                if (randomNumber == guess)
                {
                    ConsoleIO.SuccessMessage(count + 1);
                    return false;
                }
                else if (randomNumber < guess && guess < maxNumber)
                {
                    string message = "lower";
                    ConsoleIO.FailureMessage(message);
                    return true;
                }
                else if (randomNumber > guess && guess > 0)
                {
                    string message = "higher";
                    ConsoleIO.FailureMessage(message);
                    return true;
                }
                else
                {
                    Console.WriteLine("Number is out of range try again.");
                    return true;
                }
                
            }
            else
            {
                ConsoleIO.DuplicateGuess();
                return true;
            }
        }
        public void Run()
        {
            int maxNumber = ConsoleIO.GetMaxNumber();

            int randomNumber = _scrambler.Scramble(maxNumber);

            int[] guessArray = _checker.GetGuessArray(maxNumber);

            bool playing = true;

            int count = 0;

            while(playing)
            {
                int guess = ConsoleIO.GetGuess();

                playing = CheckGuess(guess, randomNumber, count, maxNumber, guessArray);

                count++;

            }
        }
    }
}
