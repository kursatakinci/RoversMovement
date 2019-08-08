using HepsiBurada.Enums;
using HepsiBurada.ReadAndWrite;
using HepsiBurada.RoverActions;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.Factory
{
    public static class Creator
    {
        public static IAction GetAction(RoverAction rAction)
        {
            IAction action;

            switch (rAction)
            {
                case RoverAction.L:
                    action = new TurnLeftAction();
                    break;
                case RoverAction.R:
                    action = new TurnRightAction();
                    break;
                case RoverAction.M:
                    action = new MoveForwardAction();
                    break;
                default:
                    action = new NoAction();
                    break;
            }

            return action;
        }

        public static IWriter GetWriter(WritingElements writingElements)
        {
            IWriter writer;

            switch (writingElements)
            {
                case WritingElements.Startup:
                    writer = new StartupWriter();
                    break;
                case WritingElements.GetGridDimensions:
                    writer = new AreaDimensionsWriter();
                    break;
                case WritingElements.GetRoversPosition:
                    writer = new PositionInfoWriter();
                    break;
                case WritingElements.GetRoversCommand:
                    writer = new MovementCommandsWriter();
                    break;
                default:
                    writer = null;
                    break;
            }

            return writer;
        }

        public static IReader GetReader(ReaderElements readerElements)
        {
            IReader reader;

            switch (readerElements)
            {
                case ReaderElements.Standard:
                    reader = new Reader();
                    break;
                default:
                    reader = null;
                    break;
            }

            return reader;
        }
    }
}
