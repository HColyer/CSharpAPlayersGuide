using Microsoft.VisualBasic;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net;
using System.Xml.Linq;

namespace SimulasSoup
{
    //Simula is impressed with how you reconstructed the box with an enumeration.When the box opened,
    //you saw a glowing emerald gem inside.You don’t know what it is, but it seems important. Also in the box
    //were three vials of powder labeled HOT, SALTY, and SWEET.
    //“Finally! I can make soup again!” Simula says. She casually tosses the small glowing gem to you but is
    //wholly focused on the powders. “You stick around and help me make soup with your programming skills,
    //and I’ll tell you what that gem does.”
    //She pulls out a cookpot, knocks the clutter off the table with a quick sweep of her arm, and begins
    //cooking.She says, “I’m the best soup maker in town, and you’re in for a treat. I’ve got recipes for soup,
    //stew, and gumbo. I’ve got mushrooms, chicken, carrots, and potatoes for ingredients.And thanks to you
    //getting that box open, I’ve got seasonings again! Spicy, salty, and sweet seasoning.Pick a recipe, an
    //ingredient, and a seasoning, and I’ll make it.Use your programming skills to help us track what we make.”
    //
    //
    //Objectives:
    //• Define enumerations for the three variations on food: type (soup, stew, gumbo), main ingredient
    //(mushrooms, chicken, carrots, potatoes), and seasoning (spicy, salty, sweet).
    //• Make a tuple variable to represent a soup composed of the three above enumeration types.
    //• Let the user pick a type, main ingredient, and seasoning from the allowed choices and fill the tuple
    //with the results. Hint: You could give the user a menu to pick from or simply compare the user’s
    //text input against specific strings to determine which enumeration value represents their choice.
    //• When done, display the contents of the soup tuple variable in a format like “Sweet Chicken Gumbo.”
    //Hint: You don’t need to convert the enumeration value back to a string. Simply displaying an
    //enumeration value with Write or WriteLine will display the name of the enumeration value.)
    internal class Program
    {
        static void Main(string[] args)
        {
            (Seasoning seasoning, Ingredients ingredients, Type type) soup;

            PrintTypeChoices();
            int typeChoice = Convert.ToInt32(Console.ReadLine()!);
            Type type = (Type)(typeChoice - 1);

            PrintIngredientChoices();
            int ingredientChoice = Convert.ToInt32(Console.ReadLine()!);
            Ingredients ingredients = (Ingredients)(ingredientChoice - 1);

            PrintSeasoningChoices();
            int seasoningChoice = Convert.ToInt32(Console.ReadLine()!);
            Seasoning seasoning = (Seasoning)(seasoningChoice - 1);

            soup.type = type;
            soup.ingredients = ingredients;
            soup.seasoning = seasoning;

            Console.WriteLine($"{soup.ToString()}");
            Console.ReadKey();


            // Functions for printing choices
            static void PrintTypeChoices()
            {
                Console.WriteLine("What type of food would you like?");
                Console.WriteLine("1: Soup");
                Console.WriteLine("2: Stew");
                Console.WriteLine("3: Gumbo");
            }

            static void PrintIngredientChoices()
            {
                Console.WriteLine("What ingredient would you like?");
                Console.WriteLine("1: Mushrooms");
                Console.WriteLine("2: Chicken");
                Console.WriteLine("3: Carrots");
                Console.WriteLine("4: Potatoes");
            }

            static void PrintSeasoningChoices()
            {
                Console.WriteLine("What seasoning would you like?");
                Console.WriteLine("1: Spicy");
                Console.WriteLine("2: Salty");
                Console.WriteLine("3: Sweet");
            }
        }

        enum Type { Soup, Stew, Gumbo }

        enum Ingredients { Mushrooms, Chicken, Carrots, Potatoes }

        enum Seasoning { Spicy, Salty, Sweet }
    }
}
