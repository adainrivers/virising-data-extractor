using System.Collections.Generic;
using System.Linq;
using VRising.Models.Enums;

namespace VRising.Models.Items
{
    public class DatabaseItems : DatabaseDictionary<ItemModel>
    {
        private static DatabaseItems _instance;

        private DatabaseItems()
        {
            var builder = new ItemModelBuilder();
            Populate(Database.Current.ComponentTypeToEntitiesMap["ItemData"], builder.Build);
            SetProperties();
        }

        public List<ItemModel> Armors { get; set; }
        public List<ItemModel> Books { get; set; }
        public List<ItemModel> Cloaks { get; set; }
        public List<ItemModel> Consumables { get; set; }
        public List<ItemModel> Headgear { get; set; }
        public List<ItemModel> Ingredients { get; set; }
        public static DatabaseItems Instance => _instance ??= new DatabaseItems();
        public List<ItemModel> MagicSources { get; set; }
        public List<ItemModel> Other { get; set; }
        public List<ItemModel> Weapons { get; set; }

        private void SetProperties()
        {
            var displayItems = Values.Where(i => i.Display).ToList();

            Weapons = displayItems.Where(i => i.EquipmentType == EquipmentType.Weapon)
                .OrderByDescending(i => i.Rarity).ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text)
                .ToList();

            Armors = displayItems
                .Where(i => i.ItemType == ItemType.Equippable && i.ItemCategory.HasFlag(ItemCategory.Armor) &&
                            i.EquipmentType != EquipmentType.Headgear && i.EquipmentType != EquipmentType.Cloak)
                .OrderByDescending(i => i.Rarity).ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text)
                .ToList();

            Cloaks = displayItems
                .Where(i => i.ItemType == ItemType.Equippable && i.ItemCategory.HasFlag(ItemCategory.Armor) &&
                            i.EquipmentType == EquipmentType.Cloak)
                .OrderByDescending(i => i.Rarity).ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text)
                .ToList();

            Headgear = displayItems
                .Where(i => i.ItemType == ItemType.Equippable && i.ItemCategory.HasFlag(ItemCategory.Armor) &&
                            i.EquipmentType == EquipmentType.Headgear)
                .OrderByDescending(i => i.Rarity).ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text)
                .ToList();

            MagicSources = displayItems
                .Where(i => i.ItemType == ItemType.Equippable && i.EquipmentType == EquipmentType.MagicSource)
                .OrderByDescending(i => i.Rarity).ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text)
                .ToList();

            Books = displayItems
                .Where(i => i.ItemType == ItemType.Tech).OrderByDescending(i => i.Rarity)
                .ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text).ToList();

            Consumables = displayItems
                .Where(i => i.ItemType == ItemType.Consumable).OrderByDescending(i => i.Rarity)
                .ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text).ToList();

            Ingredients = displayItems
                .Where(i => i.ItemType == ItemType.Stackable && i.PrefabName.Contains("Ingredient"))
                .OrderByDescending(i => i.Rarity).ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text).ToList();

            Other = displayItems
                .Where(i => i.ItemType != ItemType.Equippable &&
                            i.ItemType != ItemType.Tech &&
                            i.ItemType != ItemType.Consumable &&
                            !(i.ItemType == ItemType.Stackable && i.PrefabName.Contains("Ingredient")))
                .OrderByDescending(i => i.Rarity).ThenByDescending(i => i.GearLevel).ThenBy(i => i.LocalizedName.Text).ToList();
        }
    }
}