namespace ConsolasAndTelim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name;
            Console.WriteLine("Bread is ready");
            Console.WriteLine("Who recieved the bread");
            name = Console.ReadLine();
            Console.WriteLine("Noted: " + name + " recieved the bread");
            Console.ReadKey();
        }
    }
}
