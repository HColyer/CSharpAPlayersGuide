namespace ThePoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point pointOne = new (2, 3);
            Point pointTwo = new (-4, 0);

            Console.WriteLine($"({pointOne.X}, {pointOne.Y})");
            Console.WriteLine($"({pointTwo.X}, {pointTwo.Y})");
            Console.ReadKey();
        }
    }
}
