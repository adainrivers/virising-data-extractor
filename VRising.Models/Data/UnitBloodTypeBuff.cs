using VRising.Models.Buffs;
using VRising.Models.Helpers;

namespace VRising.Models.Data
{
    public class UnitBloodTypeBuff
    {
        public double MinQuality { get; set; }
        public int BuffId { get; set; }

        public BuffModel Buff => Database.Current.Buffs.GetOrNull(BuffId);
    }
}