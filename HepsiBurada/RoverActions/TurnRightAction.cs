using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.RoverActions
{
    public class TurnRightAction : IAction
    {
        public void Action(Rover rover)
        {
            if (rover.dir == "N")
                rover.dir = "E";
            else if (rover.dir == "E")
                rover.dir = "S";
            else if (rover.dir == "S")
                rover.dir = "W";
            else if (rover.dir == "W")
                rover.dir = "N";
        }
    }
}
