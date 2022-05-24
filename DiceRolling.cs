namespace ProyectoAutomata
{
    public static class DiceRolling
    {
        private const int MAX_DICE_NUMBER = 6;
        private const int MIN_DICE_NUMBER = 1;

        public static List<int> GetDiceRoll(int numOfDices)
        {
            List<int> rolls = new List<int>();
            Random random = new Random();

            for (int i = 0; i < numOfDices; i++)
            {
                rolls.Add(random.Next(MIN_DICE_NUMBER, MAX_DICE_NUMBER + 1));
            }

            return rolls;
        }
    }
}
