using System;

namespace VRising.Models.Enums
{
    [Flags]
    public enum ServantType
    {
        None = 0,
        Blacksmith = 1,
        Lumberjack = 2,
        Tailor = 4,
        Officer = 8,
        Guard = 16,
    }
}