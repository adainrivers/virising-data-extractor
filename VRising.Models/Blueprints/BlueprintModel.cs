using System.Collections.Generic;
using Newtonsoft.Json;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.RootModels;

namespace VRising.Models.Blueprints;

public class BlueprintModel : ModelBase, IModel
{
    public RisingEntity Entity { get; set; }

    public int BlueprintId { get; set; }
    public BlueprintType Type { get; set; }
    public CastleLimitedType LimitedType { get; set; }
    public bool IsStartBlueprint { get; set; }
    public bool IsInventoryItemBuilding { get; set; }

    public float Health { get; set; }
    public List<ItemStacks> Requirements { get; set; }

    [JsonIgnore]
    public List<UnlockSource> UnlockSources => Database.Current.UnlockSources.ContainsKey(BlueprintId)
        ? Database.Current.UnlockSources[BlueprintId]
        : null;

    public LocalizedResource LocalizedDescription { get; set; }

    public int Id => BlueprintId;

    public int Rarity => 0;
    public string Icon { get; set; }
    public string PrefabName { get; set; }

    public string BasePath => BasePaths.Blueprints;
    public LocalizedResource LocalizedName { get; set; }
}