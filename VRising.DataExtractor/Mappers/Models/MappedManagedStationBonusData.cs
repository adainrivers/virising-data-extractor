using Stunlock.Localization;
using UnityEngine;

namespace VRising.DataExtractor.Mappers.Models;

public class MappedManagedStationBonusData
{
    public StationBonusType BonusType;
    public float ModificationValue;
    public Sprite Icon_Unlocked;
    public Sprite Icon_Locked;
    public Sprite Icon_Bonus;
    public Sprite Icon_Unlocked_TextImage;
    public Sprite Icon_Locked_TextImage;
    public LocalizationKey BonusKey;
    public LocalizationKey TextRequirements;
    public LocalizationKey TextBonus;
}