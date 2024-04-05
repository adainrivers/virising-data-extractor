using System.Collections.Generic;
using Stunlock.Localization;
using UnityEngine;

namespace VRising.DataExtractor.Mappers.Models;

public class MappedManagedBuildMenuCategoryData
{
    public int GuidHash;
    public LocalizationKey Name;
    public Sprite Icon;
    public List<MappedManagedBuildMenuTagData> Tags;
}