using System.Collections.Generic;
using System.Linq;
using VRising.Models.Enums;

namespace VRising.Models.Recipes
{
    public class DatabaseRecipes : DatabaseDictionary<RecipeModel>
    {
        private static DatabaseRecipes _instance;
        public static DatabaseRecipes Instance => _instance ??= new DatabaseRecipes();

        public List<RecipeModel> Weapons { get; set; }
        public List<RecipeModel> Armors { get; set; }
        public List<RecipeModel> MagicSources { get; set; }
        public List<RecipeModel> Consumables { get; set; }
        public List<RecipeModel> Ingredients { get; set; }
        public List<RecipeModel> Other { get; set; }

        private DatabaseRecipes()
        {
            var builder = new RecipeModelBuilder();
            Populate(Database.Current.ComponentTypeToEntitiesMap["RecipeData"], builder.Build, r => r.LocalizedName != null);

            //var validRecipes = Values.Where(i =>
            //        i.Workstations.Any(w =>
            //            w.WorkstationType == WorkstationType.Workstation ||
            //            w.WorkstationType == WorkstationType.RefinementStation ||
            //            w.WorkstationType == WorkstationType.Player))
            //    .ToList();

            var validRecipes = Values.Where(r => r.Display).ToList();


            Weapons = validRecipes.Where(i => i.OutputItem.EquipmentType == EquipmentType.Weapon)
                .OrderBy(i => i.LocalizedName.Text)
                .ToList();

            Armors = validRecipes
                .Where(i => i.OutputItem.ItemType == ItemType.Equippable &&
                            i.OutputItem.ItemCategory.HasFlag(ItemCategory.Armor))
                .OrderBy(i => i.LocalizedName.Text)
                .ToList();

            MagicSources = validRecipes
                .Where(i => i.OutputItem.ItemType == ItemType.Equippable &&
                            i.OutputItem.EquipmentType == EquipmentType.MagicSource)
                .OrderBy(i => i.LocalizedName.Text)
                .ToList();

            Consumables = validRecipes
                .Where(i => i.OutputItem.ItemType == ItemType.Consumable).OrderBy(i => i.LocalizedName.Text).ToList();

            Ingredients = validRecipes
                .Where(i => i.OutputItem.ItemType == ItemType.Stackable && i.PrefabName.Contains("Ingredient"))
                .OrderBy(i => i.LocalizedName.Text).ToList();

            Other = validRecipes
                .Where(i =>
                    i.OutputItem.ItemType != ItemType.Equippable &&
                    i.OutputItem.ItemType != ItemType.Tech &&
                    i.OutputItem.ItemType != ItemType.Consumable &&
                    !(i.OutputItem.ItemType == ItemType.Stackable && i.PrefabName.Contains("Ingredient")))
                .OrderBy(i => i.LocalizedName.Text).ToList();

        }
    }
}
