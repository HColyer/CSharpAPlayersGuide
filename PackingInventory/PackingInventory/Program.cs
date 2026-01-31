using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace PackingInventory
{
    internal class Program
    {
        enum Item { Arrow, Bow, Rope, Water, Food, Sword }
        static void Main(string[] args)
        {
            int totalItem = 10;
            decimal maxWeight = 20m;
            decimal maxVolume = 30m;
            Pack pack = new Pack(totalItem, maxWeight, maxVolume);
            while (true)
            {
                DisplayUserOptions();
                int usersInput;
                while (!int.TryParse(Console.ReadLine(), out usersInput) || usersInput > 6 || usersInput < 1)
                {
                    Console.WriteLine("Please enter a valid option");
                }
                // Cast users input to Item enum
                Item usersItem = (Item)(usersInput - 1);

                InventoryItem inventoryItem = (usersItem) switch
                {
                    Item.Arrow => new Arrow(),
                    Item.Bow => new Bow(),
                    Item.Rope => new Rope(),
                    Item.Water => new Water(),
                    Item.Food => new Food(),
                    Item.Sword => new Sword(),
                    _ => throw new NotImplementedException()
                };



                if (pack.Add(inventoryItem))
                {
                    Console.WriteLine("Items been Added");
                }
                else
                {
                    Console.WriteLine("Pack has run out of space");
                }
                Console.WriteLine(pack);
            }

            static void DisplayUserOptions()
            {
                Console.WriteLine("Which item would you like to store in your backpack");
                Console.WriteLine("1: Arrow");
                Console.WriteLine("2: Bow");
                Console.WriteLine("3: Rope");
                Console.WriteLine("4: Water");
                Console.WriteLine("5: Food");
                Console.WriteLine("6: Sword");
            }

        }
    }
}
