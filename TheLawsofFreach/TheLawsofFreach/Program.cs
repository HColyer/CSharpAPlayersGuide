namespace TheLawsofFreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 22, 2, 3, 4, 5 };

            // get smallest number in the array
            int currentSmallest = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number < currentSmallest)
                {
                    currentSmallest = number;
                }
            }
            Console.WriteLine(currentSmallest);

            // average of the array
            int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }

            float average = (float)total / numbers.Length;
            Console.WriteLine($"{average:F2}");
            Console.ReadKey();
        }
    }
}
