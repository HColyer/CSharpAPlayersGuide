namespace TheDominionOfKings
{
    internal class Program
    {
        /* Three kings, Melik, Casik, and Balik, are sitting around a table, debating who has the greatest kingdom
        among them. Each king rules an assortment of provinces, duchies, and estates. Collectively, they agree
        to a point system that helps them judge whose kingdom is greatest: Every estate is worth 1 point, every
        duchy is worth 3 points, and every province is worth 6 points. They just need a program that will allow
        them to enter their current holdings and compute a point total.
        Objectives:
        • Create a program that allows users to enter how many provinces, duchies, and estates they have.
        • Add up the user’s total score, giving 1 point per estate, 3 per duchy, and 6 per province.
        • Display the point total to the user. */
        static void Main(string[] args)
        {
            int pointsPerEstate = 1;
            int pointsPerDuchy = 3;
            int pointsPerProvince = 6;

            Console.WriteLine("Welcome to the Dominion of Kings point calculator!");
            
            Console.Write("Enter the number of estates: ");
            int estates = int.Parse(Console.ReadLine()!);
            
            Console.Write("Enter the number of duchies: ");
            int duchies = int.Parse(Console.ReadLine()!);

            Console.Write("Enter the number of provinces: ");
            int provinces = int.Parse(Console.ReadLine()!);

            int totalPoints = (estates * pointsPerEstate) + (duchies * pointsPerDuchy) + (provinces * pointsPerProvince);
            Console.WriteLine($"Your total point score is: {totalPoints}");

            Console.ReadKey();
        }
    }
}
