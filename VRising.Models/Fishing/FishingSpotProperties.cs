﻿using System;
using System.Collections.Generic;
using VRising.Models.Enums;

namespace VRising.Models.Fishing;

internal class FishingSpotProperties
{
    private readonly FishingSpotModel _model;

    public Lazy<Dictionary<int, DropTriggerType>> DropTables { get; }
    //public Lazy<Dictionary<int, List<string>>> DropTableLocationsMap { get; }

    internal FishingSpotProperties(FishingSpotModel model)
    {
        _model = model;
        DropTables = new Lazy<Dictionary<int, DropTriggerType>>(GetDropTables);
        //DropTableLocationsMap = new Lazy<Dictionary<int, List<string>>>(GetDropTableLocations);
    }

    //private Dictionary<int, List<string>> GetDropTableLocations()
    //{
    //    var result = new Dictionary<int, HashSet<string>>();
    //    foreach (var coord in _model.UnitCoords.Coords)
    //    {
    //        foreach (var (dropTableId, trigger) in coord.DropTables)
    //        {
    //            if (!result.ContainsKey(dropTableId))
    //            {
    //                result[dropTableId] = new HashSet<string>();
    //            }

    //            result[dropTableId].Add(PrefabNameCleaner.GetName(coord.ChunkName));
    //        }
    //    }

    //    return result.ToDictionary(r => r.Key,
    //        r => r.Value.OrderBy(p => p).ToList());
    //}

    private Dictionary<int, DropTriggerType> GetDropTables()
    {
        var result = new Dictionary<int, DropTriggerType>();
        if (_model.UnitCoords == null)
        {
            return result;
        }
        foreach (var unitCoordsCoord in _model.UnitCoords.Coords)
        {
            foreach (var (dropTableId, triggerType) in unitCoordsCoord.DropTables)
            {
                result[dropTableId] = triggerType;
            }
        }
        return result;
    }
}