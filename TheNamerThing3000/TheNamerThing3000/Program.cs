namespace TheNamerThing3000
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What kind of thing are we talking about?");
            string a = Console.ReadLine()!; // The thing that the user has damaged
            Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
            string b = Console.ReadLine()!; // Decription of the "thing"
            string c = "of doom";
            string d = "3000";
            Console.WriteLine("The " + b + " " + a + " " + c + " " + d + "!");
            Console.ReadKey();
        }
    }
}
