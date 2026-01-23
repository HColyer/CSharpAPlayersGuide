namespace SimulasTest
{
    internal class Program
    {
        // As you move through the village of Enumerant, you notice a short, cloaked figure following you.Not
        // being one to enjoy a mysterious figure tailing you, you seize a moment to confront the figure. “Don’t be
        // alarmed!” she says. “I am Simula.They are saying you’re a Programmer.Is this true?” You answer in the
        // affirmative, and Simula’s eyes widen. “If you are truly a Programmer, you will be able to help me.Follow
        // me.” She leads you to a backstreet and into a dimly lit hovel. She hands you a small, locked chest. “We
        // haven’t seen any Programmers in these lands in a long time. And especially not ones that can craft types.
        // If you are a True Programmer, you will want what is in that chest. And if you are a True Programmer, I
        // will gladly give it to you to aid you in your quest.”
        // The chest is a small box you can hold in your hand. The lid can be open, closed (but unlocked), or locked.
        // You’d normally be able to go between these states, opening, closing, locking, and unlocking the box, but
        // the box is broken.You need to create a program with an enumeration to recreate this locking mechanism.




        static void Main(string[] args)
        {
            ChestState currentState = ChestState.locked;
            while (true)
            {
                
                PrintMessage(currentState);
                string usersChoice = Console.ReadLine()!;
                switch (usersChoice)
                {
                    case "unlock":
                        if (currentState == ChestState.locked)
                        {
                            currentState = ChestState.unlocked;
                        }
                        else
                        {
                            Invalid(usersChoice);
                        }
                        break;
                    case "lock":
                        if (currentState == ChestState.closed)
                        {
                            currentState = ChestState.locked;
                        }
                        else
                        {
                            Invalid(usersChoice);
                        }
                        break;
                    case "close":
                        if (currentState == ChestState.open)
                        {
                            currentState = ChestState.closed;
                        }
                        else
                        {
                            Invalid(usersChoice);
                        }
                        break;
                    case "open":
                        if (currentState == ChestState.unlocked)
                        {
                            currentState = ChestState.open;
                        }
                        else
                        {
                            Invalid(usersChoice);
                        }
                        break;
                    default: Invalid(usersChoice); break;
                }

            }

            static void PrintMessage(ChestState state)
            {
                Console.Write($"Chest is {state}. What do you want to do? ");
            }

            static void Invalid(string text)
            {
                Console.WriteLine($"{text} is not a valid option");
            }
        }

        enum ChestState { locked, unlocked, open, closed }
    }
}
