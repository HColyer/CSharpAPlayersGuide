using System.Buffers.Text;
using System.Diagnostics.Metrics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace TheOldRobot
{
    internal class Program
    {
        // You spot something shiny, half-buried in the mud.You pull it out and realize that it seems to be some
        // mechanical automaton with the words “Property of Dynamak” etched into it.As you knock off the caked-
        // on mud, you realize that it seems like this old automaton might even be programmable if you can give it
        // the proper commands.The automaton seems to be structured like this:
        // public class Robot
        //        {
        //            public int X { get; set; }
        //            public int Y { get; set; }
        //            public bool IsPowered { get; set; }
        //            public RobotCommand?[] Commands { get; } = new RobotCommand?[3];
        //            public void Run()
        //            {
        //                foreach (RobotCommand? command in Commands)
        //                {
        //                    command?.Run(this);
        //                    Console.WriteLine($"[{X} {Y} {IsPowered}]");
        //                }
        //            }
        //        }
        //        You don’t see a definition of that RobotCommand class. Still, you think you might be able to recreate it
        //        (a class with only an abstract Run command) and then make derived classes that extend RobotCommand
        // that move it in each of the four directions and power it on and off. (You wish you could manufacture a
        // whole army of these!)
        //
        // Objectives:
        // • Copy the code above into a new project.
        // • Create a RobotCommand class with a public and abstract void Run(Robot robot) method. (The
        //  code above should compile after this step.)
        // • Make OnCommand and OffCommand classes that inherit from RobotCommand and turn the robot
        // on or off by overriding the Run method.
        // • Make a NorthCommand, SouthCommand, WestCommand, and EastCommand that move the robot 1
        // unit in the +Y direction, 1 unit in the -Y direction, 1 unit in the -X direction, and 1 unit in the +X
        // direction, respectively. Also, ensure that these commands only work if the robot’s IsPowered
        // property is true.
        // • Make your main method able to collect three commands from the console window. Generate new
        // RobotCommand objects based on the text entered.After filling the robot’s command set with these
        // new RobotCommand objects, use the robot’s Run method to execute them.For example:

        // on
        // north
        // west

        // [0 0 True]
        // [0 1 True]
        // [-1 1 True]
        // Define the set of valid commands for the robot
        enum Command { On, Off, North, East, South, West }

        static void Main(string[] args)
        {
            // Create a new Robot object
            Robot robot = new();

            // Infinite loop: keep asking the user for commands and running the robot
            while (true)
            {
                // Loop through the robot's command slots (array size = 3)
                for (int i = 0; i < robot.Commands.Length; i++)
                {
                    DisplayInstructions(); // Show the instructions to the user

                    // 1. Get user input as a Command enum
                    // 2. Convert it to a RobotCommand object
                    // 3. Store it in the robot's command array
                    robot.Commands[i] = GetRobotCommand(GetUsersInput());
                }

                // Old approach (commented out): manually getting three separate commands
                //Command commandOne = GetUsersInput();
                //Command commandTwo = GetUsersInput();
                //Command commandThree = GetUsersInput();
                //robot.Commands[0] = GetRobotCommand(commandOne);
                //robot.Commands[1] = GetRobotCommand(commandTwo);
                //robot.Commands[2] = GetRobotCommand(commandThree);

                // Execute all commands stored in the robot's command array
                robot.Run();
            }

            // --- Helper Methods ---

            // Prompt user until they enter a valid Command enum
            static Command GetUsersInput()
            {
                Command usersCommand;

                // Keep looping until input can be parsed to a valid Command
                while (!Enum.TryParse<Command>(Console.ReadLine(), true, out usersCommand))
                {
                    DisplayInstructions(); // Show instructions again if input is invalid
                }

                return usersCommand; // Return the parsed Command
            }

            // Convert a Command enum value into a concrete RobotCommand object
            static RobotCommand GetRobotCommand(Command command)
            {
                // Switch expression maps each Command to its corresponding RobotCommand subclass
                RobotCommand robotCommand = command switch
                {
                    Command.On => new OnCommand(),       // Turns the robot on
                    Command.Off => new OffCommand(),     // Turns the robot off
                    Command.North => new NorthCommand(), // Moves robot +Y (up)
                    Command.East => new EastCommand(),   // Moves robot +X (right)
                    Command.South => new SouthCommand(), // Moves robot -Y (down)
                    Command.West => new WestCommand(),   // Moves robot -X (left)
                    _ => throw new Exception()           // Should never happen (all enums handled)
                };

                return robotCommand; // Return the concrete RobotCommand
            }

            // Display instructions to the user
            static void DisplayInstructions()
            {
                Console.WriteLine("Type a command: On, Off, North, East, South and West");
            }
        }
    }
}