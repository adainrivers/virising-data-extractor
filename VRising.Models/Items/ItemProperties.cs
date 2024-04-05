using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Abilities;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Recipes;
using VRising.Models.UnitLocations.Models;

namespace VRising.Models.Items
{
    internal class ItemProperties
    {
        private readonly ItemModel _model;


        public Lazy<bool> Obtainable { get; }
        public Lazy<List<RecipeModel>> CraftingRecipes { get; }
        public Lazy<List<RecipeModel>> VendorRecipes { get; }
        public Lazy<List<RecipeModel>> UsedInRecipes { get; }
        public Lazy<List<UnitItemDropChance>> DroppedBy { get; }
        public Lazy<List<UnitItemDropChance>> GatheredFrom { get; }
        public Lazy<List<UnitItemDropChance>> ContainedIn { get; }
        public Lazy<List<UnitItemDropChance>> FishedFrom { get; }
        public Lazy<List<AbilityGroupModel>> Abilities { get; }
        public Lazy<List<UnlockSource>> UnlockSources { get; }
        public Lazy<string> Type { get; }
        public Lazy<int> Rarity { get; }
        public Lazy<int?> GearLevel { get; }
        public Lazy<RecipeModel> SalvageRecipe { get; }
        public Lazy<bool> Display { get; }
        public Lazy<HashSet<MapCoords>> DropLocations { get; }


        internal ItemProperties(ItemModel model)
        {
            _model = model;

            Obtainable = new Lazy<bool>(IsObtainable);
            CraftingRecipes = new Lazy<List<RecipeModel>>(GetCraftingRecipes);
            VendorRecipes = new Lazy<List<RecipeModel>>(GetVendorRecipes);
            UsedInRecipes = new Lazy<List<RecipeModel>>(GetUsedInRecipes);
            Type = new Lazy<string>(GetItemType);
            DroppedBy = new Lazy<List<UnitItemDropChance>>(() => GetUnitItemDropChances(DropTriggerType.OnDeath));
            GatheredFrom = new Lazy<List<UnitItemDropChance>>(() => GetUnitItemDropChances(DropTriggerType.YieldResourceOnDamageTaken));
            ContainedIn = new Lazy<List<UnitItemDropChance>>(() => GetUnitItemDropChances(DropTriggerType.OnSpawnDropInInventory));
            FishedFrom = new Lazy<List<UnitItemDropChance>>(() => GetUnitItemDropChances(DropTriggerType.OnSalvageDestroy));
            Abilities = new Lazy<List<AbilityGroupModel>>(GetAbilities);
            UnlockSources = new Lazy<List<UnlockSource>>(GetUnlockSources);
            Rarity = new Lazy<int>(GetRarity);
            GearLevel = new Lazy<int?>(GetGearLevel);
            SalvageRecipe = new Lazy<RecipeModel>(GetSalvageRecipe);
            Display = new Lazy<bool>(GetDisplay);
            DropLocations = new Lazy<HashSet<MapCoords>>(GetDropLocations);

        }

        private HashSet<MapCoords> GetDropLocations()
        {
            return _model.DropChances.SelectMany(dc => dc.Coords).ToHashSet(new MapCoordsComparer());
        }

        private bool GetDisplay()
        {
            if (_model.LocalizedName.Text == null) return false;
            if (Guid.TryParse(_model.LocalizedName.Text, out _)) return false;
            //if (_model.Description == null || Guid.TryParse(_model.Description, out _)) return false;

            if (_model.PrefabName.EndsWith("_Base") || _model.PrefabName.EndsWith("_StartingRags") || _model.PrefabName.EndsWith("_HunterRaiment") || _model.PrefabName.EndsWith("_Debug") || _model.PrefabName.Contains("_Hair"))
            {
                return false;
            }

            if (_model.ItemType == ItemType.OrbOfKnowledge && _model.ItemId != -950359691)
            {
                return false;
            }

            if (_model.ItemType == ItemType.Memory)
            {
                return false;
            }

            return true;
        }

        private RecipeModel GetSalvageRecipe()
        {
            if (!_model.Salvageable)
            {
                return null;
            }

            var salvageRecipe = Database.Current.Recipes.GetOrNull(_model.SalvageRecipeGuidHash);
            if (salvageRecipe != null)
            {
                return salvageRecipe;
            }

            if (_model.FakeSalvageRecipe != null)
            {
                return _model.FakeSalvageRecipe;
            }

            if (_model.CraftingRecipes.Count == 1)
            {
                return _model.CraftingRecipes[0];
            }

            return null;
        }

