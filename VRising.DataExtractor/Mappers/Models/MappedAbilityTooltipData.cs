using ProjectM.UI;
using Stunlock.Localization;
using UnityEngine;

namespace VRising.DataExtractor.Mappers.Models
{
    public class MappedAbilityTooltipData
    {
        public LocalizationKey Name;
        public LocalizedStringBuilderBase Description;
        public Sprite Icon;
        public AbilityTooltipType TooltipType;
        public PrefabGUID SpawnPrefabOnCast;
    }
}