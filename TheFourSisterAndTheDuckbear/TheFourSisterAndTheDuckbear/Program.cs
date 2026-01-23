namespace TheFourSisterAndTheDuckbear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSisters = 4;
            Console.WriteLine("How many chocolate eggs did you collect?");
            string inputEggNumber = Console.ReadLine()!;

            int eggNumber = Convert.ToInt32(inputEggNumber);
            int eggsRemaining = eggNumber % numberOfSisters;
            int eggsPerSister = eggNumber / numberOfSisters;

            Console.WriteLine($"Each sister receives {eggsPerSister} eggs.");
            Console.WriteLine($"The duckbear receives {eggsRemaining} eggs.");
            Console.ReadKey();


        }
    }
}
