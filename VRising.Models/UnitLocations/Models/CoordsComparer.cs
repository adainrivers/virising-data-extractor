using System;
using System.Collections.Generic;

namespace VRising.Models.UnitLocations.Models;

public class CoordsComparer : IEqualityComparer<Coords>
{
    public bool Equals(Coords first, Coords second)
    {
        if (ReferenceEquals(first, second)) return true;
        if (ReferenceEquals(first, null)) return false;
        if (ReferenceEquals(second, null)) return false;
        if (first.GetType() != second.GetType()) return false;
        return first.X.Equals(second.X) && first.Y.Equals(second.Y) && first.Z.Equals(second.Z);
    }

    public int GetHashCode(Coords obj)
    {
        return HashCode.Combine(obj.X, obj.Y, obj.Z);
    }
}

public class CoordsDistanceComparer : IEqualityComparer<Coords>
{
    private readonly Random _rnd;

    public CoordsDistanceComparer()
    {
        _rnd = new Random();
    }
    public bool Equals(Coords first, Coords second)
    {
        if (ReferenceEquals(first, second)) return true;
        if (ReferenceEquals(first, null)) return false;
        if (ReferenceEquals(second, null)) return false;
        if (first.GetType() != second.GetType()) return false;
        return first.Distance(second) < 10;
    }

    public int GetHashCode(Coords obj)
    {
        return _rnd.Next(int.MinValue, int.MaxValue);
    }
}