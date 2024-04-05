using System;
using System.Collections.Generic;
using System.Linq;
using VRising.Models.Data;
using VRising.Models.Enums;
using VRising.Models.Helpers;
using VRising.Models.Internal;

namespace VRising.Models.Drops
{
    internal class DropTableModelBuilder
    {
        public DropTableModel Build(RisingEntity entity)
        {
            var model = new DropTableModel
            {
                Entity = entity,
                DropTableId = entity.PrefabGuid,
                PrefabName = entity.PrefabName,
                Name = PrefabNameCleaner.GetName(entity.PrefabName),
                Entries = entity.DropTableDataBuffer.Select(b => new DropTableEntry
                {
                    EntryEntityId = b.ItemGuid,
                    DropItemType = Enum.Parse<DropItemType>(b.ItemType),
                    Quantity = b.Quantity,
                    DropRate = (float)b.DropRate
                }).ToList()
            };


            foreach (var dropTableDataEntry in model.Entries.Where(dropTableDataEntry =>
                         dropTableDataEntry.DropItemType == DropItemType.Item))
            {
                if (!Database.Current.Mappings.ItemDropTableMap.ContainsKey(dropTableDataEntry.EntryEntityId))
                {
                    Database.Current.Mappings.ItemDropTableMap[dropTableDataEntry.EntryEntityId] = new HashSet<int>();
                }

                Database.Current.Mappings.ItemDropTableMap[dropTableDataEntry.EntryEntityId].Add(model.DropTableId);
            }

            PopulateDropGroupEntries(model);

            return model;
        }

        private void PopulateDropGroupEntries(DropTableModel dropTableModel)
        {
            foreach (var dropTableEntry in dropTableModel.Entries.Where(i => i.DropItemType == DropItemType.Group))
            {
                var dropGroupModel = Database.Current.DropGroups[dropTableEntry.EntryEntityId];

                foreach (var dropGroupEntry in dropGroupModel.Entries.Where(dropGroupEntry =>
                             dropGroupEntry.DropItemType == DropItemType.Item))
                {
                    if (!Database.Current.Mappings.ItemDropTableMap.ContainsKey(dropGroupEntry.EntryEntityId))
                    {
                        Database.Current.Mappings.ItemDropTableMap[dropGroupEntry.EntryEntityId] = new HashSet<int>();
                    }

                    Database.Current.Mappings.ItemDropTableMap[dropGroupEntry.EntryEntityId]
                        .Add(dropTableModel.DropTableId);
                }

                PopulateDropGroupEntries(dropGroupModel, dropTableModel);
            }
        }

        private void PopulateDropGroupEntries(DropGroupModel parentDropGroup, DropTableModel dropTableModel)
        {
            foreach (var parentDropGroupEntry in parentDropGroup.Entries.Where(
                         i => i.DropItemType == DropItemType.Group))
            {
                var dropGroupModel = Database.Current.DropGroups[parentDropGroupEntry.EntryEntityId];


                foreach (var dropGroupEntry in dropGroupModel.Entries.Where(dropGroupEntry =>
                             dropGroupEntry.DropItemType == DropItemType.Item))
                {
                    if (!Database.Current.Mappings.ItemDropTableMap.ContainsKey(dropGroupEntry.EntryEntityId))
                    {
                        Database.Current.Mappings.ItemDropTableMap[dropGroupEntry.EntryEntityId] = new HashSet<int>();
                    }

                    Database.Current.Mappings.ItemDropTableMap[dropGroupEntry.EntryEntityId]
                        .Add(dropTableModel.DropTableId);
                }

                PopulateDropGroupEntries(dropGroupModel, dropTableModel);
            }
        }
    }
}