using System;
using System.Collections.Generic;
using System.Text;

namespace HepsiBurada.RoverActions
{
    public class Area
    {
        public int dimX { get; set; }
        public int dimY { get; set; }

        public Area(int x, int y)
        {
            dimX = x;
            dimY = y;
        }


        public override string ToString() => $"Current area dimensions is {dimX} {dimY}.";
    }
}
