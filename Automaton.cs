namespace ProyectoAutomata
{
    public class Automaton
    {
        private const string INITIAL_STATE = "q0";
        private const string END_STATE = "q2";

        private string state;

        public Automaton()
        {
            state = INITIAL_STATE;
        }

        public Tuple<string, bool> WalkWithAutomaton(string automatonString)
        {
            foreach (char currentCharacter in automatonString)
            {
                switch (state)
                {
                    case "q0":
                        if (currentCharacter == '1' || currentCharacter == '3' || currentCharacter == '5')
                        {
                            state = "q0";
                        }
                        else
                        {
                            state = "q1";
                        }
                        break;
                    case "q1":
                        if (currentCharacter == '2' || currentCharacter == '4' || currentCharacter == '6')
                        {
                            state = "q1";
                        }
                        else
                        {
                            state = "q2";
                        }
                        break;
                    case "q2":
                        if (currentCharacter == '1' || currentCharacter == '3' || currentCharacter == '5')
                        {
                            state = "q2";
                        }
                        else
                        {
                            state = "q1";
                        }
                        break;
                    default:
                        Console.WriteLine("\nSe ha llegado a un estado inválido");
                        break;
                }
            }

            // Check last state
            if (state == END_STATE)
            {
                return new Tuple<string, bool>(state, true);
            }

            return new Tuple<string, bool>(state, false);
        }
    }
}
