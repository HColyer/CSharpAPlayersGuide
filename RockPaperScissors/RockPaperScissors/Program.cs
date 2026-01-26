namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game game = new ();
            while (true)
            {
                game.PlayRound();
            }
        }
    }
}
