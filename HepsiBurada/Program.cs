using HepsiBurada.Enums;
using HepsiBurada.Factory;
using HepsiBurada.Helpers.ExceptionHelpers;
using HepsiBurada.Helpers.String;
using HepsiBurada.RoverActions;
using System;
using System.Linq;

namespace HepsiBurada
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = Creator.GetReader(ReaderElements.Standard);

            Creator.GetWriter(WritingElements.Startup).Write();

            Creator.GetWriter(WritingElements.GetGridDimensions).Write();

            string reading = reader.Read();

            var dimensions = ReaderHelper.GetIntegretValuesFromStringArray(reading);

            var area = new Area(dimensions[0], dimensions[1]);

            string commandText = string.Empty;

            while (commandText != "E")
            {
                var modifyRoversPosition = new ModifyRoversPosition();

                Creator.GetWriter(WritingElements.GetRoversPosition).Write();

                string positionInfo = reader.Read();

                var position = ReaderHelper.GetRoverPosition(positionInfo);

                var rover = new Rover(position.Value.First(), position.Value.Last(), position.Key, area);

                Creator.GetWriter(WritingElements.GetRoversCommand).Write();

                string movementCommands = reader.Read();

                Execute(rover, modifyRoversPosition, movementCommands);

                Console.WriteLine(rover);

                Console.WriteLine("Calculate Again? C - Continue, E - End");

                commandText = Console.ReadLine().ToUpper();
            }

            Console.ReadLine();
        }

        private static void Execute(Rover rover, ModifyRoversPosition modifyRoversPosition, string commands)
        {
            try
            {
                foreach (char item in commands)
                {
                    string actionString = item.ToString();
                    RoverAction roverAction = RoverAction.N;
                    
                    Enum.TryParse<RoverAction>(actionString, true, out roverAction);

                    ICommand roverCommand = new RoverCommand(rover, Creator.GetAction(roverAction));
                    modifyRoversPosition.SetCommand(roverCommand);
                    modifyRoversPosition.Invoke();
                }
            }
            catch (MovementException mEx)
            {
                Console.WriteLine(ExceptionHelper.GetExceptionMessage(mEx));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ExceptionHelper.GetExceptionMessage(ex));
            }
        }

        private static void Info()
        {
            Console.WriteLine("Valid Commands are:");
            Console.WriteLine("L - Turn Rover Left");
            Console.WriteLine("R - Turn Rover Right");
            Console.WriteLine("F - Move Rover Forward");
            Console.WriteLine("E - End");
            Console.WriteLine("Enter to execute commands");
        }
    }
}
