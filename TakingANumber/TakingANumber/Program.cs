namespace TakingANumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int AskForANumber(string text)
            {
                Console.WriteLine(text);
                int usersNumber = Convert.ToInt32(Console.ReadLine());
                return usersNumber;
            }
            AskForANumber("enter a number");

            int AskForANumberInRange(string text, int max, int min)
            {
                Console.WriteLine(text);
                int usersNumber = Convert.ToInt32(Console.ReadLine());

                while (usersNumber > max ||  usersNumber < min)
                {
                    Console.WriteLine(text);
                    usersNumber = Convert.ToInt32(Console.ReadLine());
                }
                return usersNumber;
            }
            AskForANumberInRange("enter a num", 20, 10);
        }
    }
}
