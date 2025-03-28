#if ( AddSampleConfig )
using _ProjectName_.Config;
#endif
#if ( IncludeHarmony )
using HarmonyLib;
#if ( AddSampleCode )
#endif
#if ( ModSide != "server" )
using Vintagestory.API.Client;
#endif
#if ( ModSide != "client" )
using Vintagestory.API.Server;
#endif
using Vintagestory.API.Config;
#endif
using Vintagestory.API.Common;

namespace _ProjectName_;

#if( IncludeHarmony && AdvancedHarmonySetup )
public partial class _ProjectName_Core : ModSystem
#else
public class _ProjectName_Core : ModSystem
#endif
{
#if( QuickStartCode )
    public static ILogger Logger { get; private set; }
    public static string Modid { get; private set; }
    #if ( ModSide == "client" )
    public static ICoreClientAPI Capi { get; private set; }
    #elif ( ModSide == "server" )
    public static ICoreServerAPI Sapi { get; private set; }
    #else
    public static ICoreAPI Api { get; private set; }
    #endif
    #if( IncludeHarmony )
    public static Harmony HarmonyInstance { get; private set; }
    #endif
    #if( AddSampleConfig )
    public static Config => ConfigLoader.Config;
    #endif

    public override void StartPre(ICoreAPI api)
    {
        base.StartPre(api);
        #if ( ModSide == "client" )
        Capi = api as ICoreClientAPI;
        #elif ( ModSide == "server" )
        Sapi = api as ICoreServerAPI;
        #else
        Api = api;
        #endif
        Logger = Mod.Logger;
        Modid = Mod.Info.ModID;
        #if( IncludeHarmony && AdvancedHarmonySetup )
        Patch();
        #elif( IncludeHarmony )
        HarmonyInstance = new Harmony(Modid);
        HarmonyInstance.PatchAll();
        #endif
    }
    
    public override void Start(ICoreAPI api)
    {
        base.Start(api);
        #if( AddSampleCode )
        Logger.Notification("Hello from template mod: " + api.Side);
        Logger.StoryEvent("Templates lost..."); // Sample story event (shown when loading a world)
        Logger.Event("Templates loaded..."); // Sample event (shown when loading in dev mode or in logs)
        #endif
    }
    
    #if( AddSampleCode && ModSide != "server" )
    public override void StartClientSide(ICoreClientAPI api)
    {
        base.StartClientSide(api);
        Logger.Notification("Hello from template mod client side: " + Lang.Get("_modid_:hello"));
    }
    #endif

    #if( AddSampleCode && ModSide != "client" )
    public override void StartServerSide(ICoreServerAPI api)
    {
        base.StartServerSide(api);
        Logger.Notification("Hello from template mod server side: " + Lang.Get("_modid_:hello"));
    }
    #endif

    #if( IncludeHarmony && AdvancedHarmonySetup )
    public static void Patch()
    {
        if (HarmonyInstance != null) return;
        HarmonyInstance = new Harmony(Modid);
        Logger.VerboseDebug("Patching...");
        #if( AddSampleConfig )
        ExamplePatchCategory.PatchIfEnabled(Config.ExampleConfigSetting);
        #else
        HarmonyInstance.PatchCategory(ExamplePatchCategory);
        Logger.VerboseDebug("Patched example patches...");
        #endif
    }

    public static void Unpatch()
    {
        Logger?.VerboseDebug("Unpatching...");
        HarmonyInstance?.UnpatchAll();
        HarmonyInstance = null;
    }
    #endif
    
    public override void Dispose()
    {
        #if( IncludeHarmony && AdvancedHarmonySetup )
        Unpatch();
        #elif ( IncludeHarmony)
        HarmonyInstance?.UnpatchAll(Modid);
        HarmonyInstance = null;
        #endif
        Logger = null;
        Modid = null;
        #if ( ModSide == "client" )
        Capi = null;
        #elif ( ModSide == "server" )
        Sapi = null;
        #else
        Api = null;
        #endif
        base.Dispose();
    }
#endif
}
