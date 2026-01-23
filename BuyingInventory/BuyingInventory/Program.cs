namespace BuyingInventory
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string myName = "harry";
            float rate = 1.0f;

            // Display options
            Console.WriteLine("The following items are available:");
            Console.WriteLine("1 - Rope");
            Console.WriteLine("2 - Torches");
            Console.WriteLine("3 - Climbing Equipment");
            Console.WriteLine("4 - Clean Water");
            Console.WriteLine("5 - Machete");
            Console.WriteLine("6 - Canoe");
            Console.WriteLine("7 - Food Supplies");
            Console.Write("Which item would you like to see the price of? ");
            
            // Get users choice
            int usersChoice = Convert.ToInt32(Console.ReadLine());
            
            // Get users name 
            Console.Write("What's your name? ");
            string usersName = Console.ReadLine()!;

            // If user equals my name then give 50% off
            if (usersName == myName) 
            {
                rate = 0.5f;
            }

            // Prices 
            int ropePrice = 10;
            int torchPrice = 15;
            int climbingEquipmentPrice = 25;
            int cleanWaterPrice = 1;
            int machetePrice = 20;
            int canoePrice = 200;
            int foodPrice = 1;
            

            // Same as below but using switch expression
            string response = usersChoice switch
            {
                1 => $"Rope costs {ropePrice * rate} gold.",
                2 => $"Torches cost {(torchPrice * rate):F2}  gold.",
                3 => $"Climbing Equipment costs {(climbingEquipmentPrice * rate):F2} gold.",
                4 => $"Clean Water costs {(cleanWaterPrice * rate):F2} gold.",
                5 => $"A Machete costs {machetePrice * rate} gold.",
                6 => $"A Canoe costs {canoePrice * rate} gold.",
                7 => $"Food Supplies cost {(foodPrice * rate):F2} gold.",
                _ => "That is not a valid option."
            };

            Console.WriteLine(response);
            Console.ReadKey();

            //switch (usersChoice)
            //{
            //    case 1:
            //        Console.WriteLine("Rope costs 10 gold.");
            //        break;
            //    case 2:
            //        Console.WriteLine("Torches cost 15 gold.");
            //        break;
            //    case 3:
            //        Console.WriteLine("Climbing Equipment costs 25 gold.");
            //        break;
            //    case 4:
            //        Console.WriteLine("Clean Water costs 1 gold.");
            //        break;
            //    case 5:
            //        Console.WriteLine("A Machete costs 20 gold.");
            //        break;
            //    case 6:
            //        Console.WriteLine("A Canoe costs 200 gold.");
            //        break;
            //    case 7:
            //        Console.WriteLine("Food Supplies cost 1 gold per day.");
            //        break;
            //    default:
            //        Console.WriteLine("That is not a valid option.");
            //        break;
            //}
        }
    }
}
