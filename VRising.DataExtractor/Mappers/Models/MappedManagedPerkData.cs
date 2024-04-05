using ProjectM.UI;
using Stunlock.Localization;
using UnityEngine;

namespace VRising.DataExtractor.Mappers.Models;

public class MappedManagedPerkData
{
    public LocalizationKey Name;
    public LocalizedStringBuilderBase Description;
    public Sprite Icon;
    public int Value;
    public float LootValue;
    public PrefabGUID ID;
}