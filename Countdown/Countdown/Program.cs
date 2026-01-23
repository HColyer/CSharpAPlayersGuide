namespace Countdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Countdown(int number)
            {
                if (number <= 0) return;
                Console.WriteLine(number);
                Countdown(number - 1);  
            }

            Countdown(35);
            Console.ReadKey();
        }
    }
}
