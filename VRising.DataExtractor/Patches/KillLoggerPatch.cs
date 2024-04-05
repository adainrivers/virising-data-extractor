namespace VRising.DataExtractor.Patches
{
    //[HarmonyPatch(typeof(OnDeathSystem), "YieldEssenceOnDeath")]
    //public static class KillLoggerPatch2
    //{

    //    private static void Postfix(EntityCommandBufferSafe spawnCommandBuffer,
    //        PrefabCollectionSystem prefabCollectionSystem,
    //        Entity sctPrefab,
    //        float modifier,
    //        OnDeathSystem __instance)
    //    {
    //        try
    //        {
    //            Plugin.Logger.LogInfo("Essence Yield");
    //            var world = __instance.World;
    //            var wHelper = new WorldHelper(world);
    //            var em = world.EntityManager;
    //            if (!em.TryGettingComponentData<PrefabGUID>(sctPrefab, out var prefabGuid))
    //            {
    //                prefabGuid = new PrefabGUID(0);
    //            }
    //            var data = world.EntityManager.GetAllComponentData(wHelper, prefabGuid, sctPrefab, true);
    //            var serializer = new Il2CppSerializer();
    //            var json = serializer.Serialize(data);
    //            File.WriteAllText(Path.Combine(AppConfig.DataFolder, "KillLog", $"{sctPrefab.Index}-{sctPrefab.Version}.json"), json);
    //            Plugin.Logger.LogInfo($"Logged death entity");
    //        }
    //        catch (Exception e)
    //        {
    //            Plugin.Logger.LogError(e);
    //        }
    //    }

    //}
}