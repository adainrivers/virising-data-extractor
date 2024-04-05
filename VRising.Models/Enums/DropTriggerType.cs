using System;

namespace VRising.Models.Enums
{
    public enum DropTriggerType
    {
        OnDestroy,
        OnDeath,
        OnSpawnDropInInventory,
        OnSalvageDestroy,
        YieldResourcesOnSalvage,
        YieldResourceOnDamageTaken,
        YieldResourcesOnPickup
    }

    public static class DropTriggerTypeNames
    {
        public static string GetName(this DropTriggerType dropTriggerType)
        {
            return dropTriggerType switch
            {
                DropTriggerType.OnDestroy => "When Destroyed",
                DropTriggerType.OnDeath => "When Died",
                DropTriggerType.OnSpawnDropInInventory => "When Opened",
                DropTriggerType.OnSalvageDestroy => "When Salvaged",
                DropTriggerType.YieldResourcesOnSalvage => "When Salvaged",
                DropTriggerType.YieldResourceOnDamageTaken => "When Damaged",
                DropTriggerType.YieldResourcesOnPickup => "When Picked Up",
                _ => throw new ArgumentOutOfRangeException(nameof(dropTriggerType), dropTriggerType, null)
            };
        }
    }
}