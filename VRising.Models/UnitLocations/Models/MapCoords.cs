using System;
using VRising.Localization;
using VRising.Models.Containers;
using VRising.Models.Entities;
using VRising.Models.Enums;
using VRising.Models.Fishing;
using VRising.Models.Gatherables;
using VRising.Models.Helpers;
using VRising.Models.Npcs;

namespace VRising.Models.UnitLocations.Models;

public class MapCoords
{
    public MapCoords(int unitId, int x, int y)
    {
        UnitId = unitId;
        X = x;
        Y = y;
    }

    public int UnitId { get; }
    public int X { get; }
    public int Y { get; }

    public NpcModel Npc => Database.Current.Npcs.GetOrNull(UnitId);
    public GatherableModel Gatherable => Database.Current.Gatherables.GetOrNull(UnitId);
    public ContainerModel Container => Database.Current.Containers.GetOrNull(UnitId);
    public FishingSpotModel FishingSpot => Database.Current.FishingSpots.GetOrNull(UnitId);

    public MapMarker GetMapMarker(Language language)
    {
        if (Npc != null)
        {
            return MapMarker.FromNpc(language, Npc);
        }
        if (Gatherable != null)
        {
            return MapMarker.FromGatherable(language, Gatherable);
        }
        if (Container != null)
        {
            return MapMarker.FromContainer(language, Container);
        }

        if (FishingSpot != null)
        {
            return MapMarker.FromFishingSpot(language, FishingSpot);
        }
        return new MapMarker{MapIconType = MapIconType.FontAwesome, Icon = "question", Title = string.Empty};
    }
}

public class MapMarker
{
    public MapIconType MapIconType { get; set; }
    public string Icon { get; set; }
    public string Title { get; set; }
    public string Color { get; set; }

    public static MapMarker FromNpc(Language language, NpcModel model)
    {
        var marker= new MapMarker
        {
            MapIconType = MapIconType.FontAwesome ,
            Icon = "skull",
            Title = model.LocalizedName.Translate(language),
            Color = "red"
        };
        return marker;
    }

    public static MapMarker FromContainer(Language language, ContainerModel model)
    {
        var marker= new MapMarker
        {
            MapIconType = MapIconType.FontAwesome ,
            Icon = "briefcase",
            Title = model.LocalizedName.Text,
            Color = "goldenrod"
        };
        return marker;
    }

    public static MapMarker FromGatherable(Language language, GatherableModel model)
    {
        var marker= new MapMarker
        {
            MapIconType = MapIconType.FontAwesome ,
            Icon = "gem",
            Title = model.LocalizedName.Text,
            Color = "blue"
        };
        return marker;
    }

    public static MapMarker FromFishingSpot(Language language, FishingSpotModel model)
    {
        var marker= new MapMarker
        {
            MapIconType = MapIconType.FontAwesome ,
            Icon = "fish",
            Title = model.LocalizedName.Text,
            Color = "silver"
        };
        return marker;
    }
}

public enum MapIconType
{
    Asset,
    FontAwesome
}