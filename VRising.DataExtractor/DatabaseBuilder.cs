using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;
using ProjectM.UI;
using Stunlock.Localization;
using Unity.Entities;
using Unity.Transforms;
using VRising.Configuration;
using VRising.DataExtractor.Mappers;
using VRising.DataExtractor.Mappers.Models;
using VRising.JsonToCsharp;
using BuildMenu = VRising.DataExtractor.Mappers.Models.BuildMenu;
using ItemCategory = VRising.Models.Enums.ItemCategory;
using JsonSerializer = System.Text.Json.JsonSerializer;
using LocalizedString = VRising.Models.Data.LocalizedString;


namespace VRising.DataExtractor
{
    internal static class DatabaseBuilder
    {
        public static void DumpEverything(string suffix = null)
        {
            //WeakAssetReference<>
            var world = new WorldHelper();
            //StructureCategory
            var everything = new Everything
            {
                Entities = new Dictionary<int, Dictionary<string, object>>(),
                ComponentTypeToEntitiesMap = new Dictionary<string, HashSet<int>>()
            };

            //var chunkReplacer = world.GameWorld.GetExistingSystem<ReplaceDropTablesByChunkSystem>();
            //var map = chunkReplacer.
            //foreach (var mapItem in map)
            //{
            //    mapItem.
            //}

            var il2CppSerializer = new Il2CppSerializer();

            var entities = world.EntityManager.GetAllEntities().ToArray().ToList();
            Plugin.Logger.LogInfo($"Iterating {entities.Count} entities");
            for (var i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];

                if (i % 1000 == 0)
                {
                    Plugin.Logger.LogInfo($"# {i + 1}/{entities.Count}");
                }

                if (!world.EntityManager.TryGettingComponentData<PrefabGUID>(entity, out var prefabGuid))
                {
                    continue;
                }

                var allData = world.EntityManager.GetAllComponentData(world, prefabGuid, entity);
                foreach (var allDataKey in allData.Keys)
                {
                    if (!everything.ComponentTypeToEntitiesMap.ContainsKey(allDataKey))
                    {
                        everything.ComponentTypeToEntitiesMap[allDataKey] = new HashSet<int>();
                    }

                    everything.ComponentTypeToEntitiesMap[allDataKey].Add(prefabGuid.GuidHash);
                }

                if (!everything.Entities.ContainsKey(prefabGuid.GuidHash))
                {
                    everything.Entities.Add(prefabGuid.GuidHash, allData);
                }
                else
                {
                    foreach (var key in allData.Keys)
                    {
                        if (!everything.Entities[prefabGuid.GuidHash].ContainsKey(key))
                        {
                            everything.Entities[prefabGuid.GuidHash][key] = allData[key];
                        }
                    }
                }
            }

            Plugin.Logger.LogInfo("Serializing everything");

