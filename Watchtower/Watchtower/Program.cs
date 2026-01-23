namespace Watchtower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give the X coordinates: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Give the Y coordinates: ");
            int y = Convert.ToInt32(Console.ReadLine());

            string result;

            if (x == 0 && y == 0)
            {
                result = "The enemy is here!";
            }
            else if (x < 0 && y > 0)
            {
                result = "The enemy is to the North West.";
            }
            else if (x == 0 && y > 0)
            {
                result = "The enemy is to the North.";
            }
            else if (x > 0 && y > 0)
            {
                result = "The enemy is to the North East.";
            }
            else if (x < 0 && y == 0) 
            {
                result = "The enemy is to the West.";
            } 
            else if (x > 0 && y == 0) 
            {
                result = "The enemy is to the East.";
            } 
            else if (x < 0 && y < 0) 
            {
                result = "The enemy is to the South West.";
            } 
            else if (x == 0 && y < 0) 
            {
                result = "The enemy is to the South.";
            } 
            else 
            {
                result = "The enemy is to the South East.";
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
