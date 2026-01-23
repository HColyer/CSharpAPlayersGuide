using System;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HuntingTheManticore
{
    internal class Program
    {
        //The Uncoded One’s airship, the Manticore, has begun an all-out attack on the city of Consolas.It must be
        //destroyed, or the city will fall.Only by combining Mylara’s prototype, Skorin’s cannon, and your
        //programming skills will you have a chance to win this fight.You must build a program that allows one
        //user—the pilot of the Manticore—to enter the airship’s range from the city and a second user—the city’s
        //defenses—to attempt to find what distance the airship is at and destroy it before it can lay waste to the
        //town.
        //The first user begins by secretly establishing how far the Manticore is from the city, in the range 0 to 100.
        //The program then allows a second player to repeatedly attempt to destroy the airship by picking the
        //range to target until either the city of Consolas or the Manticore is destroyed.In each attempt, the player
        //is told if they overshot (too far), fell short (not far enough), or hit the Manticore.The damage dealt to the
        //Manticore depends on the turn number. For most turns, 1 point of damage is dealt.But if the turn number
        //is a multiple of 3, a fire blast deals 3 points of damage; a multiple of 5, an electric blast deals 3 points of
        //damage, and if it is a multiple of both 3 and 5, a mighty fire-electric blast deals 10 points of damage.The
        //Manticore is destroyed after taking 10 points of damage.
        //However, if the Manticore survives a turn, it will deal a guaranteed 1 point of damage to the city of
        //Consolas.The city can only take 15 points of damage before being annihilated.
        //Before a round begins, the user should see the current status: the current round number, the city’s health,
        //and the Manticore’s health.
        static void Main(string[] args)
        {
            int citiesHealth = 15;
            int manticoreHealth = 10;
            int round = 1;


            

            Console.Write("Player 1, how far away from the city do you want to station the Manticore? ");
            int manticoresPosition = UserInputToNumber();
            Console.Clear();

            // Game Loop
            while (citiesHealth != 0 && manticoreHealth != 0)
            {
                DisplayRoundInfo(round, citiesHealth, manticoreHealth);
                int cannonDamage = GetCannonDamage(round);
                DisplayExpectedDamage(cannonDamage);
                Console.Write("Enter desired cannon range: ");
                int targetPosition = UserInputToNumber();

                if (targetPosition > manticoresPosition)
                {
                    Console.WriteLine("That round OVERSHOT the target!");
                    
                }
                else if (targetPosition < manticoresPosition)
                {
                    Console.WriteLine("That round FELL SHORT of the target!");
                    
                }
                else if (targetPosition == manticoresPosition)
                {
                    Console.WriteLine("That round was a DIRECT HIT!");
                    manticoreHealth -= cannonDamage;
                }

                if(manticoreHealth > 0)
                citiesHealth--;
                round++;
            }

            string result;

            if (citiesHealth == 0)
            {
                result = "The city has been destroyed";
            }
            else
            {
                result = "The Manticore has been destroyed! The city of Consolas has been saved!";
            }

            Console.WriteLine(result);
            Console.ReadKey();

            // Methods
            int UserInputToNumber()
            {
                return Convert.ToInt32(Console.ReadLine());
            }


            void DisplayRoundInfo(int round, int citiesHealth, int manticoreHealth)
            {
                Console.WriteLine($"STATUS: Round: {round} City: {citiesHealth}/15 Manticore: {manticoreHealth}/10");

            }

            // Returns damage based of round
            int GetCannonDamage(int round)
            {
                int damage = 1;
                if (round % 3 == 0 && round % 5 == 0)
                {
                    damage = 10;
                }
                else if (round % 3 == 0 || round % 5 == 0)
                {
                    damage = 3;
                }
                return damage;
            }

            void DisplayExpectedDamage(int damage)
            {
                Console.WriteLine($"The cannon is expected to deal {damage} damage this round.");
            }

        }
    }
}
