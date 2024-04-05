using VRising.Localization;
using VRising.Models.Localization;

namespace VRising.Models.RootModels
{
    public class ModelBase
    {
    }

    public interface IModel
    {
        int Id { get; }
        int Rarity { get; }
        string Icon { get; }
        string PrefabName { get; }
        string BasePath { get; }
        LocalizedResource LocalizedName { get; }
    }
}