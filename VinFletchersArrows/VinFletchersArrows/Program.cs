using System;
using System.Threading;

namespace VinFletchersArrows
{
    internal class Program
    {
        //Vin Fletcher is a skilled arrow maker.He asks for your help building a new class to represent arrows and
        //determine how much he should sell them for. “A tiny fragment of my soul goes into each arrow; I care
        //not for the money; I just need to be able to recoup my costs and get food on the table,” he says.Each arrow has three parts: the arrowhead (steel, wood, or obsidian), the shaft (a length between 60 and
        //100 cm long), and the fletching(plastic, turkey feathers, or goose feathers).
        //His costs are as follows: For arrowheads, steel costs 10 gold, wood costs 3 gold, and obsidian costs 5 gold.
        //For fletching, plastic costs 10 gold, turkey feathers cost 5 gold, and goose feathers cost 3 gold.For the
        //shaft, the price depends on the length: 0.05 gold per centimeter.


        // -------- Objectives -----------

        // • Define a new Arrow class with fields for arrowhead type, fletching type, and length. (Hint:
        // arrowhead types and fletching types might be good enumerations.)

        // • Allow a user to pick the arrowhead, fletching type, and length and then create a new Arrow instance.

        // • Add a GetCost method that returns its cost as a float based on the numbers above, and use this
        //   to display the arrow’s cost
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Vins Arrow Maker");
            Console.WriteLine("Choose from the follow Arrows?");
            Console.WriteLine("1: Elite Arrow");
            Console.WriteLine("2: Marksman Arrow");
            Console.WriteLine("3: Beginner Arrow");
            Console.WriteLine("4: Custom made arrow");

            int usersChoice = Convert.ToInt32(Console.ReadLine());
                
            while (usersChoice <= 0 || usersChoice >= 4)
            {
                usersChoice = Convert.ToInt32(Console.ReadLine());
            }
                
            Arrow? customersArrow = null!;
            switch (usersChoice)
            {
                case 1:
                    customersArrow = Arrow.CreateEliteArrow();
                    break;
                case 2:
                    customersArrow = Arrow.CreateMarksmanArrow();
                    break;
                case 3:
                    customersArrow = Arrow.CreateBeginnerArrow();
                    break;
                case 4:
                    PrintArrowHeadOptions();
                    ArrowHead head = (ArrowHead)Convert.ToInt32(Console.ReadLine()) - 1;
                    PrintArrowFletchingOptions();
                    ArrowFletching fletching = (ArrowFletching)Convert.ToInt32(Console.ReadLine()) - 1;
                    Console.WriteLine("How long would you like the arrow shaft to be 60-100(CM)");
                    int arrowLength = Convert.ToInt32(Console.ReadLine());
                    customersArrow = new Arrow(head, fletching, arrowLength);
                    break;
            }

            Console.WriteLine($"You have chosen an arrow with a {customersArrow.Head} head and a {customersArrow.Fletching} fletching, with a {customersArrow.ShaftLength}CM shaft.");
            Console.WriteLine($"Your total cost will be {customersArrow.GetCost():0.00} gold");
            Console.ReadKey();

            void PrintArrowHeadOptions()
            {
                Console.WriteLine("What would you like your arrow head made of?");
                Console.WriteLine("1: Steel");
                Console.WriteLine("2: Wood");
                Console.WriteLine("3: Obsidian");
            }

            void PrintArrowFletchingOptions()
            {
                Console.WriteLine("What would you like your arrow fletching made of?");
                Console.WriteLine("1: Plastic");
                Console.WriteLine("2: Turkey");
                Console.WriteLine("3: Goose");
            }

        }
    }

    enum ArrowHead { Steel, Wood, Obsidian }
    enum ArrowFletching { Plastic, Turkey, Goose }

    class Arrow
    {
        public ArrowHead Head { get; private set; }
        public ArrowFletching Fletching { get; private set; }
        public int ShaftLength { get; private set; }

        public Arrow(ArrowHead head, ArrowFletching fletching, int shaftLength)
        {
            Head = head;
            Fletching = fletching;
            ShaftLength = shaftLength;
        }

        public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.Steel, ArrowFletching.Plastic, 95);
        public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.Wood, ArrowFletching.Goose, 75);
        public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.Steel, ArrowFletching.Goose, 65);


        public double GetCost()
        {
            double shaftPrice = (double)ShaftLength * 0.05;

            int headPrice = Head switch
            {
                ArrowHead.Steel => 10,
                ArrowHead.Obsidian => 5,
                ArrowHead.Wood => 3,
                _ => 0
            };
            int fletchPrice = Fletching switch
            {
                ArrowFletching.Plastic => 10,
                ArrowFletching.Turkey => 5,
                ArrowFletching.Goose => 3,
                _ => 0,
            };

            return (double)headPrice + fletchPrice + shaftPrice;
        }
    }
}
