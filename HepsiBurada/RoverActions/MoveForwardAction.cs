using HepsiBurada.Helpers.ExceptionHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.RoverActions
{
    public class MoveForwardAction : IAction
    {
        public void Action(Rover rover)
        {
            if (rover.dir == "N")
            {
                if (rover.area.dimY == rover.yPos)
                    throw new MovementException("You are reached the edge of area in y direction");
                rover.yPos++;
            }
            else if (rover.dir == "E")
            {
                if (rover.area.dimX == rover.xPos)
                    throw new MovementException("You are reached the edge of area in x direction");
                rover.xPos++;
            }
            else if (rover.dir == "S")
            {
                if (rover.yPos == 0)
                    throw new MovementException("You are reached the edge of area in y direction");
                rover.yPos--;
            }
            else if (rover.dir == "W")
            {
                if (rover.xPos == 0)
                    throw new MovementException("You are reached the edge of area in x direction");
                rover.xPos--;
            }
        }
    }
}
