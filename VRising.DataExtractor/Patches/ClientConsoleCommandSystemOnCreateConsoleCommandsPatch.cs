//using System;
//using HarmonyLib;
//using ProjectM;
//using VRising.DataExtractor.ConsoleCommands;

//namespace VRising.DataExtractor.Patches;

//[HarmonyPatch(typeof(ClientConsoleCommandSystem), "OnCreateConsoleCommands")]
//public static class ClientConsoleCommandSystemOnCreateConsoleCommandsPatch
//{
//    //Must be a Prefix
//    private static void Prefix(ClientConsoleCommandSystem __instance)
//    {
//        try
//        {
//            new DumpGameDataConsoleCommand().Register(__instance);
//            new AddRecipeToPlayerCraftingConsoleCommand().Register(__instance);
//        }
//        catch (Exception e)
//        {
//            Plugin.Logger.LogError(e);
//        }
//    }
//}