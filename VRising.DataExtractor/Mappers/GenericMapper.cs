using System;
using System.Linq;
using AutoMapper;
using ProjectM.Portrait;
using ProjectM.UI;
using Unity.Entities;
using VRising.DataExtractor.Mappers.Models;
using LocalizationKey = Stunlock.Localization.LocalizationKey;

namespace VRising.DataExtractor.Mappers
{
    public static class GenericMapper
    {
        private static readonly Mapper Mapper;

        static GenericMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<VBloodPortraitData, MappedVBloodPortraitData>()
                    //.ForMember(a => a.HeadPortrait, b => b.MapFrom(c => c.HeadPortrait))
                    //.ForMember(a => a.FullBodyPortrait, b => b.MapFrom(c => c.FullBodyPortrait))
                    ;
                cfg.CreateMap<ServantPortraitData, MappedServantPortraitData>()
                    .ForMember(a => a.NormalPortrait, b => b.MapFrom(c => c.NormalPortrait))
                    .ForMember(a => a.VampirePortrait, b => b.MapFrom(c => c.VampirePortrait))
                    ;
                cfg.CreateMap<ManagedUnitBloodTypeData, MappedManagedUnitBloodTypeData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Icon2, b => b.MapFrom(c => c.Icon2))
                    ;

                cfg.CreateMap<ManagedRepairStationData, MappedManagedRepairStationData>()
                    .ForMember(a => a.InfoSprite, b => b.MapFrom(c => c.InfoSprite))
                    .ForMember(a => a.InfoText, b => b.MapFrom(c => c.InfoText))
                    ;

                cfg.CreateMap<ManagedMissionInjureDataAsset, MappedManagedMissionInjureDataAsset>()
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    ;

                cfg.CreateMap<ManagedDataDropGroup, MappedManagedDataDropGroup>()
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    ;

                cfg.CreateMap<ManagedJournalTooltip, MappedManagedJournalTooltip>()
                    .ForMember(a => a.TextKey, b => b.MapFrom(c => c.TextKey))
                    .ForMember(a => a.Sprite, b => b.MapFrom(c => c.Sprite))
                    .ForMember(a => a.SortOrder, b => b.MapFrom(c => c.SortOrder))
                    ;

                cfg.CreateMap<ManagedAchievementData, MappedManagedAchievementData>()
                    .ForMember(a => a.Quest, b => b.MapFrom(c => c.Quest))
                    .ForMember(a => a.Flavor, b => b.MapFrom(c => c.Flavor))
                    .ForMember(a => a.OverrideRewardText, b => b.MapFrom(c => c.OverrideRewardText))
                    ;
                cfg.CreateMap<ManagedMissionData, MappedManagedMissionData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    ;

