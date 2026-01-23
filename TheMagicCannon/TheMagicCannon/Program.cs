namespace TheMagicCannon
{
    internal class Program
    {
        /*Skorin, a member of Consolas’s wall guard, has constructed a magic cannon that draws power from two
        gems: a fire gem and an electric gem. Every third turn of a crank, the fire gem activates, and the cannon
        produces a fire blast. The electric gem activates every fifth turn of the crank, and the cannon makes an
        electric blast. When the two line up, it generates a potent combined blast. Skorin would like your help to
        produce a program that can warn the crew about which turns of the crank will produce the different
        blasts before they do it.*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 - 100");
            int usersNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= usersNumber; i++)
            {
                Console.ResetColor();
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"{i}: Fire and Electric");
                }
                else if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{i}: Fire");
                }
                else if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{i}: Electric");
                }
                else
                {

                    Console.WriteLine($"{i}: Normal");
                }
                
            }
            Console.ReadKey();
        }
    }
}
