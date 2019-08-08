using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.RoverActions
{
    public class Rover
    {
        public Area area { get; set; }
        public int xPos { get; set; }
        public int yPos { get; set; }
        public string dir { get; set; }

        public Rover(int _xPos, int _yPos, string _dir, Area _area)
        {
            xPos = _xPos;
            yPos = _yPos;
            dir = _dir;
            area = _area; 
        }

        public override string ToString() => $"Current rover position is {xPos} {yPos} {dir}.";
    }
}
