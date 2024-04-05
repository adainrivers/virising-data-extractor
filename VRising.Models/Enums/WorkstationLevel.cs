using System;

namespace VRising.Models.Enums
{
    [Flags]
    public enum WorkstationLevel : byte
    {
        None = 0,
        EnclosedRoom = 1,
        MatchingFloor = 2,
        Servant = 4,
    }
}