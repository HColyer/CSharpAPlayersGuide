namespace TheColor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color blackColor = new (0, 0, 0);
            Color whiteColor = Color.White;

            Console.WriteLine($"The RGB values for black are ({blackColor.RedValue}, {blackColor.GreenValue}, {blackColor.BlueValue})");
            Console.WriteLine($"The RGB values for white are ({whiteColor.RedValue}, {whiteColor.GreenValue}, {whiteColor.BlueValue})");
            Console.ReadKey();
        }
    }
}
