using System;
using System.Reflection;
using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using Bloodstone;
using HarmonyLib;
using VRising.DataExtractor.Patches;


namespace VRising.DataExtractor
{
    [BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
    //[BepInDependency("gg.deca.Bloodstone")]
    public class Plugin : BasePlugin, IRunOnInitialized
    {
        public const string PluginGuid = "VRising.DataExtractor";
        public const string PluginName = "VRising.DataExtractor";
        public const string PluginVersion = "2.0.0";

        public static ManualLogSource Logger { get; private set; }
        public static Harmony HarmonyInstance { get; private set; }


        public override void Load()
        {
            Logger = Log;

            //Register type to Il2Cpp
            //if (!ClassInjector.IsTypeRegisteredInIl2Cpp<DumpGameDataConsoleCommand>())
            //{
            //    ClassInjector.RegisterTypeInIl2Cpp<DumpGameDataConsoleCommand>();
            //}

            //if (!ClassInjector.IsTypeRegisteredInIl2Cpp<AddRecipeToPlayerCraftingConsoleCommand>())
            //{
            //    ClassInjector.RegisterTypeInIl2Cpp<AddRecipeToPlayerCraftingConsoleCommand>();
            //}
            Plugin.Logger.LogWarning("Loading");
            HarmonyInstance = new Harmony(PluginGuid);
            HarmonyInstance.PatchAll(Assembly.GetExecutingAssembly());

            ServerStartupStatePatch.OnServerStartupStateChanged += ServerStartupStatePatch_OnServerStartupStateChanged;
            Plugin.Logger.LogWarning("Loaded?");
        }

        private void ServerStartupStatePatch_OnServerStartupStateChanged(LoadPersistenceSystemV2 sender, ServerStartupState.State serverStartupState)
        {
            Logger.LogWarning($"ServerStartupStateChanged to {serverStartupState}");
            switch (serverStartupState)
            {
                case ServerStartupState.State.None:
                    break;
                case ServerStartupState.State.Waiting:
                    break;
                case ServerStartupState.State.Initializing:
                    break;
                case ServerStartupState.State.SuccessfulStartup:
                    //Dumper2.Dump();
                    //RecipeManipulator.AddRecipeToUser(210388568);
                    //RecipeManipulator.AddRecipeToUser(2081355058);
                    //RecipeManipulator.AddRecipeToUser(1936496678);
                    //RecipeManipulator.AddRecipeToUser(1341581379);
                    DatabaseBuilder.DumpEverything("Server");
                    //DatabaseBuilder.DumpCoords("Server");

                    break;
                case ServerStartupState.State.Failed:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(serverStartupState), serverStartupState, null);
            }
        }

        public override bool Unload()
        {
            HarmonyInstance.UnpatchSelf();
            return true;
        }

        public void OnGameInitialized()
        {
            //ComponentManager.Initialize();
            //ModelClassesGenerator.GenerateComponentModelClasses();
        }
    }
}