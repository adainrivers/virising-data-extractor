using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Items;
using VRising.Models.Localization;
using VRising.Models.Npcs;
using VRising.Models.RootModels;

namespace VRising.Models.Abilities;

public class AbilityGroupModel : ModelBase, IModel
{
    private double? _maxCastTime;
    private double? _maxCooldown;

    public RisingEntity Entity { get; set; }

    public int AbilityGroupId { get; set; }
    public List<AbilityCastConditionModel> AbilityCastConditions { get; set; }
    public List<int> AbilityIds { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public AbilityTypeEnum? AbilityType { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    public AbilitySchoolType? AbilitySchool { get; set; }

    public WeaponType? WeaponType { get; set; }

    public List<ItemModel> Items { get; set; } = new();

    public double? MaxCooldown
    {
        get
        {
            if (_maxCooldown == null && Abilities.Any()) _maxCooldown = Abilities[0]._maxCooldown;
            return _maxCooldown;
        }
        set => _maxCooldown = value;
    }

    public double? MaxCastTime
    {
        get
        {
            if (_maxCastTime == null && Abilities.Any()) _maxCastTime = Abilities[0]._maxCastTime;
            return _maxCastTime;
        }
        set => _maxCastTime = value;
    }

    public bool? HideCastBar { get; set; }

    public double? PostCastTime { get; set; }

    public double? TotalCastTime { get; set; }

    public int? MaxCharges { get; internal set; }

    public bool? IgnoreCooldownModifier { get; set; }

    public double? ChargeUpTime { get; set; }

    public int? ConsumableItemId { get; set; }

    public List<AbilityGroupModel> Abilities
    {
        get
        {
            return AbilityIds.Where(id => Database.Current.AbilityGroups.ContainsKey(id))
                .Select(id => Database.Current.AbilityGroups[id]).ToList();
        }
    }

    public List<NpcModel> CastByUnits
    {
        get
        {
            if (Database.Current.Mappings.AbilityGroupUnitMap.TryGetValue(AbilityGroupId, out var unitIds))
                return unitIds.Where(uid => Database.Current.Npcs.ContainsKey(uid))
                    .Select(uid => Database.Current.Npcs[uid])
                    .ToList();

            return new List<NpcModel>();
        }
    }

    public AbilityTooltipType? ToolTipType { get; set; }
    public bool IsAbilityGroup { get; set; }

    [JsonIgnore]
    public List<UnlockSource> UnlockSources => Database.Current.UnlockSources.ContainsKey(AbilityGroupId)
        ? Database.Current.UnlockSources[AbilityGroupId]
        : null;

    public LocalizedResource LocalizedDescription { get; set; }
    public string PrefabName { get; set; }
    public string BasePath => BasePaths.AbilityGroups;

    public int Id => AbilityGroupId;
    public int Rarity => 0;

    public string Icon { get; set; }

    public LocalizedResource LocalizedName { get; set; }
}