using System.Collections.Generic;
using System.Linq;

namespace VRising.Models.UnitLocations.Models;

public class MapData
{
    public MapData(UnitCoords unitCoords)
    {
        Coords = unitCoords.ReducedCoords.Select(c => new MapCoords(unitCoords.UnitId, c.X, c.Z)).ToHashSet(new MapCoordsComparer());
    }

    public MapData(HashSet<MapCoords> coords)
    {
        Coords = coords;
    }

    public HashSet<MapCoords> Coords { get; set; }
    private MapCoords _center;
    public MapCoords Center => _center ??= GetCenter();

    private MapCoords GetCenter()
    {
        var x = (int)Coords.Average(c => c.X);
        var y = (int)Coords.Average(c => c.Y);
        return new MapCoords(0, x, y);
    }
}