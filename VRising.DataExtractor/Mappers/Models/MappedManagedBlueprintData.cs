using ProjectM.UI;
using Stunlock.Localization;
using UnityEngine;

namespace VRising.DataExtractor.Mappers.Models;

public class MappedManagedBlueprintData
{
    public LocalizationKey Name;
    public LocalizedStringBuilderBase Description;
    public Sprite Icon;
    public BlueprintType Type;
    public CastleLimitedType LimitedType;
}