using System;

namespace VRising.Models.Enums
{
    [Flags]
    public enum ItemCategory : long
    {
        ALL = -1L,
        NONE = 0L,
        Weapon = 1L,
        Armor = 2L,
        Gem = 4L,
        BloodBound = 8L,
        Flower = 16L,
        Lumber = 32L,
        Stone = 64L,
        BloodEssence = 128L,
        SoulBound = 256L,
        TeleportBound = 512L,
        Silver = 1024L,
        LoseDurabilityOnDeath = 2048L,
        Knowledge = 4096L,
        Blood = 8192L,
        Relic = 16384L
    }
}