                cfg.CreateMap<ComponentType, MappedComponentType>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.GetManagedType().FullName))
                    .ForMember(a => a.AccessModeType, b => b.MapFrom(c => Enum.Parse<MappedComponentType.AccessMode>(c.AccessModeType.ToString())))
                    .ForMember(a => a.IsManagedComponent, b => b.MapFrom(c => c.IsManagedComponent))
                    .ForMember(a => a.IsSystemStateSharedComponent, b => b.MapFrom(c => c.IsSystemStateSharedComponent))
                    .ForMember(a => a.IsSystemStateComponent, b => b.MapFrom(c => c.IsSystemStateComponent))
                    .ForMember(a => a.IsBuffer, b => b.MapFrom(c => c.IsBuffer))
                    .ForMember(a => a.IsChunkComponent, b => b.MapFrom(c => c.IsChunkComponent))
                    .ForMember(a => a.IsZeroSized, b => b.MapFrom(c => c.IsZeroSized))
                    .ForMember(a => a.IsSharedComponent, b => b.MapFrom(c => c.IsSharedComponent))
                    ;
                cfg.CreateMap<ManagedDescriptionData, MappedManagedDescriptionData>()
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    ;

                cfg.CreateMap<AbilityTooltipData, MappedAbilityTooltipData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.TooltipType, b => b.MapFrom(c => c.TooltipType))
                    .ForMember(a => a.SpawnPrefabOnCast, b => b.MapFrom(c => c.SpawnPrefabOnCast))
                    ;

                cfg.CreateMap<ManagedStationBonusData, MappedManagedStationBonusData>()
                    .ForMember(a => a.BonusType, b => b.MapFrom(c => c.BonusType))
                    .ForMember(a => a.ModificationValue, b => b.MapFrom(c => c.ModificationValue))
                    .ForMember(a => a.Icon_Unlocked, b => b.MapFrom(c => c.Icon_Unlocked))
                    .ForMember(a => a.Icon_Locked, b => b.MapFrom(c => c.Icon_Locked))
                    .ForMember(a => a.Icon_Bonus, b => b.MapFrom(c => c.Icon_Bonus))
                    .ForMember(a => a.Icon_Unlocked_TextImage, b => b.MapFrom(c => c.Icon_Unlocked_TextImage))
                    .ForMember(a => a.Icon_Locked_TextImage, b => b.MapFrom(c => c.Icon_Locked_TextImage))
                    .ForMember(a => a.BonusKey, b => b.MapFrom(c => c.BonusKey))
                    .ForMember(a => a.TextRequirements, b => b.MapFrom(c => c.TextRequirements))
                    .ForMember(a => a.TextBonus, b => b.MapFrom(c => c.TextBonus))
                    ;


                cfg.CreateMap<ManagedItemData, MappedManagedItemData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.PrefabName, b => b.MapFrom(c => c.PrefabName))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    ;
                cfg.CreateMap<ManagedBlueprintData, MappedManagedBlueprintData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Type, b => b.MapFrom(c => c.Type))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    .ForMember(a => a.LimitedType, b => b.MapFrom(c => c.LimitedType));
                cfg.CreateMap<ManagedAbilityGroupData, MappedManagedAbilityGroupData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    ;

                cfg.CreateMap<ManagedBuildMenuGroupData, MappedManagedBuildMenuGroupData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    ;

                cfg.CreateMap<ManagedBuildMenuCategoryData, MappedManagedBuildMenuCategoryData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Tags,
                        b => b.MapFrom(c => c.TagDatas.Select(td => Mapper.Map<ManagedBuildMenuTagData, MappedManagedBuildMenuTagData>(td))))
                    ;
                cfg.CreateMap<ManagedBuildMenuCompositionData, MappedManagedBuildMenuCompositionData>()
                    .ForMember(a => a.Categories,
                        b => b.MapFrom(c => c.CategoryDatas.Select(td => Mapper.Map<ManagedBuildMenuCategoryData, MappedManagedBuildMenuCategoryData>(td))))
                    ;

                cfg.CreateMap<ManagedBuildMenuTagData, MappedManagedBuildMenuTagData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    ;

                cfg.CreateMap<ManagedPerkData, MappedManagedPerkData>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.Value, b => b.MapFrom(c => c.Value))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description))
                    .ForMember(a => a.ID, b => b.MapFrom(c => c.ID))
                    .ForMember(a => a.LootValue, b => b.MapFrom(c => c.LootValue));
                ;
                cfg.CreateMap<ManagedCharacterHUD, MappedManagedCharacterHUD>()
                    .ForMember(a => a.Name, b => b.MapFrom(c => c.Name))
                    .ForMember(a => a.PrefabName, b => b.MapFrom(c => c.PrefabName))
                    .ForMember(a => a.Icon, b => b.MapFrom(c => c.Icon))
                    .ForMember(a => a.Description, b => b.MapFrom(c => c.Description));


                cfg.CreateMap<UnitStats, VRising.Models.Data.UnitStats>();
                cfg.CreateMap<ResistanceData, VRising.Models.Data.ResistanceData>();
                cfg.CreateMap<PrefabGUID, int>();
                cfg.CreateMap<LocalizationKey, VRising.Models.Data.LocalizedString>()
                    .ForMember(a => a.Key, b => b.MapFrom(c => c.Key.ToGuid().ToSystemGuid()))
                    .ForMember(a => a.Value, b => b.MapFrom(c => SafeGetLocalizationValue(c)));
            });

            Mapper = new Mapper(config);
        }

        private static string SafeGetLocalizationValue(LocalizationKey key)
        {
            try
            {
                return key.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static TOutput Map<TInput, TOutput>(TInput input)
        {
            return Mapper.Map<TInput, TOutput>(input);
        }
    }
}