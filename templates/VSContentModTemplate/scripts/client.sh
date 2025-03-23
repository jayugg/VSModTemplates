# Unused by VS Code tasks
"build.sh"
echo "Launching game client..."
//#if (ArmMacOsLaunchSettings)
"$VINTAGE_STORY/Vintagestory" --tracelog --addModPath "{$(pwd)}"/Releases"
#else
dotnet "$VINTAGE_STORY/Vintagestory.dll" --tracelog --addModPath "{$(pwd)}"/Releases"
//#endif