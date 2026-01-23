namespace TheTriangleFarmer
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter the height of the triangle:");
            string? triangleHeightText = Console.ReadLine();

            Console.WriteLine("Enter the base of the triangle:");
            string? triangleBaseText = Console.ReadLine();

            int triangleHeight = int.Parse(triangleHeightText!);
            int triangleBase = int.Parse(triangleBaseText!);

            Console.WriteLine("The area of the triangle is: " + (triangleBase * triangleHeight) / 2);
            Console.ReadKey();
        }
    }
}
