using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;

namespace VRising.Models.Drops
{
    public static class ItemDropRateCalculator
    {
        //public const string CopperOrePrefabName = "Item_Ingredient_CopperOre";
        //public const string IronOrePrefabName = "Item_Ingredient_IronOre";
        //public const string LumberPrefabName = "Item_Ingredient_Lumber";
        //public const string StonePrefabName = "Item_Ingredient_Stone";

        private static List<ItemDropChance> CalculateDropRates(DropTableModel dropTable)
        {
            var results = new List<ItemDropChance>();
            foreach (var dropTableEntry in dropTable.Entries)
            {
                switch (dropTableEntry.DropItemType)
                {
                    case DropItemType.Item:
                        results.Add(new ItemDropChance(dropTableEntry.Item.ItemId, dropTableEntry.DropRate,
                            dropTableEntry.Quantity));
                        break;
                    case DropItemType.Group:
                        results.AddRange(TraverseDropGroup(dropTableEntry.DropGroup, dropTableEntry.DropRate,
                            dropTableEntry.Quantity));
                        break;
                        //default:
                        //    throw new NotImplementedException(
                        //        $"We don't know what does DropType.{DropItemType.Npc} means.");
                }
            }

            return results;
        }

        public static void PopulateDropChances()
        {
            foreach (var dropTableModel in Database.Current.DropTables.Values)
            {
                if (dropTableModel.DropTableId == -1863949101)
                {

                }
                dropTableModel.DropChances ??= CalculateDropRates(dropTableModel);
            }

            PopulateItemDropChances();
        }

        private static void PopulateItemDropChances()
        {
            foreach (var dropSourceModel in Database.Current.DropSources.Values)
            {
                //if (Database.Current.Resources.TryGetValue(dropSourceModel.SourceId, out var resourceModel))
                //{
                //    foreach (var dropSourceDropTable in dropSourceModel.DropTables)
                //    {
                //        if (dropSourceDropTable.DropTrigger == DropTriggerType.YieldResourceOnDamageTaken)
                //        {
                //            if (dropSourceDropTable.DropTable.Entries.All(e =>
                //                    e.Item != null && e.Item.PrefabName == LumberPrefabName))
                //            {
                //                resourceModel.Name = "Tree";
                //                break;
                //            }

                //            if (dropSourceDropTable.DropTable.Entries.All(e =>
                //                    e.Item != null && e.Item.PrefabName == StonePrefabName))
                //            {
                //                resourceModel.Name = "Rock";
                //                break;
                //            }

                //            if (dropSourceDropTable.DropTable.Entries.All(e =>
                //                    e.Item != null && e.Item.PrefabName == CopperOrePrefabName))
                //            {
                //                resourceModel.Name = "Copper Vein";
                //                break;
                //            }

                //            if (dropSourceDropTable.DropTable.Entries.All(e =>
                //                    e.Item != null && e.Item.PrefabName == IronOrePrefabName))
                //            {
                //                resourceModel.Name = "Iron Vein";
                //                break;
                //            }
                //        }
                //    }
                //}

                foreach (var dropSourceDropTable in dropSourceModel.DropTables)
                {
                    foreach (var itemDropChance in dropSourceDropTable.DropTable.DropChances)
                    {
                        if (itemDropChance.ItemId == 239338934)
                        {

                        }
                        var item = Database.Current.Items[itemDropChance.ItemId];
                        //if (!item.DropChances.Any(idc=>idc.NpcId == dropSourceModel.SourceId && idc.Quantity == itemDropChance.Quantity && Math.Abs(idc.DropChance - itemDropChance.DropChance) < 0.00001))
                        //{
                        item.DropChances.Add(
                            new UnitItemDropChance(
                                dropSourceModel.SourceId,
                                itemDropChance.ItemId,
                                itemDropChance.DropChance,
                                itemDropChance.Quantity,
                                dropSourceDropTable.DropTrigger,
                                dropSourceDropTable.RelicType,
                                dropSourceDropTable.DropTableId));
                        //}

                    }
                }
            }
        }

        private static List<ItemDropChance> TraverseDropGroup(DropGroupModel dropGroup, float parentDropChance,
            int parentQuantity)
        {
            var totalWeight = dropGroup.Entries.Sum(e => e.Weight);
            var results = new List<ItemDropChance>();
            foreach (var dropGroupEntry in dropGroup.Entries)
            {
                var dropChance = dropGroupEntry.CalculateDropRate(totalWeight) * parentDropChance;
                var quantity = dropGroupEntry.Quantity * parentQuantity;
                switch (dropGroupEntry.DropItemType)
                {
                    case DropItemType.Item:
                        results.Add(new ItemDropChance(dropGroupEntry.Item.ItemId, dropChance, quantity));
                        break;
                    case DropItemType.Group:
                        results.AddRange(TraverseDropGroup(dropGroupEntry.DropGroup, dropChance, quantity));
                        break;
                        //default:
                        //    throw new NotImplementedException(
                        //        $"We don't know what does DropType.{DropItemType.Npc} means.");
                }
            }

            return results;
        }
    }
}