namespace _ProjectName_;

public partial class _ProjectName_Core 
{
    internal const string ExamplePatchCategory = "examplePatchCategory";
}

public static class PatchExtensions
{
    public static void PatchIfEnabled(this string patchCategory, bool configFlag)
    {
        if (!configFlag) return;
        _ProjectName_Core.HarmonyInstance.PatchCategory(patchCategory);
        _ProjectName_Core.Logger.VerboseDebug("Patched {0}...", patchCategory);
    }
}