            var json = il2CppSerializer.Serialize(everything);
            File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"Everything{suffix}.json"), json);
            Plugin.Logger.LogInfo("Serializing entities");
            var json2 = il2CppSerializer.Serialize(everything.Entities.Values.ToList());
            File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"Entities{suffix}.json"), json2);

            var buildMenu = GetBuildMenuComposition();
            var buildMenuJson = il2CppSerializer.Serialize(buildMenu);
            File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"BuildMenu{suffix}.json"), buildMenuJson);
            var result = JsonToCsharpConverter.ToCsharp("RisingBuildMenu", "VRising.Models.Internal.BuildMenu", buildMenuJson);
            File.WriteAllText(Path.Combine(AppConfig.ModelsFilePath.Replace("RisingModels.cs", "BuildMenu"), "RisingBuildMenu.cs"), result);


            var json3 = JsonConvert.SerializeObject(everything.ComponentTypeToEntitiesMap, Formatting.Indented);
            File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"ComponentTypeToEntitiesMap{suffix}.json"), json3);

            var categoryNames = GetItemCategoryNames();
            var json4 = JsonConvert.SerializeObject(categoryNames, Formatting.Indented);
            File.WriteAllText(AppConfig.GetDataFilePath($"ItemCategoryNames{suffix}.json"), json4);

            Plugin.Logger.LogInfo("Generating classes");
            if (suffix == null)
            {
                GenerateClasses(json2);
            }

            Plugin.Logger.LogInfo("Done, enjoy!");
        }


        public static void DumpAllComponentTypes(string suffix = null)
        {
            var world = new WorldHelper();

            var entities = world.EntityManager.GetAllEntities().ToArray().ToList();
            Plugin.Logger.LogInfo($"Iterating {entities.Count} entities");
            var result = new List<List<MappedComponentType>>();
            for (var i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];


                if (i % 1000 == 0)
                {
                    Plugin.Logger.LogInfo($"# {i + 1}/{entities.Count}");
                }

                var componentTypes = world.EntityManager.GetComponentTypes(entity).ToArray()
                    .Select(ct => GenericMapper.Map<ComponentType, MappedComponentType>(ct)).ToList();
                result.Add(componentTypes);
            }

            File.WriteAllText(Path.Combine(AppConfig.DataFolder, "Ref", "AllComponentTypes.json"), JsonConvert.SerializeObject(result, Formatting.Indented));

            Plugin.Logger.LogInfo("Done, enjoy!");
        }


        public static void DumpAbsolutelyEverything(string suffix = null)
        {
            var world = new WorldHelper();
            var absoEverything = new List<Dictionary<string, object>>();
            var entities = world.EntityManager.GetAllEntities().ToArray().ToList();
            Plugin.Logger.LogInfo($"Iterating {entities.Count} entities");
            var result = new List<List<MappedComponentType>>();
            for (var i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];


                if (i % 1000 == 0)
                {
                    Plugin.Logger.LogInfo($"# {i + 1}/{entities.Count}");
                }

                if (!world.EntityManager.TryGettingComponentData<PrefabGUID>(entity, out var prefabGuid))
                {
                    prefabGuid = new PrefabGUID(0);
                }

                var data = world.EntityManager.GetAllComponentData(world, prefabGuid, entity, true);

                absoEverything.Add(data);
            }

            var il2CppSerializer = new Il2CppSerializer();
            var json = il2CppSerializer.Serialize(absoEverything);

            File.WriteAllText(Path.Combine(AppConfig.DataFolder, "Ref", "AbsolutelyEverything.json"), json);

            Plugin.Logger.LogInfo("Done, enjoy!");
        }

        public static void DumpCoords(string suffix = null)
        {
            var world = new WorldHelper();
            var positions = new Dictionary<string, List<MappedCoords>>();
            var entities = world.EntityManager.GetAllEntities().ToArray().ToList();
            Plugin.Logger.LogInfo($"Iterating {entities.Count} entities");
            for (var i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];

                if (i % 1000 == 0)
                {
                    Plugin.Logger.LogInfo($"# {i + 1}/{entities.Count}");
                }


                if (!world.EntityManager.TryGettingComponentData<LocalToWorld>(entity, out var localToWorld))
                {
                    continue;
                }

                if (!world.EntityManager.TryGettingComponentData<Parent>(entity, out var parent))
                {
                    continue;
                }

                if (!world.EntityManager.TryGettingComponentData<PrefabGUID>(parent.Value, out var parentPrefabGuid))
                {
                    continue;
                }

                if (!world.PrefabNames.TryGetValue(parentPrefabGuid.GuidHash, out var parentPrefabName) || parentPrefabName == null)
                {
                    continue;
                }

                var pos = localToWorld.Position;
                if (pos.x == 0 && pos.y == 0 && pos.z == 0)
                {
                    continue;
                }

                if (!positions.ContainsKey(parentPrefabName))
                {
                    positions[parentPrefabName] = new List<MappedCoords>();
                }

                positions[parentPrefabName].Add(new MappedCoords(pos.x, pos.y, pos.z));
            }

            File.WriteAllText(AppConfig.GetDataFilePath("PrefabPositions.json"), JsonConvert.SerializeObject(positions, Formatting.Indented));

            Plugin.Logger.LogInfo("Done, enjoy!");
        }


        public static BuildMenu GetBuildMenuComposition()
        {
            var buildMenu = new BuildMenu
            {
                Categories = new List<MappedManagedBuildMenuCategoryData>(),
                Groups = new List<MappedManagedBuildMenuGroupData>()
            };
            var world = new WorldHelper();

            foreach (var test in world.GameData.ManagedDataRegistry._DataLookupMap)
            {
                switch (test.Value.GetIl2CppType().Name)
                {
                    case nameof(ManagedBuildMenuGroupData):
                        var data1 =
                            world.GameData.ManagedDataRegistry.GetOrDefault<ManagedBuildMenuGroupData>(
                                test.Key.PrefabGUID);
                        var mapped1 =
                            GenericMapper.Map<ManagedBuildMenuGroupData, MappedManagedBuildMenuGroupData>(data1);
                        mapped1.GuidHash = test.Key.PrefabGUID.GuidHash;
                        buildMenu.Groups.Add(mapped1);
                        break;
                    case nameof(ManagedBuildMenuCompositionData):
                        var data2 =
                            world.GameData.ManagedDataRegistry.GetOrDefault<ManagedBuildMenuCompositionData>(
                                test.Key.PrefabGUID);
                        foreach (var managedBuildMenuCategoryData in data2.CategoryDatas)
                        {
                            var mappedCategory =
                                GenericMapper.Map<ManagedBuildMenuCategoryData, MappedManagedBuildMenuCategoryData>(managedBuildMenuCategoryData);
                            mappedCategory.GuidHash = test.Key.PrefabGUID.GuidHash;

                            buildMenu.Categories.Add(mappedCategory);
                        }

                        break;
                }
            }

            return buildMenu;
            //var entity = world.PrefabCollection.PrefabLookupMap[new PrefabGUID(-782361326)];
            //var buildMenuComposition = world.EntityManager.GetComponentData<BuildMenuComposition>(entity);

            //var blobber = buildMenuComposition.Blob.Value;

            //Plugin.Logger.LogWarning($"Categories: {blobber.Categories.Length}");
            //for (var i = 0; i < blobber.Categories.Length; i++)
            //{
            //    var blobCategory = blobber.Categories[i];
            //    Plugin.Logger.LogWarning($"Tags: {blobCategory.Tags.Length}");
            //    for (var j = 0; j < blobCategory.Tags.Length; j++)
            //    {
            //        var blobTag = blobCategory.Tags[j];
            //        Plugin.Logger.LogWarning($"Structures: {blobTag.Structures.Length}");
            //        for (var k = 0; k < blobTag.Structures.Length; k++)
            //        {
            //            var blobStructure = blobTag.Structures[k];
            //            var categoryId = blobStructure.GroupPrefabGuid;
            //            Plugin.Logger.LogWarning($"CategoryGuid: {categoryId.GuidHash}");
            //            var blueprints = new List<PrefabGUID>();
            //            Plugin.Logger.LogWarning($"Blueprints: {blobStructure.Blueprints.Length}");
            //            for (var l = 0; l < blobStructure.Blueprints.Length; l++)
            //            {
            //                blueprints.Add(blobStructure.Blueprints[l]);
            //                Plugin.Logger.LogWarning(blobStructure.Blueprints[l].GuidHash);
            //            }
            //        }
            //    }
            //}
        }

        private static void GenerateClasses(string json)
        {
            var result = JsonToCsharpConverter.ToCsharp("RisingEntity", "VRising.Models.Internal", json);
            File.WriteAllText(Path.Combine(AppConfig.ModelsFilePath), result);
        }

        private static Dictionary<ItemCategory, LocalizedString> GetItemCategoryNames()
        {
            var itemCategorySettings = JsonSerializer.Deserialize<MapperItemCategorySettings>(
                File.ReadAllText(Path.Combine(AppConfig.MonoBehaviorFolder, "ItemCategorySettings.json")));
            return new Dictionary<ItemCategory, LocalizedString>();
            return itemCategorySettings.ItemCategories.ToDictionary(
                c => (ItemCategory)c.ItemCategory,
                c => GenericMapper.Map<LocalizationKey, LocalizedString>(LocalizationMappers.GetLocalizationKey(c.Name.Key)));
        }

        private static void DumpManagedTypeNames(ManagedDataRegistry managedDataRegistry)
        {
            var managedTypes = new HashSet<string>();
            foreach (var value in managedDataRegistry._DataLookupMap.Values)
            {
                managedTypes.Add(value.ToString());
            }

            Dumper.WriteSerialized(AppConfig.GetDataFilePath("ManagedTypes.json"), managedTypes.OrderBy(c => c));
        }

        public static void DumpPrefabs()
        {
            var suffix = "Prefabs";
            //WeakAssetReference<>
            var world = new WorldHelper();
            //StructureCategory
            var everything = new Everything
            {
                Entities = new Dictionary<int, Dictionary<string, object>>(),
                ComponentTypeToEntitiesMap = new Dictionary<string, HashSet<int>>()
            };

            //var chunkReplacer = world.GameWorld.GetExistingSystem<ReplaceDropTablesByChunkSystem>();
            //var map = chunkReplacer.
            //foreach (var mapItem in map)
            //{
            //    mapItem.
            //}

            var il2CppSerializer = new Il2CppSerializer();
            var entities = new List<Entity>();
            foreach (var prefabKv in world.PrefabCollection.PrefabLookupMap.GuidToEntityMap)
            {
                entities.Add(prefabKv.Value);
            }

            //var entities = world.EntityManager.GetAllEntities().ToArray().ToList();
            Plugin.Logger.LogInfo($"Iterating {entities.Count} entities");
            for (var i = 0; i < entities.Count; i++)
            {
                var entity = entities[i];

                if (i % 1000 == 0)
                {
                    Plugin.Logger.LogInfo($"# {i + 1}/{entities.Count}");
                }

                if (!world.EntityManager.TryGettingComponentData<PrefabGUID>(entity, out var prefabGuid))
                {
                    continue;
                }

                var allData = world.EntityManager.GetAllComponentData(world, prefabGuid, entity);
                foreach (var allDataKey in allData.Keys)
                {
                    if (!everything.ComponentTypeToEntitiesMap.ContainsKey(allDataKey))
                    {
                        everything.ComponentTypeToEntitiesMap[allDataKey] = new HashSet<int>();
                    }

                    everything.ComponentTypeToEntitiesMap[allDataKey].Add(prefabGuid.GuidHash);
                }

                if (!everything.Entities.ContainsKey(prefabGuid.GuidHash))
                {
                    everything.Entities.Add(prefabGuid.GuidHash, allData);
                }
                else
                {
                    foreach (var key in allData.Keys)
                    {
                        if (!everything.Entities[prefabGuid.GuidHash].ContainsKey(key))
                        {
                            everything.Entities[prefabGuid.GuidHash][key] = allData[key];
                        }
                    }
                }
            }

            Plugin.Logger.LogInfo("Serializing everything");

            var json = il2CppSerializer.Serialize(everything);
            File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"Everything{suffix}.json"), json);
            Plugin.Logger.LogInfo("Serializing entities");
            var json2 = il2CppSerializer.Serialize(everything.Entities.Values.ToList());
            File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"Entities{suffix}.json"), json2);

            //var buildMenu = GetBuildMenuComposition();
            //var buildMenuJson = il2CppSerializer.Serialize(buildMenu);
            //File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"BuildMenu{suffix}.json"), buildMenuJson);
            //var result = JsonToCsharpConverter.ToCsharp("RisingBuildMenu", "VRising.Models.Internal.BuildMenu", buildMenuJson);
            //File.WriteAllText(Path.Combine(AppConfig.ModelsFilePath.Replace("RisingModels.cs", "BuildMenu"), "RisingBuildMenu.cs"), result);


            //var json3 = JsonConvert.SerializeObject(everything.ComponentTypeToEntitiesMap, Formatting.Indented);
            //File.WriteAllText(Path.Combine(AppConfig.DataFolder, $"ComponentTypeToEntitiesMap{suffix}.json"), json3);

            //var categoryNames = GetItemCategoryNames();
            //var json4 = JsonConvert.SerializeObject(categoryNames, Formatting.Indented);
            //File.WriteAllText(AppConfig.GetDataFilePath($"ItemCategoryNames{suffix}.json"), json4);

            //Plugin.Logger.LogInfo("Generating classes");
            //if (suffix == null)
            //{
            //    GenerateClasses(json2);
            //}

            Plugin.Logger.LogInfo("Done, enjoy!");
        }
    }
}