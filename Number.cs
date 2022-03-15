namespace NumberGame
{
    public class Number
    {
        private Random _rng = new Random();

        public int Scramble(int maxNumber)
        {
            int randomNumber = _rng.Next(1, maxNumber);
            return randomNumber;

        }
    }
}
