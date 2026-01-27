namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.Title = "Tic-Tac-Toe";
                Console.Clear();
                Game game = new Game();
                game.Play();
                Console.ReadKey();
            }
            
        }
    }
}