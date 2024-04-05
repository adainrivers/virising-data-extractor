using System;
using System.IO;

namespace VRising.Configuration
{
    public static class AppConfig
    {
#if DEBUG
        public const string DataRootFolder = "D:\\VRising";
#else
        public const string DataRootFolder = "/home/gt/vrising.data";
#endif
        public static bool DumpComponents = false;

        public static string ModelsFilePath =
            "D:\\VRising\\Development\\VRising\\VRising.Models\\Internal\\RisingModels.cs";

        public static string MapGenieDataFilePath =
            "D:\\VRising\\Development\\VRising\\VRising.Models\\Internal\\MapGenieData.cs";

        public static string DataFolder = "Data"; // Path.Combine(DataRootFolder, "Data");

        public static string GetDataFilePath(string fileName)
        {
            return Path.Combine(DataFolder, fileName);
        }

        public static string ImageAssetsSourceFolder = Path.Combine(DataRootFolder, "AssetsClient", "Texture2D");
        public static string ImageAssetsDestinationFolder = Path.Combine(AppConfig.DataFolder, "WebAssets", "assets");
        public static string MapAssetsDestinationFolder = Path.Combine(AppConfig.DataFolder, "WebAssets", "maptiles");

        public static string MonoBehaviorFolder = Path.Combine(DataRootFolder, "AssetsClient", "MonoBehaviour");
        public static string GoogleApiJsonFilePath = Path.Combine(DataFolder, "json here");

#if DEBUG
        public const bool Debug = true;
#else
        public const bool Debug = false;
#endif
        public static DateTime LastUpdated = new DateTime(2022, 9, 16);
        public const string GameVersion = "0.5.42584";
    }

    public enum WorldType
    {
        Server,
        Client
    }
}