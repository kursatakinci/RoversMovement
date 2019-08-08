using HepsiBurada.Helpers.ExceptionHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.RoverActions
{
    public class RoverCommand : ICommand
    {
        private readonly Rover _rover;
        private readonly IAction _action;

        public RoverCommand(Rover rover, IAction action)
        {
            _rover = rover;
            _action = action;
        }

        public string GetActionName()
        {
            return _action.GetType().Name;
        }

        public void ExecuteAction()
        {
            try
            {
                _action.Action(_rover);
            }
            catch (MovementException mEx)
            {
                throw new MovementException(ExceptionHelper.GetExceptionMessage(mEx) + Environment.NewLine + $"Last position of rover is {_rover.xPos} {_rover.yPos} {_rover.dir}.");
            }
        }
    }
}
