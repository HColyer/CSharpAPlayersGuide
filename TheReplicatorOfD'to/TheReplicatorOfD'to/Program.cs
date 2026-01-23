using Microsoft.VisualBasic;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace TheReplicatorOfD_to
{
    internal class Program
    {
        //While searching an abandoned storage building containing strange code artifacts, you uncover the
        //ancient Replicator of D’To.This can replicate the contents of any int array into another array.But it
        //appears broken and needs a Programmer to reforge the magic that allows it to replicate once again.
        //Objectives:
        //• Make a program that creates an array of length 5.
        //• Ask the user for five numbers and put them in the array.
        //• Make a second array of length 5.
        //• Use a loop to copy the values out of the original array and into the new one.
        //• Display the contents of both arrays one at a time to illustrate that the Replicator of D’To works
        //again.
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Enter a number");
                int usersNumber = Convert.ToInt32(Console.ReadLine());
                numbers[i] = usersNumber;
            }

            int[] numbersReplicated = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbersReplicated[i] = numbers[i];
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            for(int i = 0;i < numbersReplicated.Length; i++)
            {
                Console.WriteLine(numbersReplicated[i]);
            }
            Console.ReadKey();
        }
    }
}
