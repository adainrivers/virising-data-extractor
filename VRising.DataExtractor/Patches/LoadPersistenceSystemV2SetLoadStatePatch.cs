using System;
using HarmonyLib;
using ProjectM.UI;


namespace VRising.DataExtractor.Patches;

[HarmonyPatch(typeof(LoadPersistenceSystemV2), "SetLoadState")]
public static class ServerStartupStatePatch
{
    public delegate void ServerStartupStateChangeEventHandler(
        LoadPersistenceSystemV2 sender,
        ServerStartupState.State serverStartupState);

    public static event ServerStartupStateChangeEventHandler OnServerStartupStateChanged;

    private static void Prefix(ServerStartupState.State loadState, LoadPersistenceSystemV2 __instance)
    {
        try
        {
            OnServerStartupStateChanged?.Invoke(__instance, loadState);
        }
        catch (Exception e)
        {
            Plugin.Logger.LogError(e);
        }
    }
}

//[HarmonyPatch]
//public static class BuildMenuCompositionAssetAddStructurePatch
//{
//    [HarmonyPatch(typeof(BuildMenuCompositionAsset), "AddStructure")]
//    [HarmonyPostfix]
//    public static void Postfix(BuildMenuCompositionAsset __instance)
//    {
//        try
//        {
//            Plugin.Logger.LogWarning($"BuildMenuCompositionAssetConvertPatch Guid {__instance.PrefabGuid.GuidHash}");
//            foreach (var buildMenuCategoryAsset in __instance.Categories)
//            {
//                Plugin.Logger.LogWarning($"BuildMenuCompositionAssetConvertPatch Category {buildMenuCategoryAsset.Name.ToString()}");
//                foreach (var tag in buildMenuCategoryAsset.Tags)
//                {
//                    Plugin.Logger.LogWarning($"BuildMenuCompositionAssetConvertPatch Tag {tag.TagAsset.Name.ToString()}");
//                    foreach (var structure in tag.Structures)
//                    {
//                        Plugin.Logger.LogWarning(structure.GetIl2CppType().FullName);
//                    }
//                }
//            }
//        }
//        catch (Exception e)
//        {
//            Plugin.Logger.LogError(e);
//        }
//    }
//}