        private int? GetGearLevel()
        {
            if (_model.ItemType != ItemType.Equippable)
            {
                return null;
            }

            switch (_model.EquipmentType)
            {
                case EquipmentType.Chest:
                case EquipmentType.Footgear:
                case EquipmentType.Gloves:
                case EquipmentType.Legs:
                    return (int)Math.Ceiling(_model.ArmorLevelSource / 10);
                case EquipmentType.Weapon:
                    return (int)Math.Ceiling(_model.WeaponLevelSource * 3 / 10);
                case EquipmentType.MagicSource:
                    return (int)Math.Ceiling(_model.SpellLevelSource * 3 / 10);
                case EquipmentType.OLDClothLegs:
                case EquipmentType.OLDClothChest:
                    return null;
                case EquipmentType.Headgear:
                    return null;
                case EquipmentType.Cloak:
                    return null;
                case EquipmentType.None:
                    return null;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private int GetRarity()
        {
            if (_model.ItemType != ItemType.Equippable)
            {
                return 0;
            }

            switch (_model.EquipmentType)
            {
                case EquipmentType.Chest:
                case EquipmentType.Footgear:
                case EquipmentType.Gloves:
                case EquipmentType.Legs:
                    if (_model.GearLevel <= 1)
                    {
                        return 0;
                    }

                    if (_model.GearLevel >= 2 && _model.GearLevel <= 3)
                    {
                        return 1;
                    }

                    if (_model.GearLevel >= 4 && _model.GearLevel <= 6)
                    {
                        return 2;
                    }

                    if (_model.GearLevel >= 7 && _model.GearLevel <= 8)
                    {
                        return 3;
                    }

                    if (_model.GearLevel >= 9)
                    {
                        return 4;
                    }

                    break;
                case EquipmentType.Weapon:
                case EquipmentType.MagicSource:

                    if (_model.GearLevel <= 3)
                    {
                        return 0;
                    }

                    if (_model.GearLevel >= 6 && _model.GearLevel <= 9)
                    {
                        return 1;
                    }

                    if (_model.GearLevel >= 12 && _model.GearLevel <= 18)
                    {
                        return 2;
                    }

                    if (_model.GearLevel >= 21 && _model.GearLevel <= 24)
                    {
                        return 3;
                    }

                    if (_model.GearLevel >= 27)
                    {
                        return 4;
                    }

                    break;
                case EquipmentType.OLDClothLegs:
                case EquipmentType.OLDClothChest:
                case EquipmentType.Headgear:
                case EquipmentType.Cloak:
                case EquipmentType.None:
                    return 0;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return 0;
        }

        private List<UnlockSource> GetUnlockSources()
        {
            if (!_model.CanBeCrafted)
            {
                return null;
            }

            var result = _model.CraftingRecipes
                .Select(r => r.Id)
                .Where(rid => Database.Current.UnlockSources.ContainsKey(rid))
                .SelectMany(rid => Database.Current.UnlockSources[rid]).ToList();

            return result.Count > 0 ? result : null;
        }

        private List<AbilityGroupModel> GetAbilities()
        {
            return Database.Current.Buffs.TryGetValue(_model.EquipmentBuffGuidHash, out var buff)
                ? buff.AbilityIds.Where(aid => Database.Current.AbilityGroups.ContainsKey(aid))
                    .Select(aid => Database.Current.AbilityGroups[aid]).ToList()
                : new List<AbilityGroupModel>();
        }

        private List<UnitItemDropChance> GetUnitItemDropChances(DropTriggerType dropTrigger)
        {
            return _model.DropChances.Where(dc => dc.DropTrigger == dropTrigger).ToList();
        }

        private List<RecipeModel> GetUsedInRecipes()
        {
            return Database.Current.Recipes.Values
                .Where(r => r.Requirements.Any(o => o.ItemGuidHash == _model.ItemId)).ToList();
        }

        private string GetItemType()
        {
            switch (_model.ItemType)
            {
                case ItemType.Stackable:
                case ItemType.Consumable:
                case ItemType.Memory:
                case ItemType.Tech:
                case ItemType.OrbOfKnowledge:
                case ItemType.VBloodEssence:
                case ItemType.ItemBuilding:
                    return _model.ItemType.ToString();
                case ItemType.Equippable:
                    switch (_model.EquipmentType)
                    {
                        case EquipmentType.Headgear:
                        case EquipmentType.Footgear:
                        case EquipmentType.Cloak:
                        case EquipmentType.Gloves:
                        case EquipmentType.Legs:
                        case EquipmentType.Chest:
                            return _model.EquipmentType.ToString();
                        case EquipmentType.Weapon:
                            return _model.WeaponType.ToString();
                        case EquipmentType.MagicSource:
                            return "Magic Source";
                        case EquipmentType.OLDClothLegs:
                        case EquipmentType.OLDClothChest:
                        case EquipmentType.None:
                            return string.Empty;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private List<RecipeModel> GetVendorRecipes()
        {
            return Database.Current.Recipes.Values
                .Where(r => r.Outputs.Any(o => o.ItemGuidHash == _model.ItemId)
                            && r.Requirements.All(req => req.ItemGuidHash == KnownEntities.ItemSilverCoin) && r.Workstations.Any(w => w.Trader != null))
                .ToList();
        }

        private List<RecipeModel> GetCraftingRecipes()
        {
            return Database.Current.Recipes.Values
                .Where(r => r.Outputs.Any(o => o.ItemGuidHash == _model.ItemId)
                            && r.Requirements.All(req => req.ItemGuidHash != KnownEntities.ItemSilverCoin))
                .ToList();
        }

        private bool IsObtainable()
        {
            return Obtainables.Items.Contains(_model.ItemId) || _model.HasSources || (_model.CanBeCrafted && _model.CraftingRecipes.Any(r => r.Requirements.All(rq => rq.Item.Obtainable))) || _model.CanBeBought;
        }
    }
}
