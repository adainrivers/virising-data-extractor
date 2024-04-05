using System;
using System.Collections.Generic;
using VRising.Models.Enums;

namespace VRising.Models.UnitLocations.Models;

public class Coords
{
    public Coords(float x, float y, float z)
    {
        X = (int)Math.Round(x);
        Y = (int)Math.Round(y);
        Z = (int)Math.Round(z);
        //Seen = DateTime.UtcNow;
    }

    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }
    //public DateTime Seen { get; set; }
    //public string ChunkName { get; set; }
    public Dictionary<int, DropTriggerType> DropTables = new Dictionary<int, DropTriggerType>();

    public double Distance(Coords other)
    {
        return Math.Sqrt(Math.Pow((X - other.X), 2) + Math.Pow((Z - other.Z), 2));
    }
}