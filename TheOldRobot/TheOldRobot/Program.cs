namespace TheOldRobot
{
    internal class Program
    {
        enum Command { On, Off, North, East, South, West }
        static void Main(string[] args)
        {
            Robot robot = new ();

            while (true)
            {
                

                for (int i = 0; i < robot.Commands.Length; i++)
                {
                    DisplayInstructions();
                    robot.Commands[i] = GetRobotCommand(GetUsersInput());
                }

                //Command commandOne = GetUsersInput();
                //Command commandTwo = GetUsersInput();
                //Command commandThree = GetUsersInput();

                //robot.Commands[0] = GetRobotCommand(commandOne);
                //robot.Commands[1] = GetRobotCommand(commandTwo);
                //robot.Commands[2] = GetRobotCommand(commandThree);

                robot.Run();
            }
            
            static Command GetUsersInput()
            {
                Command usersCommand;

                while (!Enum.TryParse<Command>(Console.ReadLine(), true, out usersCommand))
                {
                    DisplayInstructions();
                }
                return usersCommand;
            }

            static RobotCommand GetRobotCommand(Command command)
            {
                RobotCommand robotCommand = (command) switch
                {
                    Command.On => new OnCommand(),
                    Command.Off => new OffCommand(),
                    Command.North => new NorthCommand(),
                    Command.East => new EastCommand(),
                    Command.South => new SouthCommand(),
                    Command.West => new WestCommand(),
                    _ => throw new Exception()
                };
                return robotCommand;

            }

            static void DisplayInstructions()
            {
                Console.WriteLine("Type a command: On, Off, North, East, South and West");
            }
        }
    }
}
