using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VRising.Models.Containers;
using VRising.Models.Gatherables;
using VRising.Models.Helpers;
using VRising.Models.Npcs;

namespace VRising.Models.UnitLocations.Models;

public class UnitCoords
{
    public int UnitId { get; set; }
    public string PrefabName { get; set; }
    public string MainCategory { get; set; }
    public string UnitCategory { get; set; }
    public string MaterialCategory { get; set; }
    public List<Coords> Coords { get; set; } = new List<Coords>();

    public Point Center
    {
        get
        {
            var x = Coords.Average(c => c.X);
            var z = Coords.Average(c => c.Z);
            return new Point((int)x, (int)z);
        }
    }

    private List<Coords> _reducedCoords;
    public List<Coords> ReducedCoords => _reducedCoords ??= GetReducedCoords();

    private List<Coords> GetReducedCoords()
    {
        var distance = Coords.Count / 10;

        var result = new List<Coords>();
        foreach (var coord in Coords)
        {
            if (result.Any(r => r.Distance(coord) < 30))
            {
                continue;
            }
            result.Add(coord);
        }
        return result;
    }
}