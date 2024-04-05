using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProjectM.Portrait;
using ProjectM.UI;
using Unity.Entities;
using VRising.DataExtractor.Mappers;
using VRising.DataExtractor.Mappers.Models;

namespace VRising.DataExtractor
{
    internal static class EntityManagerExtensions
    {
        public static HashSet<Type> TypesToSkipGetComponent { get; set; } = new();
        public static HashSet<Type> TypesToSkipGetBuffer { get; set; } = new();
        public static HashSet<Type> TypesToSkipGetManagedComponent { get; set; } = new();

        public static bool TryGettingComponentData<T>(this EntityManager entityManager, Entity entity, out T componentData) where T : new()
        {
            componentData = default;
            var allTypes = entityManager.GetAllComponentTypeNames(entity);
            if (!allTypes.Contains(typeof(T).FullName))
            {
                return false;
            }

            if (TypesToSkipGetComponent.Contains(typeof(T)))
            {
                return false;
            }

            try
            {
                componentData = entityManager.GetComponentData<T>(entity);
                if (componentData == null)
                {
                    return false;
                }

                return true;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("AOT"))
                {
                    TypesToSkipGetComponent.Add(typeof(T));
                    Plugin.Logger.LogInfo($"No AOT code for GetComponent<{typeof(T)}>");
                }
                else if (e.Message.Contains("has not been added to the entity."))
                {
                    return false;
                }
                else
                {
                    Plugin.Logger.LogError($"{typeof(T)} {e.Message}");
                }

                return false;
            }
        }

