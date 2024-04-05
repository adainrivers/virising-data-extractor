using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using VRising.Localization;
using VRising.Models.Constants;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Internal;
using VRising.Models.Items;
using VRising.Models.Localization;
using VRising.Models.RootModels;
using VRising.Models.Stations;

namespace VRising.Models.Recipes
{
    public class RecipeModel : ModelBase, IModel
    {
        public RisingEntity Entity { get; set; }

        public int RecipeId { get; set; }
        public float CraftDuration { get; set; }
        public bool AlwaysUnlocked { get; set; }
        public int HudSortingOrder { get; set; }
        public bool IgnoreServerSettings { get; set; }
        public List<ItemStacks> RepairCosts { get; set; }
        public List<ItemStacks> Requirements { get; set; }
        public List<ItemStacks> Outputs { get; set; }
        public List<ItemStacks> OutputUnits { get; set; }

        [JsonIgnore]
        public ItemModel OutputItem
        {
            get
            {
                if (Outputs.Count == 0)
                {
                    return new ItemModel();
                }

                return Outputs[^1].Item;
            }
        }

        public string PrefabName { get; set; }

        [JsonIgnore]
        public string Icon => OutputItem?.Icon;

        [JsonIgnore]
        public List<WorkstationModel> Workstations
        {
            get
            {
                return Database.Current.Workstations.Values.Where(w => w.WorkstationRecipeIds.Contains(RecipeId) || w.RefinementRecipeIds.Contains(RecipeId)).ToList();
            }
        }

        [JsonIgnore]
        public bool IsValid
        {
            get
            {
                if (PrefabName == null || OutputItem?.LocalizedName.Text == null || OutputItem.Icon == null || Requirements.Count == 0)
                {
                    return false;
                }

                return true;
            }
        }

        public bool Display
        {
            get
            {
                return Workstations.Any(w =>
                    w.WorkstationType == WorkstationType.Player ||
                    w.WorkstationType == WorkstationType.RefinementStation ||
                    w.WorkstationType == WorkstationType.Workstation ||
                    w.WorkstationType == WorkstationType.UnitSpawner);
            }
        }

        [JsonIgnore]
        public List<UnlockSource> UnlockSources => Database.Current.UnlockSources.ContainsKey(RecipeId) ?
            Database.Current.UnlockSources[RecipeId] :
            null;

        public int Id => RecipeId;

        public int Rarity => OutputItem?.Rarity ?? 0;

        public string BasePath => BasePaths.Recipe;
        public LocalizedResource LocalizedName => OutputItem.LocalizedName;
    }
}