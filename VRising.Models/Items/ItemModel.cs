using System.Collections.Generic;
using System.Linq;
using VRising.Models.Abilities;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Localization;
using VRising.Models.Recipes;
using VRising.Models.RootModels;
using VRising.Models.UnitLocations.Models;

namespace VRising.Models.Items;

public class ItemModel : ModelBase, IModel
{
    private readonly ItemProperties _properties;


    public ItemModel()
    {
        _properties = new ItemProperties(this);
    }

    public List<AbilityGroupModel> Abilities => _properties.Abilities.Value;
    public float ArmorLevelSource { get; set; }
    public bool BloodBound { get; set; }
    public bool CanBeBought => VendorRecipes != null && VendorRecipes.Count > 0;
    public bool CanBeCrafted => CraftingRecipes != null && CraftingRecipes.Count > 0;
    public int ConsumableAbilityId { get; set; }
    public List<UnitItemDropChance> ContainedIn => _properties.ContainedIn.Value;
    public List<RecipeModel> CraftingRecipes => _properties.CraftingRecipes.Value;
    public List<UnitItemDropChance> DropChances { get; set; } = new();
    public List<UnitItemDropChance> DroppedBy => _properties.DroppedBy.Value;
    public List<UnitItemDropChance> FishedFrom => _properties.FishedFrom.Value;
    public RisingEntity Entity { get; set; }
    public int EquipmentBuffGuidHash { get; set; }
    public int EquipmentSetGuidHash { get; set; }
    public EquipmentType EquipmentType { get; set; }
    public List<UnitItemDropChance> GatheredFrom => _properties.GatheredFrom.Value;
    public int? GearLevel => _properties.GearLevel.Value;
    public bool HasSources => DropChances != null && DropChances.Count > 0;
    public ItemCategory ItemCategory { get; set; }
    public int ItemId { get; set; }

    public ItemSetModel ItemSet => Database.Current.ItemSets.ContainsKey(EquipmentSetGuidHash)
        ? Database.Current.ItemSets[EquipmentSetGuidHash]
        : null;

    public ItemType ItemType { get; set; }
    public MapInfo MapInfo { get; set; }
    public float MaxDurability { get; set; }
    public int MaxStacks { get; set; }

    public bool Obtainable => _properties.Obtainable.Value;
    public bool RemoveOnConsume { get; set; }
    public float RepairOneLevelFactor { get; set; }

    public RecipeModel RepairRecipe => Database.Current.Recipes.ContainsKey(RepairRecipeGuidHash)
        ? Database.Current.Recipes[RepairRecipeGuidHash]
        : null;

    public int RepairRecipeGuidHash { get; set; }
    public float RepairThreeLevelFactor { get; set; }
    public float RepairTwoLevelFactor { get; set; }
    public bool Salvageable { get; set; }
    public float SalvageFactor { get; set; }
    public RecipeModel SalvageRecipe => _properties.SalvageRecipe.Value;
    public int SalvageRecipeGuidHash { get; set; }
    public float SalvageTimer { get; set; }
    public float SilverValue { get; set; }
    public bool SoulBound { get; set; }
    public float SpellLevelSource { get; set; }
    public TechUnlocks TechUnlocks { get; set; }
    public string Type => _properties.Type.Value;
    public List<UnitStatModification> UnitStatModifications { get; set; }
    public List<UnlockSource> UnlockSources => _properties.UnlockSources.Value;
    public List<RecipeModel> UsedInRecipes => _properties.UsedInRecipes.Value;
    public int VBloodSourceUnitId { get; set; }
    public List<RecipeModel> VendorRecipes => _properties.VendorRecipes.Value;
    public float WeaponLevelSource { get; set; }
    public WeaponType WeaponType { get; set; }
    public RecipeModel FakeSalvageRecipe { get; set; }

    public bool Display => _properties.Display.Value;
    public LocalizedResource LocalizedDescription { get; set; }
    public string PrefabName { get; set; }
    public string BasePath => BasePaths.Item;


    public string Icon { get; set; }
    public int Id => ItemId;
    public int Rarity => _properties.Rarity.Value;
    public LocalizedResource LocalizedName { get; set; }


    public HashSet<MapCoords> DropLocations => _properties.DropLocations.Value;


    //public List<DropTableModel> DropTables => Database.Current.Mappings.ItemDropTableMap.ContainsKey(ItemId)
    //    ? Database.Current.Mappings.ItemDropTableMap[ItemId].Select(dtid => Database.Current.DropTables[dtid])
    //        .ToList()
    //    : new List<DropTableModel>();
}