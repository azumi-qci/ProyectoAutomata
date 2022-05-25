using ProyectoAutomata;

namespace ProyectoAutomata
{
    public class Program
    {
        public const int NUM_ROUNDS = 5;
        public const int NUM_DICES = 2;

        static void Main(string[] args)
        {
            Automaton automaton = new Automaton();

            for (int i = 0; i < NUM_ROUNDS; i++)
            {
                Console.WriteLine(string.Format("Tirada #{0}", i + 1));

                List<int> roll = DiceRolling.GetDiceRoll(NUM_DICES);

                string automatonString = "";

                foreach (int dice in roll)
                {
                    // Append to automaton string
                    automatonString += dice.ToString();
                    // Show in screen
                    Console.Write(string.Format("{0} ", dice.ToString()));
                }

                // Process automaton
                Tuple<string, bool> result = automaton.WalkWithAutomaton(automatonString);

                // Show results
                Console.WriteLine("\nEstado actual: {0}", result.Item1);

                if (result.Item2)
                {
                    Console.WriteLine("\nSe ha llegado al estado de aceptación\n");
                }
                else
                {
                    Console.WriteLine("\nNo se encuentra en un estado de aceptación\n");
                }
            }
        }
    }
}