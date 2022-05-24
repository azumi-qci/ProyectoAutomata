using ProyectoAutomata;

namespace ProyectoAutomata
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? param = args.Length > 0 ? args[0] : null;

            // Get all rolls
            List<List<int>> rolls = new List<List<int>>
            {
                DiceRolling.GetDiceRoll(2).ToList(),
                DiceRolling.GetDiceRoll(2).ToList(),
                DiceRolling.GetDiceRoll(2).ToList(),
                DiceRolling.GetDiceRoll(2).ToList(),
                DiceRolling.GetDiceRoll(2).ToList()
            };

            // Create automaton string
            string automatonString = "";

            // Print every dice roll
            for (int i = 0; i < rolls.Count; i++)
            {
                Console.WriteLine(string.Format("Tirada #{0}", i + 1));

                foreach (int dice in rolls[i])
                {
                    Console.WriteLine(string.Format("{0} ", dice));
                    // Append to automaton string
                    automatonString += dice;
                }

                Console.Write("\n");
            }

            string stringToTest = param != null ? param : automatonString;

            // Print automaton string
            Console.WriteLine(string.Format("Cadena: {0}", stringToTest));

            // Verify string with automaton
            bool isValid = Automaton.VerifyWithAutomaton(stringToTest);

            if (isValid)
            {
                Console.WriteLine("La cadena generada es correcta");
            }
            else
            {
                Console.WriteLine("La cadena generada es incorrecta");
            }
        }
    }
}