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
            Console.WriteLine("Welcome to the arrow maker");
            Console.WriteLine("What would you like your arrow head made of?");
            Console.WriteLine("1: Steel");
            Console.WriteLine("2: Wood");
            Console.WriteLine("3: Obsidian");

            ArrowHead head = (ArrowHead)Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("What would you like your arrow fletching made of?");
            Console.WriteLine("1: Plastic");
            Console.WriteLine("2: Turkey");
            Console.WriteLine("3: Goose");

            ArrowFletching fletching = (ArrowFletching)Convert.ToInt32(Console.ReadLine()) - 1;

            Console.WriteLine("How long would you like the arrow shaft to be 60-100(CM)");
            int length = Convert.ToInt32(Console.ReadLine());

            Arrow arrow = new Arrow(head, fletching, length);
            Console.WriteLine($"You have chosen an arrow with a {head} head and a {fletching} fletching, with a {length}CM shaft.");
            Console.WriteLine($"Your total cost will be {arrow.GetCost():0.00} gold");
            Console.ReadKey();
        }
    }

    enum ArrowHead { Steel, Wood, Obsidian }
    enum ArrowFletching { Plastic, Turkey, Goose }

    class Arrow
    {
        public ArrowHead Head;
        public ArrowFletching Fletching;
        public int ShaftLength;

        public Arrow(ArrowHead head, ArrowFletching fletching, int shaftLength)
        {
            this.Head = head;
            this.Fletching = fletching;
            this.ShaftLength = shaftLength;
        }

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
