using System;

namespace VRising.Models.Enums
{
    [Flags]
    public enum BuffCategories
    {
        None = 0,
        Stun = 1,
        Knockback = 2,
        Interact = 4,
        Travel = 8,
        Slow = 16,
        Weaken = 32,
        Amplify = 64,
        Silence = 128,
        Fear = 256,
        BloodHeal = 512,
        BloodRage = 1024,
        Altar = 2048,
        Shapeshift = 4096,
        RemovableBuff = 8192,
        VeilDash = 16384,
        SunResistance = 32768,
        GarlicResistance = 65536,
        HolyResistance = 131072,
        FireResistance = 262144,
        SilverResistance = 524288,
        Ignite = 1048576,
        RemoveOnDisconnect = 2097152,
        SpellPower = 4194304,
        PhysicalPower = 8388608,
        Mount = 16777216,
        RelicCarry = 33554432,
        RelicPower = 67108864,
        PhysicalConsumables = 134217728,
        SpellConsumables = 268435456,
        AirThrow = 536870912,
        ShockwaveRecast = 1073741824
    }
}