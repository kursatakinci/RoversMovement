using HepsiBurada.Helpers.ExceptionHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HepsiBurada.RoverActions
{
    public class ModifyRoversPosition
    {
        private List<ICommand> _commands;
        private ICommand _command;

        public ModifyRoversPosition()
        {
            _commands = new List<ICommand>();
        }

        public void SetCommand(ICommand command) => _command = command;

        public void Invoke()
        {
            _commands.Add(_command);
            try
            {
                _command.ExecuteAction();
            }
            catch (MovementException mEx)
            {
                throw new MovementException(ExceptionHelper.GetExceptionMessage(mEx) + Environment.NewLine + $"Applied actions on rover are {string.Join(",", _commands.Take(_commands.Count - 1).Select(c => c.GetActionName()))}.");
            }
        }
    }
}
