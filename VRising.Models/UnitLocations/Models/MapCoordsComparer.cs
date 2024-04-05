using System;
using System.Collections.Generic;

namespace VRising.Models.UnitLocations.Models;

public class MapCoordsComparer : IEqualityComparer<MapCoords>
{
    public bool Equals(MapCoords x, MapCoords y)
    {
        if (ReferenceEquals(x, y)) return true;
        if (ReferenceEquals(x, null)) return false;
        if (ReferenceEquals(y, null)) return false;
        if (x.GetType() != y.GetType()) return false;
        return x.UnitId == y.UnitId && x.X == y.X && x.Y == y.Y;
    }

    public int GetHashCode(MapCoords obj)
    {
        return HashCode.Combine(obj.UnitId, obj.X, obj.Y);
    }
}