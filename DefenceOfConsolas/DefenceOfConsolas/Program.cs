namespace DefenceOfConsolas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Defence of Consolas";

            Console.Write("Target row? ");
            int targetRow = int.Parse(Console.ReadLine());

            Console.Write("Target column? ");
            int targetColumn = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Beep();
            Console.WriteLine($"({targetRow + 1}, {targetColumn})\n({targetRow}, {targetColumn + 1})\n({targetRow - 1}, {targetColumn})\n({targetRow}, {targetColumn - 1})");
            string name = "Willow";
            Console.WriteLine($"Defend {name}'s Consolas!");
            int age = 25;
            Console.WriteLine(age);
            Console.ReadKey();

            
        }
    }
}
