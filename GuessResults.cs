namespace NumberGame
{
    public class GuessResults
    {
        public int[] GetGuessArray(int maxNumber)
        {
            int[] guessArray = new int[maxNumber];
            return guessArray;
        }
        public int[] StoreGuess(int guess, int[] guessArray)
        {
            for (int i = 0; i < guessArray.Length; i++)
            {
                if (guessArray[i] == 0)
                {
                    guessArray[i] = guess;
                }
            }
            return guessArray;
        }
        
    }
}
