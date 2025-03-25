using System;
using Vintagestory.API.Common;

namespace _ProjectName_.Config;

public class ConfigLoader : ModSystem
{
    private const string ConfigName = = "_ProjectName_.json";
    public static ModConfig Config { get; private set; }
    public override void StartPre(ICoreAPI api)
    {
        try
        {
            Config = api.LoadModConfig<ModConfig>(ConfigName);
            if (Config == null)
            {
                Config = new ModConfig();
                Mod.Logger.VerboseDebug("Config file not found, creating a new one...");
            }
            api.StoreModConfig(Config, ConfigName);
        } catch (Exception e) {
            Mod.Logger.Error("Failed to load config, you probably made a typo: {0}", e);
            Config = new ModConfig();
        }
    }
    
    public override void Dispose()
    {
        Config = null;
        base.Dispose();
    }

    #if ( AddSampleCode )
    public override void Start(ICoreAPI api)
    {
        // Properties can be used in json patches like this
        // "condition": { "when": "_ProjectName__ExampleProperty", "isValue": "true" }
        api.World.Config.SetBool("_ProjectName__ExampleProperty", Config.ExampleConfigSetting);
    }
    #endif
}