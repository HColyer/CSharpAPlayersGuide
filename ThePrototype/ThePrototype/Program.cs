namespace ThePrototype
{
    internal class Program
    {
        /* Mylara, the captain of the Guard of Consolas, has approached you with the beginnings of a plan to hunt
        down The Uncoded One’s airship. “If we’re going to be able to track this thing down,” she says, “we need
        you to make us a program that can help us home in on a location.” She lays out a plan for a program to
        help with the hunt. One user, representing the airship pilot, picks a number between 0 and 100. Another
        user, the hunter, will then attempt to guess the number. The program will tell the hunter that they
        guessed correctly or that the number was too high or low. The program repeats until the hunter guesses
        the number correctly. Mylara claims, “If we can build this program, we can use what we learn to build a
        better version to hunt down the Uncoded One’s airship.*/
        static void Main(string[] args)
        {
            bool isGameOver = false;
            while (!isGameOver)
            {
                Console.Clear();
                int numberOfGuesses = 0;
                Console.Write("User 1, Enter a number between 1 - 100: ");
                int usersNumber = Convert.ToInt32(Console.ReadLine());

                while (usersNumber < 1 || usersNumber > 100)
                {
                    Console.WriteLine("Please enter a number between 1 and 100");
                    usersNumber = Convert.ToInt32(Console.ReadLine());
                }

                Console.Clear();

                Console.Write("User 2, guess user 1's number: ");

                int guessedNumber = Convert.ToInt32(Console.ReadLine());

                while (usersNumber != guessedNumber)
                {
                    numberOfGuesses++;
                    if (guessedNumber > usersNumber)
                    {
                        Console.WriteLine("You guessed too high");
                    }
                    else if (guessedNumber < usersNumber)
                    {
                        Console.WriteLine("You guessed too low");
                    }
                    Console.Write("Guess again: ");
                    guessedNumber = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine($"Well done, you guessed correctly! you got it in {numberOfGuesses} guesses");
                Console.WriteLine("Would you like to play again (y/n)");
                string playAgain = Console.ReadLine()!;

                while (playAgain != "y" && playAgain != "n")
                {
                    Console.WriteLine("Please a valid option");
                    playAgain = Console.ReadLine()!;

                }
                isGameOver = playAgain != "y";
            }
            Console.WriteLine("Thanks for playing");
            Console.ReadKey();
        }
    }
}
