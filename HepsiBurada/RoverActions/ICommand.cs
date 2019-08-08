using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.RoverActions
{
    public interface ICommand
    {
        void ExecuteAction();
        string GetActionName();
    }
}