        public static bool TryGettingBuffer<T>(this EntityManager entityManager, Entity entity, out List<T> componentData) where T : new()
        {
            componentData = new List<T>();
            var allTypes = entityManager.GetAllComponentTypeNames(entity);
            if (!allTypes.Contains(typeof(T).FullName))
            {
                return false;
            }

            if (TypesToSkipGetBuffer.Contains(typeof(T)))
            {
                return false;
            }

            try
            {
                foreach (var value in entityManager.GetBuffer<T>(entity))
                {
                    componentData.Add(value);
                }

                if (componentData.Count == 0)
                {
                    componentData = null;
                }

                return true;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("AOT"))
                {
                    TypesToSkipGetBuffer.Add(typeof(T));
                    Plugin.Logger.LogInfo($"No AOT code for GetBuffer<{typeof(T)}>");
                }
                else if (e.Message.Contains("has not been added to the entity."))
                {
                    return false;
                }
                else
                {
                    Plugin.Logger.LogInfo($"{typeof(T)} {e.Message}");
                }

                return false;
            }
        }

        public static bool TryHasComponent<T>(this EntityManager entityManager, Entity entity, out bool? hasComponent) where T : new()
        {
            hasComponent = null;
            var allTypes = entityManager.GetAllComponentTypeNames(entity);
            if (!allTypes.Contains(typeof(T).FullName))
            {
                return false;
            }
            else
            {
                hasComponent = true;
                return true;
            }
        }

        public static HashSet<string> GetAllComponentTypeNames(this EntityManager entityManager, Entity entity)
        {
            return entityManager.GetComponentTypes(entity).ToArray().Select(t => t.GetManagedType().FullName).ToHashSet();
        }

        public static Guid ToSystemGuid(this Il2CppSystem.Guid il2CppGuid)
        {
            return Guid.Parse(il2CppGuid.ToString());
        }

        private static readonly Dictionary<string, System.Reflection.MethodInfo> GetComponentDataMethodCache = new();
        private static readonly HashSet<string> DisabledComponentTypes = new();
        private static readonly Dictionary<string, System.Reflection.MethodInfo> GetBufferMethodCache = new();
        private static readonly HashSet<string> DisabledBufferTypes = new();
        private static readonly Dictionary<string, System.Reflection.MethodInfo> HasComponentMethodCache = new();
        private static readonly HashSet<string> DisabledHasComponentTypes = new();

        public static Dictionary<string, object> GetAllComponentData(this EntityManager entityManager, WorldHelper world, PrefabGUID prefabGuid, Entity entity,
            bool includeEverything = false)
        {
            var result = new Dictionary<string, object>
            {
                { "PrefabGuid", prefabGuid }
            };

            result.Add("Entity_Self", entity);

            if (world.PrefabNames.TryGetValue(prefabGuid.GuidHash, out var prefabName))
            {
                result.Add("PrefabName", prefabName);
            }

            var managedItemData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedItemData>(prefabGuid);
            if (managedItemData != null)
            {
                result[nameof(ManagedItemData)] = GenericMapper.Map<ManagedItemData, MappedManagedItemData>(managedItemData);
            }

            var managedBlueprintData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedBlueprintData>(prefabGuid);
            if (managedBlueprintData != null)
            {
                result[nameof(ManagedBlueprintData)] = GenericMapper.Map<ManagedBlueprintData, MappedManagedBlueprintData>(managedBlueprintData);
            }

            var managedAbilityGroupData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedAbilityGroupData>(prefabGuid);
            if (managedAbilityGroupData != null)
            {
                result[nameof(ManagedAbilityGroupData)] = GenericMapper.Map<ManagedAbilityGroupData, MappedManagedAbilityGroupData>(managedAbilityGroupData);
            }

            var managedPerkData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedPerkData>(prefabGuid);
            if (managedPerkData != null)
            {
                result[nameof(ManagedPerkData)] = GenericMapper.Map<ManagedPerkData, MappedManagedPerkData>(managedPerkData);
            }

            var managedCharacterHud = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedCharacterHUD>(prefabGuid);
            if (managedCharacterHud != null)
            {
                result[nameof(ManagedCharacterHUD)] = GenericMapper.Map<ManagedCharacterHUD, MappedManagedCharacterHUD>(managedCharacterHud);
            }

            var managedStationBonusData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedStationBonusData>(prefabGuid);
            if (managedStationBonusData != null)
            {
                result[nameof(ManagedStationBonusData)] = GenericMapper.Map<ManagedStationBonusData, MappedManagedStationBonusData>(managedStationBonusData);
            }

            var managedDescriptionData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedDescriptionData>(prefabGuid);
            if (managedDescriptionData != null)
            {
                result[nameof(ManagedDescriptionData)] = GenericMapper.Map<ManagedDescriptionData, MappedManagedDescriptionData>(managedDescriptionData);
            }

            var managedBuildMenuGroupData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedBuildMenuGroupData>(prefabGuid);
            if (managedBuildMenuGroupData != null)
            {
                result[nameof(ManagedBuildMenuGroupData)] =
                    GenericMapper.Map<ManagedBuildMenuGroupData, MappedManagedBuildMenuGroupData>(managedBuildMenuGroupData);
            }

            var managedBuildMenuCompositionData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedBuildMenuCompositionData>(prefabGuid);
            if (managedBuildMenuCompositionData != null)
            {
                result[nameof(ManagedBuildMenuCompositionData)] =
                    GenericMapper.Map<ManagedBuildMenuCompositionData, MappedManagedBuildMenuCompositionData>(managedBuildMenuCompositionData);
            }

            var managedJournalTooltip = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedJournalTooltip>(prefabGuid);
            if (managedJournalTooltip != null)
            {
                result[nameof(ManagedJournalTooltip)] = GenericMapper.Map<ManagedJournalTooltip, MappedManagedJournalTooltip>(managedJournalTooltip);
            }

            var managedMissionData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedMissionData>(prefabGuid);
            if (managedMissionData != null)
            {
                result[nameof(ManagedMissionData)] = GenericMapper.Map<ManagedMissionData, MappedManagedMissionData>(managedMissionData);
            }

            var managedAchievementData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedAchievementData>(prefabGuid);
            if (managedAchievementData != null)
            {
                result[nameof(ManagedAchievementData)] = GenericMapper.Map<ManagedAchievementData, MappedManagedAchievementData>(managedAchievementData);
            }

            var managedDataDropGroup = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedDataDropGroup>(prefabGuid);
            if (managedDataDropGroup != null)
            {
                result[nameof(ManagedDataDropGroup)] = GenericMapper.Map<ManagedDataDropGroup, MappedManagedDataDropGroup>(managedDataDropGroup);
            }

            var managedMissionInjureDataAsset = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedMissionInjureDataAsset>(prefabGuid);
            if (managedMissionInjureDataAsset != null)
            {
                result[nameof(ManagedMissionInjureDataAsset)] =
                    GenericMapper.Map<ManagedMissionInjureDataAsset, MappedManagedMissionInjureDataAsset>(managedMissionInjureDataAsset);
            }

            var managedRepairStationData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedRepairStationData>(prefabGuid);
            if (managedRepairStationData != null)
            {
                result[nameof(ManagedRepairStationData)] =
                    GenericMapper.Map<ManagedRepairStationData, MappedManagedRepairStationData>(managedRepairStationData);
            }

            var managedUnitBloodTypeData = world.GameData.ManagedDataRegistry.GetOrDefault<ManagedUnitBloodTypeData>(prefabGuid);
            if (managedUnitBloodTypeData != null)
            {
                result[nameof(ManagedUnitBloodTypeData)] =
                    GenericMapper.Map<ManagedUnitBloodTypeData, MappedManagedUnitBloodTypeData>(managedUnitBloodTypeData);
            }

            var vBloodPortraitData = world.GameData.ManagedDataRegistry.GetOrDefault<VBloodPortraitData>(prefabGuid);
            if (vBloodPortraitData != null)
            {
                result[nameof(VBloodPortraitData)] = GenericMapper.Map<VBloodPortraitData, MappedVBloodPortraitData>(vBloodPortraitData);
            }

            var servantPortraitData = world.GameData.ManagedDataRegistry.GetOrDefault<ServantPortraitData>(prefabGuid);
            if (servantPortraitData != null)
            {
                result[nameof(ServantPortraitData)] = GenericMapper.Map<ServantPortraitData, MappedServantPortraitData>(servantPortraitData);
            }

            try
            {
                var abilityTooltipData = EntityManagerManagedComponentExtensions.GetComponentData<AbilityTooltipData>(ref entityManager, entity);
                if (abilityTooltipData != null)
                {
                    result[nameof(AbilityTooltipData)] = GenericMapper.Map<AbilityTooltipData, MappedAbilityTooltipData>(abilityTooltipData);
                }
            }
            catch (Exception)
            {
                // ignored
            }

            var componentTypes = entityManager.GetComponentTypes(entity);
            //result["ComponentTypes"] = componentTypes.ToArray().ToArray().Select(ct =>
            //{
            //    var mappedComponentType = GenericMapper.Map<ComponentType, MappedComponentType>(ct);
            //    mappedComponentType.n = ct.GetManagedType().FullName;
            //    return mappedComponentType;
            //}).ToList();

            foreach (var componentType in componentTypes)
            {
                var il2CppType = componentType.GetManagedType();
                var typeName = il2CppType.FullName;

                if (!includeEverything)
                {
                    if (typeName.StartsWith("Stunlock") || typeName.Contains("Network") || typeName.StartsWith("Unity"))
                    {
                        continue;
                    }
                }

                if (result.ContainsKey(il2CppType.Name) && result[il2CppType.Name] != null)
                {
                    continue;
                }

                if (il2CppType.Name is nameof(PrefabGUID) or nameof(AbilityTooltipData))
                {
                    continue;
                }

                if (!DisabledComponentTypes.Contains(il2CppType.AssemblyQualifiedName))
                {
                    if (!GetComponentDataMethodCache.TryGetValue(il2CppType.AssemblyQualifiedName,
                            out var tryGetComponentData))
                    {
                        var method = typeof(EntityManagerExtensions).GetMethod(nameof(TryGettingComponentData));
                        var type = Type.GetType(il2CppType.AssemblyQualifiedName);
                        tryGetComponentData = method.MakeGenericMethod(type);
                        GetComponentDataMethodCache[il2CppType.AssemblyQualifiedName] = tryGetComponentData;
                    }

                    var parameters1 = new object[] { entityManager, entity, null };
                    var value1 = tryGetComponentData.Invoke(null, parameters1);
                    if ((bool)value1)
                    {
                        if (componentType.GetManagedType().Name == "ItemData")
                        {
                            var itemData = (ItemData)parameters1[2];
                            if (itemData.ItemType == ItemType.Consumable && GameplayHelper.TryGetConsumableTooltip(entityManager, world.GameData,
                                    world.PrefabCollection, prefabGuid, out var consumableDescription))
                            {
                                result["ConsumableDescription"] = consumableDescription;
                            }
                        }

                        result[il2CppType.Name] = parameters1[2];
                        continue;
                    }
                    else
                    {
                        DisabledComponentTypes.Add(il2CppType.AssemblyQualifiedName);
                    }
                }

                if (!DisabledBufferTypes.Contains(il2CppType.AssemblyQualifiedName))
                {
                    if (!GetBufferMethodCache.TryGetValue(il2CppType.AssemblyQualifiedName, out var tryGetBuffer))
                    {
                        var method = typeof(EntityManagerExtensions).GetMethod(nameof(TryGettingBuffer));
                        var type = Type.GetType(il2CppType.AssemblyQualifiedName);
                        tryGetBuffer = method.MakeGenericMethod(type);
                        GetBufferMethodCache[il2CppType.AssemblyQualifiedName] = tryGetBuffer;
                    }

                    var parameters2 = new object[] { entityManager, entity, null };
                    var value2 = tryGetBuffer.Invoke(null, parameters2);
                    if ((bool)value2)
                    {
                        if (componentType.GetManagedType().FullName == typeof(ModifyUnitStatBuff_DOTS).FullName)
                        {
                            var componentValue = (List<ModifyUnitStatBuff_DOTS>)parameters2[2];
                            result[il2CppType.Name] = componentValue?.Select(m => new MappedUnitStatModification
                            {
                                StatType = m.StatType.ToString(),
                                ModificationType = m.ModificationType.ToString(),
                                Value = m.Value,
                                Name = world.GameData.RandomLocalizationKeys.GetLocalizationKey(m.StatType)
                                    .ToString(),
                                NameKey = world.GameData.RandomLocalizationKeys.GetLocalizationKey(m.StatType).Key
                                    .ToGuid().ToSystemGuid()
                            }).ToList();
                        }
                        else
                        {
                            result[il2CppType.Name] = (IEnumerable)(parameters2[2]);
                        }

                        continue;
                    }
                    else
                    {
                        DisabledBufferTypes.Add(il2CppType.AssemblyQualifiedName);
                    }
                }

                if (!DisabledHasComponentTypes.Contains(il2CppType.AssemblyQualifiedName))
                {
                    if (!HasComponentMethodCache.TryGetValue(il2CppType.AssemblyQualifiedName, out var tryHasComponent))
                    {
                        var method = typeof(EntityManagerExtensions).GetMethod(nameof(TryHasComponent));
                        var type = Type.GetType(il2CppType.AssemblyQualifiedName);
                        tryHasComponent = method.MakeGenericMethod(type);
                        HasComponentMethodCache[il2CppType.AssemblyQualifiedName] = tryHasComponent;
                    }

                    var parameters2 = new object[] { entityManager, entity, null };
                    var value2 = tryHasComponent.Invoke(null, parameters2);
                    if ((bool)value2)
                    {
                        result[il2CppType.Name] = (bool?)(parameters2[2]);
                    }
                    else
                    {
                        DisabledHasComponentTypes.Add(il2CppType.AssemblyQualifiedName);
                    }
                }
            }

            return result;
        }
    }
}