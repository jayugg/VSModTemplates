using System;
using Vintagestory.API.Common;

namespace _ProjectName_.Config;

public class ConfigLoader : ModSystem
{
    internal static readonly string ConfigName = "_ProjectName_.json";
    public static ModConfig Config { get; private set; }
    public override void StartPre(ICoreAPI api)
    {
        try
        {
            Config = api.LoadModConfig<ModConfig>(ConfigName);
            if (Config == null)
            {
                Config = new ModConfig();
                api.Logger.VerboseDebug("[_ProjectName_] Config file not found, creating a new one...");
            }
            api.StoreModConfig(Config, ConfigName);
        } catch (Exception e) {
            api.Logger.Error("[_ProjectName_] Failed to load config, you probably made a typo: {0}", e);
            Config = new ModConfig();
        }
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